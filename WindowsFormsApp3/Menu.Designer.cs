namespace WindowsFormsApp3
{
    partial class Menu
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.menu_tabcontrol = new Guna.UI2.WinForms.Guna2TabControl();
            this.tab_matching = new System.Windows.Forms.TabPage();
            this.tab_chat = new System.Windows.Forms.TabPage();
            this.tab_profile = new System.Windows.Forms.TabPage();
            this.Image_View = new System.Windows.Forms.PictureBox();
            this.Select_Image = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateofbirth_t = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Done_button = new System.Windows.Forms.Button();
            this.interest_t = new System.Windows.Forms.RichTextBox();
            this.location_select = new System.Windows.Forms.ComboBox();
            this.Interests_I = new System.Windows.Forms.Label();
            this.location_I = new System.Windows.Forms.Label();
            this.dateofbirth_I = new System.Windows.Forms.Label();
            this.fullname_t = new System.Windows.Forms.TextBox();
            this.username_t = new System.Windows.Forms.TextBox();
            this.gender_l = new System.Windows.Forms.Label();
            this.fullname_l = new System.Windows.Forms.Label();
            this.username_l = new System.Windows.Forms.Label();
            this.gender_t = new System.Windows.Forms.TextBox();
            this.menu_tabcontrol.SuspendLayout();
            this.tab_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_View)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // menu_tabcontrol
            // 
            this.menu_tabcontrol.Controls.Add(this.tab_profile);
            this.menu_tabcontrol.Controls.Add(this.tab_chat);
            this.menu_tabcontrol.Controls.Add(this.tab_matching);
            this.menu_tabcontrol.ItemSize = new System.Drawing.Size(160, 40);
            this.menu_tabcontrol.Location = new System.Drawing.Point(0, -1);
            this.menu_tabcontrol.Name = "menu_tabcontrol";
            this.menu_tabcontrol.SelectedIndex = 0;
            this.menu_tabcontrol.Size = new System.Drawing.Size(855, 499);
            this.menu_tabcontrol.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.menu_tabcontrol.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.menu_tabcontrol.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.menu_tabcontrol.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.menu_tabcontrol.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.menu_tabcontrol.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.menu_tabcontrol.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.menu_tabcontrol.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.menu_tabcontrol.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.menu_tabcontrol.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.menu_tabcontrol.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.menu_tabcontrol.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.menu_tabcontrol.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.menu_tabcontrol.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.menu_tabcontrol.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.menu_tabcontrol.TabButtonSize = new System.Drawing.Size(160, 40);
            this.menu_tabcontrol.TabIndex = 8;
            this.menu_tabcontrol.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menu_tabcontrol.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tab_matching
            // 
            this.tab_matching.BackColor = System.Drawing.Color.Pink;
            this.tab_matching.Location = new System.Drawing.Point(4, 44);
            this.tab_matching.Name = "tab_matching";
            this.tab_matching.Padding = new System.Windows.Forms.Padding(3);
            this.tab_matching.Size = new System.Drawing.Size(858, 450);
            this.tab_matching.TabIndex = 1;
            this.tab_matching.Text = "Matching";
            // 
            // tab_chat
            // 
            this.tab_chat.BackColor = System.Drawing.Color.Pink;
            this.tab_chat.Location = new System.Drawing.Point(4, 44);
            this.tab_chat.Name = "tab_chat";
            this.tab_chat.Padding = new System.Windows.Forms.Padding(3);
            this.tab_chat.Size = new System.Drawing.Size(858, 450);
            this.tab_chat.TabIndex = 2;
            this.tab_chat.Text = "Chat";
            // 
            // tab_profile
            // 
            this.tab_profile.BackColor = System.Drawing.Color.Pink;
            this.tab_profile.Controls.Add(this.Image_View);
            this.tab_profile.Controls.Add(this.Select_Image);
            this.tab_profile.Controls.Add(this.label1);
            this.tab_profile.Controls.Add(this.dateofbirth_t);
            this.tab_profile.Controls.Add(this.gender_t);
            this.tab_profile.Controls.Add(this.Back_button);
            this.tab_profile.Controls.Add(this.Done_button);
            this.tab_profile.Controls.Add(this.interest_t);
            this.tab_profile.Controls.Add(this.location_select);
            this.tab_profile.Controls.Add(this.Interests_I);
            this.tab_profile.Controls.Add(this.location_I);
            this.tab_profile.Controls.Add(this.dateofbirth_I);
            this.tab_profile.Controls.Add(this.fullname_t);
            this.tab_profile.Controls.Add(this.username_t);
            this.tab_profile.Controls.Add(this.gender_l);
            this.tab_profile.Controls.Add(this.fullname_l);
            this.tab_profile.Controls.Add(this.username_l);
            this.tab_profile.Location = new System.Drawing.Point(4, 44);
            this.tab_profile.Name = "tab_profile";
            this.tab_profile.Padding = new System.Windows.Forms.Padding(3);
            this.tab_profile.Size = new System.Drawing.Size(847, 451);
            this.tab_profile.TabIndex = 0;
            this.tab_profile.Text = "Profile";
            // 
            // Image_View
            // 
            this.Image_View.Location = new System.Drawing.Point(558, 180);
            this.Image_View.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Image_View.Name = "Image_View";
            this.Image_View.Size = new System.Drawing.Size(241, 182);
            this.Image_View.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image_View.TabIndex = 73;
            this.Image_View.TabStop = false;
            // 
            // Select_Image
            // 
            this.Select_Image.Location = new System.Drawing.Point(444, 239);
            this.Select_Image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Select_Image.Name = "Select_Image";
            this.Select_Image.Size = new System.Drawing.Size(84, 29);
            this.Select_Image.TabIndex = 72;
            this.Select_Image.Text = "Select image";
            this.Select_Image.UseVisualStyleBackColor = true;
            this.Select_Image.Click += new System.EventHandler(this.Select_Image_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Image";
            // 
            // dateofbirth_t
            // 
            this.dateofbirth_t.Location = new System.Drawing.Point(184, 122);
            this.dateofbirth_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateofbirth_t.Name = "dateofbirth_t";
            this.dateofbirth_t.ReadOnly = true;
            this.dateofbirth_t.Size = new System.Drawing.Size(231, 26);
            this.dateofbirth_t.TabIndex = 70;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(184, 391);
            this.Back_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(219, 42);
            this.Back_button.TabIndex = 68;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            // 
            // Done_button
            // 
            this.Done_button.Location = new System.Drawing.Point(558, 391);
            this.Done_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(219, 42);
            this.Done_button.TabIndex = 67;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // interest_t
            // 
            this.interest_t.Location = new System.Drawing.Point(184, 180);
            this.interest_t.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interest_t.Name = "interest_t";
            this.interest_t.Size = new System.Drawing.Size(231, 180);
            this.interest_t.TabIndex = 66;
            this.interest_t.Text = "";
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
            this.location_select.Location = new System.Drawing.Point(547, 122);
            this.location_select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.location_select.Name = "location_select";
            this.location_select.Size = new System.Drawing.Size(231, 28);
            this.location_select.TabIndex = 65;
            // 
            // Interests_I
            // 
            this.Interests_I.AutoSize = true;
            this.Interests_I.Location = new System.Drawing.Point(60, 182);
            this.Interests_I.Name = "Interests_I";
            this.Interests_I.Size = new System.Drawing.Size(72, 20);
            this.Interests_I.TabIndex = 64;
            this.Interests_I.Text = "Interests";
            // 
            // location_I
            // 
            this.location_I.AutoSize = true;
            this.location_I.Location = new System.Drawing.Point(458, 126);
            this.location_I.Name = "location_I";
            this.location_I.Size = new System.Drawing.Size(70, 20);
            this.location_I.TabIndex = 63;
            this.location_I.Text = "Location";
            // 
            // dateofbirth_I
            // 
            this.dateofbirth_I.AutoSize = true;
            this.dateofbirth_I.Location = new System.Drawing.Point(60, 126);
            this.dateofbirth_I.Name = "dateofbirth_I";
            this.dateofbirth_I.Size = new System.Drawing.Size(99, 20);
            this.dateofbirth_I.TabIndex = 62;
            this.dateofbirth_I.Text = "Date of Birth";
            // 
            // fullname_t
            // 
            this.fullname_t.Location = new System.Drawing.Point(184, 68);
            this.fullname_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fullname_t.Name = "fullname_t";
            this.fullname_t.ReadOnly = true;
            this.fullname_t.Size = new System.Drawing.Size(594, 26);
            this.fullname_t.TabIndex = 61;
            // 
            // username_t
            // 
            this.username_t.Location = new System.Drawing.Point(184, 17);
            this.username_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_t.Name = "username_t";
            this.username_t.ReadOnly = true;
            this.username_t.Size = new System.Drawing.Size(231, 26);
            this.username_t.TabIndex = 60;
            // 
            // gender_l
            // 
            this.gender_l.AutoSize = true;
            this.gender_l.Location = new System.Drawing.Point(458, 24);
            this.gender_l.Name = "gender_l";
            this.gender_l.Size = new System.Drawing.Size(63, 20);
            this.gender_l.TabIndex = 59;
            this.gender_l.Text = "Gender";
            // 
            // fullname_l
            // 
            this.fullname_l.AutoSize = true;
            this.fullname_l.Location = new System.Drawing.Point(60, 71);
            this.fullname_l.Name = "fullname_l";
            this.fullname_l.Size = new System.Drawing.Size(80, 20);
            this.fullname_l.TabIndex = 58;
            this.fullname_l.Text = "Full Name";
            // 
            // username_l
            // 
            this.username_l.AutoSize = true;
            this.username_l.Location = new System.Drawing.Point(60, 21);
            this.username_l.Name = "username_l";
            this.username_l.Size = new System.Drawing.Size(89, 20);
            this.username_l.TabIndex = 57;
            this.username_l.Text = "User Name";
            // 
            // gender_t
            // 
            this.gender_t.Location = new System.Drawing.Point(547, 17);
            this.gender_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender_t.Name = "gender_t";
            this.gender_t.ReadOnly = true;
            this.gender_t.Size = new System.Drawing.Size(231, 26);
            this.gender_t.TabIndex = 69;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(867, 499);
            this.Controls.Add(this.menu_tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menu_tabcontrol.ResumeLayout(false);
            this.tab_profile.ResumeLayout(false);
            this.tab_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TabControl menu_tabcontrol;
        private System.Windows.Forms.TabPage tab_matching;
        private System.Windows.Forms.TabPage tab_chat;
        private System.Windows.Forms.TabPage tab_profile;
        private System.Windows.Forms.PictureBox Image_View;
        private System.Windows.Forms.Button Select_Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dateofbirth_t;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.RichTextBox interest_t;
        private System.Windows.Forms.ComboBox location_select;
        private System.Windows.Forms.Label Interests_I;
        private System.Windows.Forms.Label location_I;
        private System.Windows.Forms.Label dateofbirth_I;
        private System.Windows.Forms.TextBox fullname_t;
        private System.Windows.Forms.TextBox username_t;
        private System.Windows.Forms.Label gender_l;
        private System.Windows.Forms.Label fullname_l;
        private System.Windows.Forms.Label username_l;
        private System.Windows.Forms.TextBox gender_t;
    }
}