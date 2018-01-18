using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogDataLibrary
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public string Author { get; set; }

        // Navigation Property
        public List<Post> Posts { get; set; }
    }
}
