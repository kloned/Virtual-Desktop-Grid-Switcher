using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsDesktop.Interop.Proxy;
using WindowsDesktop.Utils;

namespace WindowsDesktop.Interop.Build26100;

public class VirtualDesktopNotificationService : ComWrapperBase<IVirtualDesktopNotificationService>, IVirtualDesktopNotificationService
{
    private const System.Reflection.BindingFlags BaseTypeMemberAttrs = 
        System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.DeclaredOnly;

    private readonly ComWrapperFactory _factory;

    internal VirtualDesktopNotificationService(ComInterfaceAssembly assembly, ComWrapperFactory factory)
        : base(assembly, CLSID.VirtualDesktopNotificationService)
    {
        this._factory = factory;
    }

    public IDisposable Register(IVirtualDesktopNotification notification)
    {
        var type = this.ComInterfaceAssembly.GetType("VirtualDesktopNotification");
        if (type == null)
            throw new Exception($"VirtualDesktopNotification type not found in the COM interface assembly. Has types {
                string.Join(
                    Environment.NewLine, 
                    (this.ComInterfaceAssembly.GetType().GetField("_knownTypes", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .GetValue(this.ComInterfaceAssembly)
                        as Dictionary<string, Type>)
                        .Values.Select(t => t.FullName))}");

        var listener = Activator.CreateInstance(type) as EventListenerBase;
        if (listener == null) {
            throw new Exception($"{nameof(EventListenerBase)} inheritance type is not found in the COM interface assembly. Base Type is {type.BaseType.FullName} and has members {
                string.Join(
                    Environment.NewLine, 
                    type.BaseType.GetMembers(BaseTypeMemberAttrs)
                    .Select(m => m.ToString()))}");
        }

        listener.Notification = notification;
        listener.Factory = this._factory;

        var dwCookie = this.InvokeMethod<uint>(Args(listener));
        return Disposable.Create(() => this.Unregister(dwCookie));
    }

    private void Unregister(uint dwCookie)
    {
        try
        {
            this.InvokeMethod(Args(dwCookie));
        }
        catch (COMException ex) when (ex.Match(HResult.RPC_S_SERVER_UNAVAILABLE))
        {
            // Nothing particular to do.
        }
    }

    public abstract class EventListenerBase
    {
        internal ComWrapperFactory Factory { get; set; } = null!;

        internal IVirtualDesktopNotification Notification { get; set; } = null!;

        protected void CreatedCore(object pDesktop)
            => this.Notification.VirtualDesktopCreated(this.Wrap(pDesktop));

        protected void DestroyBeginCore(object pDesktopDestroyed, object pDesktopFallback)
            => this.Notification.VirtualDesktopDestroyBegin(this.Wrap(pDesktopDestroyed), this.Wrap(pDesktopFallback));

        protected void DestroyFailedCore(object pDesktopDestroyed, object pDesktopFallback)
            => this.Notification.VirtualDesktopDestroyFailed(this.Wrap(pDesktopDestroyed), this.Wrap(pDesktopFallback));

        protected void DestroyedCore(object pDesktopDestroyed, object pDesktopFallback)
            => this.Notification.VirtualDesktopDestroyed(this.Wrap(pDesktopDestroyed), this.Wrap(pDesktopFallback));

        //protected void MovedCore(object pDesktop, int nIndexFrom, int nIndexTo)
        //    => this.Notification.VirtualDesktopMoved(this.Wrap(pDesktop), nIndexFrom, nIndexTo);

        //protected void RenamedCore(object pDesktop, HString chName)
        //    => this.Notification.VirtualDesktopRenamed(this.Wrap(pDesktop), chName);

        protected void ViewChangedCore(object view)
            => this.Notification.ViewVirtualDesktopChanged(this.Factory.ApplicationView(view).Interface);

        protected void CurrentChangedCore(object pDesktopOld, object pDesktopNew)
            => this.Notification.CurrentVirtualDesktopChanged(this.Wrap(pDesktopOld), this.Wrap(pDesktopNew));

        //protected void WallpaperChangedCore(object pDesktop, HString chPath)
        //    => this.Notification.VirtualDesktopWallpaperChanged(this.Wrap(pDesktop), chPath);

        //protected void SwitchedCore(object pDesktop)
        //    => this.Notification.VirtualDesktopSwitched(this.Wrap(pDesktop));

        //protected void RemoteConnectedCore(object pDesktop)
        //    => this.Notification.RemoteVirtualDesktopConnected(this.Wrap(pDesktop));

        private IVirtualDesktop Wrap(object desktop)
            => this.Factory.VirtualDesktop(desktop).Interface;
    }
}
