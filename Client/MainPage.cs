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
    public partial class MainPage : Form
    {
        List<Post> Posts = new List<Post>();

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            
            int y = 10;
            for (int i = 0; i < 10; i++)
            {
                Post p = new Post(y);
                p.Location = new Point(10, y);
                panel1.Controls.Add(p);
                y += 35;
            }
        }
    }
}
