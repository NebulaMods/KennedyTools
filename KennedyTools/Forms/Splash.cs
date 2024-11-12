using DevExpress.XtraSplashScreen;

namespace KennedyTools.Forms;

public partial class Splash : SplashScreen
{
    public static bool IsLoading = true;

    private static Splash? _instance;

    public Splash()
    {
        InitializeComponent();
        this.labelCopyright.Text = "Copyright © 2020-" + DateTime.Now.Year.ToString();
        _instance = this;
    }

    public static void SetStatusText(string text)
    {
        if (_instance != null)
            _instance.labelStatus.Text = text;
    }
}