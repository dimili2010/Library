using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Editorial
    {
        [Key]
        public int EditorialId { get; set; }

        [Required(ErrorMessage = "Nombre de la Editorial es Obligatorio")]
        [Display(Name = "Nombre de la Editorial:")]
        [StringLength(45)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Sede es Obligatorio")]
        [Display(Name = "Sede de la Editorial:")]
        [StringLength(45)]
        public string Sede { get; set; }            
    }
}
