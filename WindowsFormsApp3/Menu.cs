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

namespace WindowsFormsApp3
{
    public partial class Menu : Form
    {
        public Menu()
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
                Image_View.Image = Image.FromStream(a);
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
                Image img = new Bitmap(ofd.FileName);
                Image_View.Image = img.GetThumbnailImage(195, 136, null, new IntPtr());
            }
        }

        string currentmatchlist = "";
        string currentdislikelist = "";
        string[] dislike;
        string[] matches;
        private async void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                var userResponse = await client.GetTaskAsync("Users/" + username);
                var userData = userResponse.ResultAs<User_Entity.User_Model>();
                
                username_t.Text = userData.UserName;
                fullname_t.Text = userData.FullName;
                gender_t.Text = userData.Gender == 0 ? "Male" : "Female";
                dateofbirth_t.Text = userData.DateOfBirth.ToString("dd/MM/yyyy");
                location_select.SelectedItem = userData.Location.ToString();
                interest_t.Text = userData.Interests;
                byte[] imageBytes = Convert.FromBase64String(userData.ImagePath);
                MemoryStream ms = new MemoryStream(imageBytes);
                Image_View.Image = Image.FromStream(ms);

                if (userData.MatchList != null)
                {
                    currentmatchlist = userData.MatchList;
                    string[] tempmatches = currentmatchlist.Split(',');
                    matches = new string[tempmatches.Length - 1];
                    Array.Copy(tempmatches, matches, tempmatches.Length - 1);
                }

                if (userData.DislikeList != null)
                {
                    currentdislikelist = userData.DislikeList;
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

        private List<User_Entity.User_Model> usersList;

        private int currentPos = 0;
        private async void start_Click(object sender, EventArgs e)
        {
            var userResponse = await client.GetTaskAsync("Users");

            var usersData = JsonConvert.DeserializeObject<Dictionary<string, User_Entity.User_Model>>(userResponse.Body);

            usersList = new List<User_Entity.User_Model>(usersData.Values);

            ShowUser(currentPos);
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



        private void ShowUser(int pos)
        {
            while (usersList.Count > 0 && pos < usersList.Count)
            {
                if (usersList[pos].UserName == username || checkMatch(matches, usersList[pos].UserName) == 1 || checkDis(dislike, usersList[pos].UserName) == 1)
                {
                    pos++;
                    currentPos++;
                }
                else
                {
                    name_text.Text = usersList[pos].FullName;
                    gender_text.Text = usersList[pos].Gender == 0 ? "Male" : "Female";
                    birth_text.Text = usersList[pos].DateOfBirth.ToString("dd/MM/yyyy");
                    location_text.SelectedItem = usersList[pos].Location.ToString();
                    interest_text.Text = usersList[pos].Interests;
                    byte[] imageBytes = Convert.FromBase64String(usersList[pos].ImagePath);
                    MemoryStream ms = new MemoryStream(imageBytes);
                    image_t.Image = Image.FromStream(ms);
                    break;
                }
            }

            if (pos >= usersList.Count)
            {
                MessageBox.Show("No users found.");                
            }
        }

        private async void Like_Button_Click(object sender, EventArgs e)
        {

            currentmatchlist += $"{usersList[currentPos].UserName},";

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
            }
        }




        private void location_select_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

  
        private async void Dislike_Button_Click(object sender, EventArgs e)
        {
            currentdislikelist += $"{usersList[currentPos].UserName},";

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
    }
}
