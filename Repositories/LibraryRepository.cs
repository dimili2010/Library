using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Repositories
{
    public class LibraryRepository: ILibraryRepository
    {
        private LibroContext _context;

        public LibraryRepository(LibroContext context)
        {
            _context = context;
        }

        public IEnumerable<Libro> GetLibros()
        {
            return _context.Libros.ToList();
        }

        public Libro GetLibroById(int id)
        {
            return _context.Libros.Include(b => b.Autor).Include(a => a.Editorial)
                 .SingleOrDefault(c => c.LibroId == id);
        }       
    }
}
