using DevExpress.XtraBars.Alerter;

using System.Diagnostics;

namespace KennedyTools.Forms;

public partial class Main : DevExpress.XtraBars.ToolbarForm.ToolbarForm
{
    public static NotifyIcon NotifyIcon = new();
    public static AlertControl AlertControl = new();

    public Main()
    {
        InitializeComponent();
        HomeTabPage.SuperTip = MainToolTipControl.GetSuperTip(this);
        NotifyIcon = MainNotifyIcon;
        AlertControl = MainAlertControl;
    }

    private void Main_Load(object sender, EventArgs e)
    {
    }

    private async void Main_FormClosing(object sender, FormClosingEventArgs e) => await CloseApplicationAsync();

    private async Task CloseApplicationAsync()
    {
        Utilities.ThemeUtils.SaveSkinToRegistry();

        // Check if application is in the startup folder
//#if DEBUG
//        var currentPath = Path.GetDirectoryName(Environment.ProcessPath);

//        if (string.IsNullOrWhiteSpace(currentPath))
//            return;

//        var exeName = "KennedyTools.exe";
//        var currentExePath = Path.Combine(currentPath, exeName);

//        if (currentExePath == Domain.Configuration.ApplicationInstallPath)
//        {
//            await Utilities.Miscellaneous.MoveApplicationToStartupAsync();
//            Utilities.Miscellaneous.DeleteRunningApplication();
//        }
//#endif

        Process.GetCurrentProcess().Kill();
    }

    private void MainNotifyIcon_MouseUp(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Left:
                // Show the form when the user clicks on the tray icon
                Show();
                WindowState = FormWindowState.Normal;
                // Remove the tray icon from the system tray
                MainNotifyIcon.Visible = false;
                break;

            case MouseButtons.Right:
                MainPopupMenu.ShowPopup(Cursor.Position);
                break;
        }
    }

    private void Main_Resize(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Minimized)
        {
            // Hide the form when the user minimizes the application
            Hide();
            WindowState = FormWindowState.Minimized;

            // Show the tray icon in the system tray
            MainNotifyIcon.Visible = true;
        }
    }

    private async void CloseApplicationPopupButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => await CloseApplicationAsync();

    private void OpenApplicationPopupButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        Show();
        WindowState = FormWindowState.Normal;
        MainNotifyIcon.Visible = false;
    }
}