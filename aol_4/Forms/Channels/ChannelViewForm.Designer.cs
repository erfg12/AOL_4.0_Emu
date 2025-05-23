﻿namespace aol.Forms
{
    partial class ChannelViewForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ChannelViewForm));
            toolStripContainer1 = new ToolStripContainer();
            WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            TitlePanel = new Panel();
            labelTitle = new Label();
            pictureBox22 = new PictureBox();
            favoriteBtn = new PictureBox();
            titleLabel = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((ISupportInitialize)WebView).BeginInit();
            TitlePanel.SuspendLayout();
            ((ISupportInitialize)pictureBox22).BeginInit();
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
            toolStripContainer1.ContentPanel.Size = new Size(906, 501);
            toolStripContainer1.ContentPanel.UseWaitCursor = true;
            toolStripContainer1.Location = new Point(3, 25);
            toolStripContainer1.Margin = new Padding(4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(906, 526);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // WebView
            // 
            WebView.AllowExternalDrop = true;
            WebView.CreationProperties = null;
            WebView.DefaultBackgroundColor = Color.White;
            WebView.Dock = DockStyle.Fill;
            WebView.Location = new Point(0, 0);
            WebView.Margin = new Padding(2);
            WebView.Name = "WebView";
            WebView.Size = new Size(906, 501);
            WebView.TabIndex = 0;
            WebView.UseWaitCursor = true;
            WebView.ZoomFactor = 1D;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitlePanel.BackColor = Color.White;
            TitlePanel.BackgroundImage = Properties.Resources.top_bar;
            TitlePanel.BackgroundImageLayout = ImageLayout.Stretch;
            TitlePanel.Controls.Add(labelTitle);
            TitlePanel.Controls.Add(pictureBox22);
            TitlePanel.Controls.Add(favoriteBtn);
            TitlePanel.Controls.Add(titleLabel);
            TitlePanel.Controls.Add(miniBtn);
            TitlePanel.Controls.Add(maxBtn);
            TitlePanel.Controls.Add(closeBtn);
            TitlePanel.Location = new Point(3, 2);
            TitlePanel.Margin = new Padding(4);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(906, 21);
            TitlePanel.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(32, 3);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(56, 15);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "loading...";
            // 
            // pictureBox22
            // 
            pictureBox22.BackColor = Color.Transparent;
            pictureBox22.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox22.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox22.Image = Properties.Resources.aol_icon_4;
            pictureBox22.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox22.Location = new Point(3, -1);
            pictureBox22.Margin = new Padding(4);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(21, 21);
            pictureBox22.TabIndex = 10;
            pictureBox22.TabStop = false;
            // 
            // favoriteBtn
            // 
            favoriteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            favoriteBtn.BackColor = Color.Transparent;
            favoriteBtn.BackgroundImageLayout = ImageLayout.Stretch;
            favoriteBtn.Cursor = Cursors.Hand;
            favoriteBtn.Image = (Image)resources.GetObject("favoriteBtn.Image");
            favoriteBtn.Location = new Point(816, 0);
            favoriteBtn.Margin = new Padding(4);
            favoriteBtn.Name = "favoriteBtn";
            favoriteBtn.Size = new Size(18, 20);
            favoriteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            favoriteBtn.TabIndex = 4;
            favoriteBtn.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(24, 4);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 15);
            titleLabel.TabIndex = 3;
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
            miniBtn.Location = new Point(839, 1);
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
            maxBtn.BackgroundImage = Properties.Resources.maximize_disabled_btn;
            maxBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(860, 1);
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
            closeBtn.Location = new Point(883, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // ChannelViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 554);
            Controls.Add(TitlePanel);
            Controls.Add(toolStripContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(5, 210);
            Margin = new Padding(4);
            Name = "ChannelViewForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "browser";
            Shown += ChannelView_Shown;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((ISupportInitialize)WebView).EndInit();
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ((ISupportInitialize)pictureBox22).EndInit();
            ((ISupportInitialize)favoriteBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox favoriteBtn;
        private System.Windows.Forms.PictureBox pictureBox22;
        private Microsoft.Web.WebView2.WinForms.WebView2 WebView;
        private System.Windows.Forms.Label labelTitle;
    }
}

