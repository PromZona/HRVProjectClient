using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class MainPage : Form
    {
        List<Post> Posts = new List<Post>();
        static string ip = "";
        static int port = 0;
        static TcpClient Client = null;
        static int PanelY = 10; 

        public MainPage(string TeacherName, string serip, int serport)
        {
            InitializeComponent();
            TeacherName_LB.Text += TeacherName;
            ip = serip;
            port = serport;
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            GetPostsFromServer();
        }

        private void GetPostsFromServer()
        {
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
            byte[] data = Encoding.ASCII.GetBytes("2");
            stream.Write(data, 0, data.Length);

            Thread.Sleep(500);

            data = new byte[64];
            StringBuilder str = new StringBuilder();

            if (stream.DataAvailable)
            {
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    str.Append(Encoding.ASCII.GetString(data, 0, bytes));
                } while (stream.DataAvailable);
            }
            stream.Close();
            Client.Close();

            if (str.ToString() != "")
            {
                StringBuilder cTitle = new StringBuilder();
                StringBuilder cDate = new StringBuilder();
                StringBuilder cImportant = new StringBuilder();
                StringBuilder cText = new StringBuilder();
                int counter = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].ToString() != "/" && str[i].ToString() != "&")
                    {
                        switch (counter)
                        {
                            case 0:
                                cTitle.Append(str[i].ToString());
                                break;
                            case 1:
                                cImportant.Append(str[i].ToString());
                                break;
                            case 2:
                                cDate.Append(str[i].ToString());
                                break;
                            case 3:
                                cText.Append(str[i].ToString());
                                break;
                        }
                    }
                    else
                    {
                        if (str[i].ToString() == "/") counter++;
                        if (str[i].ToString() == "&")
                        {
                            counter = 0;
                            Post newpost = new Post(cTitle.ToString(), cImportant.ToString(), cDate.ToString(), cText.ToString(), panel1);
                            newpost.setControlY(PanelY);
                            PanelY += 35;
                            Posts.Add(newpost);

                            cText.Clear();
                            cTitle.Clear();
                            cDate.Clear();
                            cImportant.Clear();                                                                       
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Странно, Мнофрмации нет");
            }
        }
    }

    class Post
    {
        string Title;
        string Important;
        string date;
        StringBuilder Text = new StringBuilder();
        public PostControll Controll;
        Panel p;

        public Post(string Tit, string Imp, string dat, string tex, Panel pan)
        {
            Title = Tit;
            Important = Imp;
            date = dat;
            Text.Append(tex);
            Controll = new PostControll(Title, Important, date);
            p = pan;
            p.Controls.Add(Controll);
        }

        public void setControlY(int y)
        {
            Controll.Location = new Point(0, y);
        }
    }
}
