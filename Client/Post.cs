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
    public partial class Post : UserControl
    {
        int smt = 0;
        public Post(int kek)
        {
            InitializeComponent();
            smt = kek;
        }

        private void Post_Load(object sender, EventArgs e)
        {
            Title.Text = smt.ToString();
            Important.Text = "Here";
            Date.Text = "11.11.2222";
        }
    }
}
