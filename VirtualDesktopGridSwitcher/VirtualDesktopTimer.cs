using System;
using System.Collections.Generic;
using WindowsDesktop;

public class VirtualDesktopTimer : IDisposable
{
    private readonly object callbackMutex;
    private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
    private readonly Func<int> getCurrentDesktop;
    private readonly Action<object, VirtualDesktopChangedEventArgs> onDesktopChanged;
    private readonly System.Guid[] desktopIdLookup;
    public int IntervalMs { get; set; } = 500; // Default value
    public VirtualDesktopTimer(
        object callbackMutex,
        System.Guid[] desktopIdLookup,
        Func<int> getCurrentDesktop,
        Action<object, VirtualDesktopChangedEventArgs> onDesktopChanged,
        int? intervalMs = 500)
    {
        this.callbackMutex = callbackMutex;
        this.desktopIdLookup = desktopIdLookup;
        this.getCurrentDesktop = getCurrentDesktop;
        this.onDesktopChanged = onDesktopChanged;
        if (intervalMs.HasValue)
        {
            IntervalMs = intervalMs.Value;
        }
    }

    public void Start()
    {
        timer = new System.Windows.Forms.Timer();
        timer.Interval = IntervalMs;
        timer.Tick += (sender, e) =>
        {
            lock (callbackMutex)
            {
                DoOnTimerTick(sender, e);
            }
        };
        timer.Start();
    }

    public void UpdateInterval(int newIntervalMs)
    {
        IntervalMs = newIntervalMs;
        if (timer.Enabled)
        {
            timer.Interval = newIntervalMs;
        }
    }

    private void DoOnTimerTick(object sender, EventArgs e)
    {
        lock (callbackMutex)
        {
            // check if virtual desktop has switched
            if (VirtualDesktop.Current != VirtualDesktop.FromId(desktopIdLookup[getCurrentDesktop()]))
            {
                // call VirtualDesktop_CurrentChanged
                onDesktopChanged(null,
                    new VirtualDesktopChangedEventArgs(
                        VirtualDesktop.FromId(desktopIdLookup[getCurrentDesktop()]),
                        VirtualDesktop.Current));
            }
        }
    }

    public void Stop()
    {
        timer.Stop();
        timer.Dispose();
    }

    public void Dispose()
    {
        Stop();
    }
}