using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Imagen_Diseno
    {
        public int Imagen_DisenoID { get; set; }
        public virtual Funda_Diseno FundaDiseno { get; set; }
        public virtual Imagen Imagen { get; set; }
    }
}