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

        private void Title_Click(object sender, EventArgs e)
        {
            PostForm PostOpned = new PostForm(str, Title.Text, Important.Text, Date.Text, MP, IP, PORT, ID);
            PostOpned.Show();
            MP.Hide();
        }

        private void Important_Click(object sender, EventArgs e)
        {
            PostForm PostOpned = new PostForm(str, Title.Text, Important.Text, Date.Text, MP, IP, PORT, ID);
            PostOpned.Show();
            MP.Hide();
        }

        private void Date_Click(object sender, EventArgs e)
        {
            PostForm PostOpned = new PostForm(str, Title.Text, Important.Text, Date.Text, MP, IP, PORT, ID);
            PostOpned.Show();
            MP.Hide();
        }


        //наведние на элемент управления
        private void PostControll_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void PostControll_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Cursor.Current = Cursors.Arrow;
        }

        private void PostControll_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }



        //Наведение на заголовок
        private void Title_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void Title_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Cursor.Current = Cursors.Arrow;
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }


        //Наведнеи на важность
        private void Important_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void Important_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Cursor.Current = Cursors.Arrow;
        }

        private void Important_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }



        //наведение на дату

        private void Date_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void Date_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            Cursor.Current = Cursors.Arrow;
        }

        private void Date_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
