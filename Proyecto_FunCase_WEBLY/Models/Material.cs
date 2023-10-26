using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Material
    {
        public int MaterialID { get; set; }
        public string Nombre { get; set; }
        public char TieneRelieve { get; set; }
        public string Color { get; set; } 
        public double Precio { get; set; }

    }
}