﻿namespace aol.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accForm));
            this.label1 = new System.Windows.Forms.Label();
            this.screenName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectLocation = new System.Windows.Forms.ComboBox();
            this.signOnBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.setupBtn = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.accCheck = new System.Windows.Forms.Timer(this.components);
            this.leftBanner = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftBanner)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Screen Name:";
            // 
            // screenName
            // 
            this.screenName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenName.FormattingEnabled = true;
            this.screenName.Items.AddRange(new object[] {
            "New User",
            "Existing Member",
            "Guest"});
            this.screenName.Location = new System.Drawing.Point(266, 256);
            this.screenName.Margin = new System.Windows.Forms.Padding(6);
            this.screenName.Name = "screenName";
            this.screenName.Size = new System.Drawing.Size(336, 33);
            this.screenName.TabIndex = 0;
            this.screenName.SelectedIndexChanged += new System.EventHandler(this.screenName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 412);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Location:";
            // 
            // selectLocation
            // 
            this.selectLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLocation.FormattingEnabled = true;
            this.selectLocation.Items.AddRange(new object[] {
            "ISP/LAN Connection",
            "Dial-Up"});
            this.selectLocation.Location = new System.Drawing.Point(266, 452);
            this.selectLocation.Margin = new System.Windows.Forms.Padding(6);
            this.selectLocation.Name = "selectLocation";
            this.selectLocation.Size = new System.Drawing.Size(336, 33);
            this.selectLocation.TabIndex = 2;
            // 
            // signOnBtn
            // 
            this.signOnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.signOnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOnBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signOnBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signOnBtn.Location = new System.Drawing.Point(532, 527);
            this.signOnBtn.Margin = new System.Windows.Forms.Padding(6);
            this.signOnBtn.Name = "signOnBtn";
            this.signOnBtn.Size = new System.Drawing.Size(121, 44);
            this.signOnBtn.TabIndex = 5;
            this.signOnBtn.Text = "SIGN ON";
            this.signOnBtn.UseVisualStyleBackColor = false;
            this.signOnBtn.Click += new System.EventHandler(this.signOnBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.helpBtn.Location = new System.Drawing.Point(372, 527);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(6);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(121, 44);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "HELP";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // setupBtn
            // 
            this.setupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.setupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setupBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.setupBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.setupBtn.Location = new System.Drawing.Point(209, 527);
            this.setupBtn.Margin = new System.Windows.Forms.Padding(6);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(121, 44);
            this.setupBtn.TabIndex = 3;
            this.setupBtn.Text = "SETUP";
            this.setupBtn.UseVisualStyleBackColor = false;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(266, 352);
            this.passBox.Margin = new System.Windows.Forms.Padding(6);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(336, 33);
            this.passBox.TabIndex = 1;
            this.passBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passBox_KeyDown);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(260, 315);
            this.passLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(155, 21);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "Enter Password:";
            // 
            // accCheck
            // 
            this.accCheck.Enabled = true;
            this.accCheck.Interval = 1000;
            this.accCheck.Tick += new System.EventHandler(this.accCheck_Tick);
            // 
            // leftBanner
            // 
            this.leftBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftBanner.Image = ((System.Drawing.Image)(resources.GetObject("leftBanner.Image")));
            this.leftBanner.Location = new System.Drawing.Point(4, 38);
            this.leftBanner.Margin = new System.Windows.Forms.Padding(6);
            this.leftBanner.Name = "leftBanner";
            this.leftBanner.Size = new System.Drawing.Size(193, 580);
            this.leftBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftBanner.TabIndex = 5;
            this.leftBanner.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::aol.Properties.Resources.top_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.mainTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 35);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(48, 4);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(79, 25);
            this.mainTitle.TabIndex = 10;
            this.mainTitle.Text = "Sign On";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.InitialImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.Location = new System.Drawing.Point(7, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.BackgroundImage = global::aol.Properties.Resources.close_btn;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(658, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(33, 31);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // accForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(700, 619);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.setupBtn);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.signOnBtn);
            this.Controls.Add(this.selectLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.screenName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftBanner);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(375, 250);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "accForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "accForm";
            this.Load += new System.EventHandler(this.accForm_Load);
            this.Shown += new System.EventHandler(this.accForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.leftBanner)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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