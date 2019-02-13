using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FarmaciaLab1.Models;
using FarmaciaLab1.Helpers;
using lEstructurasLineales;
namespace FarmaciaLab1.Controllers
{
    public class AlmacenamientoEmpleadosController : Controller
    {
        // GET: Empleados
        public ActionResult Index()
        {
            return View(Datos.Instance.ListaEmpleados);
        }
        public  ActionResult PrincipalM()
        {
            return View();
        }

        public ActionResult MenuBuscar()
        {
            return View();
        }
        public ActionResult Buscador(string SerchString)
        {
            Datos.Instance.ListaEmpleados.Where(i => i.sNombre.ToString() == SerchString);
            return View(Datos.Instance.ListaEmpleados.OrderBy(it => it.sNombre));
        }
        //public async cEmpleado<IActionResult> Index(string searchString)
        //{
        //    var movies = from m in _context.Movie
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        movies = movies.Where(s => s.Title.Contains(searchString));
        //    }

        //    return View(await movies.ToListAsync());
        //}
        // GET: Empleados/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var EmpleadoActual = new cEmpleado
                {
                    iCodigo = int.Parse(collection["iCodigo"]),
                    sNombre = collection["sNombre"],
                    dHorasTrabajadas = double.Parse(collection["dHorasTrabajadas"]),
                    sEnOficina=collection["sEnOficina"],
                    
                };
                Datos.Instance.ListaEmpleados.Agregar(EmpleadoActual);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleados/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleados/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleados/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
