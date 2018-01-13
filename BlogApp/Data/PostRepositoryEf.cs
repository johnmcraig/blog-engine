using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data
{
    public class PostRepositoryEf : IPostRepository
    {
        protected readonly BloggingDbContext _dbContext;

        public PostRepositoryEf(BloggingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Post> ListAllPosts()
        {
            return _dbContext.Posts
                .ToList();
        }

        public Post GetPostById(int id)
        {
            return _dbContext.Posts.Find(id);
        }

        public Post AddPost(Post newPost)
        {
            _dbContext.Posts.Add(newPost);
            _dbContext.SaveChanges();

            return newPost;
        }

        public void UpdatePost(Post changedPost)
        {
            _dbContext.Entry<Post>(changedPost).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeletePost(Post postToDelete)
        {
            _dbContext.Posts.Remove(postToDelete);
            _dbContext.SaveChanges();
        }
    }
}
