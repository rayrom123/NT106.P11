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
            this.username_l = new System.Windows.Forms.Label();
            this.password_l = new System.Windows.Forms.Label();
            this.fullname_l = new System.Windows.Forms.Label();
            this.confirmpass_l = new System.Windows.Forms.Label();
            this.gender_l = new System.Windows.Forms.Label();
            this.Confirm_Register = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.username_t = new System.Windows.Forms.TextBox();
            this.password_t = new System.Windows.Forms.TextBox();
            this.fullname_t = new System.Windows.Forms.TextBox();
            this.confirmpass_t = new System.Windows.Forms.TextBox();
            this.genderselect = new System.Windows.Forms.ComboBox();
            this.dateofbirth_t = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // username_l
            // 
            this.username_l.AutoSize = true;
            this.username_l.Location = new System.Drawing.Point(39, 98);
            this.username_l.Name = "username_l";
            this.username_l.Size = new System.Drawing.Size(89, 20);
            this.username_l.TabIndex = 0;
            this.username_l.Text = "User Name";
            // 
            // password_l
            // 
            this.password_l.AutoSize = true;
            this.password_l.Location = new System.Drawing.Point(39, 196);
            this.password_l.Name = "password_l";
            this.password_l.Size = new System.Drawing.Size(82, 20);
            this.password_l.TabIndex = 1;
            this.password_l.Text = "PassWord";
            // 
            // fullname_l
            // 
            this.fullname_l.AutoSize = true;
            this.fullname_l.Location = new System.Drawing.Point(39, 145);
            this.fullname_l.Name = "fullname_l";
            this.fullname_l.Size = new System.Drawing.Size(80, 20);
            this.fullname_l.TabIndex = 2;
            this.fullname_l.Text = "Full Name";
            // 
            // confirmpass_l
            // 
            this.confirmpass_l.AutoSize = true;
            this.confirmpass_l.Location = new System.Drawing.Point(39, 244);
            this.confirmpass_l.Name = "confirmpass_l";
            this.confirmpass_l.Size = new System.Drawing.Size(141, 20);
            this.confirmpass_l.TabIndex = 3;
            this.confirmpass_l.Text = "Confirm PassWord";
            // 
            // gender_l
            // 
            this.gender_l.AutoSize = true;
            this.gender_l.Location = new System.Drawing.Point(39, 292);
            this.gender_l.Name = "gender_l";
            this.gender_l.Size = new System.Drawing.Size(63, 20);
            this.gender_l.TabIndex = 4;
            this.gender_l.Text = "Gender";
            // 
            // Confirm_Register
            // 
            this.Confirm_Register.Location = new System.Drawing.Point(64, 384);
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
            this.Cancel.Location = new System.Drawing.Point(254, 384);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(109, 46);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // username_t
            // 
            this.username_t.Location = new System.Drawing.Point(254, 94);
            this.username_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_t.Name = "username_t";
            this.username_t.Size = new System.Drawing.Size(164, 26);
            this.username_t.TabIndex = 7;
            // 
            // password_t
            // 
            this.password_t.Location = new System.Drawing.Point(254, 189);
            this.password_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_t.Name = "password_t";
            this.password_t.Size = new System.Drawing.Size(164, 26);
            this.password_t.TabIndex = 8;
            // 
            // fullname_t
            // 
            this.fullname_t.Location = new System.Drawing.Point(254, 141);
            this.fullname_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullname_t.Name = "fullname_t";
            this.fullname_t.Size = new System.Drawing.Size(164, 26);
            this.fullname_t.TabIndex = 9;
            // 
            // confirmpass_t
            // 
            this.confirmpass_t.Location = new System.Drawing.Point(254, 236);
            this.confirmpass_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmpass_t.Name = "confirmpass_t";
            this.confirmpass_t.Size = new System.Drawing.Size(164, 26);
            this.confirmpass_t.TabIndex = 10;
            // 
            // genderselect
            // 
            this.genderselect.FormattingEnabled = true;
            this.genderselect.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderselect.Location = new System.Drawing.Point(254, 282);
            this.genderselect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderselect.Name = "genderselect";
            this.genderselect.Size = new System.Drawing.Size(164, 28);
            this.genderselect.TabIndex = 11;
            // 
            // dateofbirth_t
            // 
            this.dateofbirth_t.AutoSize = true;
            this.dateofbirth_t.Location = new System.Drawing.Point(39, 339);
            this.dateofbirth_t.Name = "dateofbirth_t";
            this.dateofbirth_t.Size = new System.Drawing.Size(99, 20);
            this.dateofbirth_t.TabIndex = 12;
            this.dateofbirth_t.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 333);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 10, 24, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2024, 10, 24, 0, 0, 0, 0);
            // 
            // Register_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 508);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateofbirth_t);
            this.Controls.Add(this.genderselect);
            this.Controls.Add(this.confirmpass_t);
            this.Controls.Add(this.fullname_t);
            this.Controls.Add(this.password_t);
            this.Controls.Add(this.username_t);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm_Register);
            this.Controls.Add(this.gender_l);
            this.Controls.Add(this.confirmpass_l);
            this.Controls.Add(this.fullname_l);
            this.Controls.Add(this.password_l);
            this.Controls.Add(this.username_l);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Register_Interface";
            this.Text = "Register_Interface";
            this.Load += new System.EventHandler(this.Register_Interface_Load);
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
        private System.Windows.Forms.TextBox username_t;
        private System.Windows.Forms.TextBox password_t;
        private System.Windows.Forms.TextBox fullname_t;
        private System.Windows.Forms.TextBox confirmpass_t;
        private System.Windows.Forms.ComboBox genderselect;
        private System.Windows.Forms.Label dateofbirth_t;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}