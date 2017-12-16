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

namespace Client
{
    public partial class PostForm : Form
    {
        MainPage MP;
        static bool Exit = true;
        static string ip = "";
        static int port = 0;
        static int id;

        public PostForm(StringBuilder tex, string tit, string Import, string Dat ,MainPage mp, string IP, int PORT, int ID)
        {
            InitializeComponent();
            MP = mp;
            Title_label.Text = tit;
            Text_TB.Text = tex.ToString();
            Important_label.Text = Import;
            Date_Label.Text = Dat;
            ip = IP;
            port = PORT;
            id = ID;
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

        private void IsRead_BTN_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(IPAddress.Parse(ip), port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes("." + id.ToString());
            stream.Write(data, 0, data.Length);
        }
    }
}