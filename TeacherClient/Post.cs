﻿using System;
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
        public PostLine postline;

        public bool IsReaded = false;

        public string Title;
        public string Author;
        public string Date;
        public string Text;

        public Post(int id, int important, string title, string author, string text, string date)
        {
            Id = id;

            if (important > 5)
            {
                Importancy = 5;
            }
            else if (important < 0)
            {
                Importancy = 1;
            }
            else
            {
                Importancy = important;
            }


            Title = title;
            Author = author;
            Text = text;
            Date = date;
        }
    }
}
