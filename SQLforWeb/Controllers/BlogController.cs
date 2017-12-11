using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLforWeb.Data;
using SQLforWeb.Models;

namespace SQLforWeb.Controllers
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
            var blogs = _blogRepo.ListAll();
            return View(blogs);
        }

        // GET: Blog/Details/5
        public ActionResult Details(int id)
        {
            var blog = _blogRepo.GetBlogbyId(id);
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
        public ActionResult Create(Blog newBlog,  IFormCollection collection)
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
                Console.WriteLine("Error saving BLog. " + ex.Message);
                return View(newBlog);
            }
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(int id)
        {
            Blog blogToEdit = _blogRepo.GetBlogbyId(id);
            return View();
        }

        // POST: Blog/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Blog editedBlog,IFormCollection collection)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    _blogRepo.UpdateBlog(editedBlog);
                    return RedirectToAction(nameof(Index));
                }
                // TODO: Add update logic here

                return View(editedBlog);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error edited Blog. " + ex.Message);
                return View(editedBlog);
            }
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_blogRepo.GetBlogbyId(id));
        }

        // POST: Blog/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {

                _blogRepo.DeltetBlog(_blogRepo.GetBlogbyId(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}