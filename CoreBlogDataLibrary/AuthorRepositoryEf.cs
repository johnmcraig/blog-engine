using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreBlogDataLibrary
{
     public class AuthorRepositoryEf : IAuthorRepository
    {
        private readonly WebBlogDbContext _dbContext;

        public AuthorRepositoryEf(WebBlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Author newAuthor)
        {   
            _dbContext.Authors.Add(newAuthor);
            _dbContext.SaveChanges();
            
        }

        public Author GetById(int id)
        {
            return _dbContext.Authors.Find(id);

        }

        public List<Author> List()
        {
            return _dbContext.Authors
                .ToList();
            
        }
    }
}
