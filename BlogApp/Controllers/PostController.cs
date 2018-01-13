using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data;
using BlogApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepo;
        private readonly IBlogRepository _blogRepo;

        public PostController(IPostRepository postRepo,
            IBlogRepository blogRepo)
        {
            _postRepo = postRepo;
            _blogRepo = blogRepo;
        }
        // GET: Post
        public ActionResult Index()
        {
            return View(_postRepo.ListAllPosts());
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View(_postRepo.GetPostById(id));
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            PostCreateViewModel newPost = new PostCreateViewModel();

            foreach (var blog in _blogRepo.ListAllBlogs())
            {
                newPost.Blogs.Add(new SelectListItem { Text = blog.Url, Value = blog.BlogId.ToString() });
            }

            return View(newPost);
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostCreateViewModel newPost, IFormCollection collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _postRepo.AddPost(newPost.Post);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}