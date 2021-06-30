using BlogPlatform.Models;
using BlogPlatform.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class CommentController : Controller
    {
        public IRepository<Comment> commentRepo;
        public CommentController(IRepository<Comment> categoryRepo)
        {
            this.commentRepo = categoryRepo;
        }
       
        public ViewResult Index()
        {
            return View(commentRepo.GetAll());
        }

        public ViewResult Details(int id)
        {
            return View(commentRepo.GetByID(id));
        }

        public IActionResult Create(int id)
        {
            Post PostToComment = commentRepo.GetPostById(id);
            ViewBag.Post = PostToComment;
            return View(new Comment() { PostId = id });
        }

        [HttpPost]

        public ActionResult Create(Comment comment)
        {
            commentRepo.Create(comment);
            return RedirectToAction("Details", new { id = comment.Id });

        }

        public IActionResult Update(int id)
        {
            Comment comment = commentRepo.GetByID(id);
            return View(comment);
        }

        [HttpPost]
        public IActionResult Update(Comment comment)
        {
            commentRepo.Update(comment);
            ViewBag.ResultMessage = "Comment Updated.";
            return RedirectToAction("Details", new { id = comment.Id });
            
        }

        public IActionResult Delete(int id)
        {
            Comment comment = commentRepo.GetByID(id);
            return View(comment);
        }

        [HttpPost]
        public IActionResult Delete(Comment obj)
        {
            //Course course = courseRepo.GetByID(obj.Id);
            commentRepo.Delete(obj);

            return RedirectToAction("Index");
        }
    }
}
