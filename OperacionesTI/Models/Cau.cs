using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacionesTI.Models
{
    public class Cau
    {
        public int IdCau { get; set; }
        public string Numero { get; set; }
        public string Propietario { get; set; }
        public int Grupo { get; set; }
        public string Resumen { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
        public int Region  { get; set; }
        public int Tecnico { get; set; }

    }
}
