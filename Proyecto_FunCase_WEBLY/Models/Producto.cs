using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string ImagenFinal { get; set; }
        public double Total { get; set; }
        public int Stock { get; set; }
        public virtual Material Material { get; set; }
        public virtual Modelo Modelo { get; set; }
    }
}