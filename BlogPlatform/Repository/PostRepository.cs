using BlogPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repository
{
    public class PostRepository : IRepository<Post>
    {
        public BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
            //contentList = new List<Content>()
            //{
            //    new Content("Title1", "body1", "Author1", 1999, "Category1"),
            //    new Content("Title2", "body2", "Author2", 1998, "Category2"),
            //    new Content("Title3", "body3", "Author3", 1997, "Category3")

            //};
        }
        public void Create(Post obj)
        {
            db.Posts.Add(obj);
            db.SaveChanges();
        }

        public void Delete(Post obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Post obj)
        {
            db.Posts.Update(obj);
            db.SaveChanges();
        }


        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetByID(int id)
        {
            return db.Posts.Where(p => p.Id == id).FirstOrDefault();
        }

        public Post GetPostById(int id)
        {
            throw new NotImplementedException();
        }


    }
}
