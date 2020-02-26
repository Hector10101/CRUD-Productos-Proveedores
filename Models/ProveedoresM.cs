using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Productos_Proveedores_ASP.Models
{
    public class ProveedoresM
    {
        
        public string ID_prov { get; set; }
        public string Nombre_prov { get; set; }
        public string Direccion_prov { get; set; }
        public string Numero_Telefonico_prov { get; set; }

    }

    public class DatosProveedor
    {
       
        public List<ProveedoresM> Proveedor;
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
