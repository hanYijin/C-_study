﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectTest
{
    class Book
    {
        /*item.SubItems.Add(title);
                    item.SubItems.Add(author);
                    item.SubItems.Add(publisher);
                    item.SubItems.Add(description);
                    item.SubItems.Add(link);*/
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string isbn { get; set; }
        public string image  { get; set; }


        public Book(string title, string author, string publisher, string description, string link,string isbn,string image)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.description = description;
            this.link = link;
            this.isbn = isbn;
            this.image = image;
        }
    }
}
