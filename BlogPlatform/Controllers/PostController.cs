using BlogPlatform.Models;
using BlogPlatform.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class PostController : Controller
    {
        public IRepository<Post> postRepo;

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }
        public ViewResult Index()
        {
            return View(postRepo.GetAll());
        }

		public ViewResult Create()
		{

			return View(new Post());

		}

		[HttpPost]
		public IActionResult Create(Post model)
		{
			postRepo.Create(model);
			return RedirectToAction("Update", new { id = model.Id });
		}

		public IActionResult Update(int id)
		{
			Post post = postRepo.GetByID(id);
			return View(post);
		}

		[HttpPost]
		public IActionResult Update(Post model)
		{
			postRepo.Update(model);
			return RedirectToAction("Index");
		}

		public ViewResult Details(int id)
		{
			return View(postRepo.GetByID(id));
		}
	}
}
