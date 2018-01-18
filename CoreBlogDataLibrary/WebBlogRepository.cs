using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CoreBlogDataLibrary
{
//    public class WebBlogRepository
//    {
//        protected readonly WebBlogDbContext _dbContext;

//        public WebBlogRepository(WebBlogDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public List<Blog> ListAllBlogs()
//        {
//            return _dbContext.Blogs
//                .Include(b => b.Posts)
//                .ThenInclude(p => p.PostCategory)
//                .ToList();
//        }

//        public Blog GetBlogById(int id)
//        {
//            return _dbContext.Blogs.Find(id);
//        }

//        public Blog AddBlog(Blog newBlog)
//        {
//            _dbContext.Blogs.Add(newBlog);
//            _dbContext.SaveChanges();

//            return newBlog;
//        }

//        public void UpdateBlog(Blog changedBlog)
//        {
//            _dbContext.Entry<Blog>(changedBlog).State = EntityState.Modified;
//            _dbContext.SaveChanges();
//        }

//        public void DeleteBlog(Blog blogToDelete)
//        {
//            _dbContext.Blogs.Remove(blogToDelete);
//            _dbContext.SaveChanges();
//        }
//    }
}
