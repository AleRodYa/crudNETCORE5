using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAspNetCore5.Models
{
    public class Libro
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(50,ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Título")]
        public string TITULO { get; set; }

        [Required(ErrorMessage = "La descripción es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción")]
        public string DESCRIPCION { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha lanzamiento")]
        public DateTime FECHA_LANZAMIENTO { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        //[StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Autor")]
        public string AUTOR { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        //[StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Precio")]
        public int PRECIO { get; set; }
    }
}
