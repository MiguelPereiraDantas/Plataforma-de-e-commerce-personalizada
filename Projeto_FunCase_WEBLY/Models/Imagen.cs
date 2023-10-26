using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Imagen
    {
        public int ImagenID { get; set; }
        public string NombreImagen { get; set; }
        public string ruta { get; set; }
        public virtual Designer Designer { get; set; }
    }
}