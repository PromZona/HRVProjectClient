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
    public partial class Settings : Form
    {
        Question question;
        Main_form MP;

        public Settings(Question q, Main_form m)
        {
            InitializeComponent();

            
           

            CenterToScreen();
        }

        private void Addmai1_Button_Click(object sender, EventArgs e)
        {
            Adress2_label.Visible = true;
            Adress2_TB.Visible = true;
            Pass2_label.Visible = true;
            Pass2_TB.Visible = true;

            Addmai1_Button.Visible = false;
            Addmai2_Button.Visible = true;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            Sucess_label.Text = "Изменения сохранены";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionStatus_label.Text = "Не работает";
            ConnectionStatus_label.ForeColor = Color.Red;
        }

        private void Addmai2_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Альфа версия. Данный функционал пока не поддерживается");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Альфа версия. Данный функционал пока не поддерживается");
        }

        private void PostsShow_Button_Click(object sender, EventArgs e)
        {
            MP = new Main_form();
            MP.Show();
            Hide();
        }

        private void FeedBackShow_Button_Click(object sender, EventArgs e)
        {
            question = new Question(MP, 5000, "", this);
            question.Show();
            Hide();
        }
    }
}
