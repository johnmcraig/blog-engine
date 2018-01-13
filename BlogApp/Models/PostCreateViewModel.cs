using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class PostCreateViewModel
    {
        public PostCreateViewModel()
        {
            Blogs = new List<SelectListItem>();
            Categories = new List<SelectListItem>();
            Categories.Add(new SelectListItem { Text = "Technical Article", Value = "1" });
            Categories.Add(new SelectListItem { Text = "Science Article", Value = "2" });
            Categories.Add(new SelectListItem { Text = "Vacation Post", Value = "3" });
            Categories.Add(new SelectListItem { Text = "Humorous Post", Value = "4" });
            Categories.Add(new SelectListItem { Text = "How To Article", Value = "5" });
        }
        public Post Post { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Blogs { get; set; }
    }
}
