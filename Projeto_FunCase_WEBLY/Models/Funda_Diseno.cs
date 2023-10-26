using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Funda_Diseno
    {
        public int Funda_DisenoID { get; set; }
        public string Imagen { get; set; }
        public double ValorNeto { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Cliente Cliente { get; set; }

    }
}