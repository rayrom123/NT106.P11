using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using User_Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp3
{
    public partial class Register_Interface : Form
    {
        
        public Register_Interface()
        {
            InitializeComponent();
            this.Load += new EventHandler(Register_Interface_Load);
        }
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kggHKAGWQR5afL75qkBb8jxrvkPRe6bfptpe16Ev",
            BasePath = "https://tinder-e074f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client = new FirebaseClient(config);
       
        private async void Confirm_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (username_t.Text == string.Empty)
                {
                    MessageBox.Show("Ten nguoi dung khong duoc bo trong");
                    return;
                }
                if (fullname_t.Text == string.Empty)
                {
                    MessageBox.Show("Khong duoc bo trong ten");
                    return;
                }
                if (password_t.Text == string.Empty)
                {
                    MessageBox.Show("Khong duoc bo trong mat khau");
                    return;
                }
                if (confirmpass_t.Text == string.Empty)
                {
                    MessageBox.Show("Khong duoc bo trong mat khau");
                    return;
                }
                if (password_t.Text != confirmpass_t.Text)
                {
                    MessageBox.Show("Vui long xac thuc mat khau tai");
                    return;
                }
                if (genderselect.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui long chon gioi tinh");
                    return;
                }


                var new_user = new User_Entity.User_Model();
                
                new_user.Gender = genderselect.SelectedIndex;
                new_user.FullName = fullname_t.Text;
                new_user.Password = new_user.encrypt(password_t.Text.ToString());
                new_user.UserName = username_t.Text;
                new_user.DateOfBirth = dateTimePicker1.Value;
                var userResponse = await client.GetTaskAsync("Users/" + username_t.Text);

                if (userResponse.Body != "null")
                {
                    MessageBox.Show("Da ton tai tai khoan");
                    return;
                }
                SetResponse response = await client.SetTaskAsync("Users/" + username_t.Text, new_user);
                User_Entity.User_Model result = response.ResultAs<User_Entity.User_Model>();
                MessageBox.Show("Đã thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Interface_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form login_interface = new Login_Interface();
            login_interface.Show();
        }
    }
}
