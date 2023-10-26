using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Designer
    {
        public int DesignerID { get; set; }
        public string nombrePresentacion { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual RegisterViewModel User { get; set; }
    }
}