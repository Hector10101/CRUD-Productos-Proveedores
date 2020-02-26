using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Productos_Proveedores_ASP.Models
{
    public class ProductosM
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public string ID_Proveedor { get; set; }


    }
}
