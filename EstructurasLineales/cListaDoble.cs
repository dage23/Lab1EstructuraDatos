using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasLineales
{
    class cListaDoble<T> : iEstructurasLineales<T>
    {
        static Nodo<T> nInicio { get; set; }
        static int iTamano{ get; set; }
        public void Agregar(T value)
        {
            if (iTamano==0)
            {
                nInicio = new Nodo<T>(value);
                iTamano = 1;
            }
            var nNodoAuxiliar = new Nodo<T>(value);
            var nNodoActual = nInicio;
            while (nNodoActual.nSiguiente!=null)
            {
                nNodoActual = nNodoActual.nSiguiente;
            }
            nNodoActual.nSiguiente = nNodoAuxiliar;
            nNodoAuxiliar.nAnterior = nNodoActual;
            iTamano++;
        }

        public void Buscar(T value)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(T value)
        {
            throw new NotImplementedException();
        }
    }
}
