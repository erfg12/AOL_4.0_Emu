namespace aol.Forms
{
    partial class buddies_online
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Buddies 0/0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Offline 0/0");
            this.buddiesLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.setupBtn = new System.Windows.Forms.PictureBox();
            this.IMBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.miniBtn = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buddyTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buddiesLabel
            // 
            this.buddiesLabel.AutoSize = true;
            this.buddiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buddiesLabel.Location = new System.Drawing.Point(3, 23);
            this.buddiesLabel.Name = "buddiesLabel";
            this.buddiesLabel.Size = new System.Drawing.Size(105, 15);
            this.buddiesLabel.TabIndex = 8;
            this.buddiesLabel.Text = "Buddies Online";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Locate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "IM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Setup";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 233);
            this.label5.MinimumSize = new System.Drawing.Size(30, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buddy Chat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Keyword: BuddyView";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::aol.Properties.Resources.buddiesonline_buddychat_btn;
            this.pictureBox4.Location = new System.Drawing.Point(113, 206);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // setupBtn
            // 
            this.setupBtn.BackgroundImage = global::aol.Properties.Resources.buddiesonline_setup_btn;
            this.setupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setupBtn.Location = new System.Drawing.Point(77, 206);
            this.setupBtn.Margin = new System.Windows.Forms.Padding(0);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(25, 25);
            this.setupBtn.TabIndex = 6;
            this.setupBtn.TabStop = false;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // IMBtn
            // 
            this.IMBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IMBtn.Image = global::aol.Properties.Resources.buddiesonline_IM_btn;
            this.IMBtn.Location = new System.Drawing.Point(42, 206);
            this.IMBtn.Margin = new System.Windows.Forms.Padding(0);
            this.IMBtn.Name = "IMBtn";
            this.IMBtn.Size = new System.Drawing.Size(25, 25);
            this.IMBtn.TabIndex = 5;
            this.IMBtn.TabStop = false;
            this.IMBtn.Click += new System.EventHandler(this.IMBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::aol.Properties.Resources.buddiesonline_locate_btn;
            this.pictureBox1.Location = new System.Drawing.Point(8, 206);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::aol.Properties.Resources.top_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.maxBtn);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 18);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.closeBtn.Location = new System.Drawing.Point(122, 1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(18, 16);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBtn.BackColor = System.Drawing.SystemColors.Control;
            this.maxBtn.BackgroundImage = global::aol.Properties.Resources.maximize_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maxBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxBtn.ForeColor = System.Drawing.Color.Black;
            this.maxBtn.Location = new System.Drawing.Point(102, 1);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maxBtn.Size = new System.Drawing.Size(18, 16);
            this.maxBtn.TabIndex = 1;
            this.maxBtn.UseVisualStyleBackColor = false;
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
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
            this.miniBtn.Location = new System.Drawing.Point(84, 1);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(18, 16);
            this.miniBtn.TabIndex = 2;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 13);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Buddy List Window";
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // buddyTreeView
            // 
            this.buddyTreeView.Location = new System.Drawing.Point(6, 41);
            this.buddyTreeView.Name = "buddyTreeView";
            treeNode1.Checked = true;
            treeNode1.Name = "onlineBuddies";
            treeNode1.Text = "Buddies 0/0";
            treeNode2.Checked = true;
            treeNode2.Name = "offlineBuddies";
            treeNode2.Text = "Offline 0/0";
            this.buddyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.buddyTreeView.Size = new System.Drawing.Size(134, 162);
            this.buddyTreeView.TabIndex = 15;
            this.buddyTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.buddyTreeView_MouseDoubleClick);
            // 
            // buddies_online
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(145, 280);
            this.Controls.Add(this.buddyTreeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buddiesLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.setupBtn);
            this.Controls.Add(this.IMBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 120);
            this.MinimumSize = new System.Drawing.Size(145, 280);
            this.Name = "buddies_online";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Buddy List Window";
            this.Load += new System.EventHandler(this.buddies_online_Load);
            this.Shown += new System.EventHandler(this.buddies_online_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox IMBtn;
        private System.Windows.Forms.PictureBox setupBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label buddiesLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TreeView buddyTreeView;
    }
}