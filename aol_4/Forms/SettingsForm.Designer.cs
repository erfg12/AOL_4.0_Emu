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
            fullscreenCheckbox = new System.Windows.Forms.CheckBox();
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            homePageBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            fullnameBox = new System.Windows.Forms.TextBox();
            updateFNBtn = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            searchProvider = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            browseHistoryList = new System.Windows.Forms.ListView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            DeleteAllBrowsingHistory = new System.Windows.Forms.Button();
            deleteBrowserHistoryBtn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            cityBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            countryBox = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // fullscreenCheckbox
            // 
            fullscreenCheckbox.AutoSize = true;
            fullscreenCheckbox.Location = new System.Drawing.Point(10, 41);
            fullscreenCheckbox.Margin = new System.Windows.Forms.Padding(4);
            fullscreenCheckbox.Name = "fullscreenCheckbox";
            fullscreenCheckbox.Size = new System.Drawing.Size(110, 19);
            fullscreenCheckbox.TabIndex = 0;
            fullscreenCheckbox.Text = "Start Full Screen";
            fullscreenCheckbox.UseVisualStyleBackColor = true;
            fullscreenCheckbox.CheckedChanged += fullscreenCheckbox_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(3, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(374, 21);
            panel1.TabIndex = 3;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = System.Drawing.Color.Transparent;
            mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            mainTitle.Location = new System.Drawing.Point(4, 2);
            mainTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new System.Drawing.Size(92, 15);
            mainTitle.TabIndex = 11;
            mainTitle.Text = "General Settings";
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
            miniBtn.Location = new System.Drawing.Point(308, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += MiniBtn_Click;
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
            maxBtn.Location = new System.Drawing.Point(329, 1);
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
            closeBtn.Location = new System.Drawing.Point(353, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            button1.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Location = new System.Drawing.Point(300, 491);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(66, 26);
            button1.TabIndex = 10;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // homePageBox
            // 
            homePageBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            homePageBox.Location = new System.Drawing.Point(94, 77);
            homePageBox.Margin = new System.Windows.Forms.Padding(4);
            homePageBox.Name = "homePageBox";
            homePageBox.Size = new System.Drawing.Size(274, 23);
            homePageBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 81);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 6;
            label1.Text = "Home Page:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 111);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "Full Name:";
            // 
            // fullnameBox
            // 
            fullnameBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fullnameBox.Location = new System.Drawing.Point(94, 107);
            fullnameBox.Margin = new System.Windows.Forms.Padding(4);
            fullnameBox.Name = "fullnameBox";
            fullnameBox.Size = new System.Drawing.Size(201, 23);
            fullnameBox.TabIndex = 2;
            // 
            // updateFNBtn
            // 
            updateFNBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            updateFNBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            updateFNBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            updateFNBtn.ForeColor = System.Drawing.SystemColors.Control;
            updateFNBtn.Location = new System.Drawing.Point(304, 106);
            updateFNBtn.Margin = new System.Windows.Forms.Padding(4);
            updateFNBtn.Name = "updateFNBtn";
            updateFNBtn.Size = new System.Drawing.Size(66, 25);
            updateFNBtn.TabIndex = 3;
            updateFNBtn.Text = "Update";
            updateFNBtn.UseVisualStyleBackColor = false;
            updateFNBtn.Click += updateFNBtn_Click;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(14, 501);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(176, 15);
            label9.TabIndex = 22;
            label9.Text = "Settings are saved automatically";
            // 
            // searchProvider
            // 
            searchProvider.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            searchProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            searchProvider.FormattingEnabled = true;
            searchProvider.Items.AddRange(new object[] { "Dogpile", "Google", "Yahoo", "Bing" });
            searchProvider.Location = new System.Drawing.Point(94, 137);
            searchProvider.Margin = new System.Windows.Forms.Padding(4);
            searchProvider.Name = "searchProvider";
            searchProvider.Size = new System.Drawing.Size(274, 23);
            searchProvider.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(36, 141);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 15);
            label3.TabIndex = 24;
            label3.Text = "Search:";
            // 
            // browseHistoryList
            // 
            browseHistoryList.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            browseHistoryList.FullRowSelect = true;
            browseHistoryList.Location = new System.Drawing.Point(8, 19);
            browseHistoryList.Margin = new System.Windows.Forms.Padding(4);
            browseHistoryList.Name = "browseHistoryList";
            browseHistoryList.Size = new System.Drawing.Size(344, 192);
            browseHistoryList.TabIndex = 25;
            browseHistoryList.UseCompatibleStateImageBehavior = false;
            browseHistoryList.View = System.Windows.Forms.View.List;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(DeleteAllBrowsingHistory);
            groupBox1.Controls.Add(deleteBrowserHistoryBtn);
            groupBox1.Controls.Add(browseHistoryList);
            groupBox1.Location = new System.Drawing.Point(10, 235);
            groupBox1.Margin = new System.Windows.Forms.Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4);
            groupBox1.Size = new System.Drawing.Size(360, 249);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Browse History";
            // 
            // DeleteAllBrowsingHistory
            // 
            DeleteAllBrowsingHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            DeleteAllBrowsingHistory.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            DeleteAllBrowsingHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DeleteAllBrowsingHistory.ForeColor = System.Drawing.SystemColors.Control;
            DeleteAllBrowsingHistory.Location = new System.Drawing.Point(8, 218);
            DeleteAllBrowsingHistory.Margin = new System.Windows.Forms.Padding(4);
            DeleteAllBrowsingHistory.Name = "DeleteAllBrowsingHistory";
            DeleteAllBrowsingHistory.Size = new System.Drawing.Size(88, 26);
            DeleteAllBrowsingHistory.TabIndex = 27;
            DeleteAllBrowsingHistory.Text = "Delete All";
            DeleteAllBrowsingHistory.UseVisualStyleBackColor = false;
            DeleteAllBrowsingHistory.Click += DeleteAllBrowsingHistory_Click;
            // 
            // deleteBrowserHistoryBtn
            // 
            deleteBrowserHistoryBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            deleteBrowserHistoryBtn.BackColor = System.Drawing.Color.FromArgb(0, 109, 170);
            deleteBrowserHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deleteBrowserHistoryBtn.ForeColor = System.Drawing.SystemColors.Control;
            deleteBrowserHistoryBtn.Location = new System.Drawing.Point(290, 216);
            deleteBrowserHistoryBtn.Margin = new System.Windows.Forms.Padding(4);
            deleteBrowserHistoryBtn.Name = "deleteBrowserHistoryBtn";
            deleteBrowserHistoryBtn.Size = new System.Drawing.Size(63, 26);
            deleteBrowserHistoryBtn.TabIndex = 26;
            deleteBrowserHistoryBtn.Text = "Delete";
            deleteBrowserHistoryBtn.UseVisualStyleBackColor = false;
            deleteBrowserHistoryBtn.Click += DeleteBrowserHistoryBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(51, 171);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(31, 15);
            label4.TabIndex = 28;
            label4.Text = "City:";
            // 
            // cityBox
            // 
            cityBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cityBox.Location = new System.Drawing.Point(94, 168);
            cityBox.Margin = new System.Windows.Forms.Padding(4);
            cityBox.Name = "cityBox";
            cityBox.Size = new System.Drawing.Size(274, 23);
            cityBox.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(32, 202);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 15);
            label5.TabIndex = 30;
            label5.Text = "Country:";
            // 
            // countryBox
            // 
            countryBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            countryBox.Location = new System.Drawing.Point(94, 199);
            countryBox.Margin = new System.Windows.Forms.Padding(4);
            countryBox.Name = "countryBox";
            countryBox.Size = new System.Drawing.Size(274, 23);
            countryBox.TabIndex = 29;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 251, 240);
            ClientSize = new System.Drawing.Size(379, 531);
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
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(fullscreenCheckbox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(15, 220);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(379, 473);
            Name = "SettingsForm";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "General Settings";
            FormClosing += settings_FormClosing;
            Load += settings_Load;
            Shown += settings_Shown;
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
        private System.Windows.Forms.Button button1;
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
    }
}