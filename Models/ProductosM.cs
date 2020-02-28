using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Productos_Proveedores_ASP.Models
{
    public class ProductosM
    {
        [Required(ErrorMessage = "¡El campo ID debe ser completado!")]
        public string ID_prod { get; set; }

        [Required(ErrorMessage = "¡El campo Nombre debe ser completado!")]
        [MaxLength(25, ErrorMessage = "¡Maximo 25 caracteres!")]
        public string Nombre_prod { get; set; }

        [Required(ErrorMessage = "¡El campo Descripcion debe ser completado!")]
        [MaxLength(75, ErrorMessage = "¡Maximo 75 caracteres!")]
        [MinLength(10, ErrorMessage = "¡Minimo 10 caracteres!")]
        public string Descripcion_prod { get; set; }

        [Required(ErrorMessage = "¡El campo Fecha de Vencimiento debe ser completado!")]
        public string Fecha_Vencimiento_prod { get; set; }
        public string ID_Proveedor_prod { get; set; }

    }

    public class DatosProductos
    {
        private static List<ProductosM> Producto;
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
