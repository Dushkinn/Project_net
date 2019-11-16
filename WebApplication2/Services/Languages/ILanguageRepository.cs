using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services.Languages
{
    public interface ILanguageRepository
    {
        Task<List<Language>> getList();
        void Add(Language language);
        void Update(Language language);
        void Remove(Language language);
        Language Find(Guid id);
    }
}
