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
            ViewBag.Bienvenido = "Hola Mundo!";
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

        public ActionResult ParqueoPop()
        {
            return View(Datos.Instance.PilaEmpleados);
        }
        public ActionResult DetalleBuscar(int iCodigo)
        {
            return View(Datos.Instance.ListaEmpleados.Get(iCodigo));
        }
        public ActionResult Buscador()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Buscador(FormCollection collection)
        {
            try
            {
                return RedirectToAction("DetalleBuscar", new { iCodigo = int.Parse(collection["iCodigo"]) });
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ActionResult Simulacion(int iCodigo)
        {
            var std = Datos.Instance.ListaEmpleados.Where(s => s.iCodigo == iCodigo).FirstOrDefault();

            return View(std);
         }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Simulacion(cEmpleado std)
        {
            try
            {
                var Empleado = new cEmpleado
                {

                };
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
        public ActionResult BuscaIDSimu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BuscaIDSimu(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Simulacion", new { iCodigo = int.Parse(collection["iCodigo"]) });
            }
            catch (Exception)
            {

                throw;
            }
        }

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
                    sEnOficina = collection["sEnOficina"],
                    HoraLlegada = DateTime.Now,
                    HoraVisita = DateTime.Now,//Modificar DateTime.Now por la cantidad de visitas + 1h30m
                };
                Datos.Instance.ListaEmpleados.Agregar(EmpleadoActual);
                Datos.Instance.PilaEmpleados.Agregar(EmpleadoActual);
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
