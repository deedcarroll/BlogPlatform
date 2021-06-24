using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Link { get; set; }

        public virtual List<Comment> Comments { get; set; }


        

        public Post(int id, string title, string link, string body, string author, DateTime publishDate )
        {
            Id = id;
            Title = title;
            Link = link;
            Body = body;
            Author = author;
            PublishDate = publishDate;

            

            

        }

        public Post()
        {
        }
    }
}
