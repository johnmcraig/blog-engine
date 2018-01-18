using CoreBlogDataLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoreBlogDataLibrary
{
    public class WebBlogDbContext : DbContext
    {
        public WebBlogDbContext(DbContextOptions<WebBlogDbContext> options)
            : base(options)
        {
                
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
