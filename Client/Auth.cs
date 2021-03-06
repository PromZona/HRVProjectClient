﻿#define RELEASE
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    public partial class Auth : Form
    {
        static string ip = "158.255.152.202";
        static int port = 5000;
        static TcpClient Client = null;
        MainPage MP = null;

        public Auth()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void SendAuth_BTN_Click(object sender, EventArgs e)
        {
            EnterProgramm();       
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FeedBack FB = new FeedBack("Аноним", ip, port, this);
            Hide();
            FB.Show();
        }

        private void EnterProgramm()
        {
#if RELEASE
                StreamReader strrd = new StreamReader("IPconfig.txt");
                ip = strrd.ReadLine();
                port = int.Parse(strrd.ReadLine());
                strrd.Close();
#endif

            //#if DEBUG
            //            MP = new MainPage(TeacherName_TB.Text, ip, port);
            //            MP.Show();
            //            Hide();

            //#endif

            if (TeacherName_TB.Text == "") return; // Защита от дурака

            Client = new TcpClient(); // Инициализируем переменную
            Client.Connect(IPAddress.Parse(ip), port); // Делаем конект по айпи и порту
            string response = "";

            if (TeacherName_TB.Text.Trim() != "") // Если Текст Бокс пустой, то выводим предупреждение и выходим
            {
                response = TeacherName_TB.Text;
            }
            else
            {
                MessageBox.Show("Введите Фамилию Имя в специальное поле");
                return;
            }

            NetworkStream stream = Client.GetStream(); // получаем поток для передачи данных
            response = "1" + response; // Создаем запрос. Единица - команда, респонс - сам запрос
            byte[] data = Encoding.ASCII.GetBytes(response); // Переводим нашу запрос в байты чтобы отправить
            stream.Write(data, 0, data.Length); // отправляем запрос

            Thread.Sleep(500); // Ожидание овета, даем серваку разобраться

            data = new byte[32];
            StringBuilder str = new StringBuilder();

            if (stream.DataAvailable)
            {
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    str.Append(Encoding.ASCII.GetString(data, 0, bytes));
                } while (stream.DataAvailable);
            }

            stream.Close();
            Client.Close();
            if (str != null)
            {
                if (str[1].ToString() == "1")
                {
                    MP = new MainPage(TeacherName_TB.Text, ip, port);
                    MP.Show();
                    Hide();
                }
            }
        }

        private void Auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterProgramm();
            }
        }

        private void TeacherName_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterProgramm();
            }
        }
    }   
}
