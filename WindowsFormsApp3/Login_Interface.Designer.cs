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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Interface));
            this.user_name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Register_button = new Guna.UI2.WinForms.Guna2Button();
            this.Login_button = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel_button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.ForeColor = System.Drawing.Color.Black;
            this.user_name.Location = new System.Drawing.Point(107, 103);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(124, 29);
            this.user_name.TabIndex = 0;
            this.user_name.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.Location = new System.Drawing.Point(107, 178);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(124, 29);
            this.password.TabIndex = 1;
            this.password.Text = "PassWord";
            // 
            // username_t
            // 
            this.username_t.Animated = true;
            this.username_t.BorderRadius = 10;
            this.username_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_t.DefaultText = "";
            this.username_t.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_t.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_t.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_t.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_t.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_t.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_t.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_t.IconLeft = ((System.Drawing.Image)(resources.GetObject("username_t.IconLeft")));
            this.username_t.Location = new System.Drawing.Point(255, 91);
            this.username_t.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_t.Name = "username_t";
            this.username_t.PasswordChar = '\0';
            this.username_t.PlaceholderText = "username";
            this.username_t.SelectedText = "";
            this.username_t.Size = new System.Drawing.Size(395, 47);
            this.username_t.TabIndex = 7;
            // 
            // password_t
            // 
            this.password_t.Animated = true;
            this.password_t.BorderRadius = 10;
            this.password_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_t.DefaultText = "";
            this.password_t.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_t.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_t.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_t.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_t.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_t.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_t.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_t.IconLeft = ((System.Drawing.Image)(resources.GetObject("password_t.IconLeft")));
            this.password_t.Location = new System.Drawing.Point(255, 168);
            this.password_t.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_t.Name = "password_t";
            this.password_t.PasswordChar = '*';
            this.password_t.PlaceholderText = "password";
            this.password_t.SelectedText = "";
            this.password_t.Size = new System.Drawing.Size(395, 47);
            this.password_t.TabIndex = 8;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 75);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Login";
            // 
            // Register_button
            // 
            this.Register_button.Animated = true;
            this.Register_button.AutoRoundedCorners = true;
            this.Register_button.BorderRadius = 26;
            this.Register_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Register_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Register_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Register_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Register_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Register_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Register_button.ForeColor = System.Drawing.Color.White;
            this.Register_button.Location = new System.Drawing.Point(159, 273);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(125, 55);
            this.Register_button.TabIndex = 11;
            this.Register_button.Text = "Register";
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Animated = true;
            this.Login_button.AutoRoundedCorners = true;
            this.Login_button.BorderRadius = 26;
            this.Login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Login_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Login_button.ForeColor = System.Drawing.Color.White;
            this.Login_button.Location = new System.Drawing.Point(338, 273);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(125, 55);
            this.Login_button.TabIndex = 12;
            this.Login_button.Text = "Login";
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Animated = true;
            this.Cancel_button.AutoRoundedCorners = true;
            this.Cancel_button.BorderRadius = 26;
            this.Cancel_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancel_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancel_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancel_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancel_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Cancel_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancel_button.ForeColor = System.Drawing.Color.White;
            this.Cancel_button.Location = new System.Drawing.Point(525, 273);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(125, 55);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Login_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(834, 405);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.password_t);
            this.Controls.Add(this.username_t);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label password;
        private Guna.UI2.WinForms.Guna2TextBox username_t;
        private Guna.UI2.WinForms.Guna2TextBox password_t;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button Register_button;
        private Guna.UI2.WinForms.Guna2Button Cancel_button;
        private Guna.UI2.WinForms.Guna2Button Login_button;
    }
}

