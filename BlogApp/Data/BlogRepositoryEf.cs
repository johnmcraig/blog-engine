using BlogApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Data
{
    public class BlogRepositoryEf : IBlogRepository
    {
        protected readonly BloggingDbContext _dbContext;

        public BlogRepositoryEf(BloggingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Blog> ListAllBlogs()
        {
            return _dbContext.Blogs
                .Include(b => b.Posts)
                    .ThenInclude(p => p.PostCategory)
                .ToList();
        }

        public Blog GetBlogById(int id)
        {
            return _dbContext.Blogs.Find(id);
        }

        public Blog AddBlog(Blog newBlog)
        {
            _dbContext.Blogs.Add(newBlog);
            _dbContext.SaveChanges();

            return newBlog;
        }

        public void UpdateBlog(Blog changedBlog)
        {
            _dbContext.Entry<Blog>(changedBlog).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteBlog(Blog blogToDelete)
        {
            _dbContext.Blogs.Remove(blogToDelete);
            _dbContext.SaveChanges();
        }
    }
}
