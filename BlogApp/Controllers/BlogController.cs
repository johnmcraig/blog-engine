using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data;
using BlogApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepo;

        public BlogController(IBlogRepository blogRepo)
        {
            _blogRepo = blogRepo;
        }

        // GET: Blog
        public ActionResult Index()
        {
            var blogs = _blogRepo.ListAllBlogs();
            return View(blogs);
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            var blog = _blogRepo.GetBlogById(id);
            return View(blog);
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Blog/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Blog newBlog, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _blogRepo.AddBlog(newBlog);
                    return RedirectToAction(nameof(Index));
                }

                return View(newBlog);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error saving new Blog. " + ex.Message);
                return View(newBlog);
            }
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            Blog blogToEdit = _blogRepo.GetBlogById(id);
            return View(blogToEdit);
        }

        // POST: Blog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Blog editedBlog, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _blogRepo.UpdateBlog(editedBlog);
                    return RedirectToAction(nameof(Index));
                }
                return View(editedBlog);
            }
            catch
            {
                return View(editedBlog);
            }
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_blogRepo.GetBlogById(id));
        }

        // POST: Blog/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _blogRepo.DeleteBlog(_blogRepo.GetBlogById(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}