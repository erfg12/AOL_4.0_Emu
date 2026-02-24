namespace aol.Forms
{
    partial class BuddyListForm
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
            components = new Container();
            TreeNode treeNode1 = new TreeNode("Buddies 0/0");
            TreeNode treeNode2 = new TreeNode("Offline 0/0");
            buddiesLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            buddyTreeView = new TreeView();
            pictureBox4 = new PictureBox();
            setupBtn = new PictureBox();
            IMBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            TitleBar = new Panel();
            closeBtn = new Button();
            maxBtn = new Button();
            miniBtn = new Button();
            titleLabel = new Label();
            UpdateTimer = new System.Windows.Forms.Timer(components);
            buddyContextMenuStrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)setupBtn).BeginInit();
            ((ISupportInitialize)IMBtn).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            TitleBar.SuspendLayout();
            buddyContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // buddiesLabel
            // 
            buddiesLabel.AutoSize = true;
            buddiesLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            buddiesLabel.Location = new Point(4, 26);
            buddiesLabel.Margin = new Padding(4, 0, 4, 0);
            buddiesLabel.Name = "buddiesLabel";
            buddiesLabel.Size = new Size(105, 15);
            buddiesLabel.TabIndex = 8;
            buddiesLabel.Text = "Buddies Online";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(4, 269);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 13);
            label2.TabIndex = 9;
            label2.Text = "Locate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(52, 269);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 13);
            label3.TabIndex = 10;
            label3.Text = "IM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(88, 269);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(35, 13);
            label4.TabIndex = 11;
            label4.Text = "Setup";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(130, 269);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.MinimumSize = new Size(35, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 35);
            label5.TabIndex = 12;
            label5.Text = "Buddy Chat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(4, 304);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 13;
            label1.Text = "Keyword: BuddyView";
            // 
            // buddyTreeView
            // 
            buddyTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buddyTreeView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            buddyTreeView.Location = new Point(7, 47);
            buddyTreeView.Margin = new Padding(4);
            buddyTreeView.Name = "buddyTreeView";
            treeNode1.Checked = true;
            treeNode1.Name = "onlineBuddies";
            treeNode1.Text = "Buddies 0/0";
            treeNode2.Checked = true;
            treeNode2.Name = "offlineBuddies";
            treeNode2.Text = "Offline 0/0";
            buddyTreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2 });
            buddyTreeView.Size = new Size(155, 186);
            buddyTreeView.TabIndex = 15;
            buddyTreeView.MouseDoubleClick += BuddyTreeView_MouseDoubleClick;
            buddyTreeView.MouseUp += BuddyTreeView_MouseUp;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.buddiesonline_buddychat_btn;
            pictureBox4.Location = new Point(132, 238);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(29, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // setupBtn
            // 
            setupBtn.BackgroundImage = Properties.Resources.buddiesonline_setup_btn;
            setupBtn.BackgroundImageLayout = ImageLayout.Stretch;
            setupBtn.Cursor = Cursors.Hand;
            setupBtn.Location = new Point(90, 238);
            setupBtn.Margin = new Padding(0);
            setupBtn.Name = "setupBtn";
            setupBtn.Size = new Size(29, 29);
            setupBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            setupBtn.TabIndex = 6;
            setupBtn.TabStop = false;
            setupBtn.Click += SetupBtn_Click;
            // 
            // IMBtn
            // 
            IMBtn.Cursor = Cursors.Hand;
            IMBtn.Image = Properties.Resources.buddiesonline_IM_btn;
            IMBtn.Location = new Point(49, 238);
            IMBtn.Margin = new Padding(0);
            IMBtn.Name = "IMBtn";
            IMBtn.Size = new Size(29, 29);
            IMBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            IMBtn.TabIndex = 5;
            IMBtn.TabStop = false;
            IMBtn.Click += IMBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.buddiesonline_locate_btn;
            pictureBox1.Location = new Point(10, 238);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.AutoSize = true;
            TitleBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(titleLabel);
            TitleBar.Location = new Point(2, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(165, 24);
            TitleBar.TabIndex = 2;
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
            closeBtn.Location = new Point(144, 1);
            closeBtn.Margin = new Padding(0);
            closeBtn.Name = "closeBtn";
            closeBtn.RightToLeft = RightToLeft.No;
            closeBtn.Size = new Size(21, 19);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // maxBtn
            // 
            maxBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxBtn.BackColor = SystemColors.Control;
            maxBtn.BackgroundImage = Properties.Resources.maximize_disabled_btn;
            maxBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(120, 1);
            maxBtn.Margin = new Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = RightToLeft.No;
            maxBtn.Size = new Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
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
            miniBtn.Location = new Point(99, 1);
            miniBtn.Margin = new Padding(4);
            miniBtn.Name = "miniBtn";
            miniBtn.Size = new Size(21, 19);
            miniBtn.TabIndex = 2;
            miniBtn.UseVisualStyleBackColor = false;
            miniBtn.Click += MiniBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 2);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(109, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Buddy List Window";
            // 
            // UpdateTimer
            // 
            UpdateTimer.Enabled = true;
            UpdateTimer.Interval = 9900;
            UpdateTimer.Tick += UpdateTimer_Tick;
            // 
            // buddyContextMenuStrip
            // 
            buddyContextMenuStrip.ImageScalingSize = new Size(24, 24);
            buddyContextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            buddyContextMenuStrip.Name = "buddyContextMenuStrip";
            buddyContextMenuStrip.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // BuddyListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(169, 323);
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
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1157, 120);
            Margin = new Padding(4);
            MinimumSize = new Size(169, 323);
            Name = "BuddyListForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Buddy List Window";
            FormClosing += Buddies_online_FormClosing;
            Shown += BuddiesOnline_Shown;
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)setupBtn).EndInit();
            ((ISupportInitialize)IMBtn).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            buddyContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
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
        private System.Windows.Forms.TreeView buddyTreeView;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.ContextMenuStrip buddyContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}