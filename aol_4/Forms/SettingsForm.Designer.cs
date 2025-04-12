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
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // fullscreenCheckbox
            // 
            fullscreenCheckbox.AutoSize = true;
            fullscreenCheckbox.Location = new Point(10, 41);
            fullscreenCheckbox.Margin = new Padding(4);
            fullscreenCheckbox.Name = "fullscreenCheckbox";
            fullscreenCheckbox.Size = new Size(110, 19);
            fullscreenCheckbox.TabIndex = 0;
            fullscreenCheckbox.Text = "Start Full Screen";
            fullscreenCheckbox.UseVisualStyleBackColor = true;
            fullscreenCheckbox.CheckedChanged += fullscreenCheckbox_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 21);
            panel1.TabIndex = 3;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
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
            miniBtn.Location = new Point(308, 1);
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
            maxBtn.Location = new Point(329, 1);
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
            closeBtn.Location = new Point(353, 1);
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
            CloseBlueBtn.ForeColor = SystemColors.Control;
            CloseBlueBtn.Location = new Point(300, 491);
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
            homePageBox.Location = new Point(94, 77);
            homePageBox.Margin = new Padding(4);
            homePageBox.Name = "homePageBox";
            homePageBox.Size = new Size(274, 23);
            homePageBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            fullnameBox.Location = new Point(94, 107);
            fullnameBox.Margin = new Padding(4);
            fullnameBox.Name = "fullnameBox";
            fullnameBox.Size = new Size(201, 23);
            fullnameBox.TabIndex = 2;
            // 
            // updateFNBtn
            // 
            updateFNBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateFNBtn.BackColor = Color.FromArgb(0, 109, 170);
            updateFNBtn.FlatStyle = FlatStyle.Flat;
            updateFNBtn.ForeColor = SystemColors.Control;
            updateFNBtn.Location = new Point(304, 106);
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
            label9.Location = new Point(14, 501);
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
            searchProvider.FormattingEnabled = true;
            searchProvider.Items.AddRange(new object[] { "Dogpile", "Google", "Yahoo", "Bing" });
            searchProvider.Location = new Point(94, 137);
            searchProvider.Margin = new Padding(4);
            searchProvider.Name = "searchProvider";
            searchProvider.Size = new Size(274, 23);
            searchProvider.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
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
            browseHistoryList.Size = new Size(344, 192);
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
            groupBox1.Location = new Point(10, 235);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(360, 249);
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
            DeleteAllBrowsingHistory.Location = new Point(8, 218);
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
            deleteBrowserHistoryBtn.Location = new Point(290, 216);
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
            cityBox.Location = new Point(94, 168);
            cityBox.Margin = new Padding(4);
            cityBox.Name = "cityBox";
            cityBox.Size = new Size(274, 23);
            cityBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
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
            countryBox.Size = new Size(274, 23);
            countryBox.TabIndex = 29;
            // 
            // UIScaleBox
            // 
            UIScaleBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
            UIScaleLabel.Location = new Point(257, 44);
            UIScaleLabel.Name = "UIScaleLabel";
            UIScaleLabel.Size = new Size(48, 15);
            UIScaleLabel.TabIndex = 32;
            UIScaleLabel.Text = "UI Scale";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 240);
            ClientSize = new Size(379, 531);
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
            Controls.Add(panel1);
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
            LocationChanged += SettingsForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fullscreenCheckbox;
        private System.Windows.Forms.Panel panel1;
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
    }
}