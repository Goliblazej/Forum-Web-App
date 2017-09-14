using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forum.Domain.Abstract;
using Forum.Domain.Entities;

namespace Forum.WebUI.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository repository;

        public PostController(IPostRepository postRepository)
        {
            this.repository = postRepository;
        }

        public ViewResult List()
        {
            return View(repository.Posts);
        }
    }
}