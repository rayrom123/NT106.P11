namespace WindowsFormsApp3
{
    partial class Details_Interface
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
            this.dateofbirth_I = new System.Windows.Forms.Label();
            this.fullname_t = new System.Windows.Forms.TextBox();
            this.username_t = new System.Windows.Forms.TextBox();
            this.gender_l = new System.Windows.Forms.Label();
            this.fullname_l = new System.Windows.Forms.Label();
            this.username_l = new System.Windows.Forms.Label();
            this.location_I = new System.Windows.Forms.Label();
            this.Interests_I = new System.Windows.Forms.Label();
            this.location_select = new System.Windows.Forms.ComboBox();
            this.interest_t = new System.Windows.Forms.RichTextBox();
            this.title_I = new System.Windows.Forms.Label();
            this.Done_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.gender_t = new System.Windows.Forms.TextBox();
            this.dateofbrith_t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateofbirth_I
            // 
            this.dateofbirth_I.AutoSize = true;
            this.dateofbirth_I.Location = new System.Drawing.Point(30, 197);
            this.dateofbirth_I.Name = "dateofbirth_I";
            this.dateofbirth_I.Size = new System.Drawing.Size(99, 20);
            this.dateofbirth_I.TabIndex = 24;
            this.dateofbirth_I.Text = "Date of Birth";
            // 
            // fullname_t
            // 
            this.fullname_t.Location = new System.Drawing.Point(154, 140);
            this.fullname_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullname_t.Name = "fullname_t";
            this.fullname_t.ReadOnly = true;
            this.fullname_t.Size = new System.Drawing.Size(594, 26);
            this.fullname_t.TabIndex = 21;
            // 
            // username_t
            // 
            this.username_t.Location = new System.Drawing.Point(154, 89);
            this.username_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_t.Name = "username_t";
            this.username_t.ReadOnly = true;
            this.username_t.Size = new System.Drawing.Size(231, 26);
            this.username_t.TabIndex = 19;
            // 
            // gender_l
            // 
            this.gender_l.AutoSize = true;
            this.gender_l.Location = new System.Drawing.Point(429, 95);
            this.gender_l.Name = "gender_l";
            this.gender_l.Size = new System.Drawing.Size(63, 20);
            this.gender_l.TabIndex = 18;
            this.gender_l.Text = "Gender";
            // 
            // fullname_l
            // 
            this.fullname_l.AutoSize = true;
            this.fullname_l.Location = new System.Drawing.Point(30, 143);
            this.fullname_l.Name = "fullname_l";
            this.fullname_l.Size = new System.Drawing.Size(80, 20);
            this.fullname_l.TabIndex = 16;
            this.fullname_l.Text = "Full Name";
            // 
            // username_l
            // 
            this.username_l.AutoSize = true;
            this.username_l.Location = new System.Drawing.Point(30, 92);
            this.username_l.Name = "username_l";
            this.username_l.Size = new System.Drawing.Size(89, 20);
            this.username_l.TabIndex = 14;
            this.username_l.Text = "User Name";
            // 
            // location_I
            // 
            this.location_I.AutoSize = true;
            this.location_I.Location = new System.Drawing.Point(429, 197);
            this.location_I.Name = "location_I";
            this.location_I.Size = new System.Drawing.Size(70, 20);
            this.location_I.TabIndex = 26;
            this.location_I.Text = "Location";
            // 
            // Interests_I
            // 
            this.Interests_I.AutoSize = true;
            this.Interests_I.Location = new System.Drawing.Point(30, 254);
            this.Interests_I.Name = "Interests_I";
            this.Interests_I.Size = new System.Drawing.Size(72, 20);
            this.Interests_I.TabIndex = 27;
            this.Interests_I.Text = "Interests";
            // 
            // location_select
            // 
            this.location_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_select.FormattingEnabled = true;
            this.location_select.Items.AddRange(new object[] {
            "Quận 1",
            "Quận 2",
            "Quận 3",
            "Quận 4",
            "Quận 5",
            "Quận 6",
            "Quận 7",
            "Quận 8",
            "Quận 9",
            "Quận 10",
            "Quận 11",
            "Quận 12",
            "Quận Bình Thạnh",
            "Quận Bình Tân",
            "Quận Phú Nhuận",
            "Quận Tân Bình",
            "Quận Tân Phú",
            "Quận Gò Vấp",
            "Quận Thủ Đức",
            "Huyện Củ Chi",
            "Huyện Hóc Môn",
            "Huyện Nhà Bè"});
            this.location_select.Location = new System.Drawing.Point(517, 194);
            this.location_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.location_select.Name = "location_select";
            this.location_select.Size = new System.Drawing.Size(231, 28);
            this.location_select.TabIndex = 28;
            // 
            // interest_t
            // 
            this.interest_t.Location = new System.Drawing.Point(154, 251);
            this.interest_t.Name = "interest_t";
            this.interest_t.Size = new System.Drawing.Size(594, 180);
            this.interest_t.TabIndex = 29;
            this.interest_t.Text = "";
            // 
            // title_I
            // 
            this.title_I.AutoSize = true;
            this.title_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_I.Location = new System.Drawing.Point(267, 9);
            this.title_I.Name = "title_I";
            this.title_I.Size = new System.Drawing.Size(311, 46);
            this.title_I.TabIndex = 30;
            this.title_I.Text = "Personal Details";
            // 
            // Done_button
            // 
            this.Done_button.Location = new System.Drawing.Point(529, 463);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(219, 42);
            this.Done_button.TabIndex = 31;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(154, 463);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(219, 42);
            this.Back_button.TabIndex = 32;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // gender_t
            // 
            this.gender_t.Location = new System.Drawing.Point(517, 89);
            this.gender_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender_t.Name = "gender_t";
            this.gender_t.ReadOnly = true;
            this.gender_t.Size = new System.Drawing.Size(231, 26);
            this.gender_t.TabIndex = 33;
            // 
            // dateofbrith_t
            // 
            this.dateofbrith_t.Location = new System.Drawing.Point(154, 194);
            this.dateofbrith_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateofbrith_t.Name = "dateofbrith_t";
            this.dateofbrith_t.ReadOnly = true;
            this.dateofbrith_t.Size = new System.Drawing.Size(231, 26);
            this.dateofbrith_t.TabIndex = 34;
            // 
            // Details_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 517);
            this.Controls.Add(this.dateofbrith_t);
            this.Controls.Add(this.gender_t);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.title_I);
            this.Controls.Add(this.interest_t);
            this.Controls.Add(this.location_select);
            this.Controls.Add(this.Interests_I);
            this.Controls.Add(this.location_I);
            this.Controls.Add(this.dateofbirth_I);
            this.Controls.Add(this.fullname_t);
            this.Controls.Add(this.username_t);
            this.Controls.Add(this.gender_l);
            this.Controls.Add(this.fullname_l);
            this.Controls.Add(this.username_l);
            this.Name = "Details_Interface";
            this.Text = "Details_Interface";
            this.Load += new System.EventHandler(this.Details_Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateofbirth_I;
        private System.Windows.Forms.TextBox fullname_t;
        private System.Windows.Forms.TextBox username_t;
        private System.Windows.Forms.Label gender_l;
        private System.Windows.Forms.Label fullname_l;
        private System.Windows.Forms.Label username_l;
        private System.Windows.Forms.Label location_I;
        private System.Windows.Forms.Label Interests_I;
        private System.Windows.Forms.ComboBox location_select;
        private System.Windows.Forms.RichTextBox interest_t;
        private System.Windows.Forms.Label title_I;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox gender_t;
        private System.Windows.Forms.TextBox dateofbrith_t;
    }
}