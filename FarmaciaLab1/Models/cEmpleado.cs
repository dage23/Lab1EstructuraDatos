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
        [Display(Name = "Numero de Visitas")]
        public int VisitasEmpleado { get; set; }
        [Display(Name = "Hora de Llegada"), DataType(DataType.Time)]
        public DateTime HoraLlegada { get; set; }
        [Display(Name = "Horas de Visita"), DataType(DataType.Time)]
        public DateTime HoraVisita { get; set; }
        [Display(Name = "Salario")]
        public double dSueldo { get; set; }
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