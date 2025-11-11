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
            richTextBox1 = new RichTextBox();
            githubLink = new Label();
            SuspendLayout();
            // 
            // installBtn
            // 
            installBtn.Location = new Point(424, 122);
            installBtn.Name = "installBtn";
            installBtn.Size = new Size(77, 45);
            installBtn.TabIndex = 0;
            installBtn.Text = "Install";
            installBtn.UseVisualStyleBackColor = true;
            installBtn.Click += installBtn_Click;
            // 
            // installPath
            // 
            installPath.Location = new Point(16, 93);
            installPath.Name = "installPath";
            installPath.Size = new Size(404, 23);
            installPath.TabIndex = 2;
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(426, 93);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(75, 23);
            browseBtn.TabIndex = 3;
            browseBtn.Text = "browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(16, 16);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(483, 71);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "This is a fan-made Windows application emulating the AOL 4.0 interface. Not affiliated with or endorsed by America Online.";
            // 
            // githubLink
            // 
            githubLink.AutoSize = true;
            githubLink.Cursor = Cursors.Hand;
            githubLink.ForeColor = SystemColors.MenuHighlight;
            githubLink.Location = new Point(16, 137);
            githubLink.Name = "githubLink";
            githubLink.Size = new Size(224, 15);
            githubLink.TabIndex = 5;
            githubLink.Text = "https://github.com/erfg12/AOL_4.0_Emu";
            githubLink.Click += githubLink_Click;
            // 
            // InstallForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 187);
            Controls.Add(githubLink);
            Controls.Add(richTextBox1);
            Controls.Add(browseBtn);
            Controls.Add(installPath);
            Controls.Add(installBtn);
            MaximizeBox = false;
            Name = "InstallForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "AOL 4.0 Emu Installer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button installBtn;
        private TextBox installPath;
        private Button browseBtn;
        private RichTextBox richTextBox1;
        private Label githubLink;
    }
}
