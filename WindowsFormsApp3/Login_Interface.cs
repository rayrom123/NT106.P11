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
using System.IO;
using System.Web.UI.WebControls;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Login_Interface : Form
    {
        public Login_Interface()
        {
            InitializeComponent();
            StartConnection();
        }
        public string username;
        private void Register_button_Click(object sender, EventArgs e) // hiển thị form đăng ký
        {
            var frm = new Register_Interface();
            this.Hide();
            frm.ShowDialog();
        }
        public bool isSuccess = false;
        private TcpClient user;
        private NetworkStream stream;
        private void StartConnection()
        {
            try
            {
                user = new TcpClient("127.0.0.1", 8888);
                stream = user.GetStream();
                Thread listenThread = new Thread(ListenForMessages);
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
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show(message);
                    isSuccess = true;
                });
            }
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
                if (user != null && stream != null)
                {
                    string message = $"Login:{username_t.Text}:{password_t.Text}\n";
                    byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(messageBuffer, 0, messageBuffer.Length);
                }
                if (isSuccess)
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
