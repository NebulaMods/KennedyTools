using DevExpress.LookAndFeel;
using DevExpress.XtraSplashScreen;

using KennedyTools.Utilities;

namespace KennedyTools;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // Check if application is already running
        InstanceCheck.RaiseOtherProcess();

        Control.CheckForIllegalCrossThreadCalls = false;
        ApplicationConfiguration.Initialize();

        SetTheme();

        // Check if application was launched by the user or by the system
        var form = ShouldAppLaunchMinimized();
        if (form == null)
        {
            return;
        }

        SplashScreenManager.ShowForm(typeof(Forms.Splash));
        Task.Run(Startup.LoadApplicationAsync).Wait(TimeSpan.FromSeconds(10));

        // While loop to check if the application is still loading
        while (Forms.Splash.IsLoading)
        {
            Application.DoEvents();
        }

        SplashScreenManager.CloseForm();
        Application.Run(form);
    }

    private static Forms.Main? ShouldAppLaunchMinimized()
    {
        var args = Environment.GetCommandLineArgs();
        var form = new Forms.Main();
        if (args.Length > 1)
        {
            Task.Run(Startup.LoadApplicationAsync).Wait(TimeSpan.FromSeconds(10));
            // While loop to check if the application is still loading
            while (Forms.Splash.IsLoading)
            {
                Application.DoEvents();
            }

            //Utilities.Miscellaneous.StartApplicationInTray(form, Forms.Main.NotifyIcon, Forms.Main.AlertControl);
            Application.Run(form);
            return null;
        }
        return form;
    }

    private static void SetTheme()
    {
        var skinName = Utilities.ThemeUtils.GetThemeFromRegistry();
        if (string.IsNullOrWhiteSpace(skinName))
        {
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style");
        }
        else
        {
            UserLookAndFeel.Default.SetSkinStyle(skinName);
        }
    }
}