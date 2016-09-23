using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TusCars.Models
{
    public class PromotorModels
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal Longitud { get; set; }
        public decimal Latitud { get; set; }
    }
}