using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Modelo
    {
        public int ModeloID { get; set; }
        public string Nombre { get; set; }
        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double Grosor { get; set; }
        public string ImagenReferencia { get; set; }
        public virtual Marca Marca { get; set; }

    }
}