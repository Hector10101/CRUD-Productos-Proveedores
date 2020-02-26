using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Productos_Proveedores_ASP.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult IndexProductos()
        {
            return View();
        }
    }
}