using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
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
            TcpClient client = (TcpClient)obj;  // Sử dụng đối tượng client truyền vào, không tạo mới một TcpClient.
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[256];
            int bytesRead;
            string user = null;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string[] parts = message.Split(':');
                string request = parts[0];
                parts[2] = parts[2].Replace("\n", "");
                if (request == "Login")
                {
                    var userResponse = await fbdt.GetAsync("Users/" + parts[1]);
                    if (userResponse == null || userResponse.Body == "null")
                    {
                        BroadcastMessage("Error", client);
                        return;
                    }
                    var response = userResponse.ResultAs<User_Entity.User_Model>(); // lấy dữ liệu thông tin người dùng theo class user_model

                    if (response == null)
                    {
                        BroadcastMessage("Error username", client);
                        return;
                    }

                    // Kiểm tra mật khẩu (có thể so sánh với hàm băm hoặc mã hóa nếu có)
                    if (response.Password != response.encrypt(parts[2]))
                    {
                        BroadcastMessage("Wrong Password", client);
                        return;
                    }
                    BroadcastMessage("Success", client);
                }
            }
        }
        private void BroadcastMessage(string message, TcpClient sender)
        {
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
            richTextBox1.Invoke((MethodInvoker)delegate
            {
                richTextBox1.AppendText(message);
            });
            foreach (var client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(messageBuffer, 0, messageBuffer.Length);
            }
        }

        private void LogSever_Load(object sender, EventArgs e)
        {

        }
    }
}
