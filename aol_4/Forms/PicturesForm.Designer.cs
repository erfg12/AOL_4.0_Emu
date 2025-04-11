namespace aol.Forms
{
    partial class PicturesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicturesForm));
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            closeBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            miniBtn = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            goToPics = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(526, 22);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(204, 86);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 22);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(536, 86);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(titleLabel);
            panel1.Location = new System.Drawing.Point(1, 1);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(731, 21);
            panel1.TabIndex = 3;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox3.Image = Properties.Resources.aol_icon_4;
            pictureBox3.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox3.Location = new System.Drawing.Point(4, -1);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(21, 21);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
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
            closeBtn.Location = new System.Drawing.Point(708, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            maxBtn.BackColor = System.Drawing.SystemColors.Control;
            maxBtn.BackgroundImage = Properties.Resources.maximize_btn;
            maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = System.Drawing.Color.Black;
            maxBtn.Location = new System.Drawing.Point(685, 1);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
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
            miniBtn.Location = new System.Drawing.Point(664, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += MiniBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(27, 2);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(178, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "You've Got Pictures - Quick Start";
            titleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            label1.Location = new System.Drawing.Point(4, 110);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 13);
            label1.TabIndex = 4;
            label1.Text = "Help";
            // 
            // goToPics
            // 
            goToPics.FlatStyle = System.Windows.Forms.FlatStyle.System;
            goToPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            goToPics.Location = new System.Drawing.Point(181, 403);
            goToPics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            goToPics.Name = "goToPics";
            goToPics.Size = new System.Drawing.Size(346, 32);
            goToPics.TabIndex = 5;
            goToPics.TabStop = false;
            goToPics.Text = "Go To You've Got Pictures NOW!";
            goToPics.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.Ivory;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Location = new System.Drawing.Point(14, 242);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(144, 75);
            textBox1.TabIndex = 6;
            textBox1.TabStop = false;
            textBox1.Text = "Print a copy of Show Me\r\nHow --the easiest way to\r\nlearn about \"You've Got Pictures.\"";
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.Ivory;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Location = new System.Drawing.Point(563, 139);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(144, 75);
            textBox2.TabIndex = 7;
            textBox2.TabStop = false;
            textBox2.Text = "Click Here to receive a list\r\nof participating photo\r\ndevelopers.";
            // 
            // textBox3
            // 
            textBox3.BackColor = System.Drawing.Color.Ivory;
            textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox3.Location = new System.Drawing.Point(561, 230);
            textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new System.Drawing.Size(155, 75);
            textBox3.TabIndex = 8;
            textBox3.TabStop = false;
            textBox3.Text = "Click Here to see a sample\r\nalbum. Now you can\r\nshare personalized\r\nalbums just like this.";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(14, 136);
            pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(150, 99);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(183, 135);
            pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(346, 261);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(601, 424);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 13);
            label2.TabIndex = 11;
            label2.Text = "Keyword: Pictures";
            // 
            // PicturesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(734, 449);
            Controls.Add(label2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(goToPics);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(15, 220);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "PicturesForm";
            Text = "pictures";
            Load += Pictures_Load;
            LocationChanged += PicturesForm_LocationChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goToPics;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
    }
}