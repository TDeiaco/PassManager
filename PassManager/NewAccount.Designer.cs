namespace PassManager
{
    partial class NewAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewAccountUsernameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewAccountPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewAccountReenterPasswordTextbox = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.NewAccountAccountNameTextbox = new System.Windows.Forms.TextBox();
            this.NewAccountAccountNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // NewAccountUsernameTextbox
            // 
            this.NewAccountUsernameTextbox.Location = new System.Drawing.Point(27, 79);
            this.NewAccountUsernameTextbox.Name = "NewAccountUsernameTextbox";
            this.NewAccountUsernameTextbox.Size = new System.Drawing.Size(221, 20);
            this.NewAccountUsernameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // NewAccountPasswordTextbox
            // 
            this.NewAccountPasswordTextbox.Location = new System.Drawing.Point(27, 123);
            this.NewAccountPasswordTextbox.Name = "NewAccountPasswordTextbox";
            this.NewAccountPasswordTextbox.Size = new System.Drawing.Size(221, 20);
            this.NewAccountPasswordTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-Enter Password";
            // 
            // NewAccountReenterPasswordTextbox
            // 
            this.NewAccountReenterPasswordTextbox.Location = new System.Drawing.Point(27, 167);
            this.NewAccountReenterPasswordTextbox.Name = "NewAccountReenterPasswordTextbox";
            this.NewAccountReenterPasswordTextbox.Size = new System.Drawing.Size(221, 20);
            this.NewAccountReenterPasswordTextbox.TabIndex = 5;
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(173, 193);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 6;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(92, 193);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // NewAccountAccountNameTextbox
            // 
            this.NewAccountAccountNameTextbox.Location = new System.Drawing.Point(27, 36);
            this.NewAccountAccountNameTextbox.Name = "NewAccountAccountNameTextbox";
            this.NewAccountAccountNameTextbox.Size = new System.Drawing.Size(221, 20);
            this.NewAccountAccountNameTextbox.TabIndex = 9;
            // 
            // NewAccountAccountNameLabel
            // 
            this.NewAccountAccountNameLabel.AutoSize = true;
            this.NewAccountAccountNameLabel.Location = new System.Drawing.Point(27, 19);
            this.NewAccountAccountNameLabel.Name = "NewAccountAccountNameLabel";
            this.NewAccountAccountNameLabel.Size = new System.Drawing.Size(78, 13);
            this.NewAccountAccountNameLabel.TabIndex = 8;
            this.NewAccountAccountNameLabel.Text = "Account Name";
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 235);
            this.Controls.Add(this.NewAccountAccountNameTextbox);
            this.Controls.Add(this.NewAccountAccountNameLabel);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.NewAccountReenterPasswordTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewAccountPasswordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewAccountUsernameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewAccountUsernameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewAccountPasswordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewAccountReenterPasswordTextbox;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox NewAccountAccountNameTextbox;
        private System.Windows.Forms.Label NewAccountAccountNameLabel;
    }
}