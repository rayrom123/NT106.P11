namespace WindowsFormsApp3
{
    partial class Register_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_Interface));
            this.username_l = new System.Windows.Forms.Label();
            this.password_l = new System.Windows.Forms.Label();
            this.fullname_l = new System.Windows.Forms.Label();
            this.confirmpass_l = new System.Windows.Forms.Label();
            this.gender_l = new System.Windows.Forms.Label();
            this.Confirm_Register = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.dateofbirth_t = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.username_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullname_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmpass_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_t = new Guna.UI2.WinForms.Guna2TextBox();
            this.genderselect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.register_l = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_l
            // 
            this.username_l.AutoSize = true;
            this.username_l.Location = new System.Drawing.Point(39, 81);
            this.username_l.Name = "username_l";
            this.username_l.Size = new System.Drawing.Size(89, 20);
            this.username_l.TabIndex = 0;
            this.username_l.Text = "User Name";
            // 
            // password_l
            // 
            this.password_l.AutoSize = true;
            this.password_l.Location = new System.Drawing.Point(39, 203);
            this.password_l.Name = "password_l";
            this.password_l.Size = new System.Drawing.Size(82, 20);
            this.password_l.TabIndex = 1;
            this.password_l.Text = "PassWord";
            // 
            // fullname_l
            // 
            this.fullname_l.AutoSize = true;
            this.fullname_l.Location = new System.Drawing.Point(39, 142);
            this.fullname_l.Name = "fullname_l";
            this.fullname_l.Size = new System.Drawing.Size(80, 20);
            this.fullname_l.TabIndex = 2;
            this.fullname_l.Text = "Full Name";
            // 
            // confirmpass_l
            // 
            this.confirmpass_l.AutoSize = true;
            this.confirmpass_l.Location = new System.Drawing.Point(39, 264);
            this.confirmpass_l.Name = "confirmpass_l";
            this.confirmpass_l.Size = new System.Drawing.Size(141, 20);
            this.confirmpass_l.TabIndex = 3;
            this.confirmpass_l.Text = "Confirm PassWord";
            // 
            // gender_l
            // 
            this.gender_l.AutoSize = true;
            this.gender_l.Location = new System.Drawing.Point(39, 325);
            this.gender_l.Name = "gender_l";
            this.gender_l.Size = new System.Drawing.Size(63, 20);
            this.gender_l.TabIndex = 4;
            this.gender_l.Text = "Gender";
            // 
            // Confirm_Register
            // 
            this.Confirm_Register.Location = new System.Drawing.Point(202, 437);
            this.Confirm_Register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Confirm_Register.Name = "Confirm_Register";
            this.Confirm_Register.Size = new System.Drawing.Size(109, 46);
            this.Confirm_Register.TabIndex = 5;
            this.Confirm_Register.Text = "Register";
            this.Confirm_Register.UseVisualStyleBackColor = true;
            this.Confirm_Register.Click += new System.EventHandler(this.Confirm_Register_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(407, 2);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 46);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // dateofbirth_t
            // 
            this.dateofbirth_t.AutoSize = true;
            this.dateofbirth_t.Location = new System.Drawing.Point(39, 386);
            this.dateofbirth_t.Name = "dateofbirth_t";
            this.dateofbirth_t.Size = new System.Drawing.Size(99, 20);
            this.dateofbirth_t.TabIndex = 12;
            this.dateofbirth_t.Text = "Date of Birth";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.username_t.Location = new System.Drawing.Point(219, 71);
            this.username_t.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username_t.Name = "username_t";
            this.username_t.PasswordChar = '\0';
            this.username_t.PlaceholderText = "username";
            this.username_t.SelectedText = "";
            this.username_t.Size = new System.Drawing.Size(194, 38);
            this.username_t.TabIndex = 14;
            // 
            // fullname_t
            // 
            this.fullname_t.Animated = true;
            this.fullname_t.BorderRadius = 10;
            this.fullname_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullname_t.DefaultText = "";
            this.fullname_t.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullname_t.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullname_t.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullname_t.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullname_t.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullname_t.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullname_t.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullname_t.Location = new System.Drawing.Point(219, 132);
            this.fullname_t.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullname_t.Name = "fullname_t";
            this.fullname_t.PasswordChar = '\0';
            this.fullname_t.PlaceholderText = "fullname";
            this.fullname_t.SelectedText = "";
            this.fullname_t.Size = new System.Drawing.Size(194, 38);
            this.fullname_t.TabIndex = 15;
            // 
            // confirmpass_t
            // 
            this.confirmpass_t.Animated = true;
            this.confirmpass_t.BorderRadius = 10;
            this.confirmpass_t.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmpass_t.DefaultText = "";
            this.confirmpass_t.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmpass_t.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmpass_t.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmpass_t.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmpass_t.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmpass_t.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmpass_t.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmpass_t.Location = new System.Drawing.Point(219, 254);
            this.confirmpass_t.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmpass_t.Name = "confirmpass_t";
            this.confirmpass_t.PasswordChar = '\0';
            this.confirmpass_t.PlaceholderText = "confirm password";
            this.confirmpass_t.SelectedText = "";
            this.confirmpass_t.Size = new System.Drawing.Size(194, 38);
            this.confirmpass_t.TabIndex = 17;
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
            this.password_t.Location = new System.Drawing.Point(219, 193);
            this.password_t.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_t.Name = "password_t";
            this.password_t.PasswordChar = '\0';
            this.password_t.PlaceholderText = "password";
            this.password_t.SelectedText = "";
            this.password_t.Size = new System.Drawing.Size(194, 38);
            this.password_t.TabIndex = 18;
            // 
            // genderselect
            // 
            this.genderselect.BackColor = System.Drawing.Color.Transparent;
            this.genderselect.BorderRadius = 10;
            this.genderselect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderselect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderselect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderselect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderselect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.genderselect.ItemHeight = 30;
            this.genderselect.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderselect.Location = new System.Drawing.Point(219, 315);
            this.genderselect.Name = "genderselect";
            this.genderselect.Size = new System.Drawing.Size(194, 36);
            this.genderselect.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderRadius = 10;
            this.dateTimePicker1.Checked = true;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.FillColor = System.Drawing.SystemColors.Window;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 376);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 10, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 36);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(2024, 10, 30, 0, 0, 0, 0);
            // 
            // register_l
            // 
            this.register_l.AutoSize = true;
            this.register_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_l.Location = new System.Drawing.Point(176, 9);
            this.register_l.Name = "register_l";
            this.register_l.Size = new System.Drawing.Size(176, 46);
            this.register_l.TabIndex = 21;
            this.register_l.Text = "Register";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(59, 53);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 22;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Register_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(518, 508);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.register_l);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.genderselect);
            this.Controls.Add(this.password_t);
            this.Controls.Add(this.confirmpass_t);
            this.Controls.Add(this.fullname_t);
            this.Controls.Add(this.username_t);
            this.Controls.Add(this.dateofbirth_t);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm_Register);
            this.Controls.Add(this.gender_l);
            this.Controls.Add(this.confirmpass_l);
            this.Controls.Add(this.fullname_l);
            this.Controls.Add(this.password_l);
            this.Controls.Add(this.username_l);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register_Interface";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_l;
        private System.Windows.Forms.Label password_l;
        private System.Windows.Forms.Label fullname_l;
        private System.Windows.Forms.Label confirmpass_l;
        private System.Windows.Forms.Label gender_l;
        private System.Windows.Forms.Button Confirm_Register;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label dateofbirth_t;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox username_t;
        private Guna.UI2.WinForms.Guna2ComboBox genderselect;
        private Guna.UI2.WinForms.Guna2TextBox password_t;
        private Guna.UI2.WinForms.Guna2TextBox confirmpass_t;
        private Guna.UI2.WinForms.Guna2TextBox fullname_t;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label register_l;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}