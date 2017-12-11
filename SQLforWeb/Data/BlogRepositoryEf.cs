using SQLforWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLforWeb.Data
{
    public class BlogRepositoryEf : IBlogRepository
    {
        protected readonly BloggingDbContext _dbContext;

        public BlogRepositoryEf(BloggingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Blog> ListAll()
        {
            return _dbContext.Blogs
                .ToList();
        }

        public Blog GetBlogbyId(int id)
        {
            return _dbContext.Blogs.Find(id);
        }

        public Blog AddBlog(Blog newBlog)
        {
            _dbContext.Blogs.Add(newBlog);
            _dbContext.SaveChanges();

            return newBlog;
        }

        public void UpdateBlog(Blog changeBlog)
        {
            _dbContext.Entry<Blog>(changeBlog).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeltetBlog(Blog blogToDelete)
        {
            _dbContext.Blogs.Remove(blogToDelete);
            _dbContext.SaveChanges();
        }
    }
}
