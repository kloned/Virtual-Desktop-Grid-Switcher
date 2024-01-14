﻿using System;
using System.Runtime.InteropServices;
using WindowsDesktop.Interop.Build10240;

namespace WindowsDesktop.Interop.Build20348
{
    [ComImport]
    [Guid("00000000-0000-0000-0000-000000000000") /* replace at runtime */]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVirtualDesktopNotification
    {
        void VirtualDesktopCreated(IVirtualDesktop pDesktop);

        void VirtualDesktopDestroyBegin(IVirtualDesktop pDesktopDestroyed, IVirtualDesktop pDesktopFallback);

        void VirtualDesktopDestroyFailed(IVirtualDesktop pDesktopDestroyed, IVirtualDesktop pDesktopFallback);

        void VirtualDesktopDestroyed(IVirtualDesktop pDesktopDestroyed, IVirtualDesktop pDesktopFallback);

        void VirtualDesktopIsPerMonitorChanged(int i);

        void VirtualDesktopRenamed(IVirtualDesktop pDesktop, HString chName);

        void ViewVirtualDesktopChanged(IApplicationView pView);

        void CurrentVirtualDesktopChanged(IVirtualDesktop pDesktopOld, IVirtualDesktop pDesktopNew);
    }

    internal class VirtualDesktopNotification : VirtualDesktopNotificationService.EventListenerBase, IVirtualDesktopNotification
    {
        public void VirtualDesktopCreated(IVirtualDesktop pDesktop)
        {
            this.CreatedCore(pDesktop);
        }

        public void VirtualDesktopDestroyBegin(IVirtualDesktop pDesktopDestroyed, IVirtualDesktop pDesktopFallback)
        {
            this.DestroyBeginCore(pDesktopDestroyed, pDesktopFallback);
        }

        public void VirtualDesktopDestroyFailed(IVirtualDesktop pDesktopDestroyed, IVirtualDesktop pDesktopFallback)
        {
            this.DestroyFailedCore(pDesktopDestroyed, pDesktopFallback);
        }

        public void VirtualDesktopDestroyed(IVirtualDesktop pDesktopDestroyed, IVirtualDesktop pDesktopFallback)
        {
            this.DestroyedCore(pDesktopDestroyed, pDesktopFallback);
        }

        public void VirtualDesktopIsPerMonitorChanged(int i)
        {
            this.IsPerMonitorChangedCore(i);
        }

        public void VirtualDesktopRenamed(IVirtualDesktop pDesktop, HString chName)
        {
            this.RenamedCore(pDesktop, chName);
        }

        public void ViewVirtualDesktopChanged(IApplicationView pView)
        {
            this.ViewChangedCore(pView);
        }

        public void CurrentVirtualDesktopChanged(IVirtualDesktop pDesktopOld, IVirtualDesktop pDesktopNew)
        {
            this.CurrentChangedCore(pDesktopOld, pDesktopNew);
        }
    }
}
