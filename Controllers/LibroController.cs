using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using Library.Repositories;
using Microsoft.AspNetCore.Hosting;

namespace Library.Controllers
{
    public class LibroController : Controller
    {
        private ILibraryRepository _repository;
        private IHostingEnvironment _environment;

        public LibroController(ILibraryRepository repository, IHostingEnvironment environment)
        {
            _repository = repository;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View(_repository.GetLibros());
        }

        public IActionResult Details(int id)
        {
            var libro = _repository.GetLibroById(id);
            if (libro == null)
            {
                return NotFound();
            }
            return View(libro);
        }
    }
}