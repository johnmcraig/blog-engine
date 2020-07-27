using System.Collections.Generic;
using CoreBlogDataLibrary.Entities;

namespace CoreBlogDataLibrary.Data
{
    public interface IAuthorRepository
    {
        void Add(Author newAuthor);
        Author GetById(int id);
        List<Author> ListAllAuthors();
    }
}