using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Models.ViewModel;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public UserController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var user = _dbContext.Users.Include(c => c.Role).ToList();

            return View(user);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            var roles = _dbContext.Roles.ToList();

            ViewBag.Roles = new MultiSelectList(roles, "Role", "Name");

            return View(new UserViewModel
            {
                ID = Guid.NewGuid()
            });
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserViewModel userViewModel)
        {
            try
            {
                UserRole userRole = _dbContext.UserRoles.Find(userViewModel.selectedRole);

                User user = new User
                {
                    ID = userViewModel.ID,
                    FullName = userViewModel.FullName,
                    Password = userViewModel.Password,
                    Role = userRole
                };
                _dbContext.Users.Add(user);
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
            User user = _dbContext.Users.Where(c => c.ID == id).Include(c => c.Role).First();
            var roles = _dbContext.Roles.ToList();

            ViewBag.Roles = new MultiSelectList(roles, "Role", "Name");

            return View(new UserViewModel
            {
                ID = Guid.NewGuid(),
                FullName = user.FullName,
                Password = user.Password,
                UserRole = user.Role,
                selectedRole = user.Role.Role

            });
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Book book)
        {
            try
            {
                book.ID = id;
                _dbContext.Books.Update(book);
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

        //POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBook(Guid id)
        {
            try
            {
                Book Book = new Book { ID = id };
                _dbContext.Books.Remove(Book);
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