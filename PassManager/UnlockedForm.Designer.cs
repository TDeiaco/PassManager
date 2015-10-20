namespace PassManager
{
    partial class UnlockedForm
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
            this.passwords_list = new System.Windows.Forms.ListView();
            this.PasswordsView_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.password_display_label = new System.Windows.Forms.Label();
            this.AddPassword_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwords_list
            // 
            this.passwords_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwords_list.Location = new System.Drawing.Point(19, 19);
            this.passwords_list.Margin = new System.Windows.Forms.Padding(10);
            this.passwords_list.Name = "passwords_list";
            this.passwords_list.Size = new System.Drawing.Size(434, 234);
            this.passwords_list.TabIndex = 0;
            this.passwords_list.UseCompatibleStateImageBehavior = false;
            this.passwords_list.View = System.Windows.Forms.View.List;
            this.passwords_list.SelectedIndexChanged += new System.EventHandler(this.passwords_list_SelectedIndexChanged);
            // 
            // PasswordsView_button
            // 
            this.PasswordsView_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordsView_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PasswordsView_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordsView_button.Location = new System.Drawing.Point(138, 273);
            this.PasswordsView_button.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordsView_button.Name = "PasswordsView_button";
            this.PasswordsView_button.Size = new System.Drawing.Size(75, 23);
            this.PasswordsView_button.TabIndex = 1;
            this.PasswordsView_button.Text = "View";
            this.PasswordsView_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy to Clipboard..";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // password_display_label
            // 
            this.password_display_label.AutoSize = true;
            this.password_display_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.password_display_label.Location = new System.Drawing.Point(0, 0);
            this.password_display_label.Name = "password_display_label";
            this.password_display_label.Size = new System.Drawing.Size(0, 13);
            this.password_display_label.TabIndex = 3;
            // 
            // AddPassword_button
            // 
            this.AddPassword_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPassword_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddPassword_button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPassword_button.Location = new System.Drawing.Point(362, 273);
            this.AddPassword_button.Margin = new System.Windows.Forms.Padding(10);
            this.AddPassword_button.Name = "AddPassword_button";
            this.AddPassword_button.Size = new System.Drawing.Size(91, 23);
            this.AddPassword_button.TabIndex = 4;
            this.AddPassword_button.Text = "Add Password";
            this.AddPassword_button.UseVisualStyleBackColor = false;
            this.AddPassword_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnlockedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 315);
            this.Controls.Add(this.AddPassword_button);
            this.Controls.Add(this.password_display_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordsView_button);
            this.Controls.Add(this.passwords_list);
            this.Name = "UnlockedForm";
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.UnlockedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView passwords_list;
        private System.Windows.Forms.Button PasswordsView_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label password_display_label;
        private System.Windows.Forms.Button AddPassword_button;
    }
}