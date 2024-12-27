using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseAdmin.Messaging;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
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
            //string user = null;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string[] parts = message.Split(':');
                
                string request = parts[0];
                
                if (request == "startMatch")
                {
                    var userResponse = await fbdt.GetAsync("Users");
                    var users = userResponse.Body;
                    var usersData = JsonConvert.DeserializeObject<Dictionary<string, User_Entity.User_Model>>(userResponse.Body);

                    List<string> usersList = new List<string>();

                    foreach (var user in usersData)
                    {
                        usersList.Add(user.Value.UserName);
                    }
                    await SendUsersListAsync(client, usersList);
                }
                else if (request == "checkMatch")
                {
                    string usernameMatch = parts[1];
                    var userResponse = await fbdt.GetAsync("Users/" + usernameMatch);

                    BroadcastMessage(userResponse.ResultAs<User_Model>(), client);
                }
                else if (request == "Login")
                {
                    string username = parts[1];
                    string password = parts[2].Replace("\n", "");
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
                else if (request == "StartChat")
                {
                    string username = parts[1];
                    // Lấy danh sách người dùng từ Firebase
                    var usersResponse = await fbdt.GetAsync($"Users/{username}/MatchList/");

                    // Lấy danh sách username từ Firebase
                    string matchListString = $"StartChat_Response:{usersResponse.Body}";
                    
                    // Gửi danh sách username đến client
                    richTextBox1.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.AppendText($"Like List of {username}: \n");
                            BroadcastMessage(matchListString, client);  // Gửi danh sách username đến client
                        });
                }
                else if (request == "Chat")
                {
                     string senderUsername = parts[1];
                     string receiverUsername = parts[2];
                     string messageContent = parts[3];

                     await SendMessageAsync(senderUsername,receiverUsername, client, messageContent);
                }
            }
        }
        public async Task SendMessageAsync(string usersend,string receiverUsername, TcpClient sender, string messageContent)
        {
            string message = $"Receive_Message:{receiverUsername}:{messageContent}";
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(messageBuffer, 0, messageBuffer.Length);
            }
        }
        
        public async Task SendUsersListAsync(TcpClient sender, List<string> usersList)
        {
            try
            {
                // Chuyển đổi danh sách thành chuỗi JSON
                var jsonString = JsonConvert.SerializeObject(usersList);

                // Chuyển đổi chuỗi JSON thành mảng byte
                byte[] byteArray = Encoding.UTF8.GetBytes(jsonString);

                foreach (var client in clients)
                {
                    if (client == sender) // Tránh gửi lại cho client gửi
                    {
                        NetworkStream stream = client.GetStream();
                        await stream.WriteAsync(byteArray, 0, byteArray.Length);
             
                    }
                }

                // Gửi mảng byte qua NetworkStream
               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi dữ liệu: {ex.Message}");
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
           string dtb = user.DateOfBirth.ToString("dd/MM/yyyy");
           string message = $"{user.UserName}:{user.Password}:{user.FullName}:{dtb}:{user.Interests}:{user.Gender}:{user.Location}:{user.MatchList}:{user.ImagePath}:{user.DislikeList}";
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
