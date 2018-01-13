using System.Collections.Generic;
using BlogApp.Models;

namespace BlogApp.Data
{
    public interface IBlogRepository
    {
        Blog AddBlog(Blog newBlog);
        void DeleteBlog(Blog blogToDelete);
        Blog GetBlogById(int id);
        List<Blog> ListAllBlogs();
        void UpdateBlog(Blog changedBlog);
    }
}