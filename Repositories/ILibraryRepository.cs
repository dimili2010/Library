using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    public interface ILibraryRepository
    {
        IEnumerable<Libro> GetLibros();
        Libro GetLibroById(int id);      
    }
}
