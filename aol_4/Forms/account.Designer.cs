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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.leftBanner = new System.Windows.Forms.PictureBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::aol.Properties.Resources.top_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.mainTitle);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 18);
            this.panel1.TabIndex = 4;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(26, 2);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(45, 13);
            this.mainTitle.TabIndex = 10;
            this.mainTitle.Text = "Sign On";
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.miniBtn.BackgroundImage = global::aol.Properties.Resources.minimize_btn;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBtn.ForeColor = System.Drawing.Color.Black;
            this.miniBtn.Location = new System.Drawing.Point(321, 1);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(18, 16);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.InitialImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.Location = new System.Drawing.Point(4, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.maxBtn.BackgroundImage = global::aol.Properties.Resources.maximize_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxBtn.Enabled = false;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(339, 1);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxBtn.Size = new System.Drawing.Size(18, 16);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.closeBtn.BackgroundImage = global::aol.Properties.Resources.close_btn;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Black;
            this.closeBtn.Location = new System.Drawing.Point(359, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(18, 16);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // leftBanner
            // 
            this.leftBanner.Image = ((System.Drawing.Image)(resources.GetObject("leftBanner.Image")));
            this.leftBanner.Location = new System.Drawing.Point(2, 18);
            this.leftBanner.Name = "leftBanner";
            this.leftBanner.Size = new System.Drawing.Size(100, 300);
            this.leftBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftBanner.TabIndex = 5;
            this.leftBanner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
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
            this.screenName.Location = new System.Drawing.Point(145, 133);
            this.screenName.Name = "screenName";
            this.screenName.Size = new System.Drawing.Size(185, 21);
            this.screenName.TabIndex = 0;
            this.screenName.SelectedIndexChanged += new System.EventHandler(this.screenName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Location:";
            // 
            // selectLocation
            // 
            this.selectLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLocation.FormattingEnabled = true;
            this.selectLocation.Items.AddRange(new object[] {
            "ISP/LAN Connection"});
            this.selectLocation.Location = new System.Drawing.Point(145, 235);
            this.selectLocation.Name = "selectLocation";
            this.selectLocation.Size = new System.Drawing.Size(185, 21);
            this.selectLocation.TabIndex = 2;
            // 
            // signOnBtn
            // 
            this.signOnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.signOnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOnBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOnBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.signOnBtn.Location = new System.Drawing.Point(290, 274);
            this.signOnBtn.Name = "signOnBtn";
            this.signOnBtn.Size = new System.Drawing.Size(66, 23);
            this.signOnBtn.TabIndex = 5;
            this.signOnBtn.Text = "SIGN ON";
            this.signOnBtn.UseVisualStyleBackColor = false;
            this.signOnBtn.Click += new System.EventHandler(this.signOnBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.helpBtn.Location = new System.Drawing.Point(203, 274);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(66, 23);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "HELP";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // setupBtn
            // 
            this.setupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.setupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setupBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.setupBtn.Location = new System.Drawing.Point(114, 274);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(66, 23);
            this.setupBtn.TabIndex = 3;
            this.setupBtn.Text = "SETUP";
            this.setupBtn.UseVisualStyleBackColor = false;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(145, 183);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(185, 20);
            this.passBox.TabIndex = 1;
            this.passBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passBox_KeyDown);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(142, 164);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(101, 15);
            this.passLabel.TabIndex = 14;
            this.passLabel.Text = "Enter Password:";
            // 
            // accCheck
            // 
            this.accCheck.Enabled = true;
            this.accCheck.Interval = 1000;
            this.accCheck.Tick += new System.EventHandler(this.accCheck_Tick);
            // 
            // accForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(382, 320);
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
            this.Location = new System.Drawing.Point(215, 170);
            this.Name = "accForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "accForm";
            this.Load += new System.EventHandler(this.accForm_Load);
            this.Shown += new System.EventHandler(this.accForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
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