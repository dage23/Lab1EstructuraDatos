using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FarmaciaLab1.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace FarmaciaLab1.Models
{
    public class cEmpleado:IComparable,IEnumerable
    {
        [Display(Name ="Nombre de Empleado")]
        public string sNombre { get; set; }
        [Display(Name = "Codigo")]
        public int iCodigo { get; set; }
        [Display(Name = "Horas de Trabajo")]
        public double dHorasTrabajadas { get; set; }
        [Display(Name = "En la Oficina?")]
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

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}