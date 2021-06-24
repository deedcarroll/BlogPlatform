using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Comment
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public string Content { get; set; }

        public Comment(int id,int postId, string name, string content) 
        {
            Id = id;
            Name = name;
            PostId = postId;
            Content = content;
        }

        public Comment()
        {
        }
    }
}
