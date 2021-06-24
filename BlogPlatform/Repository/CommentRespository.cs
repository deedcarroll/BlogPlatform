
using BlogPlatform.Repository;
using BlogPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repository
{
    public class CommentRepository : IRepository<Comment>
    {
        public BlogContext db;
                      
        public CommentRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Comment> GetAll()
        {
            return db.Comments.ToList();
        }

        public Comment GetByID(int id)
        {
            return db.Comments.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Create(Comment obj)
        {
            db.Comments.Add(obj);
            db.SaveChanges();
        }

        public void Update(Comment obj)
        {
            db.Comments.Update(obj);
            db.SaveChanges();
        }

        public void Delete(Comment obj)
        {
            db.Comments.Remove(obj);
            db.SaveChanges();
        }

        public Post GetPostById(int id)
        {
            return db.Posts.Find(id);
        }

       
    }
}
