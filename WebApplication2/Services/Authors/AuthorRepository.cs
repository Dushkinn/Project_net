using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Controllers;
using WebApplication2.Models;
using WebApplication2.Services.Authors;

namespace WebApplication2.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationContext _dbContext;
        public AuthorRepository(ApplicationContext context)
        {
            _dbContext = context;
        }
        public void Add(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
        }

        public Author Find(Guid id)
        {
            return _dbContext.Authors.Find(id);
        }

        public Task<List<Author>> getList()
        {
            return _dbContext.Authors.ToListAsync(); 
        }

        public void Remove(Author author)
        {
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }

        public void Update(Author author)
        {
            _dbContext.Authors.Update(author);
            _dbContext.SaveChanges();
        }

    }
}
