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
using System.IO;
using System.Net.Sockets;
using System.Threading;
using User_Entity;
using System.Runtime.InteropServices.ComTypes;

namespace WindowsFormsApp3
{
    public partial class Login_Interface : Form
    {
        public Login_Interface()
        {
            InitializeComponent();
            StartConnection();
        }

        public string username;  // Lưu tên người dùng sau khi đăng nhập
        private TcpClient user;
        private NetworkStream stream;
        public bool isSuccess = false;
        public bool isLogin = false;

        // Khởi tạo kết nối đến server
        private void StartConnection()
        {
            try
            {
                user = new TcpClient("127.0.0.1", 8888);  // Kết nối đến server
                stream = user.GetStream();
                Thread listenThread = new Thread(ListenForMessages);  // Lắng nghe tin nhắn từ server
                listenThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to server: {ex.Message}");
            }
        }

        // Lắng nghe tin nhắn từ server
        private void ListenForMessages()
        {
            byte[] buffer = new byte[12200];
            int bytesRead;
            while (!isLogin && (bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                {
                    Invoke((MethodInvoker)delegate
                    {
                        // Giả sử "A" là đối tượng User_Model được nhận từ server
                        User_Model userModel = ParseUserModel(message);
                        if (userModel != null)
                        {
                            username = userModel.UserName;  // Lưu tên người dùng
                            isSuccess = true;  // Đăng nhập thành công
                            MessageBox.Show("Success");
                            isLogin = true;
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Invalid credentials.");
                            this.Close();
                            Login_Interface lg = new Login_Interface();
                            lg.Show();
                            return;
                        }
                        // Kiểm tra thông tin chi tiết người dùng
                        if (userModel.Location == null || userModel.ImagePath == string.Empty)
                        {
                            var formttcn = new Details_Interface();
                            formttcn.username = username;
                            this.Hide();
                            formttcn.ShowDialog();  // Mở form chi tiết người dùng
                        }
                        else
                        {
                            var frm_menu = new Menu(user, stream);
                            frm_menu.user = userModel;
                            frm_menu.username = username;
                            this.Hide();
                            frm_menu.Show();
                            isLogin = true;
                        }
                    });
                }
            }
        }



        // Phương thức để phân tích dữ liệu người dùng từ server
        private User_Model ParseUserModel(string message)
        {
            try
            {
                // Giả sử bạn nhận được dữ liệu người dùng dưới dạng JSON hoặc chuỗi văn bản.
                string[] parts = message.Split(':');
                if (parts.Length >= 7)
                {
                    int gender;
                    bool isGenderValid = int.TryParse(parts[5], out gender);
                    DateTime dateOfBirth;
                    bool isDateValid = DateTime.TryParse(parts[3], out dateOfBirth);

                    return new User_Model
                    {
                        UserName = parts[0],
                        Password = parts[1],
                        FullName = parts[2],
                        DateOfBirth = isDateValid ? dateOfBirth : DateTime.MinValue,
                        Interests = parts[4],
                        Gender = isGenderValid ? gender : -1,
                        Location = parts[6],
                        MatchList = parts[7],
                        ImagePath = parts[8],
                        DislikeList = parts[9],

                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing user data: {ex.Message}");
            }
            return null;
        }

        // Xử lý sự kiện nhấn nút login
        private void Login_button_Click(object sender, EventArgs e)
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

                if (user != null && stream != null)
                {
                    // Gửi yêu cầu đăng nhập tới server
                    string message = $"Login:{username_t.Text}:{password_t.Text}\n";
                    byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(messageBuffer, 0, messageBuffer.Length);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Xử lý sự kiện nhấn nút hủy
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            //Application.Exit();  // Đóng ứng dụng
            this.Close();
        }

        // Xử lý sự kiện đăng ký
        private void Register_button_Click(object sender, EventArgs e)
        {
            var frm = new Register_Interface();
            this.Hide();  // Ẩn form đăng nhập
            frm.ShowDialog();  // Mở form đăng ký
        }
    }
}
