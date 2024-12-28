using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuSever : Form
    {
        public MenuSever()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ChatSever = new ChatSever();
            ChatSever.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var LogSever = new LogSever();
            LogSever.Show();
        }
    }
}
