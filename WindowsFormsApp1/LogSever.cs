using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using User_Entity;

namespace WindowsFormsApp1
{
    public partial class LogSever : Form
    {
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kggHKAGWQR5afL75qkBb8jxrvkPRe6bfptpe16Ev",
            BasePath = "https://tinder-e074f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient fbdt = new FirebaseClient(config);

        public LogSever()
        {
            InitializeComponent();
        }

        TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isListening = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isListening)
            {
                isListening = true;
                listener = new TcpListener(IPAddress.Any, 8888);
                listener.Start();
                richTextBox1.AppendText("Server started...\n");
                Thread listenerThread = new Thread(ListenForClients);
                listenerThread.Start();
            }
        }

        private void ListenForClients()
        {
            while (isListening)
            {
                TcpClient client = listener.AcceptTcpClient();
                clients.Add(client);
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.AppendText($"Client connected: {client.Client.RemoteEndPoint}\n");
                });

                Thread clientThread = new Thread(HandleClient);
                clientThread.Start(client);
            }
        }

        private async void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[256];
            int bytesRead;
            string user = null;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string[] parts = message.Split(':');
                string request = parts[0];
                string username = parts[1];
                string password = parts[2].Replace("\n", ""); // Xử lý ký tự newline nếu có

                if (request == "Login")
                {
                    // Kiểm tra người dùng trong Firebase
                    var userResponse = await fbdt.GetAsync("Users/" + username);
                    if (userResponse.Body == "null" || userResponse.ResultAs<User_Model>() == null)
                    {
                        BroadcastMessage("User not found", client); // Người dùng không tồn tại
                        return;
                    }

                    var response = userResponse.ResultAs<User_Model>(); // Lấy thông tin người dùng từ Firebase

                    // Kiểm tra mật khẩu
                    if (response == null || response.Password != response.encrypt(password))
                    {
                        BroadcastMessage("Wrong Password", client); // Mật khẩu sai
                        return;
                    }

                    // Đăng nhập thành công
                    BroadcastMessage(userResponse.ResultAs<User_Model>(), client);
                }
            }
        }

        private void BroadcastMessage(string message, TcpClient sender)
        {
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
            richTextBox1.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText(message + "\n");
            });

            // Gửi thông điệp đến tất cả các client
            foreach (var client in clients)
            {
                if (client == sender) // Tránh gửi lại cho client gửi
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(messageBuffer, 0, messageBuffer.Length);
                }
            }
        }

        private void BroadcastMessage(User_Model user, TcpClient sender)
        {
            // Gửi thông tin người dùng đến tất cả các client
            string message = $"{user.UserName}:{user.Password}:{user.Gender}:{user.Location}:{user.MatchList}";
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);

            richTextBox1.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText(message + "\n");
            });

            foreach (var client in clients)
            {
                if (client == sender) // Tránh gửi lại cho client gửi
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(messageBuffer, 0, messageBuffer.Length);
                }
            }
        }

        private void LogSever_Load(object sender, EventArgs e)
        {
            // Mã khởi tạo khi form load
        }
    }
}
