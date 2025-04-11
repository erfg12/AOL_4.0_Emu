﻿namespace aol.Forms
{
    partial class HomeMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenuForm));
            todayLabel = new Label();
            RightPictureBox = new PictureBox();
            TitleBar = new Panel();
            pictureBox2 = new PictureBox();
            TitleBar_TitleLabel = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            temperatureLabel = new TextBox();
            AOLLogoPictureBox = new PictureBox();
            mailCenterBtn = new PictureBox();
            YouveGotPicturesBtn = new PictureBox();
            aolChannelsBtn = new PictureBox();
            chatBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)RightPictureBox).BeginInit();
            TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AOLLogoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailCenterBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YouveGotPicturesBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aolChannelsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).BeginInit();
            SuspendLayout();
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.BackColor = Color.LemonChiffon;
            todayLabel.Font = new Font("Microsoft Sans Serif", 6.75F);
            todayLabel.Location = new Point(295, 54);
            todayLabel.Margin = new Padding(4, 0, 4, 0);
            todayLabel.Name = "todayLabel";
            todayLabel.Size = new Size(28, 12);
            todayLabel.TabIndex = 4;
            todayLabel.Text = "today";
            // 
            // RightPictureBox
            // 
            RightPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RightPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            RightPictureBox.Image = (Image)resources.GetObject("RightPictureBox.Image");
            RightPictureBox.Location = new Point(129, 23);
            RightPictureBox.Margin = new Padding(4);
            RightPictureBox.Name = "RightPictureBox";
            RightPictureBox.Size = new Size(441, 312);
            RightPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RightPictureBox.TabIndex = 3;
            RightPictureBox.TabStop = false;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(pictureBox2);
            TitleBar.Controls.Add(TitleBar_TitleLabel);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(2, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(568, 21);
            TitleBar.TabIndex = 2;
            TitleBar.MouseMove += TitleBar_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.aol_icon_4;
            pictureBox2.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox2.Location = new Point(4, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // TitleBar_TitleLabel
            // 
            TitleBar_TitleLabel.AutoSize = true;
            TitleBar_TitleLabel.BackColor = Color.Transparent;
            TitleBar_TitleLabel.ForeColor = Color.White;
            TitleBar_TitleLabel.Location = new Point(28, 2);
            TitleBar_TitleLabel.Margin = new Padding(4, 0, 4, 0);
            TitleBar_TitleLabel.Name = "TitleBar_TitleLabel";
            TitleBar_TitleLabel.Size = new Size(98, 15);
            TitleBar_TitleLabel.TabIndex = 3;
            TitleBar_TitleLabel.Text = "Welcome, Name!";
            TitleBar_TitleLabel.MouseMove += TitleBar_TitleLabel_MouseMove;
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
            miniBtn.Location = new Point(500, 1);
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
            maxBtn.Enabled = false;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(522, 1);
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
            closeBtn.Location = new Point(546, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // temperatureLabel
            // 
            temperatureLabel.BackColor = Color.Snow;
            temperatureLabel.BorderStyle = BorderStyle.None;
            temperatureLabel.HideSelection = false;
            temperatureLabel.Location = new Point(192, 151);
            temperatureLabel.Margin = new Padding(4);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.ReadOnly = true;
            temperatureLabel.Size = new Size(94, 16);
            temperatureLabel.TabIndex = 6;
            temperatureLabel.TabStop = false;
            temperatureLabel.Text = "Temperature";
            // 
            // AOLLogoPictureBox
            // 
            AOLLogoPictureBox.BackgroundImage = (Image)resources.GetObject("AOLLogoPictureBox.BackgroundImage");
            AOLLogoPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            AOLLogoPictureBox.Location = new Point(2, 23);
            AOLLogoPictureBox.Margin = new Padding(2);
            AOLLogoPictureBox.Name = "AOLLogoPictureBox";
            AOLLogoPictureBox.Size = new Size(126, 92);
            AOLLogoPictureBox.TabIndex = 7;
            AOLLogoPictureBox.TabStop = false;
            // 
            // mailCenterBtn
            // 
            mailCenterBtn.BackgroundImage = (Image)resources.GetObject("mailCenterBtn.BackgroundImage");
            mailCenterBtn.BackgroundImageLayout = ImageLayout.Stretch;
            mailCenterBtn.Cursor = Cursors.Hand;
            mailCenterBtn.Location = new Point(2, 114);
            mailCenterBtn.Margin = new Padding(2);
            mailCenterBtn.Name = "mailCenterBtn";
            mailCenterBtn.Size = new Size(126, 53);
            mailCenterBtn.TabIndex = 8;
            mailCenterBtn.TabStop = false;
            mailCenterBtn.Click += MailCenterBtn_Click;
            // 
            // YouveGotPicturesBtn
            // 
            YouveGotPicturesBtn.BackgroundImage = (Image)resources.GetObject("YouveGotPicturesBtn.BackgroundImage");
            YouveGotPicturesBtn.BackgroundImageLayout = ImageLayout.Stretch;
            YouveGotPicturesBtn.Cursor = Cursors.Hand;
            YouveGotPicturesBtn.Location = new Point(2, 167);
            YouveGotPicturesBtn.Margin = new Padding(2);
            YouveGotPicturesBtn.Name = "YouveGotPicturesBtn";
            YouveGotPicturesBtn.Size = new Size(126, 54);
            YouveGotPicturesBtn.TabIndex = 9;
            YouveGotPicturesBtn.TabStop = false;
            YouveGotPicturesBtn.Click += YouveGotPicturesBtn_Click;
            // 
            // aolChannelsBtn
            // 
            aolChannelsBtn.BackgroundImage = (Image)resources.GetObject("aolChannelsBtn.BackgroundImage");
            aolChannelsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            aolChannelsBtn.Cursor = Cursors.Hand;
            aolChannelsBtn.Location = new Point(2, 220);
            aolChannelsBtn.Margin = new Padding(2);
            aolChannelsBtn.Name = "aolChannelsBtn";
            aolChannelsBtn.Size = new Size(126, 59);
            aolChannelsBtn.TabIndex = 10;
            aolChannelsBtn.TabStop = false;
            aolChannelsBtn.Click += AolChannelsBtn_Click;
            // 
            // chatBtn
            // 
            chatBtn.BackgroundImage = (Image)resources.GetObject("chatBtn.BackgroundImage");
            chatBtn.BackgroundImageLayout = ImageLayout.Stretch;
            chatBtn.Cursor = Cursors.Hand;
            chatBtn.Location = new Point(2, 279);
            chatBtn.Margin = new Padding(2);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new Size(126, 56);
            chatBtn.TabIndex = 11;
            chatBtn.TabStop = false;
            chatBtn.Click += ChatBtn_Click;
            // 
            // HomeMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 197);
            ClientSize = new Size(573, 337);
            Controls.Add(chatBtn);
            Controls.Add(aolChannelsBtn);
            Controls.Add(YouveGotPicturesBtn);
            Controls.Add(mailCenterBtn);
            Controls.Add(AOLLogoPictureBox);
            Controls.Add(temperatureLabel);
            Controls.Add(todayLabel);
            Controls.Add(RightPictureBox);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "HomeMenuForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.Manual;
            Text = "Welcome Home Window";
            Shown += HomeMenu_ShownAsync;
            LocationChanged += HomeMenuForm_LocationChanged;
            ((System.ComponentModel.ISupportInitialize)RightPictureBox).EndInit();
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AOLLogoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailCenterBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)YouveGotPicturesBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)aolChannelsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label TitleBar_TitleLabel;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox RightPictureBox;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox temperatureLabel;
        private System.Windows.Forms.PictureBox AOLLogoPictureBox;
        private System.Windows.Forms.PictureBox mailCenterBtn;
        private System.Windows.Forms.PictureBox YouveGotPicturesBtn;
        private System.Windows.Forms.PictureBox aolChannelsBtn;
        private System.Windows.Forms.PictureBox chatBtn;
    }
}