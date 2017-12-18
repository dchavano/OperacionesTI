using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OperacionesTI.Models
{
    public class Roturas_Estado
    {

        [Key]
        public int IdEstado { get; set; }
        [StringLength(35, ErrorMessage = "campo con un minimo de 1 caracter y maximo de 35 caracteres", MinimumLength = 1)]
        [Required]
        public string Estado { get; set; }


        public virtual ICollection<Roturas> Roturas { get; set; }


    }
}
