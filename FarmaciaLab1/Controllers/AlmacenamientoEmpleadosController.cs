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
                DateTime AgregarMinutos = DateTime.Now;
                AgregarMinutos = AgregarMinutos.AddHours(2);//Agrega 2Horas a la hora actual
                Random Ran = new Random();//Se crea un objeto aleatorio
                int Visitas = Ran.Next(1, 5);//Crea numeros aleatorios entre 1 a 4
                switch (Visitas)//Dependiendo del numero generado se agregan "x" cantidad de minutos
                {
                    case 1:
                        AgregarMinutos = AgregarMinutos.AddMinutes(90);//Agrega 90 minutos
                        break;
                    case 2:
                        AgregarMinutos = AgregarMinutos.AddMinutes(180);//Agrega 180 minutos
                        break;
                    case 3:
                        AgregarMinutos = AgregarMinutos.AddMinutes(270);//Agrega 270 minutos
                        break;
                    case 4:
                        AgregarMinutos = AgregarMinutos.AddMinutes(360);//Agrega 360 minutos
                        break;
                }
                var SueldoFinal = AgregarMinutos.Hour;
                if (AgregarMinutos.Minute != 00)//En caso que existan minutos
                {
                    AgregarMinutos = AgregarMinutos.AddHours(1);
                    SueldoFinal = AgregarMinutos.Hour;//Se redondean las horas a +1h
                }
                var EmpleadoActual = new cEmpleado
                {
                    iCodigo = int.Parse(collection["iCodigo"]),
                    sNombre = collection["sNombre"],
                    sEnOficina = collection["sEnOficina"],
                    VisitasEmpleado = Visitas,
                    dHorasTrabajadas = AgregarMinutos.Hour,
                    HoraLlegada = DateTime.Now,
                    HoraVisita = AgregarMinutos,
                    dSueldo = SueldoFinal * 38,
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
