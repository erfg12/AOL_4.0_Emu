namespace aol.Forms
{
    partial class SettingsForm
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
            fullscreenCheckbox = new CheckBox();
            TitleBar = new Panel();
            mainTitle = new Label();
            miniBtn = new Button();
            maxBtn = new Button();
            closeBtn = new Button();
            CloseBlueBtn = new Button();
            homePageBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            fullnameBox = new TextBox();
            updateFNBtn = new Button();
            label9 = new Label();
            searchProvider = new ComboBox();
            label3 = new Label();
            browseHistoryList = new ListView();
            groupBox1 = new GroupBox();
            DeleteAllBrowsingHistory = new Button();
            deleteBrowserHistoryBtn = new Button();
            label4 = new Label();
            cityBox = new TextBox();
            label5 = new Label();
            countryBox = new TextBox();
            UIScaleBox = new ComboBox();
            UIScaleLabel = new Label();
            groupBox2 = new GroupBox();
            addressLabel = new Label();
            emailAddressBox = new TextBox();
            label7 = new Label();
            emailSmtpPortBox = new TextBox();
            label10 = new Label();
            label8 = new Label();
            emailPasswordBox = new TextBox();
            emailPortBox = new Label();
            label6 = new Label();
            emailImapPortBox = new TextBox();
            emailUsernameBox = new TextBox();
            emailImapHost = new TextBox();
            label11 = new Label();
            emailSmtpHostBox = new TextBox();
            TitleBar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // fullscreenCheckbox
            // 
            fullscreenCheckbox.AutoSize = true;
            fullscreenCheckbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullscreenCheckbox.Location = new Point(10, 41);
            fullscreenCheckbox.Margin = new Padding(4);
            fullscreenCheckbox.Name = "fullscreenCheckbox";
            fullscreenCheckbox.Size = new Size(110, 19);
            fullscreenCheckbox.TabIndex = 0;
            fullscreenCheckbox.Text = "Start Full Screen";
            fullscreenCheckbox.UseVisualStyleBackColor = true;
            fullscreenCheckbox.CheckedChanged += fullscreenCheckbox_CheckedChanged;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(mainTitle);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(3, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(411, 24);
            TitleBar.TabIndex = 3;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(4, 2);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(92, 15);
            mainTitle.TabIndex = 11;
            mainTitle.Text = "General Settings";
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
            miniBtn.Location = new Point(345, 1);
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
            maxBtn.Location = new Point(366, 1);
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
            closeBtn.Location = new Point(390, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // CloseBlueBtn
            // 
            CloseBlueBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CloseBlueBtn.BackColor = Color.FromArgb(0, 109, 170);
            CloseBlueBtn.FlatStyle = FlatStyle.Flat;
            CloseBlueBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            CloseBlueBtn.ForeColor = SystemColors.Control;
            CloseBlueBtn.Location = new Point(337, 592);
            CloseBlueBtn.Margin = new Padding(4);
            CloseBlueBtn.Name = "CloseBlueBtn";
            CloseBlueBtn.Size = new Size(66, 26);
            CloseBlueBtn.TabIndex = 10;
            CloseBlueBtn.Text = "Close";
            CloseBlueBtn.UseVisualStyleBackColor = false;
            CloseBlueBtn.Click += CloseBlueBtn_Click;
            // 
            // homePageBox
            // 
            homePageBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            homePageBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            homePageBox.Location = new Point(94, 77);
            homePageBox.Margin = new Padding(4);
            homePageBox.Name = "homePageBox";
            homePageBox.Size = new Size(311, 23);
            homePageBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(10, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 6;
            label1.Text = "Home Page:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(21, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "Full Name:";
            // 
            // fullnameBox
            // 
            fullnameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullnameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullnameBox.Location = new Point(94, 107);
            fullnameBox.Margin = new Padding(4);
            fullnameBox.Name = "fullnameBox";
            fullnameBox.Size = new Size(238, 23);
            fullnameBox.TabIndex = 2;
            // 
            // updateFNBtn
            // 
            updateFNBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateFNBtn.BackColor = Color.FromArgb(0, 109, 170);
            updateFNBtn.FlatStyle = FlatStyle.Flat;
            updateFNBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            updateFNBtn.ForeColor = SystemColors.Control;
            updateFNBtn.Location = new Point(341, 106);
            updateFNBtn.Margin = new Padding(4);
            updateFNBtn.Name = "updateFNBtn";
            updateFNBtn.Size = new Size(66, 25);
            updateFNBtn.TabIndex = 3;
            updateFNBtn.Text = "Update";
            updateFNBtn.UseVisualStyleBackColor = false;
            updateFNBtn.Click += UpdateFNBtn_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.Location = new Point(14, 595);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(176, 15);
            label9.TabIndex = 22;
            label9.Text = "Settings are saved automatically";
            // 
            // searchProvider
            // 
            searchProvider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            searchProvider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchProvider.FormattingEnabled = true;
            searchProvider.Items.AddRange(new object[] { "AOL", "Google", "Yahoo", "Bing", "Dogpile" });
            searchProvider.Location = new Point(94, 137);
            searchProvider.Margin = new Padding(4);
            searchProvider.Name = "searchProvider";
            searchProvider.Size = new Size(311, 23);
            searchProvider.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(36, 141);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 24;
            label3.Text = "Search:";
            // 
            // browseHistoryList
            // 
            browseHistoryList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            browseHistoryList.FullRowSelect = true;
            browseHistoryList.Location = new Point(8, 19);
            browseHistoryList.Margin = new Padding(4);
            browseHistoryList.Name = "browseHistoryList";
            browseHistoryList.Size = new Size(381, 148);
            browseHistoryList.TabIndex = 25;
            browseHistoryList.UseCompatibleStateImageBehavior = false;
            browseHistoryList.View = View.List;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(DeleteAllBrowsingHistory);
            groupBox1.Controls.Add(deleteBrowserHistoryBtn);
            groupBox1.Controls.Add(browseHistoryList);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            groupBox1.Location = new Point(10, 380);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(397, 205);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Browse History";
            // 
            // DeleteAllBrowsingHistory
            // 
            DeleteAllBrowsingHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteAllBrowsingHistory.BackColor = Color.FromArgb(0, 109, 170);
            DeleteAllBrowsingHistory.FlatStyle = FlatStyle.Flat;
            DeleteAllBrowsingHistory.ForeColor = SystemColors.Control;
            DeleteAllBrowsingHistory.Location = new Point(45, 174);
            DeleteAllBrowsingHistory.Margin = new Padding(4);
            DeleteAllBrowsingHistory.Name = "DeleteAllBrowsingHistory";
            DeleteAllBrowsingHistory.Size = new Size(88, 26);
            DeleteAllBrowsingHistory.TabIndex = 27;
            DeleteAllBrowsingHistory.Text = "Delete All";
            DeleteAllBrowsingHistory.UseVisualStyleBackColor = false;
            DeleteAllBrowsingHistory.Click += DeleteAllBrowsingHistory_Click;
            // 
            // deleteBrowserHistoryBtn
            // 
            deleteBrowserHistoryBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteBrowserHistoryBtn.BackColor = Color.FromArgb(0, 109, 170);
            deleteBrowserHistoryBtn.FlatStyle = FlatStyle.Flat;
            deleteBrowserHistoryBtn.ForeColor = SystemColors.Control;
            deleteBrowserHistoryBtn.Location = new Point(327, 172);
            deleteBrowserHistoryBtn.Margin = new Padding(4);
            deleteBrowserHistoryBtn.Name = "deleteBrowserHistoryBtn";
            deleteBrowserHistoryBtn.Size = new Size(63, 26);
            deleteBrowserHistoryBtn.TabIndex = 26;
            deleteBrowserHistoryBtn.Text = "Delete";
            deleteBrowserHistoryBtn.UseVisualStyleBackColor = false;
            deleteBrowserHistoryBtn.Click += DeleteBrowserHistoryBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(51, 171);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 28;
            label4.Text = "City:";
            // 
            // cityBox
            // 
            cityBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cityBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            cityBox.Location = new Point(94, 168);
            cityBox.Margin = new Padding(4);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(311, 23);
            cityBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(32, 202);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 30;
            label5.Text = "Country:";
            // 
            // countryBox
            // 
            countryBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countryBox.Location = new Point(94, 199);
            countryBox.Margin = new Padding(4);
            countryBox.Name = "countryBox";
            countryBox.Size = new Size(311, 23);
            countryBox.TabIndex = 29;
            // 
            // UIScaleBox
            // 
            UIScaleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UIScaleBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            UIScaleBox.FormattingEnabled = true;
            UIScaleBox.Items.AddRange(new object[] { "1.20", "1.15", "1.10", "1.05", "1.0", "0.95", "0.90", "0.85", "0.80", "0.75", "0.70" });
            UIScaleBox.Location = new Point(309, 41);
            UIScaleBox.Name = "UIScaleBox";
            UIScaleBox.Size = new Size(59, 23);
            UIScaleBox.TabIndex = 31;
            UIScaleBox.SelectedIndexChanged += UIScaleBox_SelectedIndexChanged;
            // 
            // UIScaleLabel
            // 
            UIScaleLabel.AutoSize = true;
            UIScaleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            UIScaleLabel.Location = new Point(257, 47);
            UIScaleLabel.Name = "UIScaleLabel";
            UIScaleLabel.Size = new Size(48, 15);
            UIScaleLabel.TabIndex = 32;
            UIScaleLabel.Text = "UI Scale";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(emailSmtpHostBox);
            groupBox2.Controls.Add(addressLabel);
            groupBox2.Controls.Add(emailAddressBox);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(emailSmtpPortBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(emailPasswordBox);
            groupBox2.Controls.Add(emailPortBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(emailImapPortBox);
            groupBox2.Controls.Add(emailUsernameBox);
            groupBox2.Controls.Add(emailImapHost);
            groupBox2.Location = new Point(10, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(397, 144);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Email";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            addressLabel.Location = new Point(21, 21);
            addressLabel.Margin = new Padding(4, 0, 4, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 42;
            addressLabel.Text = "Address:";
            // 
            // emailAddressBox
            // 
            emailAddressBox.Location = new Point(80, 18);
            emailAddressBox.Name = "emailAddressBox";
            emailAddressBox.Size = new Size(309, 23);
            emailAddressBox.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.Location = new Point(196, 79);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 40;
            label7.Text = "SMTP Port:";
            // 
            // emailSmtpPortBox
            // 
            emailSmtpPortBox.Location = new Point(263, 76);
            emailSmtpPortBox.Name = "emailSmtpPortBox";
            emailSmtpPortBox.Size = new Size(59, 23);
            emailSmtpPortBox.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label10.Location = new Point(199, 109);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 38;
            label10.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.Location = new Point(10, 109);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 37;
            label8.Text = "Username:";
            // 
            // emailPasswordBox
            // 
            emailPasswordBox.Location = new Point(261, 105);
            emailPasswordBox.Name = "emailPasswordBox";
            emailPasswordBox.PasswordChar = '*';
            emailPasswordBox.Size = new Size(128, 23);
            emailPasswordBox.TabIndex = 36;
            // 
            // emailPortBox
            // 
            emailPortBox.AutoSize = true;
            emailPortBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            emailPortBox.Location = new Point(198, 50);
            emailPortBox.Margin = new Padding(4, 0, 4, 0);
            emailPortBox.Name = "emailPortBox";
            emailPortBox.Size = new Size(64, 15);
            emailPortBox.TabIndex = 35;
            emailPortBox.Text = "IMAP Port:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.Location = new Point(8, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 34;
            label6.Text = "IMAP Host:";
            // 
            // emailImapPortBox
            // 
            emailImapPortBox.Location = new Point(263, 47);
            emailImapPortBox.Name = "emailImapPortBox";
            emailImapPortBox.Size = new Size(59, 23);
            emailImapPortBox.TabIndex = 2;
            // 
            // emailUsernameBox
            // 
            emailUsernameBox.Location = new Point(80, 105);
            emailUsernameBox.Name = "emailUsernameBox";
            emailUsernameBox.Size = new Size(114, 23);
            emailUsernameBox.TabIndex = 1;
            // 
            // emailImapHost
            // 
            emailImapHost.Location = new Point(80, 47);
            emailImapHost.Name = "emailImapHost";
            emailImapHost.Size = new Size(114, 23);
            emailImapHost.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label11.Location = new Point(8, 79);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 44;
            label11.Text = "SMTP Host:";
            // 
            // emailSmtpHostBox
            // 
            emailSmtpHostBox.Location = new Point(80, 76);
            emailSmtpHostBox.Name = "emailSmtpHostBox";
            emailSmtpHostBox.Size = new Size(114, 23);
            emailSmtpHostBox.TabIndex = 43;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 240);
            ClientSize = new Size(416, 625);
            Controls.Add(groupBox2);
            Controls.Add(UIScaleLabel);
            Controls.Add(UIScaleBox);
            Controls.Add(label5);
            Controls.Add(countryBox);
            Controls.Add(label4);
            Controls.Add(cityBox);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(searchProvider);
            Controls.Add(label9);
            Controls.Add(updateFNBtn);
            Controls.Add(label2);
            Controls.Add(fullnameBox);
            Controls.Add(label1);
            Controls.Add(homePageBox);
            Controls.Add(CloseBlueBtn);
            Controls.Add(TitleBar);
            Controls.Add(fullscreenCheckbox);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(15, 220);
            Margin = new Padding(4);
            MinimumSize = new Size(379, 473);
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "General Settings";
            FormClosing += Settings_FormClosing;
            Shown += Settings_Shown;
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fullscreenCheckbox;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button CloseBlueBtn;
        private System.Windows.Forms.TextBox homePageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullnameBox;
        private System.Windows.Forms.Button updateFNBtn;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox searchProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView browseHistoryList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBrowserHistoryBtn;
        private System.Windows.Forms.Button DeleteAllBrowsingHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox countryBox;
        private ComboBox UIScaleBox;
        private Label UIScaleLabel;
        private GroupBox groupBox2;
        private TextBox emailPasswordBox;
        private Label emailPortBox;
        private Label label6;
        private TextBox emailImapPortBox;
        private TextBox emailUsernameBox;
        private TextBox emailImapHost;
        private Label label10;
        private Label label8;
        private Label label7;
        private TextBox emailSmtpPortBox;
        private Label addressLabel;
        private TextBox emailAddressBox;
        private Label label11;
        private TextBox emailSmtpHostBox;
    }
}