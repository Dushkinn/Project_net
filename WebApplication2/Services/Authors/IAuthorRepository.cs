﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
namespace WebApplication2.Services.Authors
{
    public interface IAuthorRepository
    {
        Task<List<Author>> getList();
        void Add(Author author);
        void Update(Author author);
        void Remove(Author author);
        Author Find(Guid id);

    }


}
