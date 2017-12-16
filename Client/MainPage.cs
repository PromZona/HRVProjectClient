using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            GetPostsFromServer(); // Врубать при рабочем серваке
            //Post n = new Post("Smth", "5", "11.11.1111", "Very Important Text", panel1, this);
            //n.setControlY(PanelY);
            //PanelY += 35;
            //Post k = new Post("kek", "4", "22.11.1011", "Very Important Text", panel1, this);
            //k.setControlY(PanelY);
            //PanelY += 35;
            //Post l = new Post("Cheburek", "1", "11.16.1181", "Very Important Text", panel1, this);
            //l.setControlY(PanelY);
            //PanelY += 35;
            //Post z = new Post("Alternative", "2", "11.11.1156", "Very Important Text", panel1, this);
            //z.setControlY(PanelY);
            //PanelY += 35;
            //Post t = new Post("Stanislav", "2", "14.51.1111", "Very Important Text", panel1, this);
            //t.setControlY(PanelY);
            //PanelY += 35;
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
            byte[] data = Encoding.UTF8.GetBytes("2");
            stream.Write(data, 0, data.Length);           

            Thread.Sleep(600);

            data = new byte[1024];
            StringBuilder str = new StringBuilder();

            if (stream.DataAvailable)
            {
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    str.Append(Encoding.UTF8.GetString(data, 0, bytes));
                } while (stream.DataAvailable);
            }
            stream.Close();
            Client.Close();
            str.Append("&");
            if (str.ToString() != "")
            {
                StringBuilder cId = new StringBuilder();
                StringBuilder cTitle = new StringBuilder();
                StringBuilder cDate = new StringBuilder();
                StringBuilder cImportant = new StringBuilder();
                StringBuilder cText = new StringBuilder();
                int counter = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i].ToString() != "/" && str[i].ToString() != "&")
                    {
                        switch (counter)
                        {
                            case 0:
                                cId.Append(str[i].ToString());
                                break;
                            case 1:
                                cTitle.Append(str[i].ToString());
                                break;
                            case 2:
                                cImportant.Append(str[i].ToString());
                                break;
                            case 3:
                                cDate.Append(str[i].ToString());
                                break;
                            case 4:
                                cText.Append(str[i].ToString());
                                break;
                        }
                    }
                    else
                    {
                        if (str[i].ToString() == "/") counter++;
                        if (str[i].ToString() == "&" || i == str.Length - 1)
                        {
                            counter = 0;
                            Post newpost = new Post(Convert.ToInt32(cId.ToString()), cTitle.ToString(), cImportant.ToString(), cDate.ToString(), cText.ToString(), panel1, this, ip, port);
                            newpost.setControlY(PanelY);
                            PanelY += 35;
                            Posts.Add(newpost);                       

                            cText.Clear();
                            cTitle.Clear();
                            cDate.Clear();
                            cImportant.Clear();
                            cId.Clear();
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Странно, инофрмации нет");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FeedBack FB = new FeedBack("Аноним", ip, port, this);
            Hide();
            FB.Show();
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
        int PostId;

        public Post(int id, string Tit, string Imp, string dat, string tex, Panel pan, MainPage MP, string IP, int PORT)
        {
            PostId = id;
            Title = Tit;
            Important = Imp;
            date = dat;
            Text.Append(tex);
            Controll = new PostControll(Title, Important, date, Text,MP, IP, PORT, id);
            p = pan;
            p.Controls.Add(Controll);
        }
        public void setControlY(int y)
        {
            Controll.Location = new Point(0, y);
        }
        public string GetTitle()
        {
            return Title;
        }
    }
}