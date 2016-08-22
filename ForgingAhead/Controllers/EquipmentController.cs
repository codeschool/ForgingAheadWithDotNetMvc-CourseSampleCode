using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

using ForgingAhead.Models;

namespace ForgingAhead.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        public EquipmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        //Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }   
        
        //Create
        [HttpPost]
        public IActionResult Create(Equipment equipment)
        {
            _context.Equipment.Add(equipment);
            return RedirectToAction("Index");
        }
        
        //Read
        [HttpGet]
        public IActionResult Index() 
        {
            ViewData["Title"] = "Equipment";
            
            var model = _context.Equipment.ToList();
            return View(model);
        }
        
        [HttpGet]
        public IActionResult Details(string name)
        {
            ViewData["Title"] = name;
            
            var model = _context.Equipment.FirstOrDefault(e => e.Name == name);
            return View();
        }
        
        //Update
        [HttpPut]
        public IActionResult Update(Equipment equipment)
        { 
            _context.Equipment.Attach(equipment);
            _context.Entry(equipment).State = EntityState.Modified;
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        
        //Delete
        [HttpDelete]
        public IActionResult Delete(string name)
        { 
            var equipment = _context.Equipment.FirstOrDefault(e => e.Name == name);
            _context.Equipment.Remove(equipment);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}