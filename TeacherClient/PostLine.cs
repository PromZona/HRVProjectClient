using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherClient
{
    public partial class PostLine : UserControl
    {
        public Post post;
        int yPosition;
        Main_form mainform;

        public PostLine(Post nPost, int ypos, Main_form main)
        {
            InitializeComponent();

            yPosition = ypos;
            post = nPost;
            mainform = main;

            Titile_label.Text = nPost.Title;
            Date_Label.Text = nPost.Date;
            PostAuthor_Label.Text = nPost.Author;

            Location = new Point(145, yPosition);
        }

        public void OpenPost()
        {
            mainform.ShowPostPanel(this);
        }

        private void PostOpen_Button_Click(object sender, EventArgs e)
        {
            OpenPost();
        }

        private void PostOpen_Button_MouseEnter(object sender, EventArgs e)
        {
            PostAuthor_Label.BackColor = Color.FromArgb(71, 70, 106);
            Titile_label.BackColor = Color.FromArgb(71, 70, 106);
            Date_Label.BackColor = Color.FromArgb(71, 70, 106);

            FireImportancy1_PictureBox.BackColor = Color.FromArgb(71, 70, 106);
            FireImportancy2_PictureBox.BackColor = Color.FromArgb(71, 70, 106);
            FireImportancy3_PictureBox.BackColor = Color.FromArgb(71, 70, 106);
            FireImportancy4_PictureBox.BackColor = Color.FromArgb(71, 70, 106);
            FireImportancy5_PictureBox.BackColor = Color.FromArgb(71, 70, 106);
        }

        private void PostOpen_Button_MouseLeave(object sender, EventArgs e)
        {
            PostAuthor_Label.BackColor = Color.FromArgb(61, 60, 89);
            Titile_label.BackColor = Color.FromArgb(61, 60, 89);
            Date_Label.BackColor = Color.FromArgb(61, 60, 89);

            FireImportancy1_PictureBox.BackColor = Color.FromArgb(61, 60, 89);
            FireImportancy2_PictureBox.BackColor = Color.FromArgb(61, 60, 89);
            FireImportancy3_PictureBox.BackColor = Color.FromArgb(61, 60, 89);
            FireImportancy4_PictureBox.BackColor = Color.FromArgb(61, 60, 89);
            FireImportancy5_PictureBox.BackColor = Color.FromArgb(61, 60, 89);
        }

        private void PostAuthor_Label_Click(object sender, EventArgs e)
        {
            OpenPost();
        }

        private void Titile_label_Click(object sender, EventArgs e)
        {
            OpenPost();
        }

        private void Date_Label_Click(object sender, EventArgs e)
        {
            OpenPost();
        }
    }
}
