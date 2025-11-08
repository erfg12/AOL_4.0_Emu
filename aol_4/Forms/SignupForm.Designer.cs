namespace aol.Forms
{
    partial class SignupForm
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(SignupForm));
            TitleBar = new Panel();
            mainTitle = new Label();
            miniBtn = new Button();
            pictureBox1 = new PictureBox();
            maxBtn = new Button();
            closeBtn = new Button();
            newAOL = new RadioButton();
            oldAOL = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            nextBtn = new PictureBox();
            leftBanner = new PictureBox();
            label3 = new Label();
            cancelBtn = new Button();
            label4 = new Label();
            recoverUser = new TextBox();
            recoverPass = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            LoadingLabel = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            password = new TextBox();
            fullname = new TextBox();
            username = new TextBox();
            backBtn = new PictureBox();
            registerBtn = new PictureBox();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)nextBtn).BeginInit();
            ((ISupportInitialize)leftBanner).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((ISupportInitialize)backBtn).BeginInit();
            ((ISupportInitialize)registerBtn).BeginInit();
            SuspendLayout();
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
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(pictureBox1);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Location = new Point(3, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(665, 24);
            TitleBar.TabIndex = 5;
            // 
            // mainTitle
            // 
            mainTitle.AutoSize = true;
            mainTitle.BackColor = Color.Transparent;
            mainTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainTitle.ForeColor = Color.WhiteSmoke;
            mainTitle.Location = new Point(31, 2);
            mainTitle.Margin = new Padding(4, 0, 4, 0);
            mainTitle.Name = "mainTitle";
            mainTitle.Size = new Size(170, 15);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Create Your AOL Account Now";
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
            miniBtn.Location = new Point(598, 1);
            miniBtn.Margin = new Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
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
            maxBtn.Location = new Point(620, 1);
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
            closeBtn.Location = new Point(643, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // newAOL
            // 
            newAOL.AutoSize = true;
            newAOL.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Pixel);
            newAOL.Location = new Point(28, 80);
            newAOL.Margin = new Padding(4);
            newAOL.Name = "newAOL";
            newAOL.Size = new Size(390, 20);
            newAOL.TabIndex = 6;
            newAOL.Text = "Yes, I would like a NEW AOL e-email address and Screen Name!";
            newAOL.UseVisualStyleBackColor = true;
            // 
            // oldAOL
            // 
            oldAOL.AutoSize = true;
            oldAOL.Checked = true;
            oldAOL.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Pixel);
            oldAOL.Location = new Point(28, 127);
            oldAOL.Margin = new Padding(4);
            oldAOL.Name = "oldAOL";
            oldAOL.Size = new Size(441, 20);
            oldAOL.TabIndex = 7;
            oldAOL.TabStop = true;
            oldAOL.Text = "No, I already have an AOL account or e-email address and Screen Name.";
            oldAOL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(10, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 22);
            label1.TabIndex = 8;
            label1.Text = "Create Your AOL Account Now";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Pixel);
            label2.Location = new Point(15, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(321, 15);
            label2.TabIndex = 9;
            label2.Text = "Select which of the following statements applies to you:";
            // 
            // nextBtn
            // 
            nextBtn.BackgroundImageLayout = ImageLayout.Stretch;
            nextBtn.Cursor = Cursors.Hand;
            nextBtn.Image = (Image)resources.GetObject("nextBtn.Image");
            nextBtn.Location = new Point(486, 307);
            nextBtn.Margin = new Padding(4);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(50, 28);
            nextBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            nextBtn.TabIndex = 10;
            nextBtn.TabStop = false;
            nextBtn.Click += NextBtn_Click;
            // 
            // leftBanner
            // 
            leftBanner.BackgroundImageLayout = ImageLayout.Stretch;
            leftBanner.Image = (Image)resources.GetObject("leftBanner.Image");
            leftBanner.Location = new Point(3, 21);
            leftBanner.Margin = new Padding(4);
            leftBanner.Name = "leftBanner";
            leftBanner.Size = new Size(118, 346);
            leftBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            leftBanner.TabIndex = 11;
            leftBanner.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(24, 103);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(462, 15);
            label3.TabIndex = 12;
            label3.Text = "Click this button if you do not have an AOL Screen Name or an existing AOL account.";
            // 
            // cancelBtn
            // 
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(24, 307);
            cancelBtn.Margin = new Padding(4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(62, 26);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(24, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(426, 15);
            label4.TabIndex = 14;
            label4.Text = "Click this button if you are already an AOL member and have a Screen Name.";
            // 
            // recoverUser
            // 
            recoverUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            recoverUser.Location = new Point(312, 173);
            recoverUser.Margin = new Padding(4);
            recoverUser.MaxLength = 30;
            recoverUser.Name = "recoverUser";
            recoverUser.Size = new Size(197, 23);
            recoverUser.TabIndex = 15;
            recoverUser.KeyPress += RecoverUser_KeyPress;
            // 
            // recoverPass
            // 
            recoverPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            recoverPass.Location = new Point(312, 199);
            recoverPass.Margin = new Padding(4);
            recoverPass.MaxLength = 30;
            recoverPass.Name = "recoverPass";
            recoverPass.Size = new Size(197, 23);
            recoverPass.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(92, 176);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 15);
            label5.TabIndex = 17;
            label5.Text = "Type your Screen Name in here:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Pixel);
            label6.Location = new Point(109, 202);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 15);
            label6.TabIndex = 18;
            label6.Text = "Please enter your Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.Location = new Point(24, 225);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(433, 15);
            label7.TabIndex = 19;
            label7.Text = "Tip: You can have up to seven active screen names on your AOL account. If you";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.Location = new Point(24, 240);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(424, 15);
            label8.TabIndex = 20;
            label8.Text = "would like to add a screen name, sign in with your existing screen name and";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Pixel);
            label9.Location = new Point(24, 255);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(228, 15);
            label9.TabIndex = 21;
            label9.Text = "password and go to myaccount.aol.com.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Pixel);
            label10.Location = new Point(24, 278);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(127, 15);
            label10.TabIndex = 22;
            label10.Text = "Click Next to continue.";
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(nextBtn);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(newAOL);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(oldAOL);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(recoverPass);
            panel2.Controls.Add(cancelBtn);
            panel2.Controls.Add(recoverUser);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(119, 22);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 345);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(LoadingLabel);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(password);
            panel3.Controls.Add(fullname);
            panel3.Controls.Add(username);
            panel3.Controls.Add(backBtn);
            panel3.Controls.Add(registerBtn);
            panel3.Location = new Point(119, 24);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 341);
            panel3.TabIndex = 23;
            // 
            // LoadingLabel
            // 
            LoadingLabel.AutoSize = true;
            LoadingLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LoadingLabel.ForeColor = SystemColors.Highlight;
            LoadingLabel.Location = new Point(168, 238);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new Size(0, 28);
            LoadingLabel.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(165, 181);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(91, 25);
            label13.TabIndex = 7;
            label13.Text = "Password:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(164, 121);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(95, 25);
            label12.TabIndex = 6;
            label12.Text = "Full Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(164, 64);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(95, 25);
            label11.TabIndex = 5;
            label11.Text = "Username:";
            // 
            // password
            // 
            password.Location = new Point(168, 200);
            password.Margin = new Padding(4);
            password.Name = "password";
            password.Size = new Size(213, 31);
            password.TabIndex = 4;
            // 
            // fullname
            // 
            fullname.Location = new Point(168, 141);
            fullname.Margin = new Padding(4);
            fullname.Name = "fullname";
            fullname.Size = new Size(213, 31);
            fullname.TabIndex = 3;
            // 
            // username
            // 
            username.Location = new Point(168, 82);
            username.Margin = new Padding(4);
            username.Name = "username";
            username.Size = new Size(213, 31);
            username.TabIndex = 2;
            // 
            // backBtn
            // 
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new Point(14, 299);
            backBtn.Margin = new Padding(4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(39, 23);
            backBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            backBtn.TabIndex = 1;
            backBtn.TabStop = false;
            backBtn.Click += BackBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.Image = (Image)resources.GetObject("registerBtn.Image");
            registerBtn.Location = new Point(486, 307);
            registerBtn.Margin = new Padding(4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(40, 23);
            registerBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            registerBtn.TabIndex = 0;
            registerBtn.TabStop = false;
            registerBtn.Click += RegisterBtn_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 369);
            Controls.Add(leftBanner);
            Controls.Add(TitleBar);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(100, 150);
            Margin = new Padding(4);
            Name = "SignupForm";
            StartPosition = FormStartPosition.Manual;
            Text = "signup_form";
            Shown += SignupForm_Shown;
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)nextBtn).EndInit();
            ((ISupportInitialize)leftBanner).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((ISupportInitialize)backBtn).EndInit();
            ((ISupportInitialize)registerBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.RadioButton newAOL;
        private System.Windows.Forms.RadioButton oldAOL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.PictureBox leftBanner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox recoverUser;
        private System.Windows.Forms.TextBox recoverPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.PictureBox registerBtn;
        private Label LoadingLabel;
    }
}