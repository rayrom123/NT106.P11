using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Entity;

namespace WindowsFormsApp1
{
    public partial class ChatSever : Form
    {
        public ChatSever()
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
                listener = new TcpListener(IPAddress.Any, 8080);
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
            try
            {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string[] parts = message.Split(':');

                    string request = parts[0];
                    if (request == "Chat")
                     {
                        string senderUsername = parts[1];
                        string receiverUsername = parts[2];
                        string messageContent = parts[3];
                        richTextBox1.Invoke((MethodInvoker)delegate
                        {
                            richTextBox1.AppendText($"ChatLogs: {senderUsername} to {receiverUsername}: {messageContent}\n");
                        });
                        await SendMessageAsync(senderUsername, receiverUsername, client, messageContent);
                     }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }

        }
        public async Task SendMessageAsync(string usersend, string receiverUsername, TcpClient sender, string messageContent)
        {
            string message = $"Receive_Message:{receiverUsername}:{messageContent}";
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients)
            {
                NetworkStream stream = client.GetStream();
                stream.Write(messageBuffer, 0, messageBuffer.Length);
            }
        }
    }
}
