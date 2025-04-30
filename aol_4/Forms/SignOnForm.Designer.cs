namespace aol.Forms
{
    partial class SignOnForm
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SignOnForm));
            label1 = new Label();
            screenName = new ComboBox();
            label2 = new Label();
            selectLocation = new ComboBox();
            signOnBtn = new Button();
            helpBtn = new Button();
            setupBtn = new Button();
            passBox = new TextBox();
            passLabel = new Label();
            accCheck = new System.Windows.Forms.Timer(components);
            leftBanner = new PictureBox();
            TitleBar = new Panel();
            mainTitle = new Label();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            ((ISupportInitialize)leftBanner).BeginInit();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold);
            label1.Location = new Point(165, 129);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 6;
            label1.Text = "Select Screen Name:";
            // 
            // screenName
            // 
            screenName.DropDownStyle = ComboBoxStyle.DropDownList;
            screenName.FormattingEnabled = true;
            screenName.Items.AddRange(new object[] { "New User", "Existing Member", "Guest" });
            screenName.Location = new Point(169, 154);
            screenName.Margin = new Padding(4);
            screenName.MaxLength = 30;
            screenName.Name = "screenName";
            screenName.Size = new Size(215, 23);
            screenName.TabIndex = 0;
            screenName.SelectedIndexChanged += ScreenName_SelectedIndexChanged;
            screenName.KeyPress += ScreenName_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold);
            label2.Location = new Point(165, 247);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 8;
            label2.Text = "Select Location:";
            // 
            // selectLocation
            // 
            selectLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            selectLocation.FormattingEnabled = true;
            selectLocation.Items.AddRange(new object[] { "ISP/LAN Connection", "Dial-Up" });
            selectLocation.Location = new Point(169, 271);
            selectLocation.Margin = new Padding(4);
            selectLocation.Name = "selectLocation";
            selectLocation.Size = new Size(215, 23);
            selectLocation.TabIndex = 2;
            selectLocation.SelectedIndexChanged += selectLocation_SelectedIndexChanged;
            // 
            // signOnBtn
            // 
            signOnBtn.BackColor = Color.FromArgb(0, 109, 170);
            signOnBtn.Cursor = Cursors.Hand;
            signOnBtn.FlatStyle = FlatStyle.Flat;
            signOnBtn.Font = new Font("Arial", 8.25F);
            signOnBtn.ForeColor = SystemColors.Control;
            signOnBtn.Location = new Point(339, 316);
            signOnBtn.Margin = new Padding(4);
            signOnBtn.Name = "signOnBtn";
            signOnBtn.Size = new Size(77, 26);
            signOnBtn.TabIndex = 5;
            signOnBtn.Text = "SIGN ON";
            signOnBtn.UseVisualStyleBackColor = false;
            signOnBtn.Click += SignOnBtn_Click;
            // 
            // helpBtn
            // 
            helpBtn.BackColor = Color.FromArgb(0, 109, 170);
            helpBtn.Cursor = Cursors.Hand;
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.Font = new Font("Arial", 8.25F);
            helpBtn.ForeColor = SystemColors.Control;
            helpBtn.Location = new Point(237, 316);
            helpBtn.Margin = new Padding(4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new Size(77, 26);
            helpBtn.TabIndex = 4;
            helpBtn.Text = "HELP";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // setupBtn
            // 
            setupBtn.BackColor = Color.FromArgb(0, 109, 170);
            setupBtn.Cursor = Cursors.Hand;
            setupBtn.FlatStyle = FlatStyle.Flat;
            setupBtn.Font = new Font("Arial", 8.25F);
            setupBtn.ForeColor = SystemColors.Control;
            setupBtn.Location = new Point(133, 316);
            setupBtn.Margin = new Padding(4);
            setupBtn.Name = "setupBtn";
            setupBtn.Size = new Size(77, 26);
            setupBtn.TabIndex = 3;
            setupBtn.Text = "SETUP";
            setupBtn.UseVisualStyleBackColor = false;
            setupBtn.Click += SetupBtn_Click;
            // 
            // passBox
            // 
            passBox.Location = new Point(169, 211);
            passBox.Margin = new Padding(4);
            passBox.MaxLength = 30;
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(215, 23);
            passBox.TabIndex = 1;
            passBox.KeyDown += PassBox_KeyDown;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Arial", 9F, FontStyle.Bold);
            passLabel.Location = new Point(165, 189);
            passLabel.Margin = new Padding(4, 0, 4, 0);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(101, 15);
            passLabel.TabIndex = 14;
            passLabel.Text = "Enter Password:";
            // 
            // accCheck
            // 
            accCheck.Enabled = true;
            accCheck.Interval = 1000;
            accCheck.Tick += AccCheck_Tick;
            // 
            // leftBanner
            // 
            leftBanner.BackgroundImageLayout = ImageLayout.Stretch;
            leftBanner.Image = (Image)resources.GetObject("leftBanner.Image");
            leftBanner.Location = new Point(1, 22);
            leftBanner.Margin = new Padding(4);
            leftBanner.Name = "leftBanner";
            leftBanner.Size = new Size(123, 348);
            leftBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBanner.TabIndex = 5;
            leftBanner.TabStop = false;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSize = true;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(mainTitle);
            TitleBar.Controls.Add(pictureBox1);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(1, 1);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(443, 24);
            TitleBar.TabIndex = 4;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(31, 2);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(49, 15);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Sign On";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(4, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
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
            closeBtn.Location = new Point(421, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            // 
            // SignOnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 240);
            ClientSize = new Size(445, 371);
            Controls.Add(passLabel);
            Controls.Add(passBox);
            Controls.Add(setupBtn);
            Controls.Add(helpBtn);
            Controls.Add(signOnBtn);
            Controls.Add(selectLocation);
            Controls.Add(label2);
            Controls.Add(screenName);
            Controls.Add(label1);
            Controls.Add(leftBanner);
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(375, 250);
            Margin = new Padding(4);
            Name = "SignOnForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "SignOnForm";
            FormClosing += AccForm_FormClosing;
            Load += AccForm_Load;
            Shown += AccForm_Shown;
            ((ISupportInitialize)leftBanner).EndInit();
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox leftBanner;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox screenName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectLocation;
        private System.Windows.Forms.Button signOnBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button setupBtn;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Timer accCheck;
    }
}