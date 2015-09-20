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
            this.select_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.password_display_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwords_list
            // 
            this.passwords_list.Location = new System.Drawing.Point(6, 7);
            this.passwords_list.Name = "passwords_list";
            this.passwords_list.Size = new System.Drawing.Size(441, 242);
            this.passwords_list.TabIndex = 0;
            this.passwords_list.UseCompatibleStateImageBehavior = false;
            this.passwords_list.View = System.Windows.Forms.View.List;
            this.passwords_list.SelectedIndexChanged += new System.EventHandler(this.passwords_list_SelectedIndexChanged);
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(13, 267);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(75, 23);
            this.select_button.TabIndex = 1;
            this.select_button.Text = "View";
            this.select_button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy to Clipboard..";
            this.button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnlockedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.password_display_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.passwords_list);
            this.Name = "UnlockedForm";
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.UnlockedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView passwords_list;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label password_display_label;
        private System.Windows.Forms.Button button2;
    }
}