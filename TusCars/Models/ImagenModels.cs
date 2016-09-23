using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TusCars.Models
{
    public class ImagenModels
    {
        public int id { get; set; }
        public string ubicacon { get; set; }
        public AutoModel auto { get; set; }
        public int autoId { get; set; }
        public PromotorModels promotor { get; set; }
        public int promotorId { get; set; }
    }
}