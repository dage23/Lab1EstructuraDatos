using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaLab1.Helpers;
using System.ComponentModel.DataAnnotations;
namespace FarmaciaLab1.Models
{
    public class cEmpleado:IComparable
    {
        public string sNombre { get; set; }
        public int iCodigo { get; set; }
        public double dHorasTrabajadas { get; set; }
        public string sEnOficina { get; set; }
        public double dSueldo;
      
        
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