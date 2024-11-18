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
                //FirebaseResponse Response_Image = await client.UpdateTaskAsync("Users/" + username_t.Text, Up_Image);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }
    }
}
