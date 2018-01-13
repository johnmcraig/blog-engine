using System.Collections.Generic;
using BlogApp.Models;

namespace BlogApp.Data
{
    public interface IPostRepository
    {
        Post AddPost(Post newPost);
        void DeletePost(Post postToDelete);
        Post GetPostById(int id);
        List<Post> ListAllPosts();
        void UpdatePost(Post changedPost);
    }
}