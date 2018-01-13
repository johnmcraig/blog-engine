using BlogApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data
{
    public class BloggingDbContext : DbContext
    {
        public BloggingDbContext(DbContextOptions<BloggingDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        // TODO: Wire it up so we can pull back posts and blogs together more easily.



    }
}
