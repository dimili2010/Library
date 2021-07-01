using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Library.Models
{
    public class Autor
    {
        [Key]
        public int AutorId { get; set; }

        [Required(ErrorMessage = "Nombre del Autor es Obligatorio")]
        [Display(Name = "Nombre del Autor:")]
        [StringLength(45)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Apellidos del Autor es Obligatorio")]
        [Display(Name = "Apellidos del Autor:")]
        [StringLength(45)]
        public string Apellidos { get; set; }

    }
}
