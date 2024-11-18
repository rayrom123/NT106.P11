using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Login_Interface : Form
    {
        public Login_Interface()
        {
            InitializeComponent();
        }
        public string username;
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kggHKAGWQR5afL75qkBb8jxrvkPRe6bfptpe16Ev",
            BasePath = "https://tinder-e074f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client = new FirebaseClient(config);



       

        private void Register_button_Click(object sender, EventArgs e) // hiển thị form đăng ký
        {
            var frm = new Register_Interface();
            this.Hide();
            frm.ShowDialog();
        }

        private async void Login_button_Click(object sender, EventArgs e) // tính năng nút login
        {
            try
            {
                if (username_t.Text == string.Empty)
                {
                    MessageBox.Show("Tên người dùng không được bỏ trống");
                    return;
                }
                if (password_t.Text == string.Empty)
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                    return;
                }

                var userResponse = await client.GetTaskAsync("Users/" + username_t.Text); // lấy thông tin người dùng từ textbox rồi so sánh với dữ liệu trên firebase
                if (userResponse == null || userResponse.Body == "null")
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                    return;
                }
                var user = userResponse.ResultAs<User_Entity.User_Model>(); // lấy dữ liệu thông tin người dùng theo class user_model

                if (user == null)
                {
                    MessageBox.Show("Không thể lấy thông tin người dùng");
                    return;
                }

                if (user.Password != user.encrypt(password_t.Text))
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                    return;
                }
                MessageBox.Show("Đăng nhập thành công");
                username = username_t.Text;

                if (user.Location == null || user.ImagePath == string.Empty)
                {
                    var formttcn = new Details_Interface();
                    formttcn.username = username;
                    this.Hide();                    
                    formttcn.ShowDialog();
                }
                else
                {
                    var frm_menu = new Menu();
                    frm_menu.username = username;
                    this.Hide();
                    frm_menu.ShowDialog();

                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {            
                Application.Exit();
        }
    }
}
