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
    public partial class OnlyTitlePostButton : UserControl
    {
        Main_form main_Form;
        Post post;

        public OnlyTitlePostButton(Post post, Main_form mf)
        {
            InitializeComponent();

            main_Form = mf;
            this.post = post;


            Title.Text = post.Title;
        }

        private void Title_Click(object sender, EventArgs e)
        {
            main_Form.ShowPostPanel(post);
        }
    }
}
