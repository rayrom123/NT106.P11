using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using User_Entity;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Details_Interface : Form
    {
        public Details_Interface(string dataToSend)
        {
            InitializeComponent();
            username_t.Text = dataToSend;
        }

        public string Username;

        public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kggHKAGWQR5afL75qkBb8jxrvkPRe6bfptpe16Ev",
            BasePath = "https://tinder-e074f-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client = new FirebaseClient(config);

        private async void Done_button_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            Image_View.Image.Save(ms, ImageFormat.Jpeg);
            byte[] data = ms.GetBuffer();

            string output = Convert.ToBase64String(data);

            if (location_select.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn địa điểm");
                return;
            }

            if (Image_View.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh ");
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
                FirebaseResponse response = await client.UpdateTaskAsync("Users/" + username_t.Text, updates);
                //FirebaseResponse Response_Image = await client.UpdateTaskAsync("Users/" + username_t.Text, Up_Image);
                User_Entity.User_Model result = response.ResultAs<User_Entity.User_Model>();
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private async void Details_Interface_Load(object sender, EventArgs e)
        {
            try
            {
                var userResponse = await client.GetTaskAsync("Users/" + username_t.Text);
                var userData = userResponse.ResultAs<User_Entity.User_Model>();
                fullname_t.Text = userData.FullName;
                gender_t.Text = userData.Gender == 0 ? "Male" : "Female";
                dateofbirth_t.Text = userData.DateOfBirth.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form login_interface = new Login_Interface();
            login_interface.Show();
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

       
    }
}
