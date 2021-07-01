using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Libro
    {
        [Key]
        public int LibroId { get; set; }

        [Required(ErrorMessage = "Título del libro es Obligatorio")]
        [Display(Name = "Título del libro:")]
        [StringLength(50)]
        public string Titulo { get; set; }
       
        [Required(ErrorMessage = "Sinapsis es Obligatorio")]
        [Display(Name = "Sinapsis del libro:")]
        public string Sinapsis { get; set; }

        [Required(ErrorMessage = "Número de páginas es Obligatorio")]
        [Display(Name = "Número de páginas:")]
        public int NumPaginas { get; set; }

        [Required(ErrorMessage = "Por favor seleccione un Autor")]
        public int? AutorId { get; set; }
        public virtual Autor Autor { get; set; }


        [Required(ErrorMessage = "Por favor seleccione una Editorial")]
        public int? EditorialId { get; set; }
        public virtual Editorial Editorial { get; set; }
    }
}
