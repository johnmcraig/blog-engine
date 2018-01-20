using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CoreBlogDataLibrary
{
     public class PostRepositoryEf : IPostRepository
    {
        protected readonly WebBlogDbContext _dbContext;
        
        public PostRepositoryEf(WebBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Post AddPost(Post newPost)
        {
            _dbContext.Posts.Add(newPost);
            _dbContext.SaveChanges();
            return newPost;

        }

        public void DeletePost(Post postToDelete)
        {
            _dbContext.Posts.Remove(postToDelete);
            _dbContext.SaveChanges();
 
        }

        public Post GetById(int id)
        {
            return _dbContext.Posts.Find(id);

        }

        public Post GetByPermalink(string permalink)
        {
            return _dbContext.Posts.Where(p => p.Permalink == permalink)
                .FirstOrDefault();
            
        }

        //public List<Post> List()
        //{
        //    throw new NotImplementedException();
        //}

        public List<Post> ListAllPosts()
        {
            return _dbContext.Posts
              .ToList();
 
        }

        public void UpdatePost(Post updatePost)
        {
            _dbContext.Entry<Post>(updatePost).State = EntityState.Modified;
            _dbContext.SaveChanges();

        }
    }
}

