using DevExpress.LookAndFeel;

using Domain;

using Microsoft.Win32;

namespace KennedyTools.Utilities;

internal static class ThemeUtils
{
    public static string? GetThemeFromRegistry()
    {
        // Get the saved skin name from the registry
        return Registry.GetValue($"HKEY_CURRENT_USER\\Software\\{Configuration.ApplicationName}", "SkinName", null) as string;
    }

    public static void SaveSkinToRegistry()
    {
        // Get the current skin name
        var skinName = UserLookAndFeel.Default.SkinName;

        // Save the skin name to the registry
        Registry.SetValue($"HKEY_CURRENT_USER\\Software\\{Configuration.ApplicationName}", "SkinName", skinName);
    }
}