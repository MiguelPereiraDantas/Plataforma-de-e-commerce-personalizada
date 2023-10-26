using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Direccion
    {
        public int DireccionID { get; set; }
        public string Calle { get; set; }
        public string NumeroExt { get; set; }
        public string NumeroInt { get; set; }
        public string Colonia { get; set; }
        public string CodigoPosta { get; set; }
        public char esDireccionEnvio { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Estado Estado { get; set; }
    }
}