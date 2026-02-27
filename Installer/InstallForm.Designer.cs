namespace Installer
{
    partial class InstallForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            installBtn = new Button();
            installPath = new TextBox();
            browseBtn = new Button();
            topLabel = new RichTextBox();
            githubLink = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            outputBox = new RichTextBox();
            progressBar1 = new ProgressBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // installBtn
            // 
            installBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            installBtn.BackColor = SystemColors.ControlLightLight;
            installBtn.Cursor = Cursors.Hand;
            installBtn.FlatStyle = FlatStyle.Popup;
            installBtn.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            installBtn.ForeColor = Color.MediumBlue;
            installBtn.Location = new Point(414, 285);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(94, 45);
            installBtn.TabIndex = 0;
            installBtn.Text = "INSTALL";
            installBtn.UseVisualStyleBackColor = false;
            installBtn.Click += installBtn_Click;
            // 
            // installPath
            // 
            installPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            installPath.Location = new Point(8, 22);
            installPath.Name = "installPath";
            installPath.Size = new Size(402, 23);
            installPath.TabIndex = 2;
            // 
            // browseBtn
            // 
            browseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            browseBtn.Cursor = Cursors.Hand;
            browseBtn.FlatStyle = FlatStyle.Popup;
            browseBtn.Location = new Point(416, 22);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(66, 23);
            browseBtn.TabIndex = 3;
            browseBtn.Text = "browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // topLabel
            // 
            topLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topLabel.BackColor = SystemColors.Control;
            topLabel.BorderStyle = BorderStyle.None;
            topLabel.HideSelection = false;
            topLabel.Location = new Point(16, 16);
            topLabel.Name = "topLabel";
            topLabel.ReadOnly = true;
            topLabel.Size = new Size(492, 45);
            topLabel.TabIndex = 4;
            topLabel.Text = "This is a fan-made Windows application emulating the AOL 4.0 interface. Not affiliated with or endorsed by America Online.";
            // 
            // githubLink
            // 
            githubLink.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            githubLink.AutoSize = true;
            githubLink.Cursor = Cursors.Hand;
            githubLink.ForeColor = SystemColors.MenuHighlight;
            githubLink.Location = new Point(15, 309);
            githubLink.Name = "githubLink";
            githubLink.Size = new Size(224, 15);
            githubLink.TabIndex = 5;
            githubLink.Text = "https://github.com/erfg12/AOL_4.0_Emu";
            githubLink.Click += githubLink_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(browseBtn);
            groupBox1.Controls.Add(installPath);
            groupBox1.Location = new Point(15, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 56);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Installation Path";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(outputBox);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(16, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(492, 150);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Installation Progress";
            // 
            // outputBox
            // 
            outputBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputBox.HideSelection = false;
            outputBox.Location = new Point(6, 54);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(475, 90);
            outputBox.TabIndex = 1;
            outputBox.Text = "Change the installation path above, and press the INSTALL button below to start.\n";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(7, 22);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(474, 23);
            progressBar1.TabIndex = 0;
            // 
            // InstallForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 342);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(githubLink);
            Controls.Add(topLabel);
            Controls.Add(installBtn);
            MaximizeBox = false;
            MinimumSize = new Size(536, 381);
            Name = "InstallForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AOL 4.0 Emu Installer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button installBtn;
        private TextBox installPath;
        private Button browseBtn;
        private RichTextBox topLabel;
        private Label githubLink;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox outputBox;
        private ProgressBar progressBar1;
    }
}
