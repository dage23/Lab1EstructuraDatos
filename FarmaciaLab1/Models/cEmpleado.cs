using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaLab1.Helpers;

namespace FarmaciaLab1.Models
{
    public class cEmpleado:IComparable
    {
        public string sNombre { get; set; }
        public int iCodigo { get; set; }
        public double dHorasTrabajadas { get; set; }
        public bool bEnOficina { get; set; }
        public double dSueldo { get; set; }
        //public static void Guardar(cEmpleado cEmpleado)
        //{
        //    Datos.Instance.Empleados.Add(cEmpleado);
        //}
        public int CompareTo(object obj)
        {
            var vComparador = (cEmpleado)obj;
            return iCodigo.CompareTo(vComparador.iCodigo);
        }
    }
}