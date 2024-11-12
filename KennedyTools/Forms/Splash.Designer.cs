namespace KennedyTools.Forms;

partial class Splash
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
        progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
        labelCopyright = new DevExpress.XtraEditors.LabelControl();
        labelStatus = new DevExpress.XtraEditors.LabelControl();
        peImage = new DevExpress.XtraEditors.PictureEdit();
        ((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)peImage.Properties).BeginInit();
        SuspendLayout();
        // 
        // progressBarControl
        // 
        progressBarControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        progressBarControl.EditValue = 0;
        progressBarControl.Location = new Point(24, 368);
        progressBarControl.Name = "progressBarControl";
        progressBarControl.Size = new Size(402, 12);
        progressBarControl.TabIndex = 5;
        // 
        // labelCopyright
        // 
        labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        labelCopyright.Location = new Point(24, 423);
        labelCopyright.Name = "labelCopyright";
        labelCopyright.Size = new Size(47, 13);
        labelCopyright.TabIndex = 6;
        labelCopyright.Text = "Copyright";
        // 
        // labelStatus
        // 
        labelStatus.Location = new Point(24, 351);
        labelStatus.Margin = new Padding(3, 3, 3, 1);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(50, 13);
        labelStatus.TabIndex = 7;
        labelStatus.Text = "Starting...";
        // 
        // peImage
        // 
        peImage.Dock = DockStyle.Top;
        peImage.EditValue = resources.GetObject("peImage.EditValue");
        peImage.Location = new Point(1, 1);
        peImage.Name = "peImage";
        peImage.Properties.AllowFocused = false;
        peImage.Properties.Appearance.BackColor = Color.Transparent;
        peImage.Properties.Appearance.Options.UseBackColor = true;
        peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        peImage.Properties.ShowMenu = false;
        peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
        peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
        peImage.Size = new Size(448, 344);
        peImage.TabIndex = 9;
        // 
        // Splash
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(450, 450);
        Controls.Add(peImage);
        Controls.Add(labelStatus);
        Controls.Add(labelCopyright);
        Controls.Add(progressBarControl);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MaximumSize = new Size(450, 450);
        MinimumSize = new Size(450, 450);
        Name = "Splash";
        Padding = new Padding(1);
        Text = "--";
        ((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)peImage.Properties).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
    private DevExpress.XtraEditors.LabelControl labelCopyright;
    private DevExpress.XtraEditors.LabelControl labelStatus;
    private DevExpress.XtraEditors.PictureEdit peImage;
}
