namespace aol.Forms
{
    partial class FavoritePlacesForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Favorite Places");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoritePlacesForm));
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            closeBtn = new System.Windows.Forms.Button();
            maxBtn = new System.Windows.Forms.Button();
            miniBtn = new System.Windows.Forms.Button();
            titleLabel = new System.Windows.Forms.Label();
            fpTreeView = new System.Windows.Forms.TreeView();
            goBtn = new System.Windows.Forms.PictureBox();
            newBtn = new System.Windows.Forms.PictureBox();
            editBtn = new System.Windows.Forms.PictureBox();
            deleteBtn = new System.Windows.Forms.PictureBox();
            saveRplcBtn = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saveRplcBtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.White;
            panel1.BackgroundImage = Properties.Resources.top_bar;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(closeBtn);
            panel1.Controls.Add(maxBtn);
            panel1.Controls.Add(miniBtn);
            panel1.Controls.Add(titleLabel);
            panel1.Location = new System.Drawing.Point(3, 2);
            panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(224, 21);
            panel1.TabIndex = 4;
            panel1.MouseMove += TitleBar_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new System.Drawing.Point(1, -1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(21, 21);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            closeBtn.Location = new System.Drawing.Point(202, 1);
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
            maxBtn.Location = new System.Drawing.Point(178, 1);
            maxBtn.Margin = new System.Windows.Forms.Padding(0);
            maxBtn.Name = "maxBtn";
            maxBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            maxBtn.Size = new System.Drawing.Size(21, 19);
            maxBtn.TabIndex = 1;
            maxBtn.UseVisualStyleBackColor = false;
            maxBtn.Click += MaxBtn_Click;
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
            miniBtn.Location = new System.Drawing.Point(158, 1);
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
            titleLabel.Location = new System.Drawing.Point(24, 2);
            titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(85, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Favorite Places";
            titleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // fpTreeView
            // 
            fpTreeView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fpTreeView.Location = new System.Drawing.Point(10, 31);
            fpTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            fpTreeView.Name = "fpTreeView";
            treeNode1.Name = "favorite_places";
            treeNode1.Text = "Favorite Places";
            fpTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode1 });
            fpTreeView.Size = new System.Drawing.Size(208, 330);
            fpTreeView.TabIndex = 5;
            fpTreeView.DoubleClick += FpTreeView_DoubleClick;
            // 
            // goBtn
            // 
            goBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            goBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            goBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            goBtn.Image = (System.Drawing.Image)resources.GetObject("goBtn.Image");
            goBtn.Location = new System.Drawing.Point(10, 369);
            goBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            goBtn.Name = "goBtn";
            goBtn.Size = new System.Drawing.Size(25, 25);
            goBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            goBtn.TabIndex = 6;
            goBtn.TabStop = false;
            goBtn.Click += GoBtn_Click;
            // 
            // newBtn
            // 
            newBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            newBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            newBtn.Image = (System.Drawing.Image)resources.GetObject("newBtn.Image");
            newBtn.Location = new System.Drawing.Point(55, 369);
            newBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            newBtn.Name = "newBtn";
            newBtn.Size = new System.Drawing.Size(25, 25);
            newBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            newBtn.TabIndex = 7;
            newBtn.TabStop = false;
            newBtn.Click += NewBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            editBtn.Image = (System.Drawing.Image)resources.GetObject("editBtn.Image");
            editBtn.Location = new System.Drawing.Point(99, 369);
            editBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            editBtn.Name = "editBtn";
            editBtn.Size = new System.Drawing.Size(25, 25);
            editBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            editBtn.TabIndex = 8;
            editBtn.TabStop = false;
            editBtn.Click += EditBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            deleteBtn.Image = (System.Drawing.Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new System.Drawing.Point(146, 369);
            deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new System.Drawing.Size(25, 25);
            deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            deleteBtn.TabIndex = 9;
            deleteBtn.TabStop = false;
            deleteBtn.Click += DeleteBtn_Click;
            // 
            // saveRplcBtn
            // 
            saveRplcBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            saveRplcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            saveRplcBtn.Image = (System.Drawing.Image)resources.GetObject("saveRplcBtn.Image");
            saveRplcBtn.Location = new System.Drawing.Point(192, 369);
            saveRplcBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            saveRplcBtn.Name = "saveRplcBtn";
            saveRplcBtn.Size = new System.Drawing.Size(25, 25);
            saveRplcBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            saveRplcBtn.TabIndex = 10;
            saveRplcBtn.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            label1.Location = new System.Drawing.Point(10, 396);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(21, 13);
            label1.TabIndex = 11;
            label1.Text = "Go";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            label2.Location = new System.Drawing.Point(52, 397);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 13);
            label2.TabIndex = 12;
            label2.Text = "New";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            label3.Location = new System.Drawing.Point(97, 397);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 13);
            label3.TabIndex = 13;
            label3.Text = "Edit";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            label4.Location = new System.Drawing.Point(136, 397);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 14;
            label4.Text = "Delete";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            label5.Location = new System.Drawing.Point(186, 397);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 13);
            label5.TabIndex = 15;
            label5.Text = "Save/";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            label6.Location = new System.Drawing.Point(181, 412);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 12);
            label6.TabIndex = 16;
            label6.Text = "Replace";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            // 
            // FavoritePlacesForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(228, 429);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveRplcBtn);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(newBtn);
            Controls.Add(goBtn);
            Controls.Add(fpTreeView);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Location = new System.Drawing.Point(15, 150);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MinimumSize = new System.Drawing.Size(228, 429);
            Name = "FavoritePlacesForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "favorite_places";
            Shown += Favorite_places_Shown;
            LocationChanged += FavoritePlacesForm_LocationChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)goBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)newBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)editBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)saveRplcBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button maxBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TreeView fpTreeView;
        private System.Windows.Forms.PictureBox goBtn;
        private System.Windows.Forms.PictureBox newBtn;
        private System.Windows.Forms.PictureBox editBtn;
        private System.Windows.Forms.PictureBox deleteBtn;
        private System.Windows.Forms.PictureBox saveRplcBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}