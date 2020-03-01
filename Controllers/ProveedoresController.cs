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
        

        public IActionResult ModificarProveedores(DatosProveedor datosProveedor)
        {

            return View(datosProveedor);
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
                var IdProvee = datosProveedor.datoSelectIdProveedor;
                return RedirectToAction("EditarProveedor", new { ProveedorID = IdProvee });
            }
            var ValorBotonEliminar = Request.Form["Eliminar"];

            if (ValorBotonEliminar == "1")
            {
                var IdProvee = datosProveedor.datoSelectIdProveedor;
                return RedirectToAction("EliminarProveedor", new { ProveedorID = IdProvee });
            }

            return View(datosProveedor);
        }


        public IActionResult EditarProveedor(DatosProveedor datosProveedor, string ProveedorID)
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
            return View();
        }
        public IActionResult EliminarProveedor(DatosProveedor datosProveedor, string ProveedorID)
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

            return View();
        }
    }
}