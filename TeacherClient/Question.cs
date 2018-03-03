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
    public partial class Question : Form
    {
        TcpClient Client;

        Settings settings;
        Main_form main_Form;

        int port;
        string ip;

        public Question(Main_form main, int port, string ip, Settings set)
        {
            InitializeComponent();
            CenterToScreen();

            

            this.port = port;
            this.ip = ip;

            
        }

        private void SendQuestion_Button_Click(object sender, EventArgs e)
        {
            Sucess_label.Text = "Сообщение доставлено";
            Sucess_label.ForeColor = Color.Green;
            //try
            //{
            //    Client = new TcpClient(ip, port);
            //    NetworkStream stream = Client.GetStream();
            //    string response = "A" + Title_TextBox.Text + "/" + Text_TextBox.Text;
            //    byte[] data = Encoding.UTF8.GetBytes(response);
            //    stream.Write(data, 0, data.Length);

            //    Sucess_label.Text = "Сообщение доставлено";
            //    Sucess_label.ForeColor = Color.Green;
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    Sucess_label.Text = "Сбой при отправке";
            //    Sucess_label.ForeColor = Color.Red;
            //    return;
            //}
        }

        private void PostsShow_Button_Click(object sender, EventArgs e)
        {
            main_Form = new Main_form();
            main_Form.Show();
            Hide();

        }

        private void SettingsShow_Button_Click(object sender, EventArgs e)
        {
            settings = new Settings(this, main_Form);
            settings.Show();
            Hide();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logo_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void info_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuBar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
