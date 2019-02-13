using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaLab1.Models;
using lEstructurasLineales;
namespace FarmaciaLab1.Helpers
{
    public class Datos
    {
        private static Datos _instance = null;
        public static Datos Instance
        {
            get
            {
                if (_instance == null) _instance = new Datos();
                {
                    return _instance;
                }
            }
        }
        public cListaDoblementeEnlazada<cEmpleado> ListaEmpleados = new cListaDoblementeEnlazada<cEmpleado>();

        public cPila<cEmpleado> PilaEmpleados = new cPila<cEmpleado>();
    }
}