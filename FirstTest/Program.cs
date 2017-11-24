using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите IP");
            string ip = Console.ReadLine();

            Console.WriteLine("ввдеите Порт");
            int port = int.Parse(Console.ReadLine());

            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Parse(ip), port);

            NetworkStream stream = client.GetStream();
            Console.WriteLine("Подключено");

            string lol = "Проблема с авторизацией";
            Console.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(lol)));

            //byte[] data = new byte[256];

            //do
            //{
            //    int bytes = stream.Read(data, 0, data.Length);
            //    str.Append(Encoding.ASCII.GetString(data, 0, bytes));
            //} while (stream.DataAvailable);
            bool state = true;
            string response = "";
            
            while (state)
            {
                StringBuilder str = new StringBuilder();
                Console.WriteLine("Введите что отправить");
                response = Console.ReadLine();
                if (response == "1")
                {
                    break;
                }

                if (response.Length % 2 == 0)
                {
                    StringBuilder kek = new StringBuilder();
                    kek.Append("A");
                    kek.Append(response);
                    response = kek.ToString();
                }
                else
                {
                    StringBuilder kek = new StringBuilder();
                    kek.Append("B");
                    kek.Append(response);
                    response = kek.ToString();
                }

                
                stream.Write(Encoding.ASCII.GetBytes(response), 0, Encoding.ASCII.GetBytes(response).Length);

                Thread.Sleep(500);
                byte[] data = new byte[256];

                if (stream.DataAvailable)
                {
                    do
                    {
                        int bytes = stream.Read(data, 0, data.Length);
                        str.Append(Encoding.ASCII.GetString(data, 0, bytes));
                    } while (stream.DataAvailable);
                }
                Console.WriteLine(str.ToString());
            }

            stream.Close();
            client.Close();

            Console.ReadKey();
        }
    }
}
