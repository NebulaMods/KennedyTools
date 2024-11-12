using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace KennedyTools.Utilities;

/// <summary>
/// Checks if the application is already running.
/// </summary>
public sealed class InstanceCheck : IDisposable
{
    /// <summary>
    /// Brings the other process to the front.
    /// </summary>
    /// <param name="hWnd"></param>
    /// <returns></returns>
    [DllImport("user32.dll")]
    private static extern bool SetForegroundWindow(nint hWnd);

    /// <summary>
    /// Shows the window asynchronously.
    /// </summary>
    /// <param name="hWnd"></param>
    /// <param name="nCmdShow"></param>
    /// <returns></returns>
    [DllImport("user32.dll")]
    private static extern bool ShowWindowAsync(nint hWnd, int nCmdShow);

    /// <summary>
    /// Checks if the window is minimized.
    /// </summary>
    /// <param name="hWnd"></param>
    /// <returns></returns>
    [DllImport("user32.dll")]
    private static extern bool IsIconic(nint hWnd);

    /// <summary>
    /// Restores the window.
    /// </summary>
    private const int SW_RESTORE = 9;

    /// <summary>
    /// The mutex object.
    /// </summary>
    private Mutex _processSync;

    /// <summary>
    /// Determines if the application is already running.
    /// </summary>
    private bool _owned = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceCheck"/> class.
    /// </summary>
    public InstanceCheck() => _processSync = new Mutex(true, Assembly.GetExecutingAssembly().GetName().Name, out _owned);

    /// <summary>
    /// Initializes a new instance of the <see cref="InstanceCheck"/> class.
    /// </summary>
    /// <param name="identifier"></param>
    public InstanceCheck(string identifier) => _processSync = new Mutex(true, Assembly.GetExecutingAssembly().GetName().Name + identifier, out _owned);

    /// <summary>
    /// Finalizes an instance of the <see cref="InstanceCheck"/> class.
    /// </summary>
    ~InstanceCheck() => Release();

    /// <summary>
    /// Determines if the application is a single instance.
    /// </summary>
    public bool IsSingleInstance
    {
        get { return _owned; }
    }

    /// <summary>
    /// Brings the other process to the front.
    /// </summary>
    public static void RaiseOtherProcess()
    {
        Process proc = Process.GetCurrentProcess();
        string? assemblyName = Assembly.GetExecutingAssembly()?.GetName().Name;
        foreach (Process otherProc in Process.GetProcessesByName(assemblyName))
        {
            if (proc.Id != otherProc.Id)
            {
                nint hWnd = otherProc.MainWindowHandle;
                if (IsIconic(hWnd))
                {
                    ShowWindowAsync(hWnd, SW_RESTORE);
                }
                SetForegroundWindow(hWnd);
                break;
            }
        }
    }

    /// <summary>
    /// Releases the mutex.
    /// </summary>
    private void Release()
    {
        try
        {
            if (_owned)
            {
                _processSync.ReleaseMutex();
                _owned = false;
            }
        }
        catch { return; }
    }

    /// <summary>
    /// Disposes of the mutex.
    /// </summary>
    public void Dispose()
    {
        Release();
        GC.SuppressFinalize(this);
    }
}
