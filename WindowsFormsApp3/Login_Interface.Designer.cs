namespace WindowsFormsApp3
{
    partial class Login_Interface
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
            this.user_name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.username_t = new System.Windows.Forms.TextBox();
            this.password_t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(160, 80);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(89, 20);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(160, 134);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 20);
            this.password.TabIndex = 1;
            this.password.Text = "PassWord";
            // 
            // Register_button
            // 
            this.Register_button.Location = new System.Drawing.Point(163, 245);
            this.Register_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(137, 55);
            this.Register_button.TabIndex = 2;
            this.Register_button.Text = "Register";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(348, 245);
            this.Login_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(137, 55);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(520, 245);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(137, 55);
            this.Cancel_button.TabIndex = 4;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // username_t
            // 
            this.username_t.Location = new System.Drawing.Point(267, 80);
            this.username_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_t.Name = "username_t";
            this.username_t.Size = new System.Drawing.Size(390, 26);
            this.username_t.TabIndex = 5;
            // 
            // password_t
            // 
            this.password_t.Location = new System.Drawing.Point(267, 130);
            this.password_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_t.Name = "password_t";
            this.password_t.PasswordChar = '*';
            this.password_t.Size = new System.Drawing.Size(390, 26);
            this.password_t.TabIndex = 6;
            this.password_t.TextChanged += new System.EventHandler(this.password_t_TextChanged);
            // 
            // Login_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 405);
            this.Controls.Add(this.password_t);
            this.Controls.Add(this.username_t);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login_Interface";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox username_t;
        private System.Windows.Forms.TextBox password_t;
    }
}

