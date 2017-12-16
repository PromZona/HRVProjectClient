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

namespace AdminClient
{
    public partial class FeedBacks : Form
    {
        int Y = 10;
        int PORT;
        string IP;
        TcpClient client;
        List<FeedBack> FeedBacksList = new List<FeedBack>();


        public FeedBacks(int port, string ip)
        {
            InitializeComponent();
            IP = ip;
            PORT = port;
        }

        private void FeedBacks_Load(object sender, EventArgs e)
        {
            client = new TcpClient();
            try
            {
                client.Connect(IPAddress.Parse(IP), PORT);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            NetworkStream stream = client.GetStream();
            byte[] data = Encoding.UTF8.GetBytes("B");
            stream.Write(data, 0, data.Length);

            Thread.Sleep(600);

            data = new byte[1024];
            StringBuilder str = new StringBuilder();

            if (stream.DataAvailable)
            {
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    str.Append(Encoding.UTF8.GetString(data, 0, bytes));
                } while (stream.DataAvailable);
            }
            stream.Close();
            client.Close();

            str.Append("&");
            if (str.ToString() != "")
            {
                StringBuilder cTitle = new StringBuilder();
                StringBuilder cText = new StringBuilder();
                int counter = 0;
                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i].ToString() != "/" && str[i].ToString() != "&")
                    {
                        switch (counter)
                        {                           
                            case 0:
                                cTitle.Append(str[i].ToString());
                                break;                          
                            case 1:
                                cText.Append(str[i].ToString());
                                break;
                        }
                    }
                    else
                    {
                        if (str[i].ToString() == "/") counter++;
                        if (str[i].ToString() == "&" || i == str.Length - 1)
                        {
                            counter = 0;
                            FeedBack newfeedback = new FeedBack(cTitle.ToString(), cText, IP, PORT, panel1);
                            newfeedback.SetControlY(Y);
                            Y += 35;
                            FeedBacksList.Add(newfeedback);

                            cText.Clear();
                            cTitle.Clear();                           
                        }
                    }

                }
            }


        }

        private void FeedBacks_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    class FeedBack
    {
        Label MyLabel;
        string Title;
        StringBuilder Text = new StringBuilder();
        string IP;
        int PORT;
        Panel p;
        
        public FeedBack(string TITLE, StringBuilder TEXT, string ip, int port, Panel panel)
        {
            MyLabel = new Label();
            MyLabel.Font = new Font("Microsoft Sans Serif", 10);
            Text = TEXT;
            Title = TITLE;
            MyLabel.Text = Title + " " + Text.ToString();
            IP = ip;
            PORT = port;
            p = panel;
            p.Controls.Add(MyLabel);
        }

        public void SetControlY(int Y)
        {
            MyLabel.Location = new Point(0, Y);
        }
    }
}
