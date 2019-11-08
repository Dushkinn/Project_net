using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BookTypeController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public BookTypeController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var bookTypes = await _dbContext.BookTypes.ToListAsync();

            return View(bookTypes);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();  
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            BookType bookType = new BookType();
            bookType.ID = Guid.NewGuid();
            return View(bookType);
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookType bookType)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(bookType);
                }

                _dbContext.BookTypes.Add(bookType);
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
            BookType bookType = _dbContext.BookTypes.Find(id);

            return View(bookType);
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, BookType bookType)
        {
            try
            {
                bookType.ID = id;
                _dbContext.BookTypes.Update(bookType);
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

            return View(new BookType { ID = id });
        }

        // POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBookType(Guid id)
        {
            try
            {
                BookType bookType = new BookType { ID = id };
                _dbContext.BookTypes.Remove(bookType);
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