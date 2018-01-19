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
using System.Threading;

namespace TeacherClient
{
    public partial class Main_form : Form
    {
        TcpClient Client;
        int Port;
        string Ip;
        List<Post> Posts = new List<Post>();
        List<PostLine> PostControlls = new List<PostLine>();

        public Main_form()
        {
            InitializeComponent();

            PostControlls.Add(null); //костыль

            Ip = "158.255.152.202";
            Port = 5000;

            //GetAllPosts();
            CreateTestPosts();
            ShowAllPosts();
        }

        public void GetAllPosts()
        {
            Client = new TcpClient();
            try
            {
                Client.Connect(IPAddress.Parse(Ip), Port);
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
            if (str.ToString() != "&")
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
                            Post newpost = new Post(0, Convert.ToInt32(cImportant.ToString()), cTitle.ToString(), "Jame James", cText, cDate.ToString());
                            PostLine postLine = new PostLine(newpost, PostControlls[PostControlls.Count - 1] != null ? PostControlls[PostControlls.Count - 1].Location.Y + 50 : 50, this);

                            Posts.Add(newpost);
                            PostControlls.Add(postLine);

                            cText.Clear();
                            cTitle.Clear();
                            cDate.Clear();
                            cImportant.Clear();
                            cId.Clear();
                        }
                    }

                }
            }
        }

        public void ShowAllPosts()
        {
            foreach (PostLine p in PostControlls)
            {
                Posts_panel.Controls.Add(p);
            }

        }

        public void CreateTestPosts()
        {
            for (int i = 0; i < 10; i++)
            {
                Post newpost = new Post(0, 2, "Title", "Jame James", new StringBuilder("Important text."), "01.01.2017");
                PostLine postLine = new PostLine(newpost, PostControlls[PostControlls.Count - 1] != null ? PostControlls[PostControlls.Count - 1].Location.Y + 50 : 50, this);

                Posts.Add(newpost);
                PostControlls.Add(postLine);
            }
        }

        public void ShowPostPanel(PostLine postline)
        {
            Title_Label.Text = postline.post.Title;
            PostAuthor_Label.Text = postline.post.Author;
            PostText_TextBox.Text = postline.post.Text.ToString();

            ShowPost_Panel.Visible = true;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AllPostsShow_Button_Click(object sender, EventArgs e)
        {
            PostsFoldersChoosed_panel.Location = new Point(PostsFoldersChoosed_panel.Location.X, AllPostsShow_Button.Location.Y);
        }

        private void NewPostsShow_Button_Click(object sender, EventArgs e)
        {
            PostsFoldersChoosed_panel.Location = new Point(PostsFoldersChoosed_panel.Location.X, NewPostsShow_Button.Location.Y);
        }

        private void PostsShow_Button_Click(object sender, EventArgs e)
        {
            MenuBarChoosed_Panel.Location = new Point(MenuBarChoosed_Panel.Location.X, PostsShow_Button.Location.Y);
        }

        private void FeedBackShow_Button_Click(object sender, EventArgs e)
        {
            MenuBarChoosed_Panel.Location = new Point(MenuBarChoosed_Panel.Location.X, FeedBackShow_Button.Location.Y);
        }

        private void SettingsShow_Button_Click(object sender, EventArgs e)
        {
            MenuBarChoosed_Panel.Location = new Point(MenuBarChoosed_Panel.Location.X, SettingsShow_Button.Location.Y);
        }

        private void Title_Label_Click(object sender, EventArgs e)
        {

        }

        private void Importancy_Label_Click(object sender, EventArgs e)
        {

        }

        private void HidePostPanel_Button_Click(object sender, EventArgs e)
        {
            ShowPost_Panel.Visible = false;
        }
    }
}
