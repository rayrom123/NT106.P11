using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
            StartConnection();
        }
        private TcpClient user;
        private NetworkStream stream;
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kggHKAGWQR5afL75qkBb8jxrvkPRe6bfptpe16Ev",
            BasePath = "https://tinder-e074f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client = new FirebaseClient(config);
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
        private void ListenForMessages()
        {
            byte[] buffer = new byte[256];
            int bytesRead;
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (response == "Da ton tai tai khoan")
                {
                    MessageBox.Show("Account already exists");
                    return;
                }
                else if (response == "Success")
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            MessageBox.Show("Đã thêm thành công");
                            this.Close();
                            Form login_interface = new Login_Interface();
                            login_interface.Show();
                        });
                    }
                    else
                    {
                        MessageBox.Show("Đã thêm thành công");
                        this.Close();

                        // Mở form đăng nhập
                        Form login_interface = new Login_Interface();
                        login_interface.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Can't create account");
                    return;
                }
            }
        }

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
                DateTime selectedDate = dateTimePicker1.Value;
                DateTime today = DateTime.Today;
                int age = today.Year - selectedDate.Year;

                if (selectedDate > today.AddYears(-age))
                {
                    age--;
                }

                if (age < 18)
                {
                    MessageBox.Show("Bạn phải từ 18 tuổi trở lên.");
                    return;
                }

                var new_user = new User_Entity.User_Model();
                string message = $"Register:{username_t.Text}:{genderselect.SelectedIndex}:{fullname_t.Text}:" +
                    $"{password_t.Text}:{dateTimePicker1.Value.AddDays(1).ToString("dd/MM/yyyy")}\n";

                byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                stream.Write(messageBuffer, 0, messageBuffer.Length);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form login_interface = new Login_Interface();
            login_interface.Show();
        }
    }
}
