using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacionesTI.Models
{
    public class Roturas
    {

        public int IdRotura { get; set; }
        public string Serial { get; set; }
        public int IdUn { get; set; }
        public int IdBandera { get; set; }
        public int IdLocal { get; set; }
        public int IdMarca { get; set; }
        public int IdModelo { get; set; }
        public string Identificacion { get; set; }
        public int IdFalla { get; set; }
        public string Ticket { get; set; }
        public DateTime FechaEnvioaCD { get; set; }
        public DateTime FechaRecibido { get; set; }
        public DateTime FechaReparado { get; set; }
        public int IdEstadoReparacion { get; set; }
        public string Observaciones { get; set; }
        public DateTime Fechaenviomicro { get; set; }
        public DateTime Fechaautogarencia { get; set; }
        public string Presupuesto { get; set; }
        public Decimal valorMyProperty { get; set; }
        public DateTime Fecharecemicro { get; set; }
        public string Capex { get; set; }

        //  Un, Bandera, local, marca, modelo, falla, estadoreparacion


    }
}
