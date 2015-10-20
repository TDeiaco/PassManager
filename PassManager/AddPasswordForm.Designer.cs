namespace PassManager
{
    partial class AddPasswordForm
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
            this.username = new System.Windows.Forms.Label();
            this.NewPasswordUsername_textbox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.NewPasswordPassword_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(13, 13);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // NewPasswordUsername_textbox
            // 
            this.NewPasswordUsername_textbox.Location = new System.Drawing.Point(13, 30);
            this.NewPasswordUsername_textbox.Name = "NewPasswordUsername_textbox";
            this.NewPasswordUsername_textbox.Size = new System.Drawing.Size(100, 20);
            this.NewPasswordUsername_textbox.TabIndex = 1;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(116, 13);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // NewPasswordPassword_textbox
            // 
            this.NewPasswordPassword_textbox.Location = new System.Drawing.Point(119, 30);
            this.NewPasswordPassword_textbox.Name = "NewPasswordPassword_textbox";
            this.NewPasswordPassword_textbox.Size = new System.Drawing.Size(113, 20);
            this.NewPasswordPassword_textbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(119, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add New Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 91);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewPasswordPassword_textbox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.NewPasswordUsername_textbox);
            this.Controls.Add(this.username);
            this.Name = "AddPasswordForm";
            this.Text = "Add New Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox NewPasswordUsername_textbox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox NewPasswordPassword_textbox;
        private System.Windows.Forms.Button button1;
    }
}