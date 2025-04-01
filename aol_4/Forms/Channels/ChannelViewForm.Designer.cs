namespace aol.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelViewForm));
            toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1 = new System.Windows.Forms.Panel();
            labelTitle = new System.Windows.Forms.Label();
            pictureBox22 = new System.Windows.Forms.PictureBox();
            favoriteBtn = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WebView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)favoriteBtn).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(WebView);
            toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(906, 501);
            toolStripContainer1.ContentPanel.UseWaitCursor = true;
            toolStripContainer1.Location = new System.Drawing.Point(3, 25);
            toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new System.Drawing.Size(906, 526);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // WebView
            // 
            WebView.AllowExternalDrop = true;
            WebView.CreationProperties = null;
            WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            WebView.Dock = System.Windows.Forms.DockStyle.Fill;
            WebView.Location = new System.Drawing.Point(0, 0);
            WebView.Margin = new System.Windows.Forms.Padding(2);
            WebView.Name = "WebView";
            WebView.Size = new System.Drawing.Size(906, 501);
            WebView.TabIndex = 0;
            WebView.UseWaitCursor = true;
            WebView.ZoomFactor = 1D;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(pictureBox22);
            panel1.Controls.Add(favoriteBtn);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(3, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(906, 21);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            panel1.MouseDoubleClick += panel1_MouseDoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = System.Drawing.Color.Transparent;
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.Location = new System.Drawing.Point(32, 3);
            labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(56, 15);
            labelTitle.TabIndex = 11;
            labelTitle.Text = "loading...";
            // 
            // pictureBox22
            // 
            pictureBox22.BackColor = System.Drawing.Color.Transparent;
            pictureBox22.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox22.Image = Properties.Resources.aol_icon_4;
            pictureBox22.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox22.Location = new System.Drawing.Point(3, -1);
            pictureBox22.Margin = new System.Windows.Forms.Padding(4);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new System.Drawing.Size(21, 21);
            pictureBox22.TabIndex = 10;
            pictureBox22.TabStop = false;
            // 
            // favoriteBtn
            // 
            favoriteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            favoriteBtn.BackColor = System.Drawing.Color.Transparent;
            favoriteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            favoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            favoriteBtn.Image = (System.Drawing.Image)resources.GetObject("favoriteBtn.Image");
            favoriteBtn.Location = new System.Drawing.Point(816, 0);
            favoriteBtn.Margin = new System.Windows.Forms.Padding(4);
            favoriteBtn.Name = "favoriteBtn";
            favoriteBtn.Size = new System.Drawing.Size(18, 20);
            favoriteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            favoriteBtn.TabIndex = 4;
            favoriteBtn.TabStop = false;
            favoriteBtn.Click += FavoriteBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(24, 4);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(0, 15);
            titleLabel.TabIndex = 3;
            titleLabel.MouseMove += titleLabel_MouseMove;
            // 
            // miniBtn
            // 
            miniBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            miniBtn.BackColor = System.Drawing.SystemColors.Control;
            miniBtn.BackgroundImage = Properties.Resources.minimize_btn;
            miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            miniBtn.ForeColor = System.Drawing.Color.Black;
            miniBtn.Location = new System.Drawing.Point(839, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += miniBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            maxBtn.BackColor = System.Drawing.SystemColors.Control;
            maxBtn.BackgroundImage = Properties.Resources.maximize_disabled_btn;
            maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = System.Drawing.Color.Black;
            maxBtn.Location = new System.Drawing.Point(860, 1);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeBtn.BackColor = System.Drawing.SystemColors.Control;
            closeBtn.BackgroundImage = Properties.Resources.close_btn;
            closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            closeBtn.ForeColor = System.Drawing.Color.Black;
            closeBtn.Location = new System.Drawing.Point(883, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // ChannelViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(910, 554);
            Controls.Add(panel1);
            Controls.Add(toolStripContainer1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Location = new System.Drawing.Point(5, 210);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "ChannelViewForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "browser";
            Load += Form1_Load;
            Shown += Form1_Shown;
            LocationChanged += ChannelViewForm_LocationChanged;
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WebView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)favoriteBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
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

