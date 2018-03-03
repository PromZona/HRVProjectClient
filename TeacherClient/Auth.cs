using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherClient
{
    public partial class Auth : Form
    {
        Main_form MP = null;

        public Auth()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            MP = new Main_form();
            Hide();
            MP.Show();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pswrd_TB_TextChanged(object sender, EventArgs e)
        {          
        }
    }
}
