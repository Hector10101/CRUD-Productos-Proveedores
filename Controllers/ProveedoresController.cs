using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Productos_Proveedores_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Productos_Proveedores_ASP.Controllers
{
    public class ProveedoresController : Controller
    {
        public IActionResult IndexProveedores()
        {
            return View();
        }

        public IActionResult AgregarProveedor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarProveedor(DatosProveedor datosProveedor, ProveedoresM proveedores)
        {
            if (ModelState.IsValid)
            {
                datosProveedor.Proveedores.Add(proveedores);
                return RedirectToAction("VerProveedor", proveedores);
            }
            return View(proveedores);
        }
        
        public IActionResult VerProveedor(DatosProveedor datosProveedor)
        {
            return View(datosProveedor);
        }
        

        public IActionResult ModificarProveedores()
        {

            return View();
        }

    }
}