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
using System.IO;

namespace AdminClient
{
    public partial class Main : Form
    {
        static string ip = "158.255.152.202";
        static int port = 5000;
        static TcpClient Client = null;
        static bool edit_state = false;
        static int importancy = 0;

        public Main()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //StreamReader strrd = new StreamReader("IPconfig.txt");
            //ip = strrd.ReadLine();
            //port = int.Parse(strrd.ReadLine());
            //strrd.Close();
        }

        private void CreatePost_BTN_Click(object sender, EventArgs e)
        {
            //ip = IP_TB.Text;
            //port = int.Parse(Port_TB.Text);

            //if (Title_TB.Text == "" && Text_TB.Text == "" && importancy != 0)
            //{
            //    MessageBox.Show("Не все поля заполнены");
            //    return;
            //}

            //Client = new TcpClient();
            //try
            //{
            //    Client.Connect(IPAddress.Parse(ip), port);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    return;
            //}
            //NetworkStream stream = Client.GetStream();
            //DateTime dateTime = DateTime.Now;
            //string date = dateTime.Day.ToString() + "." + dateTime.Month.ToString() + "." + dateTime.Year.ToString();
            //StringBuilder str = new StringBuilder();
            //str.Append("3" + Title_TB.Text + "/" + importancy.ToString() + "/" + date + "/" + Text_TB.Text);

            //byte[] data = Encoding.UTF8.GetBytes(str.ToString());
            //stream.Write(data, 0, data.Length);

            //stream.Close();
            //Client.Close();

            Title_TextBox.Text = Title_TB.Text;
            PostText_TextBox.Text = Text_TB.Text;

            Title_TextBox.Visible = true;
            PostText_TextBox.Visible = true;

            switch (importancy)
            {
                case 1:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    break;
                case 2:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    break;

                case 3:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    break;
                case 4:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                    break;

                case 5:
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = true;
                    break;
            }

            Change_btn.Visible = true;
            label8.Visible = false;

            label7.Text = "Сообщение отправлено!";
            Text_TB.Text = "";
            Title_TB.Text = "";
            importancy = 0;
            FireImportancy1_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy2_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy3_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy4_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy5_PictureBox.Image = Image.FromFile("flame_black.png");
        }

        private void Text_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Imortant_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ip = IP_TB.Text;
            //port = int.Parse(Port_TB.Text);
            //FeedBacks FB = new FeedBacks(port, ip, this);
            //FB.Show();
            //Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FireImportancy1_PictureBox_Click(object sender, EventArgs e)
        {
            importancy = 1;
            FireImportancy1_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy2_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy3_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy4_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy5_PictureBox.Image = Image.FromFile("flame_black.png");
        }

        private void FireImportancy2_PictureBox_Click(object sender, EventArgs e)
        {
            importancy = 2;
            FireImportancy1_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy2_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy3_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy4_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy5_PictureBox.Image = Image.FromFile("flame_black.png");
        }

        private void FireImportancy3_PictureBox_Click(object sender, EventArgs e)
        {
            importancy = 3;
            FireImportancy1_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy2_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy3_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy4_PictureBox.Image = Image.FromFile("flame_black.png");
            FireImportancy5_PictureBox.Image = Image.FromFile("flame_black.png");
        }

        private void FireImportancy4_PictureBox_Click(object sender, EventArgs e)
        {
            importancy = 4;
            FireImportancy1_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy2_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy3_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy4_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy5_PictureBox.Image = Image.FromFile("flame_black.png");
        }

        private void FireImportancy5_PictureBox_Click(object sender, EventArgs e)
        {
            importancy = 5;
            FireImportancy1_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy2_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy3_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy4_PictureBox.Image = Image.FromFile("flame.png");
            FireImportancy5_PictureBox.Image = Image.FromFile("flame.png");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Title_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            if (edit_state == false)
            {
                edit_state = true;
                Change_btn.Image = Image.FromFile("save.png");

                PostText_TextBox.BackColor = Color.White;
                Title_TextBox.BackColor = Color.White;
                PostText_TextBox.ForeColor = Color.Black;
                Title_TextBox.ForeColor = Color.Black;

                PostText_TextBox.ReadOnly = false;
                Title_TextBox.ReadOnly = false;
            }
            else
            {
                edit_state = false;
                Change_btn.Image = Image.FromFile("edit.png");

                PostText_TextBox.BackColor = Color.FromArgb(46, 45, 70);
                Title_TextBox.BackColor = Color.FromArgb(46, 45, 70);
                PostText_TextBox.ForeColor = Color.White;
                Title_TextBox.ForeColor = Color.White;

                PostText_TextBox.ReadOnly = true;
                Title_TextBox.ReadOnly = true;
            }

            Change_btn.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
