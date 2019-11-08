using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public AuthorController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var author = await _dbContext.Authors.ToListAsync();

            return View(author);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            Author author = new Author();
            author.Id = Guid.NewGuid();
            return View(author);
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author author)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(author);
                }

                _dbContext.Authors.Add(author);
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
            Author author = _dbContext.Authors.Find(id);

            return View(author);
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Author author)
        {
            try
            {
                author.Id = id;
                _dbContext.Authors.Update(author);
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

            return View(new Author { Id = id });
        }

        // POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAuthor(Guid id)
        {
            try
            {
                Author author = new Author { Id = id };
                _dbContext.Authors.Remove(author);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
