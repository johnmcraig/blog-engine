using Microsoft.EntityFrameworkCore;
using SQLforWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLforWeb.Data
{
    public class BloggingDbContext : DbContext
    {
        public BloggingDbContext(DbContextOptions<BloggingDbContext> options)
            : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
