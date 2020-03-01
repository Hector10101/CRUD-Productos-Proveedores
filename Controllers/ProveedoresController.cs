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
            var X = "Hola";
            if (ModelState.IsValid)
            {
                foreach (var data in datosProveedor.Proveedores)
                {
                    if (data.ID_prov == proveedores.ID_prov)
                    {
                        X = data.ID_prov;
                        break;
                    }

                }
                if (X != proveedores.ID_prov)
                {
                    datosProveedor.Proveedores.Add(proveedores);
                    return RedirectToAction("VerProveedor", proveedores);
                }
                else
                {
                    ViewData["IDInValido"] = "Este ID ya existe!";
                }
                
            }
            return View(proveedores);
        }
        
        public IActionResult VerProveedor(DatosProveedor datosProveedor)
        {
            return View(datosProveedor);
        }
        

        public IActionResult ModificarProveedores(ProveedoresM proveedoresM)
        {

            return View(proveedoresM);
        }

        [HttpPost]
        public IActionResult ModificarProveedores(DatosProveedor datosProveedor, ProveedoresM proveedoresM)
        {
            var PosicionSelect = Request.Form["Posicion"];

            foreach (var data in datosProveedor.Proveedores)
            {

                if (data.ID_prov == PosicionSelect)
                {
                    ViewData["ID"] = data.ID_prov;
                    ViewData["Nombre"] = data.Nombre_prov;
                    ViewData["Direccion"] = data.Direccion_prov;
                    ViewData["Telefono"] = data.Numero_Telefonico_prov;
                    
                    break;
                }
            }

            var ValorBotonEdit = Request.Form["Editar"];

            if (ValorBotonEdit == "0")
            {
               
                    var IdProvee = proveedoresM.ID_prov;
                    return RedirectToAction("EditarProveedor", new { ProveedorID = IdProvee });
 
                
            }
            var ValorBotonEliminar = Request.Form["Eliminar"];

            if (ValorBotonEliminar == "1")
            {
                
                var IdProvee = proveedoresM.ID_prov;
                return RedirectToAction("EliminarProveedor", new { ProveedorID = IdProvee });
            }

            return View(proveedoresM);
        }


        public IActionResult EditarProveedor(ProveedoresM proveedoresM, string ProveedorID)
        {
            DatosProveedor datosProveedor = new DatosProveedor();
            foreach (var data in datosProveedor.Proveedores)
            {

                if (data.ID_prov == ProveedorID)
                {
                    ViewData["ID"] = data.ID_prov;
                    ViewData["Nombre"] = data.Nombre_prov;
                    ViewData["Direccion"] = data.Direccion_prov;
                    ViewData["Telefono"] = data.Numero_Telefonico_prov;

                    break;
                }
            }
            ViewBag.IDProveedor = ProveedorID;

            return View(proveedoresM);
        }
        [HttpPost]
        public IActionResult EditarProveedor(ProveedoresM proveedoresM, DatosProveedor datosProveedor, string ProveedorID)
        {

            int Y = 0;

            foreach (var data in datosProveedor.Proveedores)
            {
                if (data.ID_prov == ProveedorID)
                {

                    break;
                }
                Y++;
            }
            datosProveedor.Proveedores.RemoveAt(Y);
            datosProveedor.Proveedores.Add(proveedoresM);

            return RedirectToAction("ModificarProveedores");
        }
        public IActionResult EliminarProveedor(ProveedoresM proveedoresM, DatosProveedor datosProveedor, string ProveedorID)
        {
            foreach (var data in datosProveedor.Proveedores)
            {

                if (data.ID_prov == ProveedorID)
                {
                    ViewData["ID"] = data.ID_prov;
                    ViewData["Nombre"] = data.Nombre_prov;
                    ViewData["Direccion"] = data.Direccion_prov;
                    ViewData["Telefono"] = data.Numero_Telefonico_prov;
                    break;
                }
            }
            ViewBag.IDProveedor = ProveedorID;

            return View(proveedoresM);
        }
        [HttpPost]
        public IActionResult EliminarProveedor(string ProveedorID)
        {
            DatosProveedor datosProveedor = new DatosProveedor();
            int Y = 0;
            
            foreach (var data in datosProveedor.Proveedores)
            {
                if (ProveedorID == data.ID_prov)
                {

                    break;
                }
                Y++;
            }

            datosProveedor.Proveedores.RemoveAt(Y);

            return RedirectToAction("ModificarProveedores");
        }
    }
}