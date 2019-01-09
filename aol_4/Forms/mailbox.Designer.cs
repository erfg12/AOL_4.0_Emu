namespace aol
{
    partial class mailbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mailbox));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.readBtn = new System.Windows.Forms.Button();
            this.statusBtn = new System.Windows.Forms.Button();
            this.keepBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.newListview = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 345);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.tabPage1.Controls.Add(this.newListview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Mail";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Old Mail";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(676, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sent Mail";
            // 
            // readBtn
            // 
            this.readBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.readBtn.Location = new System.Drawing.Point(12, 435);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(57, 23);
            this.readBtn.TabIndex = 4;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = false;
            // 
            // statusBtn
            // 
            this.statusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.statusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.statusBtn.Location = new System.Drawing.Point(75, 435);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(55, 23);
            this.statusBtn.TabIndex = 5;
            this.statusBtn.Text = "Status";
            this.statusBtn.UseVisualStyleBackColor = false;
            // 
            // keepBtn
            // 
            this.keepBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.keepBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.keepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keepBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.keepBtn.Location = new System.Drawing.Point(216, 435);
            this.keepBtn.Name = "keepBtn";
            this.keepBtn.Size = new System.Drawing.Size(95, 23);
            this.keepBtn.TabIndex = 6;
            this.keepBtn.Text = "Keep As New";
            this.keepBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteBtn.Location = new System.Drawing.Point(317, 435);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(55, 23);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // helpBtn
            // 
            this.helpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(170)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.helpBtn.Location = new System.Drawing.Point(637, 435);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(55, 23);
            this.helpBtn.TabIndex = 8;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "REMINDER: AOL Staff will never ask for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "your password or billing information.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
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
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 18);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainTitle.Location = new System.Drawing.Point(23, 2);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(114, 13);
            this.mainTitle.TabIndex = 8;
            this.mainTitle.Text = "Name\'s Online Mailbox";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.InitialImage = global::aol.Properties.Resources.aol_icon_4;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // miniBtn
            // 
            this.miniBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBtn.BackColor = System.Drawing.SystemColors.Control;
            this.miniBtn.BackgroundImage = global::aol.Properties.Resources.minimize_btn;
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miniBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniBtn.ForeColor = System.Drawing.Color.Black;
            this.miniBtn.Location = new System.Drawing.Point(650, 1);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(18, 16);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.maxBtn.BackgroundImage = global::aol.Properties.Resources.maximize_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(668, 1);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxBtn.Size = new System.Drawing.Size(18, 16);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(688, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(18, 16);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // newListview
            // 
            this.newListview.Location = new System.Drawing.Point(9, 7);
            this.newListview.Name = "newListview";
            this.newListview.Size = new System.Drawing.Size(659, 306);
            this.newListview.TabIndex = 0;
            this.newListview.UseCompatibleStateImageBehavior = false;
            this.newListview.View = System.Windows.Forms.View.Details;
            // 
            // mailbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(708, 468);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.keepBtn);
            this.Controls.Add(this.statusBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 120);
            this.Name = "mailbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "mailbox";
            this.Load += new System.EventHandler(this.mailbox_Load);
            this.Shown += new System.EventHandler(this.mailbox_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button statusBtn;
        private System.Windows.Forms.Button keepBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView newListview;
    }
}