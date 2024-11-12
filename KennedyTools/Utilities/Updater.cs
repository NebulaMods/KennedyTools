using Domain;

using System.Diagnostics;
using System.IO;
using System.Net.Http;

namespace KennedyTools.Utilities;

internal static class Updater
{
    private static readonly string _updateCheckUrl = $"{Configuration.ApplicationUrl}/version.txt";
    private static readonly string _updateDownloadUrl = $"{Configuration.ApplicationUrl}/{Configuration.ApplicationName}{Configuration.ApplicationExtension}";

    public static async Task<bool> IsUpdateAvailableAsync()
    {
        try
        {
            using var httpClient = new HttpClient();
            httpClient.Timeout = TimeSpan.FromSeconds(5);
            httpClient.DefaultRequestHeaders.Add(Messages.UserAgent, $"{Configuration.ApplicationName}-{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}");
            var response = await httpClient.GetAsync(_updateCheckUrl);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrWhiteSpace(content))
                {
                    var latestVersion = new Version(content);
                    var currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                    return latestVersion > currentVersion;
                }
            }
            throw new Exception(Messages.FailedToCheckForUpdates);
        }
        catch
        {
            throw;
        }
    }

    public static async Task<bool> DownloadUpdateAsync()
    {
        using var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add(Messages.UserAgent, Configuration.ApplicationName);
        var response = await httpClient.GetAsync(_updateDownloadUrl);
        if (response.IsSuccessStatusCode)
        {
            var updateContent = await response.Content.ReadAsByteArrayAsync();
            if (updateContent.Length > 0)
            {
                var updatePath = Path.Combine(Environment.CurrentDirectory, $"{Configuration.ApplicationName}-update{Configuration.ApplicationExtension}");
                await File.WriteAllBytesAsync(updatePath, updateContent);
                return true;
            }
        }
        return false;
    }

    public static Task RestartApplicationAsync()
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/C timeout 5 & del {Configuration.ApplicationName}{Configuration.ApplicationExtension} & ren {Configuration.ApplicationName}-update{Configuration.ApplicationExtension} {Configuration.ApplicationName}{Configuration.ApplicationExtension} & start {Configuration.ApplicationName}{Configuration.ApplicationExtension}",
                WindowStyle = ProcessWindowStyle.Hidden
            }
        };
        process.Start();
        Process.GetCurrentProcess().Kill();
        return Task.CompletedTask;
    }
}