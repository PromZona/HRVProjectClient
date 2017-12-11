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

namespace Client
{
    public partial class FeedBack : Form
    {
        bool Exit = true;
        static string Teacher = "";
        static string ip = "";
        static int port = 0;
        static TcpClient Client = null;
        static Form PrForm = null;

        public FeedBack(string TeacherName, string IP, int PORT, Form CurForm)
        {
            InitializeComponent();
            ip = IP;
            port = PORT;
            Teacher = TeacherName;
            PrForm = CurForm;
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {

        }

        private void Send_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Client = new TcpClient(ip, port);
                NetworkStream stream = Client.GetStream();
                string response = "3&" + Tit_TB.Text + "/" + Text_TB.Text;
                byte[] data = Encoding.ASCII.GetBytes(response);
                stream.Write(data, 0, data.Length);
                MessageBox.Show("Сообщение доставлено");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Back_BTN_Click(object sender, EventArgs e)
        {
            Exit = false;
            PrForm.Show();
            Close();
        }

        private void FeedBack_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Exit == true)
            {
                Application.Exit();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
