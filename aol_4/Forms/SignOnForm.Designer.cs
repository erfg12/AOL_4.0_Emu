namespace aol.Forms
{
    partial class accForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accForm));
            label1 = new System.Windows.Forms.Label();
            screenName = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            selectLocation = new System.Windows.Forms.ComboBox();
            signOnBtn = new System.Windows.Forms.Button();
            helpBtn = new System.Windows.Forms.Button();
            setupBtn = new System.Windows.Forms.Button();
            passBox = new System.Windows.Forms.TextBox();
            passLabel = new System.Windows.Forms.Label();
            accCheck = new System.Windows.Forms.Timer(components);
            leftBanner = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)leftBanner).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(165, 129);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 15);
            label1.TabIndex = 6;
            label1.Text = "Select Screen Name:";
            // 
            // screenName
            // 
            screenName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            screenName.FormattingEnabled = true;
            screenName.Items.AddRange(new object[] { "New User", "Existing Member", "Guest" });
            screenName.Location = new System.Drawing.Point(169, 154);
            screenName.Margin = new System.Windows.Forms.Padding(4);
            screenName.MaxLength = 30;
            screenName.Name = "screenName";
            screenName.Size = new System.Drawing.Size(215, 23);
            screenName.TabIndex = 0;
            screenName.SelectedIndexChanged += screenName_SelectedIndexChanged;
            screenName.KeyPress += screenName_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(165, 247);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 15);
            label2.TabIndex = 8;
            label2.Text = "Select Location:";
            // 
            // selectLocation
            // 
            selectLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            selectLocation.FormattingEnabled = true;
            selectLocation.Items.AddRange(new object[] { "ISP/LAN Connection", "Dial-Up" });
            selectLocation.Location = new System.Drawing.Point(169, 271);
            selectLocation.Margin = new System.Windows.Forms.Padding(4);
            selectLocation.Name = "selectLocation";
            selectLocation.Size = new System.Drawing.Size(215, 23);
            selectLocation.TabIndex = 2;
            // 
            // signOnBtn
            // 
            signOnBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            signOnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            signOnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            signOnBtn.Font = new System.Drawing.Font("Arial", 8.25F);
            signOnBtn.ForeColor = System.Drawing.SystemColors.Control;
            signOnBtn.Location = new System.Drawing.Point(339, 316);
            signOnBtn.Margin = new System.Windows.Forms.Padding(4);
            signOnBtn.Name = "signOnBtn";
            signOnBtn.Size = new System.Drawing.Size(77, 26);
            signOnBtn.TabIndex = 5;
            signOnBtn.Text = "SIGN ON";
            signOnBtn.UseVisualStyleBackColor = false;
            signOnBtn.Click += signOnBtn_Click;
            // 
            // helpBtn
            // 
            helpBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            helpBtn.Font = new System.Drawing.Font("Arial", 8.25F);
            helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            helpBtn.Location = new System.Drawing.Point(237, 316);
            helpBtn.Margin = new System.Windows.Forms.Padding(4);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(77, 26);
            helpBtn.TabIndex = 4;
            helpBtn.Text = "HELP";
            helpBtn.UseVisualStyleBackColor = false;
            // 
            // setupBtn
            // 
            setupBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            setupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            setupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            setupBtn.Font = new System.Drawing.Font("Arial", 8.25F);
            setupBtn.ForeColor = System.Drawing.SystemColors.Control;
            setupBtn.Location = new System.Drawing.Point(133, 316);
            setupBtn.Margin = new System.Windows.Forms.Padding(4);
            setupBtn.Name = "setupBtn";
            setupBtn.Size = new System.Drawing.Size(77, 26);
            setupBtn.TabIndex = 3;
            setupBtn.Text = "SETUP";
            setupBtn.UseVisualStyleBackColor = false;
            setupBtn.Click += setupBtn_Click;
            // 
            // passBox
            // 
            passBox.Location = new System.Drawing.Point(169, 211);
            passBox.Margin = new System.Windows.Forms.Padding(4);
            passBox.MaxLength = 30;
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new System.Drawing.Size(215, 23);
            passBox.TabIndex = 1;
            passBox.KeyDown += passBox_KeyDown;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            passLabel.Location = new System.Drawing.Point(165, 189);
            passLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(101, 15);
            passLabel.TabIndex = 14;
            passLabel.Text = "Enter Password:";
            // 
            // accCheck
            // 
            accCheck.Enabled = true;
            accCheck.Interval = 1000;
            accCheck.Tick += accCheck_Tick;
            // 
            // leftBanner
            // 
            leftBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            leftBanner.Image = (System.Drawing.Image)resources.GetObject("leftBanner.Image");
            leftBanner.Location = new System.Drawing.Point(1, 22);
            leftBanner.Margin = new System.Windows.Forms.Padding(4);
            leftBanner.Name = "leftBanner";
            leftBanner.Size = new System.Drawing.Size(123, 348);
            leftBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            leftBanner.TabIndex = 5;
            leftBanner.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(443, 21);
            panel1.TabIndex = 4;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(31, 2);
            mainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(49, 15);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Sign On";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(4, -1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(21, 21);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
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
            closeBtn.Location = new System.Drawing.Point(421, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            // 
            // accForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 251, 240);
            ClientSize = new System.Drawing.Size(445, 371);
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
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(375, 250);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "accForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "accForm";
            FormClosing += accForm_FormClosing;
            Load += accForm_Load;
            Shown += accForm_Shown;
            ((System.ComponentModel.ISupportInitialize)leftBanner).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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