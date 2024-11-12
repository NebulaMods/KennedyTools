namespace Domain;

public class Configuration
{
    public const string ApplicationName = "KennedyTools";
    public const string ApplicationUrl = "https://api.kennedyportal.org";
    public const string ApplicationExtension = ".exe";
    public static readonly string ApplicationInstallPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\{ApplicationName}\{ApplicationName}{ApplicationExtension}";
}
