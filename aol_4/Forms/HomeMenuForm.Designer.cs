namespace aol.Forms
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
            todayLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            titleLabel = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            temperatureLabel = new System.Windows.Forms.TextBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            mailCenterBtn = new System.Windows.Forms.PictureBox();
            YouveGotPicturesBtn = new System.Windows.Forms.PictureBox();
            aolChannelsBtn = new System.Windows.Forms.PictureBox();
            chatBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailCenterBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YouveGotPicturesBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aolChannelsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).BeginInit();
            SuspendLayout();
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.BackColor = System.Drawing.Color.LemonChiffon;
            todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F);
            todayLabel.Location = new System.Drawing.Point(295, 54);
            todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            todayLabel.Name = "todayLabel";
            todayLabel.Size = new System.Drawing.Size(28, 12);
            todayLabel.TabIndex = 4;
            todayLabel.Text = "today";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(129, 23);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(441, 312);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(titleLabel);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(2, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(568, 21);
            panel1.TabIndex = 2;
            panel1.MouseClick += panel1_MouseClick;
            panel1.MouseDoubleClick += panel1_MouseDoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.aol_icon_4;
            pictureBox2.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox2.Location = new System.Drawing.Point(4, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(21, 21);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(28, 2);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(98, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Welcome, Name!";
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
            miniBtn.Location = new System.Drawing.Point(500, 1);
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
            maxBtn.Enabled = false;
            maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = System.Drawing.Color.Black;
            maxBtn.Location = new System.Drawing.Point(522, 1);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            maxBtn.Click += maxBtn_Click;
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
            closeBtn.Location = new System.Drawing.Point(546, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // temperatureLabel
            // 
            temperatureLabel.BackColor = System.Drawing.Color.Snow;
            temperatureLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            temperatureLabel.HideSelection = false;
            temperatureLabel.Location = new System.Drawing.Point(192, 151);
            temperatureLabel.Margin = new System.Windows.Forms.Padding(4);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.ReadOnly = true;
            temperatureLabel.Size = new System.Drawing.Size(94, 16);
            temperatureLabel.TabIndex = 6;
            temperatureLabel.TabStop = false;
            temperatureLabel.Text = "Temperature";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox3.Location = new System.Drawing.Point(2, 23);
            pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(126, 92);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // mailCenterBtn
            // 
            mailCenterBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("mailCenterBtn.BackgroundImage");
            mailCenterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            mailCenterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            mailCenterBtn.Location = new System.Drawing.Point(2, 114);
            mailCenterBtn.Margin = new System.Windows.Forms.Padding(2);
            mailCenterBtn.Name = "mailCenterBtn";
            mailCenterBtn.Size = new System.Drawing.Size(126, 53);
            mailCenterBtn.TabIndex = 8;
            mailCenterBtn.TabStop = false;
            mailCenterBtn.Click += mailCenterBtn_Click;
            mailCenterBtn.MouseHover += mailCenterBtn_MouseHover;
            // 
            // YouveGotPicturesBtn
            // 
            YouveGotPicturesBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("YouveGotPicturesBtn.BackgroundImage");
            YouveGotPicturesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            YouveGotPicturesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            YouveGotPicturesBtn.Location = new System.Drawing.Point(2, 167);
            YouveGotPicturesBtn.Margin = new System.Windows.Forms.Padding(2);
            YouveGotPicturesBtn.Name = "YouveGotPicturesBtn";
            YouveGotPicturesBtn.Size = new System.Drawing.Size(126, 54);
            YouveGotPicturesBtn.TabIndex = 9;
            YouveGotPicturesBtn.TabStop = false;
            YouveGotPicturesBtn.Click += YouveGotPicturesBtn_Click;
            YouveGotPicturesBtn.MouseHover += YouveGotPicturesBtn_MouseHover;
            // 
            // aolChannelsBtn
            // 
            aolChannelsBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("aolChannelsBtn.BackgroundImage");
            aolChannelsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            aolChannelsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            aolChannelsBtn.Location = new System.Drawing.Point(2, 220);
            aolChannelsBtn.Margin = new System.Windows.Forms.Padding(2);
            aolChannelsBtn.Name = "aolChannelsBtn";
            aolChannelsBtn.Size = new System.Drawing.Size(126, 59);
            aolChannelsBtn.TabIndex = 10;
            aolChannelsBtn.TabStop = false;
            aolChannelsBtn.Click += aolChannelsBtn_Click;
            aolChannelsBtn.MouseHover += aolChannelsBtn_MouseHover;
            // 
            // chatBtn
            // 
            chatBtn.BackgroundImage = (System.Drawing.Image)resources.GetObject("chatBtn.BackgroundImage");
            chatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            chatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            chatBtn.Location = new System.Drawing.Point(2, 279);
            chatBtn.Margin = new System.Windows.Forms.Padding(2);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new System.Drawing.Size(126, 56);
            chatBtn.TabIndex = 11;
            chatBtn.TabStop = false;
            chatBtn.Click += chatBtn_Click;
            chatBtn.MouseHover += chatBtn_MouseHover;
            // 
            // HomeMenuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(247, 247, 197);
            ClientSize = new System.Drawing.Size(573, 337);
            Controls.Add(chatBtn);
            Controls.Add(aolChannelsBtn);
            Controls.Add(YouveGotPicturesBtn);
            Controls.Add(mailCenterBtn);
            Controls.Add(pictureBox3);
            Controls.Add(temperatureLabel);
            Controls.Add(todayLabel);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "HomeMenuForm";
            ShowIcon = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Welcome Home Window";
            Shown += home_menu_ShownAsync;
            MouseClick += home_menu_MouseClick;
            MouseDown += home_menu_MouseDown;
            MouseMove += home_menu_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailCenterBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)YouveGotPicturesBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)aolChannelsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox temperatureLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox mailCenterBtn;
        private System.Windows.Forms.PictureBox YouveGotPicturesBtn;
        private System.Windows.Forms.PictureBox aolChannelsBtn;
        private System.Windows.Forms.PictureBox chatBtn;
    }
}