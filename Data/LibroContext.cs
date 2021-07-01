using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Data
{
    public class LibroContext : DbContext
    {
        public LibroContext(DbContextOptions<LibroContext> options) : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().HasData(
            new Autor
            {
                AutorId = 1,
                Nombre = "Gabriel",
                Apellidos = "García"               
            },
            new Autor
            {
                AutorId = 2,
                Nombre = "Jorge",
                Apellidos = "Isaac"
            },
            new Autor
            {
                AutorId = 3,
                Nombre = "Jose",
                Apellidos = "Rivera"
            }              
            );

            modelBuilder.Entity<Editorial>().HasData(
            new Editorial
            {
                EditorialId = 1,
                Nombre = "Editorial1",
                Sede = "Norte"
            },
            new Editorial
            {
                EditorialId = 2,
                Nombre = "Editorial2",
                Sede = "Sur"
            }          
            );


            modelBuilder.Entity<Libro>().HasData(
            new Libro
            {
                LibroId = 1,
                Titulo = "100 años de soledad",
                Sinapsis = "Todo comenzo...",
                NumPaginas = 1000,
                AutorId = 1,
                EditorialId = 1
            },
            new Libro
            {
                LibroId = 2,
                Titulo = "Maria",
                Sinapsis = "En Cali",
                NumPaginas = 800,
                AutorId = 2,
                EditorialId = 2
            },
            new Libro
            {
                LibroId = 3,
                Titulo = "La Voragine",
                Sinapsis = "En medio de la selva...",
                NumPaginas = 1100,
                AutorId = 3,
                EditorialId = 1
            }          
            );
        }    
    }
}
