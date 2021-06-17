using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Content
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public int PublishDate { get; set; }
        public string Category { get; set; }

        public Content(string title, string body, string author, int publishDate, string category)
        {
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
            Category = category;
        }

        public Content()
        {
        }
    }
}
