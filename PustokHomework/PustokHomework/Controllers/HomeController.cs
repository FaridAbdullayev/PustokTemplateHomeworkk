using Microsoft.AspNetCore.Mvc;
using PustokHomework.Data;
using PustokHomework.Models;
using System.Diagnostics;

namespace PustokHomework.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            List<Slider> list = _context.Sliders.ToList();
            return View(list);
        }
    }
}
