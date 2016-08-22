using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using ForgingAhead.Models;

namespace ForgingAhead.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Dashboard";
            
            var model = _context.Characters.Where(e => e.IsActive == true).ToList();
            
            return View(model);
        }
    }
}