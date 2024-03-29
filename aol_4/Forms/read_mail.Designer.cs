﻿namespace aol.Forms
{
    partial class read_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(read_mail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.miniBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.mailViewer = new System.Windows.Forms.WebBrowser();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.curID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalQty = new System.Windows.Forms.Label();
            this.replyButton = new System.Windows.Forms.PictureBox();
            this.forwardButton = new System.Windows.Forms.PictureBox();
            this.replyAllButton = new System.Windows.Forms.PictureBox();
            this.addressBookButton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replyAllButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookButton)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 35);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(6, 4);
            this.mainTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(74, 25);
            this.mainTitle.TabIndex = 8;
            this.mainTitle.Text = "Subject";
            this.mainTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.miniBtn.BackgroundImage = global::aol.Properties.Resources.minimize_btn;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miniBtn.ForeColor = System.Drawing.Color.Black;
            this.miniBtn.Location = new System.Drawing.Point(961, 2);
            this.miniBtn.Margin = new System.Windows.Forms.Padding(6);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(33, 31);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.maxBtn.BackgroundImage = global::aol.Properties.Resources.maximize_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(994, 2);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxBtn.Size = new System.Drawing.Size(33, 31);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(1030, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(33, 31);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // mailViewer
            // 
            this.mailViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailViewer.Location = new System.Drawing.Point(2, 2);
            this.mailViewer.Margin = new System.Windows.Forms.Padding(6);
            this.mailViewer.MinimumSize = new System.Drawing.Size(37, 38);
            this.mailViewer.Name = "mailViewer";
            this.mailViewer.Size = new System.Drawing.Size(898, 646);
            this.mailViewer.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 723);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(618, 723);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.helpBtn.Location = new System.Drawing.Point(944, 725);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(6);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(101, 44);
            this.helpBtn.TabIndex = 9;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(482, 723);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // curID
            // 
            this.curID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.curID.AutoSize = true;
            this.curID.Location = new System.Drawing.Point(720, 733);
            this.curID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.curID.Name = "curID";
            this.curID.Size = new System.Drawing.Size(22, 25);
            this.curID.TabIndex = 11;
            this.curID.Text = "1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 733);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "of";
            // 
            // totalQty
            // 
            this.totalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalQty.AutoSize = true;
            this.totalQty.Location = new System.Drawing.Point(772, 733);
            this.totalQty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalQty.Name = "totalQty";
            this.totalQty.Size = new System.Drawing.Size(22, 25);
            this.totalQty.TabIndex = 13;
            this.totalQty.Text = "1";
            // 
            // replyButton
            // 
            this.replyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.replyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replyButton.Image = ((System.Drawing.Image)(resources.GetObject("replyButton.Image")));
            this.replyButton.Location = new System.Drawing.Point(959, 58);
            this.replyButton.Margin = new System.Windows.Forms.Padding(6);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(75, 75);
            this.replyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.replyButton.TabIndex = 14;
            this.replyButton.TabStop = false;
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.Location = new System.Drawing.Point(959, 179);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(6);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 75);
            this.forwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forwardButton.TabIndex = 15;
            this.forwardButton.TabStop = false;
            // 
            // replyAllButton
            // 
            this.replyAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.replyAllButton.Image = ((System.Drawing.Image)(resources.GetObject("replyAllButton.Image")));
            this.replyAllButton.Location = new System.Drawing.Point(959, 300);
            this.replyAllButton.Margin = new System.Windows.Forms.Padding(6);
            this.replyAllButton.Name = "replyAllButton";
            this.replyAllButton.Size = new System.Drawing.Size(75, 75);
            this.replyAllButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.replyAllButton.TabIndex = 16;
            this.replyAllButton.TabStop = false;
            // 
            // addressBookButton
            // 
            this.addressBookButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBookButton.Image = ((System.Drawing.Image)(resources.GetObject("addressBookButton.Image")));
            this.addressBookButton.Location = new System.Drawing.Point(959, 436);
            this.addressBookButton.Margin = new System.Windows.Forms.Padding(6);
            this.addressBookButton.Name = "addressBookButton";
            this.addressBookButton.Size = new System.Drawing.Size(75, 75);
            this.addressBookButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addressBookButton.TabIndex = 17;
            this.addressBookButton.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(972, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Reply";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(962, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Forward";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(959, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reply All";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(939, 517);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Add Address";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.mailViewer);
            this.panel2.Location = new System.Drawing.Point(22, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 652);
            this.panel2.TabIndex = 22;
            // 
            // read_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1067, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressBookButton);
            this.Controls.Add(this.replyAllButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.replyButton);
            this.Controls.Add(this.totalQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.curID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 220);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "read_mail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Read Mail";
            this.Load += new System.EventHandler(this.read_mail_Load);
            this.Shown += new System.EventHandler(this.read_mail_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replyAllButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label curID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalQty;
        private System.Windows.Forms.PictureBox replyButton;
        private System.Windows.Forms.PictureBox forwardButton;
        private System.Windows.Forms.PictureBox replyAllButton;
        private System.Windows.Forms.PictureBox addressBookButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.WebBrowser mailViewer;
    }
}