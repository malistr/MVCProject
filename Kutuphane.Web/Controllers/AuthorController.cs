using Kutuphane.Data;
using Kutuphane.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthorController(ApplicationDbContext context)
        {
            _context = context;
        }

        //globalse degısken altına alt cızgı koy
        
        public IActionResult Index()
        {
            List<Author> authorList = _context.Authors.ToList<Author>();

            return View(authorList);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
           Author authorToBedeleted = _context.Authors.Find(id);
            _context.Authors.Remove(authorToBedeleted);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            //Author authorToBedeleted = _context.Authors.Find(id);
            //_context.Authors.Remove(_context.Authors.Find(id));

            return View(_context.Authors.Find(id));


        }

        [HttpPost]
        public IActionResult Edit(Author author)
        {
            //Author authorToBedeleted = _context.Authors.Find(id);
            //_context.Authors.Remove(_context.Authors.Find(id));

            _context.Authors.Update(author);
            _context.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}
