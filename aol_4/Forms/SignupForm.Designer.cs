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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            panel1 = new System.Windows.Forms.Panel();
            mainTitle = new System.Windows.Forms.Label();
            miniBtn = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            maxBtn = new System.Windows.Forms.Button();
            closeBtn = new System.Windows.Forms.Button();
            newAOL = new System.Windows.Forms.RadioButton();
            oldAOL = new System.Windows.Forms.RadioButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nextBtn = new System.Windows.Forms.PictureBox();
            leftBanner = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            cancelBtn = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            recoverUser = new System.Windows.Forms.TextBox();
            recoverPass = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            password = new System.Windows.Forms.TextBox();
            fullname = new System.Windows.Forms.TextBox();
            username = new System.Windows.Forms.TextBox();
            backBtn = new System.Windows.Forms.PictureBox();
            registerBtn = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftBanner).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registerBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(mainTitle);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(closeBtn);
            panel1.Location = new System.Drawing.Point(3, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(665, 21);
            panel1.TabIndex = 5;
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
            mainTitle.Size = new System.Drawing.Size(170, 15);
            mainTitle.TabIndex = 10;
            mainTitle.Text = "Create Your AOL Account Now";
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
            miniBtn.Location = new System.Drawing.Point(598, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
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
            maxBtn.Location = new System.Drawing.Point(620, 1);
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
            closeBtn.Location = new System.Drawing.Point(643, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // newAOL
            // 
            newAOL.AutoSize = true;
            newAOL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            newAOL.Location = new System.Drawing.Point(28, 80);
            newAOL.Margin = new System.Windows.Forms.Padding(4);
            newAOL.Name = "newAOL";
            newAOL.Size = new System.Drawing.Size(370, 18);
            newAOL.TabIndex = 6;
            newAOL.Text = "Yes, I would like a NEW AOL e-email address and Screen Name!";
            newAOL.UseVisualStyleBackColor = true;
            // 
            // oldAOL
            // 
            oldAOL.AutoSize = true;
            oldAOL.Checked = true;
            oldAOL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            oldAOL.Location = new System.Drawing.Point(28, 127);
            oldAOL.Margin = new System.Windows.Forms.Padding(4);
            oldAOL.Name = "oldAOL";
            oldAOL.Size = new System.Drawing.Size(418, 18);
            oldAOL.TabIndex = 7;
            oldAOL.TabStop = true;
            oldAOL.Text = "No, I already have an AOL account or e-email address and Screen Name.";
            oldAOL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 16F);
            label1.Location = new System.Drawing.Point(10, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(307, 25);
            label1.TabIndex = 8;
            label1.Text = "Create Your AOL Account Now";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(15, 49);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(316, 14);
            label2.TabIndex = 9;
            label2.Text = "Select which of the following statements applies to you:";
            // 
            // nextBtn
            // 
            nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            nextBtn.Image = (System.Drawing.Image)resources.GetObject("nextBtn.Image");
            nextBtn.Location = new System.Drawing.Point(486, 307);
            nextBtn.Margin = new System.Windows.Forms.Padding(4);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new System.Drawing.Size(50, 28);
            nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            nextBtn.TabIndex = 10;
            nextBtn.TabStop = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // leftBanner
            // 
            leftBanner.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            leftBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            leftBanner.Image = (System.Drawing.Image)resources.GetObject("leftBanner.Image");
            leftBanner.Location = new System.Drawing.Point(3, 21);
            leftBanner.Margin = new System.Windows.Forms.Padding(4);
            leftBanner.Name = "leftBanner";
            leftBanner.Size = new System.Drawing.Size(119, 346);
            leftBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            leftBanner.TabIndex = 11;
            leftBanner.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Arial", 8.25F);
            label3.Location = new System.Drawing.Point(24, 103);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(416, 14);
            label3.TabIndex = 12;
            label3.Text = "Click this button if you do not have an AOL Screen Name or an existing AOL account.";
            // 
            // cancelBtn
            // 
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            cancelBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            cancelBtn.Location = new System.Drawing.Point(24, 307);
            cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new System.Drawing.Size(62, 26);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial", 8.25F);
            label4.Location = new System.Drawing.Point(24, 151);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(378, 14);
            label4.TabIndex = 14;
            label4.Text = "Click this button if you are already an AOL member and have a Screen Name.";
            // 
            // recoverUser
            // 
            recoverUser.Location = new System.Drawing.Point(312, 173);
            recoverUser.Margin = new System.Windows.Forms.Padding(4);
            recoverUser.MaxLength = 30;
            recoverUser.Name = "recoverUser";
            recoverUser.Size = new System.Drawing.Size(197, 23);
            recoverUser.TabIndex = 15;
            recoverUser.KeyPress += recoverUser_KeyPress;
            // 
            // recoverPass
            // 
            recoverPass.Location = new System.Drawing.Point(312, 199);
            recoverPass.Margin = new System.Windows.Forms.Padding(4);
            recoverPass.MaxLength = 30;
            recoverPass.Name = "recoverPass";
            recoverPass.Size = new System.Drawing.Size(197, 23);
            recoverPass.TabIndex = 16;
            recoverPass.KeyPress += recoverPass_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(92, 176);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(182, 14);
            label5.TabIndex = 17;
            label5.Text = "Type your Screen Name in here:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(109, 202);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(167, 14);
            label6.TabIndex = 18;
            label6.Text = "Please enter your Password:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Arial", 8.25F);
            label7.Location = new System.Drawing.Point(24, 225);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(397, 14);
            label7.TabIndex = 19;
            label7.Text = "Tip: You can have up to seven active screen names on your AOL account. If you";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Arial", 8.25F);
            label8.Location = new System.Drawing.Point(24, 240);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(376, 14);
            label8.TabIndex = 20;
            label8.Text = "would like to add a screen name, sign in with your existing screen name and";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Arial", 8.25F);
            label9.Location = new System.Drawing.Point(24, 255);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(204, 14);
            label9.TabIndex = 21;
            label9.Text = "password and go to myaccount.aol.com.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Arial", 8.25F);
            label10.Location = new System.Drawing.Point(24, 278);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(113, 14);
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
            panel2.Location = new System.Drawing.Point(119, 22);
            panel2.Margin = new System.Windows.Forms.Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(549, 345);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(password);
            panel3.Controls.Add(fullname);
            panel3.Controls.Add(username);
            panel3.Controls.Add(backBtn);
            panel3.Controls.Add(registerBtn);
            panel3.Location = new System.Drawing.Point(119, 24);
            panel3.Margin = new System.Windows.Forms.Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(549, 341);
            panel3.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(165, 181);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(60, 15);
            label13.TabIndex = 7;
            label13.Text = "Password:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(164, 121);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(64, 15);
            label12.TabIndex = 6;
            label12.Text = "Full Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(164, 64);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(63, 15);
            label11.TabIndex = 5;
            label11.Text = "Username:";
            // 
            // password
            // 
            password.Location = new System.Drawing.Point(168, 200);
            password.Margin = new System.Windows.Forms.Padding(4);
            password.Name = "password";
            password.Size = new System.Drawing.Size(213, 23);
            password.TabIndex = 4;
            // 
            // fullname
            // 
            fullname.Location = new System.Drawing.Point(168, 141);
            fullname.Margin = new System.Windows.Forms.Padding(4);
            fullname.Name = "fullname";
            fullname.Size = new System.Drawing.Size(213, 23);
            fullname.TabIndex = 3;
            // 
            // username
            // 
            username.Location = new System.Drawing.Point(168, 82);
            username.Margin = new System.Windows.Forms.Padding(4);
            username.Name = "username";
            username.Size = new System.Drawing.Size(213, 23);
            username.TabIndex = 2;
            // 
            // backBtn
            // 
            backBtn.Image = (System.Drawing.Image)resources.GetObject("backBtn.Image");
            backBtn.Location = new System.Drawing.Point(14, 299);
            backBtn.Margin = new System.Windows.Forms.Padding(4);
            backBtn.Name = "backBtn";
            backBtn.Size = new System.Drawing.Size(39, 23);
            backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            backBtn.TabIndex = 1;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Image = (System.Drawing.Image)resources.GetObject("registerBtn.Image");
            registerBtn.Location = new System.Drawing.Point(486, 307);
            registerBtn.Margin = new System.Windows.Forms.Padding(4);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new System.Drawing.Size(40, 23);
            registerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            registerBtn.TabIndex = 0;
            registerBtn.TabStop = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(669, 369);
            Controls.Add(leftBanner);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(100, 150);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "SignupForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "signup_form";
            Shown += signup_form_Shown;
            LocationChanged += SignupForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftBanner).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)registerBtn).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}