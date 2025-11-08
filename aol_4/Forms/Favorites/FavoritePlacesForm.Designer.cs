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
            TreeNode treeNode2 = new TreeNode("Favorite Places");
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FavoritePlacesForm));
            TitleBar = new Panel();
            pictureBox1 = new PictureBox();
            closeBtn = new Button();
            maxBtn = new Button();
            miniBtn = new Button();
            titleLabel = new Label();
            fpTreeView = new TreeView();
            goBtn = new PictureBox();
            newBtn = new PictureBox();
            editBtn = new PictureBox();
            deleteBtn = new PictureBox();
            saveRplcBtn = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TitleBar.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)goBtn).BeginInit();
            ((ISupportInitialize)newBtn).BeginInit();
            ((ISupportInitialize)editBtn).BeginInit();
            ((ISupportInitialize)deleteBtn).BeginInit();
            ((ISupportInitialize)saveRplcBtn).BeginInit();
            SuspendLayout();
            // 
            // TitleBar
            // 
            TitleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TitleBar.BackColor = Color.White;
            TitleBar.BackgroundImage = Properties.Resources.top_bar;
            TitleBar.BackgroundImageLayout = ImageLayout.Stretch;
            TitleBar.Controls.Add(pictureBox1);
            TitleBar.Controls.Add(closeBtn);
            TitleBar.Controls.Add(maxBtn);
            TitleBar.Controls.Add(miniBtn);
            TitleBar.Controls.Add(titleLabel);
            TitleBar.Location = new Point(3, 2);
            TitleBar.Margin = new Padding(4);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(224, 21);
            TitleBar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.aol_icon_4;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.aol_icon_4;
            pictureBox1.InitialImage = Properties.Resources.aol_icon_4;
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            closeBtn.Location = new Point(202, 1);
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
            maxBtn.BackgroundImage = Properties.Resources.maximize_btn;
            maxBtn.BackgroundImageLayout = ImageLayout.Stretch;
            maxBtn.FlatStyle = FlatStyle.Flat;
            maxBtn.Font = new Font("Microsoft Sans Serif", 6F);
            maxBtn.ForeColor = Color.Black;
            maxBtn.Location = new Point(178, 1);
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
            miniBtn.Location = new Point(158, 1);
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
            titleLabel.Location = new Point(24, 2);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(85, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Favorite Places";
            // 
            // fpTreeView
            // 
            fpTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fpTreeView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            fpTreeView.Location = new Point(10, 31);
            fpTreeView.Margin = new Padding(4);
            fpTreeView.Name = "fpTreeView";
            treeNode2.Name = "favorite_places";
            treeNode2.Text = "Favorite Places";
            fpTreeView.Nodes.AddRange(new TreeNode[] { treeNode2 });
            fpTreeView.Size = new Size(208, 330);
            fpTreeView.TabIndex = 5;
            fpTreeView.DoubleClick += FpTreeView_DoubleClick;
            // 
            // goBtn
            // 
            goBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            goBtn.BackgroundImageLayout = ImageLayout.Stretch;
            goBtn.Cursor = Cursors.Hand;
            goBtn.Image = (Image)resources.GetObject("goBtn.Image");
            goBtn.Location = new Point(10, 369);
            goBtn.Margin = new Padding(4);
            goBtn.Name = "goBtn";
            goBtn.Size = new Size(25, 25);
            goBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            goBtn.TabIndex = 6;
            goBtn.TabStop = false;
            goBtn.Click += GoBtn_Click;
            // 
            // newBtn
            // 
            newBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newBtn.Cursor = Cursors.Hand;
            newBtn.Image = (Image)resources.GetObject("newBtn.Image");
            newBtn.Location = new Point(55, 369);
            newBtn.Margin = new Padding(4);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(25, 25);
            newBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            newBtn.TabIndex = 7;
            newBtn.TabStop = false;
            newBtn.Click += NewBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editBtn.Cursor = Cursors.Hand;
            editBtn.Image = (Image)resources.GetObject("editBtn.Image");
            editBtn.Location = new Point(99, 369);
            editBtn.Margin = new Padding(4);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(25, 25);
            editBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            editBtn.TabIndex = 8;
            editBtn.TabStop = false;
            editBtn.Click += EditBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteBtn.Cursor = Cursors.Hand;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(146, 369);
            deleteBtn.Margin = new Padding(4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(25, 25);
            deleteBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteBtn.TabIndex = 9;
            deleteBtn.TabStop = false;
            deleteBtn.Click += DeleteBtn_Click;
            // 
            // saveRplcBtn
            // 
            saveRplcBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveRplcBtn.Cursor = Cursors.Hand;
            saveRplcBtn.Image = (Image)resources.GetObject("saveRplcBtn.Image");
            saveRplcBtn.Location = new Point(192, 369);
            saveRplcBtn.Margin = new Padding(4);
            saveRplcBtn.Name = "saveRplcBtn";
            saveRplcBtn.Size = new Size(25, 25);
            saveRplcBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            saveRplcBtn.TabIndex = 10;
            saveRplcBtn.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(10, 396);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 13);
            label1.TabIndex = 11;
            label1.Text = "Go";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(52, 397);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 13);
            label2.TabIndex = 12;
            label2.Text = "New";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(97, 397);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(25, 13);
            label3.TabIndex = 13;
            label3.Text = "Edit";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(136, 397);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 13);
            label4.TabIndex = 14;
            label4.Text = "Delete";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(186, 397);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(35, 13);
            label5.TabIndex = 15;
            label5.Text = "Save/";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.Location = new Point(181, 409);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 13);
            label6.TabIndex = 16;
            label6.Text = "Replace";
            // 
            // FavoritePlacesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(228, 429);
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
            Controls.Add(TitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(15, 150);
            Margin = new Padding(4);
            MinimumSize = new Size(228, 429);
            Name = "FavoritePlacesForm";
            StartPosition = FormStartPosition.Manual;
            Text = "favorite_places";
            Shown += Favorite_places_Shown;
            TitleBar.ResumeLayout(false);
            TitleBar.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)goBtn).EndInit();
            ((ISupportInitialize)newBtn).EndInit();
            ((ISupportInitialize)editBtn).EndInit();
            ((ISupportInitialize)deleteBtn).EndInit();
            ((ISupportInitialize)saveRplcBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
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
    }
}