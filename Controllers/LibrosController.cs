
using CrudAspNetCore5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNetCore5.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> listLibros = _context.Libro;
            return View(listLibros);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "Se guardó correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var libro = _context.Libro.Find(id);
            if (id == null || id==0 || libro == null)
            {
                return NotFound();
            }

           
            return View(libro);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "Se actualizó correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            var libro = _context.Libro.Find(id);
            if (id == null || id == 0 || libro == null)
            {
                return NotFound();
            }


            return View(libro);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteLibro(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Remove(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "Se eliminó correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}


