using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Policy;
using System.Configuration;
using System.Threading;
using Newtonsoft.Json;
using static WindowsFormsApp3.Menu;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using User_Entity;
using static Google.Apis.Requests.BatchRequest;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using FirebaseAdmin.Messaging;
using Guna.UI2.WinForms;

namespace WindowsFormsApp3
{
    public partial class Menu : Form
    {
        private TcpClient userM;
        private NetworkStream streamM;
        private TcpClient userChat;
        private NetworkStream streamChat;
        private List<string> serverAddresses = new List<string> { "127.0.0.1:8080", "127.0.0.1:8081" };
        private int currentServerIndex = 0;

        
        private void StartConnection()
        {
            try
            {
                // Lấy thông tin IP và Port từ danh sách server
                string[] addressParts = serverAddresses[currentServerIndex].Split(':');
                string ip = addressParts[0];
                int port = int.Parse(addressParts[1]);

                userChat = new TcpClient(ip, port); // Kết nối đến server
                streamChat = userChat.GetStream();
                Thread listenThread = new Thread(ListenForMessages);  // Lắng nghe tin nhắn từ server
                listenThread.Start();

                // Cập nhật chỉ số server hiện tại để dùng cho lần kết nối tiếp theo
                currentServerIndex = (currentServerIndex + 1) % serverAddresses.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to server: {ex.Message}");
            }
        }

