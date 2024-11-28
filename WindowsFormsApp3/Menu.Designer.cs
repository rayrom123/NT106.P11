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
            this.tab_profile = new System.Windows.Forms.TabPage();
            this.Image_View = new System.Windows.Forms.PictureBox();
            this.Select_Image = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateofbirth_t = new System.Windows.Forms.TextBox();
            this.gender_t = new System.Windows.Forms.TextBox();
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
            this.tab_chat = new System.Windows.Forms.TabPage();
            this.tab_matching = new System.Windows.Forms.TabPage();
            this.image_t = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gender_text = new System.Windows.Forms.TextBox();
            this.interest_text = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.Dislike_Button = new System.Windows.Forms.Button();
            this.Like_Button = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.menu_tabcontrol.SuspendLayout();
            this.tab_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_View)).BeginInit();
            this.tab_matching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_t)).BeginInit();
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
            this.menu_tabcontrol.ItemSize = new System.Drawing.Size(180, 40);
            this.menu_tabcontrol.Location = new System.Drawing.Point(0, -1);
            this.menu_tabcontrol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu_tabcontrol.Name = "menu_tabcontrol";
            this.menu_tabcontrol.SelectedIndex = 0;
            this.menu_tabcontrol.Size = new System.Drawing.Size(895, 501);
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
            this.menu_tabcontrol.TabButtonSize = new System.Drawing.Size(180, 40);
            this.menu_tabcontrol.TabIndex = 8;
            this.menu_tabcontrol.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menu_tabcontrol.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.menu_tabcontrol.SelectedIndexChanged += new System.EventHandler(this.menu_tabcontrol_SelectedIndexChanged);
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
            this.tab_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_profile.Name = "tab_profile";
            this.tab_profile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_profile.Size = new System.Drawing.Size(887, 453);
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
            // gender_t
            // 
            this.gender_t.Location = new System.Drawing.Point(547, 18);
            this.gender_t.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender_t.Name = "gender_t";
            this.gender_t.ReadOnly = true;
            this.gender_t.Size = new System.Drawing.Size(231, 26);
            this.gender_t.TabIndex = 69;
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
            this.location_select.SelectedIndexChanged += new System.EventHandler(this.location_select_SelectedIndexChanged);
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
            this.username_t.Location = new System.Drawing.Point(184, 18);
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
            // tab_chat
            // 
            this.tab_chat.BackColor = System.Drawing.Color.Pink;
            this.tab_chat.Location = new System.Drawing.Point(4, 44);
            this.tab_chat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_chat.Name = "tab_chat";
            this.tab_chat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_chat.Size = new System.Drawing.Size(887, 453);
            this.tab_chat.TabIndex = 2;
            this.tab_chat.Text = "Chat";
            // 
            // tab_matching
            // 
            this.tab_matching.BackColor = System.Drawing.Color.Pink;
            this.tab_matching.Controls.Add(this.image_t);
            this.tab_matching.Controls.Add(this.gender_text);
            this.tab_matching.Controls.Add(this.interest_text);
            this.tab_matching.Controls.Add(this.label3);
            this.tab_matching.Controls.Add(this.label4);
            this.tab_matching.Controls.Add(this.label6);
            this.tab_matching.Controls.Add(this.label7);
            this.tab_matching.Controls.Add(this.start);
            this.tab_matching.Controls.Add(this.Dislike_Button);
            this.tab_matching.Controls.Add(this.Like_Button);
            this.tab_matching.Location = new System.Drawing.Point(4, 44);
            this.tab_matching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_matching.Name = "tab_matching";
            this.tab_matching.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_matching.Size = new System.Drawing.Size(887, 453);
            this.tab_matching.TabIndex = 1;
            this.tab_matching.Text = "Matching";
            // 
            // image_t
            // 
            this.image_t.BorderRadius = 10;
            this.image_t.ImageRotate = 0F;
            this.image_t.Location = new System.Drawing.Point(421, 22);
            this.image_t.Name = "image_t";
            this.image_t.Size = new System.Drawing.Size(421, 293);
            this.image_t.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_t.TabIndex = 90;
            this.image_t.TabStop = false;
            // 
            // gender_text
            // 
            this.gender_text.Location = new System.Drawing.Point(116, 9);
            this.gender_text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender_text.Name = "gender_text";
            this.gender_text.ReadOnly = true;
            this.gender_text.Size = new System.Drawing.Size(111, 26);
            this.gender_text.TabIndex = 84;
            // 
            // interest_text
            // 
            this.interest_text.Location = new System.Drawing.Point(114, 54);
            this.interest_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.interest_text.Name = "interest_text";
            this.interest_text.ReadOnly = true;
            this.interest_text.Size = new System.Drawing.Size(231, 114);
            this.interest_text.TabIndex = 83;
            this.interest_text.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Interests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(555, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 75;
            this.label7.Text = "Full Name";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(257, 196);
            this.start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(101, 47);
            this.start.TabIndex = 3;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Dislike_Button
            // 
            this.Dislike_Button.Location = new System.Drawing.Point(26, 196);
            this.Dislike_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dislike_Button.Name = "Dislike_Button";
            this.Dislike_Button.Size = new System.Drawing.Size(97, 47);
            this.Dislike_Button.TabIndex = 1;
            this.Dislike_Button.Text = "dislike";
            this.Dislike_Button.UseVisualStyleBackColor = true;
            this.Dislike_Button.Click += new System.EventHandler(this.Dislike_Button_Click);
            // 
            // Like_Button
            // 
            this.Like_Button.Location = new System.Drawing.Point(141, 196);
            this.Like_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Like_Button.Name = "Like_Button";
            this.Like_Button.Size = new System.Drawing.Size(97, 47);
            this.Like_Button.TabIndex = 0;
            this.Like_Button.Text = "like";
            this.Like_Button.UseVisualStyleBackColor = true;
            this.Like_Button.Click += new System.EventHandler(this.Like_Button_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.menu_tabcontrol;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(907, 510);
            this.Controls.Add(this.menu_tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menu_tabcontrol.ResumeLayout(false);
            this.tab_profile.ResumeLayout(false);
            this.tab_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_View)).EndInit();
            this.tab_matching.ResumeLayout(false);
            this.tab_matching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_t)).EndInit();
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
        private System.Windows.Forms.Button Dislike_Button;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Like_Button;
        private System.Windows.Forms.TextBox gender_text;
        private System.Windows.Forms.RichTextBox interest_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2PictureBox image_t;
    }
}