using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class PostForm : Form
    {
        MainPage MP;
        static bool Exit = true;      

        public PostForm(StringBuilder tex, string tit, string Import, string Dat ,MainPage mp)
        {
            InitializeComponent();
            MP = mp;
            Title_label.Text = tit;
            Text_TB.Text = tex.ToString();
            Important_label.Text = Import;
            Date_Label.Text = Dat;
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
    }
}
