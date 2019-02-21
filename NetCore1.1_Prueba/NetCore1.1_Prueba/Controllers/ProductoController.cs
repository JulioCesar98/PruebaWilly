using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductoEjmplo.Models;
using ProductoEjmplo.Models.ProductoViewModels;

namespace ProductoEjmplo.Controllers
{
    [Route("productos")]
    public class ProductoController : Controller
    {
        private DataContext db = new DataContext();
        

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Listar()
        {
            ViewBag.productos = db.Productos.ToList();
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult add()
        {
            return View("Add");
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult add(Producto producto)
        {
           db.Productos.Add(producto);
            db.SaveChanges();
            return RedirectToAction("Listar");
        }


        [HttpGet]
        [Route("Eliminar/{ID}")]
        public IActionResult Eliminar(int  ID)
        {
            db.Productos.Remove(db.Productos.Find(ID));
            db.SaveChanges();
            return RedirectToAction("Listar");
        }

        [HttpGet]
        [Route("Editar/{ID}")]
        public IActionResult Editar(int ID)
        {  
            return View("Editar", db.Productos.Find(ID));
            
        }

        [HttpPost]
        [Route("Editar/{ID}")]
        public IActionResult Editar(int ID, Producto producto)
        {
            
            db.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Listar");

        }


       
    }
}