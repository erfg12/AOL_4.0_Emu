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
            buddiesLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buddyTreeView = new System.Windows.Forms.TreeView();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            setupBtn = new System.Windows.Forms.PictureBox();
            IMBtn = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            closeBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            miniBtn = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setupBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IMBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buddiesLabel
            // 
            buddiesLabel.AutoSize = true;
            buddiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buddiesLabel.Location = new System.Drawing.Point(4, 26);
            buddiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            buddiesLabel.Name = "buddiesLabel";
            buddiesLabel.Size = new System.Drawing.Size(105, 15);
            buddiesLabel.TabIndex = 8;
            buddiesLabel.Text = "Buddies Online";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(4, 269);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 12);
            label2.TabIndex = 9;
            label2.Text = "Locate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(52, 269);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(17, 12);
            label3.TabIndex = 10;
            label3.Text = "IM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(88, 269);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 12);
            label4.TabIndex = 11;
            label4.Text = "Setup";
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(130, 269);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.MinimumSize = new System.Drawing.Size(35, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 35);
            label5.TabIndex = 12;
            label5.Text = "Buddy Chat";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 304);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 13);
            label1.TabIndex = 13;
            label1.Text = "Keyword: BuddyView";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // buddyTreeView
            // 
            buddyTreeView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buddyTreeView.Location = new System.Drawing.Point(7, 47);
            buddyTreeView.Margin = new System.Windows.Forms.Padding(4);
            buddyTreeView.Name = "buddyTreeView";
            treeNode1.Checked = true;
            treeNode1.Name = "onlineBuddies";
            treeNode1.Text = "Buddies 0/0";
            treeNode2.Checked = true;
            treeNode2.Name = "offlineBuddies";
            treeNode2.Text = "Offline 0/0";
            buddyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2 });
            buddyTreeView.Size = new System.Drawing.Size(155, 186);
            buddyTreeView.TabIndex = 15;
            buddyTreeView.MouseDoubleClick += buddyTreeView_MouseDoubleClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox4.Image = Properties.Resources.buddiesonline_buddychat_btn;
            pictureBox4.Location = new System.Drawing.Point(132, 238);
            pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(29, 29);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // setupBtn
            // 
            setupBtn.BackgroundImage = Properties.Resources.buddiesonline_setup_btn;
            setupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            setupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            setupBtn.Location = new System.Drawing.Point(90, 238);
            setupBtn.Margin = new System.Windows.Forms.Padding(0);
            setupBtn.Name = "setupBtn";
            setupBtn.Size = new System.Drawing.Size(29, 29);
            setupBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            setupBtn.TabIndex = 6;
            setupBtn.TabStop = false;
            setupBtn.Click += setupBtn_Click;
            // 
            // IMBtn
            // 
            IMBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            IMBtn.Image = Properties.Resources.buddiesonline_IM_btn;
            IMBtn.Location = new System.Drawing.Point(49, 238);
            IMBtn.Margin = new System.Windows.Forms.Padding(0);
            IMBtn.Name = "IMBtn";
            IMBtn.Size = new System.Drawing.Size(29, 29);
            IMBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            IMBtn.TabIndex = 5;
            IMBtn.TabStop = false;
            IMBtn.Click += IMBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.Image = Properties.Resources.buddiesonline_locate_btn;
            pictureBox1.Location = new System.Drawing.Point(10, 238);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(29, 29);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(titleLabel);
            panel1.Location = new System.Drawing.Point(3, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(164, 21);
            panel1.TabIndex = 2;
            panel1.MouseDoubleClick += panel1_MouseDoubleClick;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            closeBtn.BackColor = System.Drawing.SystemColors.Control;
            closeBtn.BackgroundImage = Properties.Resources.close_btn;
            closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            closeBtn.ForeColor = System.Drawing.Color.Black;
            closeBtn.Location = new System.Drawing.Point(143, 1);
            closeBtn.Margin = new System.Windows.Forms.Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            closeBtn.Size = new System.Drawing.Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            maxBtn.BackColor = System.Drawing.SystemColors.Control;
            maxBtn.BackgroundImage = Properties.Resources.maximize_disabled_btn;
            maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            maxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            maxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            maxBtn.ForeColor = System.Drawing.Color.Black;
            maxBtn.Location = new System.Drawing.Point(119, 1);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            maxBtn.Click += maxBtn_Click;
            // 
            // miniBtn
            // 
            miniBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            miniBtn.BackColor = System.Drawing.SystemColors.Control;
            miniBtn.BackgroundImage = Properties.Resources.minimize_btn;
            miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            miniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            miniBtn.ForeColor = System.Drawing.Color.Black;
            miniBtn.Location = new System.Drawing.Point(98, 1);
            miniBtn.Margin = new System.Windows.Forms.Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new System.Drawing.Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += miniBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = System.Drawing.Color.Transparent;
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(0, 2);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(109, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Buddy List Window";
            titleLabel.MouseMove += titleLabel_MouseMove;
            // 
            // buddies_online
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(169, 323);
            Controls.Add(buddyTreeView);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buddiesLabel);
            Controls.Add(pictureBox4);
            Controls.Add(setupBtn);
            Controls.Add(IMBtn);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(1157, 220);
            Margin = new System.Windows.Forms.Padding(4);
            MinimumSize = new System.Drawing.Size(169, 323);
            Name = "buddies_online";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Buddy List Window";
            FormClosing += Buddies_online_FormClosing;
            Load += buddies_online_Load;
            Shown += buddies_online_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)setupBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)IMBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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