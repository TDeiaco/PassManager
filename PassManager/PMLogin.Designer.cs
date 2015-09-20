namespace PassManager
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.PMLoginLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.PMLoginMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PMSplashUsernameLabel = new System.Windows.Forms.Label();
            this.PMSplashPasswordLabel = new System.Windows.Forms.Label();
            this.PMSplashUsernameTextbox = new System.Windows.Forms.TextBox();
            this.PMLoginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.PMLoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PMLoginLogoPictureBox)).BeginInit();
            this.PMLoginMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMLoginLogoPictureBox
            // 
            this.PMLoginLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PMLoginLogoPictureBox.Image")));
            this.PMLoginLogoPictureBox.ImageLocation = "";
            this.PMLoginLogoPictureBox.Location = new System.Drawing.Point(16, 36);
            this.PMLoginLogoPictureBox.Name = "PMLoginLogoPictureBox";
            this.PMLoginLogoPictureBox.Size = new System.Drawing.Size(256, 64);
            this.PMLoginLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PMLoginLogoPictureBox.TabIndex = 0;
            this.PMLoginLogoPictureBox.TabStop = false;
            // 
            // PMLoginMenuStrip
            // 
            this.PMLoginMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.PMLoginMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PMLoginMenuStrip.Name = "PMLoginMenuStrip";
            this.PMLoginMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.PMLoginMenuStrip.TabIndex = 1;
            this.PMLoginMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem,
            this.createAccountToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.propertiesToolStripMenuItem.Text = "Properties..";
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account..";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // PMSplashUsernameLabel
            // 
            this.PMSplashUsernameLabel.AutoSize = true;
            this.PMSplashUsernameLabel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMSplashUsernameLabel.Location = new System.Drawing.Point(13, 106);
            this.PMSplashUsernameLabel.Name = "PMSplashUsernameLabel";
            this.PMSplashUsernameLabel.Size = new System.Drawing.Size(69, 16);
            this.PMSplashUsernameLabel.TabIndex = 2;
            this.PMSplashUsernameLabel.Text = "Username";
            // 
            // PMSplashPasswordLabel
            // 
            this.PMSplashPasswordLabel.AutoSize = true;
            this.PMSplashPasswordLabel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMSplashPasswordLabel.Location = new System.Drawing.Point(13, 147);
            this.PMSplashPasswordLabel.Name = "PMSplashPasswordLabel";
            this.PMSplashPasswordLabel.Size = new System.Drawing.Size(66, 16);
            this.PMSplashPasswordLabel.TabIndex = 3;
            this.PMSplashPasswordLabel.Text = "Password";
            // 
            // PMSplashUsernameTextbox
            // 
            this.PMSplashUsernameTextbox.Location = new System.Drawing.Point(15, 122);
            this.PMSplashUsernameTextbox.Name = "PMSplashUsernameTextbox";
            this.PMSplashUsernameTextbox.Size = new System.Drawing.Size(153, 20);
            this.PMSplashUsernameTextbox.TabIndex = 4;
            // 
            // PMLoginPasswordTextbox
            // 
            this.PMLoginPasswordTextbox.Location = new System.Drawing.Point(16, 164);
            this.PMLoginPasswordTextbox.Name = "PMLoginPasswordTextbox";
            this.PMLoginPasswordTextbox.Size = new System.Drawing.Size(152, 20);
            this.PMLoginPasswordTextbox.TabIndex = 5;
            // 
            // PMLoginButton
            // 
            this.PMLoginButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.PMLoginButton.Location = new System.Drawing.Point(197, 147);
            this.PMLoginButton.Name = "PMLoginButton";
            this.PMLoginButton.Size = new System.Drawing.Size(75, 37);
            this.PMLoginButton.TabIndex = 6;
            this.PMLoginButton.Text = "Login";
            this.PMLoginButton.UseVisualStyleBackColor = true;
            this.PMLoginButton.Click += new System.EventHandler(this.PMLoginButton_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.PMLoginButton);
            this.Controls.Add(this.PMLoginPasswordTextbox);
            this.Controls.Add(this.PMSplashUsernameTextbox);
            this.Controls.Add(this.PMSplashPasswordLabel);
            this.Controls.Add(this.PMSplashUsernameLabel);
            this.Controls.Add(this.PMLoginLogoPictureBox);
            this.Controls.Add(this.PMLoginMenuStrip);
            this.MainMenuStrip = this.PMLoginMenuStrip;
            this.Name = "Splash";
            this.Text = "PassManager";
            ((System.ComponentModel.ISupportInitialize)(this.PMLoginLogoPictureBox)).EndInit();
            this.PMLoginMenuStrip.ResumeLayout(false);
            this.PMLoginMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PMLoginLogoPictureBox;
        private System.Windows.Forms.MenuStrip PMLoginMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label PMSplashUsernameLabel;
        private System.Windows.Forms.Label PMSplashPasswordLabel;
        private System.Windows.Forms.TextBox PMSplashUsernameTextbox;
        private System.Windows.Forms.TextBox PMLoginPasswordTextbox;
        private System.Windows.Forms.Button PMLoginButton;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
    }
}

