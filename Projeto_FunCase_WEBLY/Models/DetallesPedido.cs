using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_FunCase_WEBLY.Models
{
    public class DetallesPedido
    {
        public int DetallesPedidoID { get; set; }
        public int Cantidad { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}