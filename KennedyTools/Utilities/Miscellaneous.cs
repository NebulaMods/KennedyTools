using DevExpress.XtraBars.Alerter;

using Domain;

using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace KennedyTools.Utilities;

internal static class Miscellaneous
{
    public static void SetAutoStartTask(string appName, string appPath)
    {
        try
        {
            // Define the task scheduler service
            using (var taskService = new Microsoft.Win32.TaskScheduler.TaskService())
            {
                // Create a new task definition
                var taskDefinition = taskService.NewTask();
                taskDefinition.RegistrationInfo.Description = "Auto-start task for " + appName;
                taskDefinition.RegistrationInfo.Author = "Orbital, Inc.";

                taskDefinition.Settings.Enabled = true;
                taskDefinition.Settings.Hidden = true;
                taskDefinition.Settings.StartWhenAvailable = true;
                taskDefinition.Settings.AllowDemandStart = true;
                taskDefinition.Settings.DisallowStartIfOnBatteries = false;
                taskDefinition.Settings.StopIfGoingOnBatteries = false;
                taskDefinition.Settings.WakeToRun = false;
                taskDefinition.Settings.ExecutionTimeLimit = TimeSpan.Zero;
                taskDefinition.Settings.Priority = ProcessPriorityClass.Normal;
                taskDefinition.Settings.RestartCount = 0;
                taskDefinition.Settings.RestartInterval = TimeSpan.Zero;
                taskDefinition.Settings.IdleSettings.StopOnIdleEnd = false;
                taskDefinition.Settings.IdleSettings.RestartOnIdle = false;
                taskDefinition.Settings.IdleSettings.IdleDuration = TimeSpan.Zero;
                taskDefinition.Settings.MultipleInstances = Microsoft.Win32.TaskScheduler.TaskInstancesPolicy.IgnoreNew;
                taskDefinition.Settings.DisallowStartOnRemoteAppSession = false;
                taskDefinition.Settings.UseUnifiedSchedulingEngine = true;

                // Create a trigger to run the task at user logon
                taskDefinition.Triggers.Add(new Microsoft.Win32.TaskScheduler.LogonTrigger
                {
                    UserId = Environment.UserName // Triggers on logon of the current user
                });

                // Define the action to run the application
                taskDefinition.Actions.Add(new Microsoft.Win32.TaskScheduler.ExecAction(appPath, "autoStart", Path.GetDirectoryName(Configuration.ApplicationInstallPath)));

                // Set the principal to run the task with highest privileges
                //taskDefinition.Principal.UserId = "BUILTIN\\Administrators";
                taskDefinition.Principal.LogonType = Microsoft.Win32.TaskScheduler.TaskLogonType.InteractiveToken;
                taskDefinition.Principal.RunLevel = Microsoft.Win32.TaskScheduler.TaskRunLevel.Highest;

                // Register the task in the root folder
                taskService.RootFolder.RegisterTaskDefinition(appName, taskDefinition);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to create scheduled task: {ex.Message}");
            throw;
        }
    }

    public static Task MoveApplicationToStartupAsync()
    {
        _ = Task.Run(() =>
        {
            try
            {
                // Get current executing path
                var currentPath = Path.GetDirectoryName(Environment.ProcessPath);

                if (string.IsNullOrWhiteSpace(currentPath))
                    return;

                var exeName = "KennedyTools.exe";
                var currentExePath = Path.Combine(currentPath, exeName);

                if (currentExePath == Domain.Configuration.ApplicationInstallPath)
                    return;

                // Create the directory if it doesn't exist
                var dirName = Path.GetDirectoryName(Domain.Configuration.ApplicationInstallPath);
                if (string.IsNullOrWhiteSpace(dirName) is false && Directory.Exists(dirName) is false)
                    Directory.CreateDirectory(dirName);

                File.Copy(currentExePath, Domain.Configuration.ApplicationInstallPath, true);
            }
            catch {}
        });
        return Task.CompletedTask;
    }

    public static void DeleteRunningApplication()
    {
        var currentExePath = Assembly.GetExecutingAssembly().Location;
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C timeout 5 & del {currentExePath}",
                WindowStyle = ProcessWindowStyle.Hidden
            }
        };
        process.Start();
        Process.GetCurrentProcess().Kill();
    }

    public static void StartApplicationInTray(Form form, NotifyIcon notifyIcon, AlertControl alertControl)
    {
        // Minimize the application to the system tray
        form.WindowState = FormWindowState.Minimized;
        form.ShowInTaskbar = false;
        form.Hide();

        notifyIcon.Visible = true;

        alertControl.Show(form, "Application is running in the system tray.", "Click the tray icon to restore the application.");
    }

    /// <summary>
    /// Installs a certificate to the specified store on the local machine.
    /// </summary>
    /// <param name="certPath">The path to the certificate file (.pfx).</param>
    /// <param name="password">The password for the certificate file.</param>
    /// <param name="storeName">The name of the store to install the certificate (e.g., "Root" for Trusted Root Certification Authorities).</param>
    /// <param name="storeLocation">The location of the store (LocalMachine or CurrentUser).</param>
    public static bool InstallCertificate(string certPath, string password, StoreName storeName = StoreName.Root, StoreLocation storeLocation = StoreLocation.LocalMachine)
    {
        // Load the certificate
        var cert = new X509Certificate2(certPath, password, X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.Exportable);

        // Open the store
        using (var store = new X509Store(storeName, storeLocation))
        {
            store.Open(OpenFlags.ReadWrite);

            // Check if the certificate already exists
            if (!store.Certificates.Contains(cert))
            {
                // Add the certificate to the store
                store.Add(cert);
                Console.WriteLine($"Successfully installed certificate '{cert.Subject}' to the '{storeName}' store.");
                // Close the store
                store.Close();
                return true;
            }

            Console.WriteLine($"Certificate '{cert.Subject}' already exists in the '{storeName}' store.");

            // Close the store
            store.Close();

            return false;
        }
    }
}