﻿namespace aol.Forms
{
    partial class BrowserForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BrowserForm));
            toolStripContainer1 = new ToolStripContainer();
            WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            TitleBar = new Panel();
            BrowserWindowTitleLabel = new Label();
            favoriteBtn = new PictureBox();
            titleLabel = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((ISupportInitialize)WebView).BeginInit();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)favoriteBtn).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(WebView);
            toolStripContainer1.ContentPanel.Margin = new Padding(4);
            toolStripContainer1.ContentPanel.Size = new Size(876, 469);
            toolStripContainer1.ContentPanel.UseWaitCursor = true;
            toolStripContainer1.Location = new Point(3, 25);
            toolStripContainer1.Margin = new Padding(4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(876, 494);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // WebView
            // 
            WebView.AllowExternalDrop = true;
            WebView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WebView.CreationProperties = null;
            WebView.DefaultBackgroundColor = Color.White;
            WebView.Location = new Point(0, 0);
            WebView.Margin = new Padding(2);
            WebView.Name = "WebView";
            WebView.Size = new Size(874, 469);
            WebView.Source = new Uri("https://www.aol.com", UriKind.Absolute);
            WebView.TabIndex = 0;
            WebView.UseWaitCursor = true;
            WebView.ZoomFactor = 1D;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(BrowserWindowTitleLabel);
            TitleBar.Controls.Add(favoriteBtn);
            TitleBar.Controls.Add(titleLabel);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(3, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(876, 24);
            TitleBar.TabIndex = 1;
            // 
            // BrowserWindowTitleLabel
            // 
            BrowserWindowTitleLabel.AutoSize = true;
            BrowserWindowTitleLabel.BackColor = Color.Transparent;
            BrowserWindowTitleLabel.ForeColor = SystemColors.Window;
            BrowserWindowTitleLabel.Location = new Point(0, 2);
            BrowserWindowTitleLabel.Margin = new Padding(2, 0, 2, 0);
            BrowserWindowTitleLabel.Name = "BrowserWindowTitleLabel";
            BrowserWindowTitleLabel.Size = new Size(56, 15);
            BrowserWindowTitleLabel.TabIndex = 5;
            BrowserWindowTitleLabel.Text = "loading...";
            // 
            // favoriteBtn
            // 
            favoriteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            favoriteBtn.BackColor = Color.Transparent;
            favoriteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            favoriteBtn.Cursor = Cursors.Hand;
            favoriteBtn.Image = (Image)resources.GetObject("favoriteBtn.Image");
            favoriteBtn.Location = new Point(786, 1);
            favoriteBtn.Margin = new Padding(4);
            favoriteBtn.Name = "favoriteBtn";
            favoriteBtn.Size = new Size(18, 20);
            favoriteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            favoriteBtn.TabIndex = 4;
            favoriteBtn.TabStop = false;
            favoriteBtn.Click += FavoriteBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(4, 4);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 15);
            titleLabel.TabIndex = 3;
            titleLabel.MouseMove += TitleBar_TitleLabel_MouseMove;
            // 
            // miniBtn
            // 
            miniBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            miniBtn.BackColor = SystemColors.Control;
            miniBtn.BackgroundImage = Properties.Resources.minimize_btn;
            miniBtn.BackgroundImageLayout = ImageLayout.Stretch;
            miniBtn.FlatStyle = FlatStyle.Flat;
            miniBtn.Font = new Font("Microsoft Sans Serif", 6F);
            miniBtn.ForeColor = Color.Black;
            miniBtn.Location = new Point(809, 2);
            miniBtn.Margin = new Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += MiniBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxBtn.BackColor = SystemColors.Control;
            maxBtn.BackgroundImage = Properties.Resources.maximize_btn;
            maxBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(830, 2);
            maxBtn.Margin = new Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = RightToLeft.No;
            maxBtn.Size = new Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.BackColor = SystemColors.Control;
            closeBtn.BackgroundImage = Properties.Resources.close_btn;
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Microsoft Sans Serif", 6F);
            closeBtn.ForeColor = Color.Black;
            closeBtn.Location = new Point(853, 2);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // BrowserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(880, 522);
            Controls.Add(TitleBar);
            Controls.Add(toolStripContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(5, 210);
            Margin = new Padding(4);
            Name = "BrowserForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "browser";
            Shown += BrowserForm_Shown;
            Enter += BrowserForm_Enter;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((ISupportInitialize)WebView).EndInit();
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)favoriteBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox favoriteBtn;
        private System.Windows.Forms.Label BrowserWindowTitleLabel;
        public Microsoft.Web.WebView2.WinForms.WebView2 WebView;
    }
}

