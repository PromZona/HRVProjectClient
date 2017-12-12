using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class PostForm : Form
    {
        MainPage MP;
        static bool Exit = true;
        static string ip = "";
        static int port = 0;       

        public PostForm(StringBuilder tex, string tit, string Import, string Dat ,MainPage mp, string IP, int PORT)
        {
            InitializeComponent();
            MP = mp;
            Title_label.Text = tit;
            Text_TB.Text = tex.ToString();
            Important_label.Text = Import;
            Date_Label.Text = Dat;
            port = PORT;
        }

        private void PostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Exit == true)
            {
                Application.Exit();
            }
        }

        private void Back_But_Click(object sender, EventArgs e)
        {
            Exit = false;
            MP.Show();
            this.Close();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FeedBack FB = new FeedBack("Аноним", ip, port, this);
            Hide();
            FB.Show();
        }
    }
}
