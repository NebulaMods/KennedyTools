using DevExpress.XtraEditors;

using Domain;

namespace KennedyTools.Utilities;
internal static class Startup
{
    internal static async Task LoadApplicationAsync()
    {
        Forms.Splash.SetStatusText("Checking for update...");
        await UpdateApplicationAsync();

        Forms.Splash.SetStatusText("Downloading files...");
        await DownloadFilesAsync();

        Forms.Splash.SetStatusText("Initializing application...");
        await InitializeApplicationAsync();

        Forms.Splash.IsLoading = false;
    }

    private static async Task UpdateApplicationAsync()
    {
        try
        {
            var isUpdateAvailable = await Utilities.Updater.IsUpdateAvailableAsync();
            if (isUpdateAvailable)
            {
                Forms.Splash.SetStatusText("Update available, downloading now...");
                var isDownloaded = await Utilities.Updater.DownloadUpdateAsync();
                if (isDownloaded)
                {
                    Forms.Splash.SetStatusText("Update downloaded, restarting application...");
                    await Utilities.Updater.RestartApplicationAsync();
                    return;
                }
                Forms.Splash.SetStatusText("Failed to download update.");
            }
            Forms.Splash.SetStatusText("Application is on latest version.");
        }
        catch (Exception ex)
        {
            if (ex.Message == Messages.FailedToCheckForUpdates)
            {
                XtraMessageBox.Show(Messages.FailedToCheckForUpdates, Messages.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show(ex.Message, Messages.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static Task DownloadFilesAsync()
    {
        return Task.Delay(TimeSpan.FromSeconds(1));
    }

    private static async Task InitializeApplicationAsync()
    {
#if !DEBUG
        // Move application to the correct folder if it's not already there
        await Miscellaneous.MoveApplicationToStartupAsync();

        // Set auto startup
        Miscellaneous.SetAutoStartTask(Configuration.ApplicationName, Configuration.ApplicationInstallPath);
#endif
        await Task.Delay(TimeSpan.FromSeconds(1));
    }
}