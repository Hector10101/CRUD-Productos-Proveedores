using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Productos_Proveedores_ASP.Models
{
    public class ProveedoresM
    {
        [Required (ErrorMessage = "¡El campo ID debe ser completado!")]
        public string ID_prov { get; set; }

        [Required(ErrorMessage = "¡El campo Nombre debe ser completado!")]
        public string Nombre_prov { get; set; }

        [Required(ErrorMessage = "¡El campo Dirección debe ser completado!")]
        public string Direccion_prov { get; set; }

        [Required(ErrorMessage = "¡El campo Teléfono debe ser completado!")]  
        public string Numero_Telefonico_prov { get; set; }

    }

    public class DatosProveedor
    {
       
        private static List<ProveedoresM> Proveedor;
        public List<ProveedoresM> Proveedores
        {
            get
            {
                if (Proveedor == null)
                {
                    Proveedor = new List<ProveedoresM>();
                }
                return Proveedor;
            }
        }
    }
}
