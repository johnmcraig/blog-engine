using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBlog.Models;
using CoreBlogDataLibrary;

namespace WebBlog.Controllers
{
    public class HomeController : Controller
    {
        private static IAuthorRepository _authorRepo; /*= new AuthorRepository();*/
        private static IPostRepository _postRepository; /*= new PostRepository();*/

        public HomeController(IAuthorRepository authorRepo, IPostRepository postRepository)
        {
            _authorRepo = authorRepo;
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            return View(_postRepository.ListAllPosts());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
