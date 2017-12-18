using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
	
namespace OperacionesTI.Models
{
    public class Roturas
    {
        [Key]
        public int IdRotura { get; set; }
        [Required]
        [Display(Prompt = "Nº serial")]
        [MaxLength(20)]
        public string Serial { get; set; }
        [Display(Name = "Unidad de negocio")]
        [Required]
        public int IdUn { get; set; }
        [Required]
        [Display(Name = "Bandera")]
        public int IdBandera { get; set; }
        [Required]
        [Display(Name = "Local")]
        public int IdLocal { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public int IdMarca { get; set; }
        [Required]
        [Display(Name = "Modelo")]
        public int IdModelo { get; set; }
        [Required]
        [Display(Name = "Identificación interna")]
        public string Identificacion { get; set; }
        [Required]
        [Display(Name = "Falla")]
        public int IdFalla { get; set; }
        [Required]
        [MaxLength(8)]
        public string Ticket { get; set; }
        [Required]
        [Display(Name = "Fecha envio al CD")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEnvioaCD { get; set; }
        [Display(Name = "Fecha recibido en CD")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaRecibido { get; set; }
        [Display(Name = "Fecha de reparación")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaReparado { get; set; }
        [Required]
        [Display(Name = "Estado de la reparación")]
        public int IdEstado { get; set; }
        [MaxLength(255)]
        public string Observaciones { get; set; }
        [Display(Name = "Fecha envio a Micro")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fechaenviomicro { get; set; }
        [Display(Name = "Fecha autorización de gerencia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fechaautogarencia { get; set; }
        [Display(Name = "Nº de presupuesto")]
        public string Presupuesto { get; set; }
        [Display(Name = "Valor de presupuesto")]
        public Decimal valorMyProperty { get; set; }
        [Display(Name = "Fecha recepción de Micro")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecharecemicro { get; set; }
        [Display(Name = "Aplica a capex")]
        [MaxLength(4)]
        public string Capex { get; set; }


        public virtual Roturas_UN UN { get; set; }
        public virtual Roturas_Bandera Bandera { get; set; }
        public virtual Roturas_Local Local { get; set; }
        // marca, modelo, falla, estadoreparacion


        public virtual Roturas_Estado Estado { get; set; }

        // https://docs.microsoft.com/es-es/aspnet/core/data/ef-rp/complex-data-model
    }
}
