using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasLineales
{
    public class Nodo<T>
    {
        public T Informacion { get; set; }
        public Nodo<T> nSiguiente{ get; set; }
        public Nodo<T> nAnterior { get; set; }

        public Nodo(T value)
        {
            Informacion = Informacion;
            nSiguiente = null;
            nAnterior = null;
        }
    }
}
