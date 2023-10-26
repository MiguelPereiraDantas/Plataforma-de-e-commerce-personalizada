using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual RegisterViewModel User { get; set; }
    }
}