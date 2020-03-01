using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Productos_Proveedores_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult ModificarProductos(DatosProductos datosProductos)
        {
          

            return View(datosProductos);
        }

      
        [HttpPost]
        public IActionResult ModificarProductos(DatosProductos datosProductos, ProductosM productos)
        {
            
            var PosicionSelect = Request.Form["posicion"];

            foreach (var data in datosProductos.Productos)
            {
                
                if (data.ID_prod == PosicionSelect)
                {
                    ViewData["ID"] = data.ID_prod;
                    ViewData["Nombre"] = data.Nombre_prod;
                    ViewData["Descripcion"] = data.Descripcion_prod;
                    ViewData["Fecha_Venci"] = data.Fecha_Vencimiento_prod;
                    ViewData["ID_Proveedor"] = data.ID_Proveedor_prod;
                    
                    break;          
                }
            }

            var ValorBotonEdit = Request.Form["Editar"];

            if (ValorBotonEdit == "0" ) 
            {
                var IdProduct = datosProductos.datoSelectIdProduct;
                return RedirectToAction("EditarProductos", new {ProductoID = IdProduct} );
            }
            var ValorBotonEliminar = Request.Form["Eliminar"];

            if (ValorBotonEliminar == "1")
            {
                var IdProduct = datosProductos.datoSelectIdProduct;
                return RedirectToAction("EliminarProductos", new { ProductoID = IdProduct });
            }

            return View(datosProductos);
        }
        
        public IActionResult EditarProductos(DatosProductos datosProductos, string ProductoID)
        {
            foreach (var data in datosProductos.Productos)
            {

                if (data.ID_prod == ProductoID)
                {
                    ViewData["ID"] = data.ID_prod;
                    ViewData["Nombre"] = data.Nombre_prod;
                    ViewData["Descripcion"] = data.Descripcion_prod;
                    ViewData["Fecha_Venci"] = data.Fecha_Vencimiento_prod;
                    ViewData["ID_Proveedor"] = data.ID_Proveedor_prod;

                    break;
                }
            }
            ViewBag.IDProducto = ProductoID;
            return View();
        }
        public IActionResult EliminarProductos(DatosProductos datosProductos, string ProductoID)
        {
            foreach (var data in datosProductos.Productos)
            {

                if (data.ID_prod == ProductoID)
                {
                    ViewData["ID"] = data.ID_prod;
                    ViewData["Nombre"] = data.Nombre_prod;
                    ViewData["Descripcion"] = data.Descripcion_prod;
                    ViewData["Fecha_Venci"] = data.Fecha_Vencimiento_prod;
                    ViewData["ID_Proveedor"] = data.ID_Proveedor_prod;

                    break;
                }
            }
            ViewBag.IDProducto = ProductoID;
            return View();
        }
    }
}