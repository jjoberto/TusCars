using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TusCars.Models
{
    public class AutoModel
    {
       
        public int id { get; set; }        
        public string Mombre { get; set; }
        [DisplayName("Año de Fabricacion")]
        public DateTime fechaCreacion { get; set; }
        public int kimlometros { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Gama { get; set; }
        public string Combustible { get; set; }
        public string Transmicion { get; set; }

        public ConcesionariaModels concesionaria { get; set; }
        public int concecionariaId { get; set; }
    }
}