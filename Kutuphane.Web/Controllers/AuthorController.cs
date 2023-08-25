using Kutuphane.Data;
using Kutuphane.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
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
    }
}
