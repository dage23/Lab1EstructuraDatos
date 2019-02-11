using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmaciaLab1.Models
{
    public class cEmpleadoControlLlegadas
    {
        public string sNombre { get; set; }
        public int iCodigo { get; set; }
        public DateTime dtHoraLlegada { get; set; }
        public int iNumeroCitas { get; set; }
    }
}