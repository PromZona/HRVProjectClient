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
using System.IO;

namespace TeacherClient
{
    public partial class Main_form : Form
    {
        Random rnd = new Random();

        Question questionForm;
        Settings settings;

        TcpClient Client;
        int Port;
        string Ip;

        string[] TestTeachers;
        string[] TestTitles;
        string[] TestTexts;

        List<Post> Posts = new List<Post>();
        List<PostLine> PostControlls = new List<PostLine>();        

        public Main_form()
        {
            InitializeComponent();

            TestTeachers = new string[]
                {
                    "Светлана Витальевна", "Олег Сергеевич", "Алекснадр Сергеевич", "Лев Николаевич", "Юля Андреевна"
                };

            TestTitles = new string[]
                {
                    "Отправить список", "Предоставить документы", "Скоро мероприятие", "Школьное собрание", "Поездка в театр", "Порядок в столовой"
                };

            TestTexts = new string[]
                {
                    "Просим предоставить актуальный спсиок учащихся 11-ых классов к четвергу.",
                    "Администрация провдит реорганизацию школьного реестра учительских данных. Просим отдать в бухгалтерию грамоты о подтверждении повышения квалификации",
                    "На носу 8 марта. Просим всех учителей подготовить к среде по одному выступлению на общее мероприятие, посвященное данному празднику. Выступление не длинее 5 минут. Обращаться к Светлане Витальевне",
                    "1 апреля пройдет школьное собрание. Просим вас подготовить отчёт об успеваемости учахищся. Огромная просьба не опаздывать!",
                    "Учителя, которые хотят посетить со своим классом театр должны: Предоставить список учащихся, Список сопровождающих и адрес театра. Просим предоставить данные документвы в 207 кабинет.",
                    "Убедительная просьба, дежурные учителя, следите за порядком в столвой более тщательно. От кухни поступают жалобы на сверх-агрессивное поведение детей в столовой."
                };


            PostControlls.Add(null); //костыль
            
            CenterToScreen();
            /*
            StreamReader strrd = new StreamReader("IPconfig.txt");
            Ip = strrd.ReadLine();
            Port = int.Parse(strrd.ReadLine());
            strrd.Close();
            */

            questionForm = new Question(this, Port, Ip, settings);
            settings = new Settings(questionForm, this);

            //GetAllPosts();
            CreateTestPosts();
            ShowAllPosts();
        }




        /*
         * 
            МОИ МЕТОДЫ!
         *   
        */



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
                            Post newpost = new Post(0, Convert.ToInt32(cImportant.ToString()), cTitle.ToString(), "Jame James", cText.ToString(), cDate.ToString());
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
            foreach (Control c in Posts_panel.Controls)
            {
                if (c is PostLine)
                {
                    Posts_panel.Controls.Remove(c);
                }
            }

            foreach (PostLine p in PostControlls)
            {
                Posts_panel.Controls.Add(p);
            }

        }

        public void ShowUnReadedPosts()
        {
            foreach(Control c in Posts_panel.Controls)
            {
                if (c is PostLine)
                {
                    Posts_panel.Controls.Remove(c);
                }
            }


            for (int i = 0; i < PostControlls.Count; i++)
            {
                if (PostControlls[i] != null)
                {
                    if (!PostControlls[i].post.IsReaded)
                    {

                        PostControlls[i].ChangeLocation(50 + i*50);

                        Posts_panel.Controls.Add(PostControlls[i]);
                    }
                }
            
            }
        }

        public void CreateTestPosts()
        {
            for (int i = 0; i < 10; i++)
            {
                int a = rnd.Next(0, TestTitles.Length);

                Post newpost = new Post(0, rnd.Next(1, 6), TestTitles[a], TestTeachers[rnd.Next(0, TestTeachers.Length)], TestTexts[a], rnd.Next(1, 31).ToString() + "."+rnd.Next(1, 12).ToString() +".2017");
                PostLine postLine = new PostLine(newpost, PostControlls[PostControlls.Count - 1] != null ? PostControlls[PostControlls.Count - 1].Location.Y + 50 : 50, this);

                Posts.Add(newpost);
                PostControlls.Add(postLine);
            }
        }

