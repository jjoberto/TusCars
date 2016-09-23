using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TusCars.Models
{
    public class ConcesionariaModels
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitud { get; set; }
    }
}