using System.Collections.Generic;
using SQLforWeb.Models;

namespace SQLforWeb.Data
{
    public interface IBlogRepository
    {
        Blog AddBlog(Blog newBlog);
        void DeltetBlog(Blog blogToDelete);
        Blog GetBlogbyId(int id);
        List<Blog> ListAll();
        void UpdateBlog(Blog changeBlog);
    }
}