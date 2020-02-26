using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Productos_Proveedores_ASP.Models
{
    public class ProductosM
    {
        public string ID_prod { get; set; }
        public string Nombre_prod { get; set; }
        public string Descripcion_prod { get; set; }
        public string Fecha_Vencimiento_prod { get; set; }
        public string ID_Proveedor_prod { get; set; }

    }

    public class DatosProductos
    {
        public List<ProductosM> Producto;
        public List<ProductosM> Productos
        {
            get
            {
                if (Producto == null)
                {
                    Producto = new List<ProductosM>();
                }
                return Producto;
            }
        }
    }
}
