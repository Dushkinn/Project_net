using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public LanguageController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var languages = await _dbContext.Languages.ToListAsync();

            return View(languages);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            Language language = new Language();
            language.ID = Guid.NewGuid();
            return View(language);
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Language language)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(language);
                }

                _dbContext.Languages.Add(language);
                await _dbContext.SaveChangesAsync();

                return RedirectToPage("/Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Edit/5
        public ActionResult Edit(Guid id)
        {
            Language language = _dbContext.Languages.Find(id);

            return View(language);
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Language language)
        {
            try
            {
                language.ID = id;
                 _dbContext.Languages.Update(language);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Delete/5
        public ActionResult Delete(Guid id)
        {

            return View(new Language { ID = id });
        }

        // POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteLanguage(Guid id)
        {
            try
            {
                Language language = new Language { ID = id};
                _dbContext.Languages.Remove(language);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Delete));
            }
        }
    }
}