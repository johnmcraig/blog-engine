using System.Collections.Generic;

namespace CoreBlogDataLibrary
{
    public interface IAuthorRepository
    {
        void Add(Author newAuthor);
        Author GetById(int id);
        List<Author> List();
    }
}