namespace KennedyTools.Forms;

partial class Main
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        MainBarManager = new DevExpress.XtraBars.BarManager(components);
        barDockControlTop = new DevExpress.XtraBars.BarDockControl();
        barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
        barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
        barDockControlRight = new DevExpress.XtraBars.BarDockControl();
        CloseApplicationPopupButton = new DevExpress.XtraBars.BarButtonItem();
        OpenApplicationPopupButton = new DevExpress.XtraBars.BarButtonItem();
        MainAlertControl = new DevExpress.XtraBars.Alerter.AlertControl(components);
        MainPopupMenu = new DevExpress.XtraBars.PopupMenu(components);
        MainToolBarControl = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
        MainToolBarManager = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(components);
        barDockControl1 = new DevExpress.XtraBars.BarDockControl();
        barDockControl2 = new DevExpress.XtraBars.BarDockControl();
        barDockControl3 = new DevExpress.XtraBars.BarDockControl();
        barDockControl4 = new DevExpress.XtraBars.BarDockControl();
        SkinSelectorBarButton = new DevExpress.XtraBars.SkinBarSubItem();
        SettingsBarButton = new DevExpress.XtraBars.BarButtonItem();
        MainNotifyIcon = new NotifyIcon(components);
        HomeTabPage = new DevExpress.XtraTab.XtraTabPage();
        MainTabControl = new DevExpress.XtraTab.XtraTabControl();
        FileOptionsTabPage = new DevExpress.XtraTab.XtraTabPage();
        MainToolTipControl = new DevExpress.Utils.ToolTipController(components);
        VideoPlayerTabPage = new DevExpress.XtraTab.XtraTabPage();
        ((System.ComponentModel.ISupportInitialize)MainBarManager).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MainPopupMenu).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MainToolBarControl).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MainToolBarManager).BeginInit();
        ((System.ComponentModel.ISupportInitialize)MainTabControl).BeginInit();
        MainTabControl.SuspendLayout();
        SuspendLayout();
        // 
        // MainBarManager
        // 
        MainBarManager.DockControls.Add(barDockControlTop);
        MainBarManager.DockControls.Add(barDockControlBottom);
        MainBarManager.DockControls.Add(barDockControlLeft);
        MainBarManager.DockControls.Add(barDockControlRight);
        MainBarManager.Form = this;
        MainBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { CloseApplicationPopupButton, OpenApplicationPopupButton });
        MainBarManager.MaxItemId = 2;
        // 
        // barDockControlTop
        // 
        barDockControlTop.CausesValidation = false;
        barDockControlTop.Dock = DockStyle.Top;
        barDockControlTop.Location = new Point(0, 27);
        barDockControlTop.Manager = MainBarManager;
        barDockControlTop.Size = new Size(1020, 0);
        // 
        // barDockControlBottom
        // 
        barDockControlBottom.CausesValidation = false;
        barDockControlBottom.Dock = DockStyle.Bottom;
        barDockControlBottom.Location = new Point(0, 588);
        barDockControlBottom.Manager = MainBarManager;
        barDockControlBottom.Size = new Size(1020, 0);
        // 
        // barDockControlLeft
        // 
        barDockControlLeft.CausesValidation = false;
        barDockControlLeft.Dock = DockStyle.Left;
        barDockControlLeft.Location = new Point(0, 27);
        barDockControlLeft.Manager = MainBarManager;
        barDockControlLeft.Size = new Size(0, 561);
        // 
        // barDockControlRight
        // 
        barDockControlRight.CausesValidation = false;
        barDockControlRight.Dock = DockStyle.Right;
        barDockControlRight.Location = new Point(1020, 27);
        barDockControlRight.Manager = MainBarManager;
        barDockControlRight.Size = new Size(0, 561);
        // 
        // CloseApplicationPopupButton
        // 
        CloseApplicationPopupButton.Caption = "Quit";
        CloseApplicationPopupButton.Id = 0;
        CloseApplicationPopupButton.ImageOptions.LargeImage = (Image)resources.GetObject("CloseApplicationPopupButton.ImageOptions.LargeImage");
        CloseApplicationPopupButton.Name = "CloseApplicationPopupButton";
        CloseApplicationPopupButton.ItemClick += CloseApplicationPopupButton_ItemClick;
        // 
        // OpenApplicationPopupButton
        // 
        OpenApplicationPopupButton.Caption = "Open";
        OpenApplicationPopupButton.Id = 1;
        OpenApplicationPopupButton.ImageOptions.LargeImage = (Image)resources.GetObject("OpenApplicationPopupButton.ImageOptions.LargeImage");
        OpenApplicationPopupButton.Name = "OpenApplicationPopupButton";
        OpenApplicationPopupButton.ItemClick += OpenApplicationPopupButton_ItemClick;
        // 
        // MainAlertControl
        // 
        MainAlertControl.PopupMenu = MainPopupMenu;
        MainAlertControl.ShowPinButton = false;
        // 
        // MainPopupMenu
        // 
        MainPopupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(OpenApplicationPopupButton), new DevExpress.XtraBars.LinkPersistInfo(CloseApplicationPopupButton) });
        MainPopupMenu.Manager = MainBarManager;
        MainPopupMenu.Name = "MainPopupMenu";
        // 
        // MainToolBarControl
        // 
        MainToolBarControl.Location = new Point(0, 0);
        MainToolBarControl.Manager = MainToolBarManager;
        MainToolBarControl.Name = "MainToolBarControl";
        MainToolBarControl.Size = new Size(1020, 27);
        MainToolBarControl.TabIndex = 4;
        MainToolBarControl.TabStop = false;
        MainToolBarControl.TitleItemLinks.Add(SkinSelectorBarButton);
        MainToolBarControl.TitleItemLinks.Add(SettingsBarButton);
        MainToolBarControl.ToolbarForm = this;
        // 
        // MainToolBarManager
        // 
        MainToolBarManager.DockControls.Add(barDockControl1);
        MainToolBarManager.DockControls.Add(barDockControl2);
        MainToolBarManager.DockControls.Add(barDockControl3);
        MainToolBarManager.DockControls.Add(barDockControl4);
        MainToolBarManager.Form = this;
        MainToolBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { SkinSelectorBarButton, SettingsBarButton });
        MainToolBarManager.MaxItemId = 2;
        // 
        // barDockControl1
        // 
        barDockControl1.CausesValidation = false;
        barDockControl1.Dock = DockStyle.Top;
        barDockControl1.Location = new Point(0, 27);
        barDockControl1.Manager = MainToolBarManager;
        barDockControl1.Size = new Size(1020, 0);
        // 
        // barDockControl2
        // 
        barDockControl2.CausesValidation = false;
        barDockControl2.Dock = DockStyle.Bottom;
        barDockControl2.Location = new Point(0, 588);
        barDockControl2.Manager = MainToolBarManager;
        barDockControl2.Size = new Size(1020, 0);
        // 
        // barDockControl3
        // 
        barDockControl3.CausesValidation = false;
        barDockControl3.Dock = DockStyle.Left;
        barDockControl3.Location = new Point(0, 27);
        barDockControl3.Manager = MainToolBarManager;
        barDockControl3.Size = new Size(0, 561);
        // 
        // barDockControl4
        // 
        barDockControl4.CausesValidation = false;
        barDockControl4.Dock = DockStyle.Right;
        barDockControl4.Location = new Point(1020, 27);
        barDockControl4.Manager = MainToolBarManager;
        barDockControl4.Size = new Size(0, 561);
        // 
        // SkinSelectorBarButton
        // 
        SkinSelectorBarButton.Caption = "Theme Selector";
        SkinSelectorBarButton.Hint = "Theme selector";
        SkinSelectorBarButton.Id = 0;
        SkinSelectorBarButton.ImageOptions.Image = (Image)resources.GetObject("SkinSelectorBarButton.ImageOptions.Image");
        SkinSelectorBarButton.Name = "SkinSelectorBarButton";
        SkinSelectorBarButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
        // 
        // SettingsBarButton
        // 
        SettingsBarButton.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
        SettingsBarButton.Caption = "Settings";
        SettingsBarButton.Id = 1;
        SettingsBarButton.ImageOptions.Image = (Image)resources.GetObject("SettingsBarButton.ImageOptions.Image");
        SettingsBarButton.Name = "SettingsBarButton";
        SettingsBarButton.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
        // 
        // MainNotifyIcon
        // 
        MainNotifyIcon.Icon = (Icon)resources.GetObject("MainNotifyIcon.Icon");
        MainNotifyIcon.Text = "Kennedy PC Tools";
        MainNotifyIcon.MouseUp += MainNotifyIcon_MouseUp;
        // 
        // HomeTabPage
        // 
        HomeTabPage.ImageOptions.Image = (Image)resources.GetObject("HomeTabPage.ImageOptions.Image");
        HomeTabPage.Name = "HomeTabPage";
        HomeTabPage.Size = new Size(960, 537);
        HomeTabPage.Tooltip = "Home Page";
        // 
        // MainTabControl
        // 
        MainTabControl.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] { new DevExpress.XtraTab.Buttons.CustomHeaderButton() });
        MainTabControl.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
        MainTabControl.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
        MainTabControl.Location = new Point(12, 33);
        MainTabControl.Name = "MainTabControl";
        MainTabControl.SelectedTabPage = HomeTabPage;
        MainTabControl.Size = new Size(996, 543);
        MainTabControl.TabIndex = 8;
        MainTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { HomeTabPage, FileOptionsTabPage, VideoPlayerTabPage });
        // 
        // FileOptionsTabPage
        // 
        FileOptionsTabPage.ImageOptions.Image = (Image)resources.GetObject("FileOptionsTabPage.ImageOptions.Image");
        FileOptionsTabPage.Name = "FileOptionsTabPage";
        FileOptionsTabPage.Size = new Size(960, 537);
        FileOptionsTabPage.Tooltip = "File Options";
        // 
        // MainToolTipControl
        // 
        MainToolTipControl.ToolTipLocation = DevExpress.Utils.ToolTipLocation.TopLeft;
        MainToolTipControl.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
        // 
        // VideoPlayerTabPage
        // 
        VideoPlayerTabPage.ImageOptions.Image = (Image)resources.GetObject("xtraTabPage2.ImageOptions.Image");
        VideoPlayerTabPage.Name = "VideoPlayerTabPage";
        VideoPlayerTabPage.Size = new Size(960, 537);
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1020, 588);
        Controls.Add(MainTabControl);
        Controls.Add(barDockControlLeft);
        Controls.Add(barDockControlRight);
        Controls.Add(barDockControlBottom);
        Controls.Add(barDockControlTop);
        Controls.Add(barDockControl3);
        Controls.Add(barDockControl4);
        Controls.Add(barDockControl2);
        Controls.Add(barDockControl1);
        Controls.Add(MainToolBarControl);
        IconOptions.Icon = (Icon)resources.GetObject("Main.IconOptions.Icon");
        MaximizeBox = false;
        Name = "Main";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Kennedy PC Tools";
        ToolbarFormControl = MainToolBarControl;
        FormClosing += Main_FormClosing;
        Load += Main_Load;
        Resize += Main_Resize;
        ((System.ComponentModel.ISupportInitialize)MainBarManager).EndInit();
        ((System.ComponentModel.ISupportInitialize)MainPopupMenu).EndInit();
        ((System.ComponentModel.ISupportInitialize)MainToolBarControl).EndInit();
        ((System.ComponentModel.ISupportInitialize)MainToolBarManager).EndInit();
        ((System.ComponentModel.ISupportInitialize)MainTabControl).EndInit();
        MainTabControl.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.BarManager MainBarManager;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.Alerter.AlertControl MainAlertControl;
    private DevExpress.XtraBars.BarDockControl barDockControl3;
    private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager MainToolBarManager;
    private DevExpress.XtraBars.BarDockControl barDockControl1;
    private DevExpress.XtraBars.BarDockControl barDockControl2;
    private DevExpress.XtraBars.BarDockControl barDockControl4;
    private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
    private DevExpress.XtraBars.SkinBarSubItem SkinSelectorBarButton;
    private NotifyIcon MainNotifyIcon;
    private DevExpress.XtraBars.PopupMenu MainPopupMenu;
    private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl MainToolBarControl;
    private DevExpress.XtraBars.BarButtonItem CloseApplicationPopupButton;
    private DevExpress.XtraBars.BarButtonItem OpenApplicationPopupButton;
    private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    private DevExpress.XtraBars.BarButtonItem SettingsBarButton;
    private DevExpress.XtraTab.XtraTabControl MainTabControl;
    private DevExpress.XtraTab.XtraTabPage HomeTabPage;
    private DevExpress.XtraTab.XtraTabPage FileOptionsTabPage;
    private DevExpress.Utils.ToolTipController MainToolTipControl;
    private DevExpress.XtraTab.XtraTabPage VideoPlayerTabPage;
}