        public void ShowPostPanel(Post post)
        {
            PostTitle_label.Text = post.Title;
            PostAuthor_Label.Text = post.Author;
            PostText_TextBox.Text = post.Text.ToString();

            switch (post.Importancy)
            {
                case 1:
                    FireImportancy1_PictureBox.Visible = true;
                    FireImportancy2_PictureBox.Visible = false;
                    FireImportancy3_PictureBox.Visible = false;
                    FireImportancy4_PictureBox.Visible = false;
                    FireImportancy5_PictureBox.Visible = false;
                    break;
                case 2:
                    FireImportancy1_PictureBox.Visible = true;
                    FireImportancy2_PictureBox.Visible = true;
                    FireImportancy3_PictureBox.Visible = false;
                    FireImportancy4_PictureBox.Visible = false;
                    FireImportancy5_PictureBox.Visible = false;
                    break;

                case 3:
                    FireImportancy1_PictureBox.Visible = true;
                    FireImportancy2_PictureBox.Visible = true;
                    FireImportancy3_PictureBox.Visible = true;
                    FireImportancy4_PictureBox.Visible = false;
                    FireImportancy5_PictureBox.Visible = false;
                    break;
                case 4:
                    FireImportancy1_PictureBox.Visible = true;
                    FireImportancy2_PictureBox.Visible = true;
                    FireImportancy3_PictureBox.Visible = true;
                    FireImportancy4_PictureBox.Visible = true;
                    FireImportancy5_PictureBox.Visible = false;
                    break;

                case 5:
                    FireImportancy1_PictureBox.Visible = true;
                    FireImportancy2_PictureBox.Visible = true;
                    FireImportancy3_PictureBox.Visible = true;
                    FireImportancy4_PictureBox.Visible = true;
                    FireImportancy5_PictureBox.Visible = true;
                    break;
            }

            ShowPost_Panel.Visible = true;
        }

        /*
        public void PostDateSort(List<Post> posts)
        {
            for (int i = 0; i < posts.Count - 1; i++)
            {
                if(Convert.ToDateTime(posts[i].Date) > Convert.ToDateTime(posts[i + 1].Date) )
                {
                    Post p = posts[i];
                    posts[i] = posts[i + 1];
                    posts[i + 1] = p;
                }
            }
        }
        */ // PromZona(TODO): Поправить сортировку

        public void ChangePostPanelContent()
        {

        }



        /*
        * 
           СОБЫТИЙНЫЕ МЕТОДЫ!
        *   
       */


        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AllPostsShow_Button_Click(object sender, EventArgs e)
        {
            PostsFoldersChoosed_panel.Location = new Point(PostsFoldersChoosed_panel.Location.X, AllPostsShow_Button.Location.Y);

            ShowAllPosts();
        }

        private void NewPostsShow_Button_Click(object sender, EventArgs e)
        {
            PostsFoldersChoosed_panel.Location = new Point(PostsFoldersChoosed_panel.Location.X, NewPostsShow_Button.Location.Y);
            


            ShowUnReadedPosts();
        }

        private void PostsShow_Button_Click(object sender, EventArgs e)
        {
        }

        private void FeedBackShow_Button_Click(object sender, EventArgs e)
        {
            questionForm.Show();
            Hide();                      
        }

        private void SettingsShow_Button_Click(object sender, EventArgs e)
        {
            settings.Show();
            Hide();
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

        private void PostsOnlyTitles_Panel_VisibleChanged(object sender, EventArgs e)
        {
            List<OnlyTitlePostButton> buttons = new List<OnlyTitlePostButton>();
            

            if (PostsOnlyTitles_Panel.Visible)
            {
                //PostDateSort(Posts); // Пока хероваая сортировка


                foreach (Post p in Posts) // Вывод кнопок для смены  содержания панели с постом
                {
                    OnlyTitlePostButton btn = new OnlyTitlePostButton(p, this);
                    btn.Location = new Point(0, 100 + buttons.Count * 55 );

                    buttons.Add(btn);
                }

                foreach (OnlyTitlePostButton btn in buttons)
                {
                    PostsOnlyTitles_Panel.Controls.Add(btn);
                }
            }
            else
            {
                buttons.Clear();
            }
        }

        private void info_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PostText_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherProfile_Button_Click(object sender, EventArgs e)
        {

        }

        private void ShowPost_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuBar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
