using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OperacionesTI.Models
{
    public class Roturas_UN
    {
        [Key]
        public int IdUN { get; set; }
        [Required(ErrorMessage ="Ingrese unidad de negocio")]
        [Display(Name ="Unidad de negocios")]
          
        [StringLength(35, ErrorMessage ="campo con un minimo de 1 caracter y maximo de 35 caracteres", MinimumLength =1)]
        public string UnidadNegocio { get; set; }

        //relacion a roturas
        public virtual ICollection<Roturas> Roturas { get; set; }
    }
}