        private string Decrypt(string encryptedText, byte[] key, byte[] iv)
        {
            using (DESCryptoServiceProvider des = new
           DESCryptoServiceProvider())
            {
                des.Key = key;
                des.IV = iv;
                // Chuyển đổi dữ liệu mã hóa từ chuỗi Base64 thành mảng byte
                byte[] encryptedBytes =
               Convert.FromBase64String(encryptedText);
                //Tạo đối tượng giải mã
                using (ICryptoTransform decryptor = des.CreateDecryptor())
                {
                    // Giải mã dữ liệu
                    byte[] decryptedBytes =
                   decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                    // Chuyển đổi kết quả giải mã thành chuỗi
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }
        private void ListenForMessages()
        {
            byte[] buffer = new byte[40000];
            int bytesRead;

            while ((bytesRead = streamChat.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                string[] parts = message.Split(':');
                string request = parts[0];
                string sender = parts[1];
                string receiver = parts[2];
                string content = parts[3];

                if (request == "image")
                {
                    using (var ms = new MemoryStream())
                    {
                        int i = 1;
                        // Đọc tiếp cho đến khi không còn dữ liệu
                        while (i == 1)
                        {
                            bytesRead = streamChat.Read(buffer, 0, buffer.Length);
                            i++; // Nếu không còn dữ liệu, thoát khỏi vòng lặp
                            ms.Write(buffer, 0, bytesRead);
                        }

                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

                        Invoke(new System.Action(() =>
                        {
                            pictureBox1.Image?.Dispose(); // Giải phóng hình ảnh cũ
                            pictureBox1.Image = new Bitmap(image); // Hiển thị hình ảnh mới
                            if (username == receiver)
                                richTextBox1.Text += $"{sender}: {content}\n";
                        }));
                    }
                }

                    if (request == "chat")
                    {
                        string encrypted = content;
                        string keyText = "12345678";
                        string keyIv = "12345678";
                        byte[] key = GetKeyAndIv(keyText);
                        byte[] iv = GetKeyAndIv(keyIv);
                        // Mã hóa dữ liệu đầu vào
                        string decrypted = Decrypt(encrypted, key, iv);

                        Invoke((MethodInvoker)delegate
                        {
                            if (username == receiver)
                                richTextBox1.Text += $"{sender}: {decrypted}\n";

                        });
                    }
                }
            }
            public Menu(TcpClient user, NetworkStream stream)
            {
                InitializeComponent();
                this.userM = user;
                this.streamM = stream;
                this.Size = new Size(590, 350);
                hide_btn.Visible = false;
                label9.Visible = false;
                g_l.Visible = false;
                gender_text.Visible = false;
                usn_l.Visible = false;
                usn_text.Visible = false;
                inter_l.Visible = false;
                interest_text.Visible = false;
                birth_l.Visible = false;
                birthday_text.Visible = false;
                location_text.Visible = false;
                location_l.Visible = false;
            } 

        public string username;
        public string userreceive;
        public User_Entity.User_Model user;
        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kggHKAGWQR5afL75qkBb8jxrvkPRe6bfptpe16Ev",
            BasePath = "https://tinder-e074f-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client = new FirebaseClient(config);
        private async void Done_button_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            while (Image_View.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh ");
                return;
            }
            Image_View.Image.Save(ms, ImageFormat.Jpeg);
            byte[] data = ms.GetBuffer();

            string output = Convert.ToBase64String(data);

            if (location_select.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn địa điểm");
                return;
            }
            var updates = new
            {
                Location = location_select.SelectedItem.ToString(),
                Interests = interest_t.Text,
                ImagePath = output
            };

            try
            {
                FirebaseResponse response = await client.UpdateTaskAsync("Users/" + username, updates);

                User_Entity.User_Model result = response.ResultAs<User_Entity.User_Model>();
                MessageBox.Show("Đã thêm thành công");
                location_select.SelectedIndex = -1;
                interest_t.Clear();
                var userResponse = await client.GetTaskAsync("Users/" + username);
                var userData = userResponse.ResultAs<User_Entity.User_Model>();
                location_select.SelectedItem = userData.Location.ToString();
                interest_t.Text = userData.Interests;
                byte[] imageBytes = Convert.FromBase64String(userData.ImagePath);
                MemoryStream a = new MemoryStream(imageBytes);
                Image_View.Image = System.Drawing.Image.FromStream(a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void Select_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image Files(*.jpg) | *.jpg;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = new Bitmap(ofd.FileName);
                Image_View.Image = img.GetThumbnailImage(195, 136, null, new IntPtr());
            }
        }

        string currentmatchlist = "";
        string currentdislikelist = "";
        string[] dislike;
        string[] matches;
        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                username_t.Text = user.UserName;
                fullname_t.Text = user.FullName;
                gender_t.Text = user.Gender == 0 ? "Male" : "Female";
                dateofbirth_t.Text = user.DateOfBirth.ToString("dd/MM/yyyy");
                location_select.SelectedItem = user.Location.ToString();
                interest_t.Text = user.Interests;
                byte[] imageBytes = Convert.FromBase64String(user.ImagePath);
                MemoryStream ms = new MemoryStream(imageBytes);
                Image_View.Image = System.Drawing.Image.FromStream(ms);
                StartConnection();
                if (user.MatchList != null)
                {
                    currentmatchlist = user.MatchList;
                    string[] tempmatches = currentmatchlist.Split(',');
                    matches = new string[tempmatches.Length - 1];
                    Array.Copy(tempmatches, matches, tempmatches.Length - 1);
                }

                if (user.DislikeList != null)
                {
                    currentdislikelist = user.DislikeList;
                    string[] tempdislike = currentdislikelist.Split(',');
                    dislike = new string[tempdislike.Length - 1];
                    Array.Copy(tempdislike, dislike, tempdislike.Length - 1);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private List<string> usersList;

        private int currentPos = 0;

        private int startState = 0;

        private int endSig = 0;

        public async Task<List<string>> ReceiveUsersListAsync(NetworkStream stream)
        {
            try
            {
                byte[] buffer = new byte[100000]; // Buffer để lưu trữ dữ liệu
                int bytesRead = 0;
                StringBuilder jsonStringBuilder = new StringBuilder();

                // Đọc dữ liệu từ NetworkStream
                bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                // Chuyển đổi mảng byte thành chuỗi
                string part = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                jsonStringBuilder.Append(part);


                // Chuyển đổi chuỗi JSON thành danh sách đối tượng
                string jsonString = jsonStringBuilder.ToString();
                List<string> usersList = JsonConvert.DeserializeObject<List<string>>(jsonString);

                return usersList;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi nhận dữ liệu: {ex.Message}");
                return null;
            }
        }




        private int checkMatch(string[] matches, string username)
        {
            int i = 0;
            if (matches != null)
            {
                foreach (var match in matches)
                {
                    if (match == username)
                    {
                        i = 1;
                        break;
                    }

                }
            }

            if (i == 0)
            {
                return i;
            }
            else
            {
                return i;
            }
        }

        User_Model userMatch;

        private async void ShowUser(int pos)
        {
            while (usersList.Count > 0 && pos < usersList.Count)
            {
                if (usersList[pos] == username || checkMatch(matches, usersList[pos]) == 1 || checkDis(dislike, usersList[pos]) == 1)
                {
                    pos++;
                    currentPos++;
                }
                else
                {
                    string message = $"checkMatch:{usersList[pos]}";
                    byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                    streamM.Write(messageBuffer, 0, messageBuffer.Length);


                    byte[] buffer = new byte[12200];
                    int bytesRead;
                    bytesRead = await streamM.ReadAsync(buffer, 0, buffer.Length);

                    string yourmatch = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    string[] parts = yourmatch.Split(':');

                    int gender;
                    bool isGenderValid = int.TryParse(parts[5], out gender);


                    userMatch = new User_Model
                    {
                        UserName = parts[0],
                        Password = parts[1],
                        FullName = parts[2],
                        DateOfBirth = DateTime.Parse(parts[3]),
                        Interests = parts[4],
                        Gender = isGenderValid ? gender : -1,
                        Location = parts[6],
                        MatchList = parts[7],
                        ImagePath = parts[8],
                        DislikeList = parts[9],

                    };
                    DateTime dateOfBirth = userMatch.DateOfBirth;
                    DateTime today = DateTime.Today;
                    int age = today.Year - dateOfBirth.Year;

                    if (dateOfBirth > today.AddYears(-age))
                    {
                        age--;
                    }
                    label7.Text = userMatch.FullName + "  " + age.ToString();
                    gender_text.Text = userMatch.Gender == 0 ? "Male" : "Female";
                    usn_text.Text = userMatch.FullName;
                    birthday_text.Text = userMatch.DateOfBirth.ToString("dd/MM/yyyy");
                    location_text.Text = userMatch.Location.ToString();
                    interest_text.Text = userMatch.Interests;
                    byte[] imageBytes = Convert.FromBase64String(userMatch.ImagePath);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    image_t.Image = System.Drawing.Image.FromStream(ms);
                    break;
                }
            }

            if (pos >= usersList.Count)
            {
                MessageBox.Show("No users found.");
                endSig = 1;
            }
        }


        private int checkDis(string[] dis, string username)
        {
            int i = 0;
            if (dis != null)
            {
                foreach (var di in dis)
                {
                    if (di == username)
                    {
                        i = 1;
                        break;
                    }

                }
            }

            if (i == 0)
            {
                return i;
            }
            else
            {
                return i;
            }
        }


        private void show_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(590, 290);
            show_btn.Visible = false;
            hide_btn.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Height = 350;
            label9.Visible = true;
            g_l.Visible = true;
            gender_text.Visible = true;
            usn_l.Visible = true;
            usn_text.Visible = true;
            inter_l.Visible = true;
            interest_text.Visible = true;
            birth_l.Visible = true;
            birthday_text.Visible = true;
            location_text.Visible = true;
            location_l.Visible = true;
            guna2Transition1.ShowSync(guna2Panel1);


        }

        private void hide_btn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(590, 350);
            hide_btn.Visible = false;
            show_btn.Visible = true;
            guna2Panel1.Visible = false;
            label9.Visible = false;
            g_l.Visible = false;
            gender_text.Visible = false;
            usn_l.Visible = false;
            usn_text.Visible = false;
            inter_l.Visible = false;
            interest_text.Visible = false;
            birth_l.Visible = false;
            birthday_text.Visible = false;
            location_text.Visible = false;
            location_l.Visible = false;
            guna2Panel1.Height = 1;
            guna2Transition1.ShowSync(guna2Panel1);
        }

        private async void checkChat(string[] names, string[] chatnames)
        {
            int i = 0;
            foreach (var name in names)
            {
                string message = $"StartChat:{name}";
                byte[] messagebuffer = Encoding.UTF8.GetBytes(message);
                streamM.Write(messagebuffer, 0, messagebuffer.Length);

                byte[] buffer = new byte[256];
                int bytesRead;
                bytesRead = await streamM.ReadAsync(buffer, 0, buffer.Length);

                // Chuỗi đầu vào
                string yourmatch = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                // Tìm vị trí của dấu hai chấm và dấu ngoặc kép
                int startIndex = yourmatch.IndexOf(':') + 2; // +2 để bỏ qua dấu cách sau dấu hai chấm
                int endIndex = yourmatch.LastIndexOf('"');


                string namesPart = yourmatch.Substring(startIndex, endIndex - startIndex);




                string[] arr = namesPart.Split(',');

                foreach (var a in arr)
                {
                    if (a == username)
                    {
                        chatnames[i] = a;
                        i++;
                        break;
                    }

                }
            }
        }

        private async void button2_Click(object sender, EventArgs e) // search for matchlist button
        {
            try
            {
                string[] names = currentmatchlist.Split(',');
                string[] chatnames = new string[100];
                int i = 0;
                foreach (var name in names)
                {
                    if (!string.IsNullOrEmpty(name))
                    {
                        string message = $"StartChat:{name}";
                        byte[] messagebuffer = Encoding.UTF8.GetBytes(message);
                        streamM.Write(messagebuffer, 0, messagebuffer.Length);

                        byte[] buffer = new byte[256];
                        int bytesRead;
                        bytesRead = await streamM.ReadAsync(buffer, 0, buffer.Length);
                        // Chuỗi đầu vào
                        string yourmatch = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        // Tìm vị trí của dấu hai chấm và dấu ngoặc kép


                        string[] arr = yourmatch.Split(',');

                        foreach (var a in arr)
                        {
                            if (a == username)
                            {
                                chatnames[i] = name;
                                i++;
                                break;
                            }
                        }
                    }
                }
                comboBox1.Items.Clear(); // Xóa các mục cũ (nếu có)
                var validChatNames = chatnames.Take(i).Where(name => !string.IsNullOrEmpty(name)).ToArray();
                if (validChatNames.Length == 0)
                {
                    MessageBox.Show("You don't have anyone matching you");
                }
                else
                {
                    comboBox1.Items.AddRange(validChatNames); // Thêm các tên vào ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string Encrypt(string plainText, byte[] key, byte[] iv)
        {
            using (DESCryptoServiceProvider des = new
           DESCryptoServiceProvider())
            {
                // Thiết lập khóa cho DES
                des.Key = key;
                // Thiết lập IV cho DES
                des.IV = iv;
                // Chuyển đổi dữ liệu đầu vào thành mảng byte
                byte[] inputBytes = Encoding.UTF8.GetBytes(plainText);
                // Tạo đối tượng mã hpas
                using (ICryptoTransform encryptor = des.CreateEncryptor())
                {
                    // Mã hóa dữ liệu
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                    // Chuyển đổi kết quả mã hóa thành chuỗi Base64
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        private byte[] GetKeyAndIv(string keyText)
        {
            if (keyText.Length != 8)
            {
                return null; // Đảm bảo khóa có độ dài 8 ký tự
            }
            // Chuyển đổi chuỗi thành mảng byte
            return Encoding.UTF8.GetBytes(keyText);
        }

        string heartEmoji = "\u2764";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBox1.Text;

                string keyText = "12345678";
                string keyIv = "12345678";
                byte[] key = GetKeyAndIv(keyText);
                byte[] iv = GetKeyAndIv(keyIv);

                string encrypted = Encrypt(text, key, iv);
                // Hiển thị kết quả mã hóa

                if (string.IsNullOrEmpty(userreceive))
                {
                    MessageBox.Show("Please choose someone to chat");
                }
                else
                {
                    string message = $"Chat:{username}:{userreceive}:{encrypted}";
                    richTextBox1.Text += $"Me: {text}\n";
                    byte[] messagebuffer = Encoding.UTF8.GetBytes(message);
                    streamChat.Write(messagebuffer, 0, messagebuffer.Length);
                    textBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                StartConnection();
            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userreceive = comboBox1.SelectedItem.ToString();
            var userResponse = await client.GetTaskAsync($"Users/{userreceive}");
            var userData = userResponse.ResultAs<User_Entity.User_Model>();
            var img = userData.ImagePath;
            byte[] imageBytes = Convert.FromBase64String(img);
            MemoryStream ms = new MemoryStream(imageBytes);
            chat_image.Image = System.Drawing.Image.FromStream(ms);
            richTextBox1.Clear();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async void like_Click(object sender, EventArgs e)
        {
            if (startState == 1 && endSig == 0)
            {


                currentmatchlist += $"{userMatch.UserName},";

                var update = new
                {
                    MatchList = currentmatchlist
                };

                FirebaseResponse response = await client.UpdateTaskAsync("Users/" + username, update);

                if (currentPos < usersList.Count - 1)
                {
                    currentPos++;
                    ShowUser(currentPos);
                }
                else
                {
                    MessageBox.Show("This is the last user.");
                    endSig = 1;
                }
            }
            else if (endSig == 0)
            {
                MessageBox.Show("please start first.");
            }
            else
            {
                MessageBox.Show("This is the last user.");
            }
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if (startState == 1 && endSig == 0)
            {
                currentdislikelist += $"{userMatch.UserName},";

                var up = new
                {
                    DislikeList = currentdislikelist
                };

                FirebaseResponse res = await client.UpdateTaskAsync("Users/" + username, up);

                if (currentPos < usersList.Count - 1)
                {
                    currentPos++;
                    ShowUser(currentPos);
                }
                else
                {
                    MessageBox.Show("This is the last user.");
                    endSig = 1;
                }
            }
            else if (endSig == 0)
            {
                MessageBox.Show("please start first.");
            }
            else
            {
                MessageBox.Show("This is the last user.");
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (startState == 0)
            {
                string message = $"startMatch";
                byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
                streamM.Write(messageBuffer, 0, messageBuffer.Length);

                startState = 1;

                usersList = await ReceiveUsersListAsync(streamM);

                ShowUser(currentPos);
            }
            else
            {
                MessageBox.Show("Already started.");
            }
        }

        private string imagePath;

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                string message = $"image:{username}:{userreceive}:{imagePath}";
                richTextBox1.Text += $"Me: {imagePath}\n";
                byte[] messagebuffer = Encoding.UTF8.GetBytes(message);
                streamChat.Write(messagebuffer, 0, messagebuffer.Length);

                // Gửi hình ảnh
                byte[] imageBuffer = new byte[40960];
                int bytesRead;
                while ((bytesRead = fs.Read(imageBuffer, 0, imageBuffer.Length)) > 0)
                {
                    streamChat.Write(imageBuffer, 0, bytesRead);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button5, 0, button5.Height);
        }

        private void Smileys_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text += e.ClickedItem.Text;
        }

        private void Animals_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text += e.ClickedItem.Text;
        }

        private void Food_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text += e.ClickedItem.Text;
        }

        private void Symbols_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            textBox1.Text += e.ClickedItem.Text;
        }
    }
}
