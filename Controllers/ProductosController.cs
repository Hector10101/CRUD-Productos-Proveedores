using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Productos_Proveedores_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Productos_Proveedores_ASP.Controllers
{
    public class ProductosController : Controller
    {
              
        public IActionResult IndexProductos()
        {
            
            return View();
        }
        public IActionResult AgregarProducto()
        {

            return View();

        }
        [HttpPost]
        public IActionResult AgregarProducto(DatosProductos datosProductos, ProductosM productos)
        {
            
            if (ModelState.IsValid)
            {   
                datosProductos.Productos.Add(productos);
                return RedirectToAction("VerProductos", productos);
            }
            
            return View(productos);
        }

        public  IActionResult VerProductos(DatosProductos datosProductos)
        {
 
            return View(datosProductos);
        }

        
        public IActionResult ModificarProductos()
        {
            return View();
        }
    }
}