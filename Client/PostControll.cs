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

        public PostControll(string title, string important, string date, StringBuilder tex,MainPage Main)
        {
            InitializeComponent();

            Title.Text = title;
            Important.Text = important;
            Date.Text = date;
            MP = Main;
            str = tex;
        }

        private void Post_Load(object sender, EventArgs e)
        {          
        }

        private void PostControll_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void PostControll_Click(object sender, EventArgs e)
        {
            PostForm PostOpned = new PostForm(str, Title.Text, Important.Text, Date.Text, MP);
            PostOpned.Show();
            MP.Hide();
        }
    }
}
