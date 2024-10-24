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
            this.SuspendLayout();
            // 
            // username_l
            // 
            this.username_l.AutoSize = true;
            this.username_l.Location = new System.Drawing.Point(35, 78);
            this.username_l.Name = "username_l";
            this.username_l.Size = new System.Drawing.Size(76, 16);
            this.username_l.TabIndex = 0;
            this.username_l.Text = "User Name";
            // 
            // password_l
            // 
            this.password_l.AutoSize = true;
            this.password_l.Location = new System.Drawing.Point(35, 157);
            this.password_l.Name = "password_l";
            this.password_l.Size = new System.Drawing.Size(71, 16);
            this.password_l.TabIndex = 1;
            this.password_l.Text = "PassWord";
            // 
            // fullname_l
            // 
            this.fullname_l.AutoSize = true;
            this.fullname_l.Location = new System.Drawing.Point(35, 116);
            this.fullname_l.Name = "fullname_l";
            this.fullname_l.Size = new System.Drawing.Size(68, 16);
            this.fullname_l.TabIndex = 2;
            this.fullname_l.Text = "Full Name";
            // 
            // confirmpass_l
            // 
            this.confirmpass_l.AutoSize = true;
            this.confirmpass_l.Location = new System.Drawing.Point(35, 195);
            this.confirmpass_l.Name = "confirmpass_l";
            this.confirmpass_l.Size = new System.Drawing.Size(119, 16);
            this.confirmpass_l.TabIndex = 3;
            this.confirmpass_l.Text = "Confirm PassWord";
            // 
            // gender_l
            // 
            this.gender_l.AutoSize = true;
            this.gender_l.Location = new System.Drawing.Point(35, 234);
            this.gender_l.Name = "gender_l";
            this.gender_l.Size = new System.Drawing.Size(52, 16);
            this.gender_l.TabIndex = 4;
            this.gender_l.Text = "Gender";
            // 
            // Confirm_Register
            // 
            this.Confirm_Register.Location = new System.Drawing.Point(57, 307);
            this.Confirm_Register.Name = "Confirm_Register";
            this.Confirm_Register.Size = new System.Drawing.Size(97, 37);
            this.Confirm_Register.TabIndex = 5;
            this.Confirm_Register.Text = "Register";
            this.Confirm_Register.UseVisualStyleBackColor = true;
            this.Confirm_Register.Click += new System.EventHandler(this.Confirm_Register_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(226, 307);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 37);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // username_t
            // 
            this.username_t.Location = new System.Drawing.Point(226, 75);
            this.username_t.Name = "username_t";
            this.username_t.Size = new System.Drawing.Size(146, 22);
            this.username_t.TabIndex = 7;
            // 
            // password_t
            // 
            this.password_t.Location = new System.Drawing.Point(226, 151);
            this.password_t.Name = "password_t";
            this.password_t.Size = new System.Drawing.Size(146, 22);
            this.password_t.TabIndex = 8;
            // 
            // fullname_t
            // 
            this.fullname_t.Location = new System.Drawing.Point(226, 113);
            this.fullname_t.Name = "fullname_t";
            this.fullname_t.Size = new System.Drawing.Size(146, 22);
            this.fullname_t.TabIndex = 9;
            // 
            // confirmpass_t
            // 
            this.confirmpass_t.Location = new System.Drawing.Point(226, 189);
            this.confirmpass_t.Name = "confirmpass_t";
            this.confirmpass_t.Size = new System.Drawing.Size(146, 22);
            this.confirmpass_t.TabIndex = 10;
            // 
            // genderselect
            // 
            this.genderselect.FormattingEnabled = true;
            this.genderselect.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderselect.Location = new System.Drawing.Point(226, 226);
            this.genderselect.Name = "genderselect";
            this.genderselect.Size = new System.Drawing.Size(146, 24);
            this.genderselect.TabIndex = 11;
            // 
            // Register_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 406);
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
            this.Name = "Register_Interface";
            this.Text = "Register_Interface";
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
    }
}