using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class PostControll : UserControl
    {
        MainPage MP;
        StringBuilder str;
        string IP;
        int PORT;
        int ID;

        public PostControll(string title, string important, string date, StringBuilder tex,MainPage Main, string ip, int port, int id)
        {
            InitializeComponent();

            Title.Text = title;
            Important.Text = important;
            Date.Text = date;
            MP = Main;
            str = tex;
            IP = ip;
            PORT = port;
            ID = id;
        }

        private void Post_Load(object sender, EventArgs e)
        {          
        }

        private void PostControll_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void PostControll_Click(object sender, EventArgs e)
        {
            PostForm PostOpned = new PostForm(str, Title.Text, Important.Text, Date.Text, MP, IP, PORT, ID);
            PostOpned.Show();
            MP.Hide();
        }
    }
}
