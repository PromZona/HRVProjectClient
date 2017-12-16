using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace AdminClient
{
    public partial class Main : Form
    {
        static string ip = "158.255.152.202";
        static int port = 5000;
        static TcpClient Client = null;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void CreatePost_BTN_Click(object sender, EventArgs e)
        {
            ip = IP_TB.Text;
            port = int.Parse(Port_TB.Text);

            if (Title_TB.Text == "" && Text_TB.Text == "" && Imortant_TB.Text == null)
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            Client = new TcpClient();
            try
            {
                Client.Connect(IPAddress.Parse(ip), port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            NetworkStream stream = Client.GetStream();
            DateTime dateTime = DateTime.Now;
            string date = dateTime.Day.ToString() + "." + dateTime.Month.ToString() + "." + dateTime.Year.ToString();
            StringBuilder str = new StringBuilder();
            str.Append("3" + Title_TB.Text + "/" + Imortant_TB.Text +"/"+ date+ "/" + Text_TB.Text);

            byte[] data = Encoding.UTF8.GetBytes(str.ToString());
            stream.Write(data, 0, data.Length);

            stream.Close();
            Client.Close();
        }

        private void Text_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Imortant_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ip = IP_TB.Text;
            port = int.Parse(Port_TB.Text);
            FeedBacks FB = new FeedBacks(port, ip);
            FB.Show();
            Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
