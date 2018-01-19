using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherClient
{
    public class Post
    {
        public int Id;
        public int Importancy;

        public bool IsReaded = false;

        public string Title;
        public string Author;
        public string Date;
        public StringBuilder Text;

        public Post(int id, int important, string title, string author, StringBuilder text, string date)
        {
            Id = id;
            Importancy = important;
            Title = title;
            Author = author;
            Text = text;
            Date = date;
        }
    }
}
