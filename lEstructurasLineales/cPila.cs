using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lEstructurasLineales
{
    public class cPila<T> : iEstructuraDatosLineales<T>, IEnumerable<T> where T : IComparable
    {
        private cNodo<T> nInicio { get; set; }
        static int iTamano { get; set; }
        public void Agregar(T value)
        {
            if (iTamano == 0)
            {
                nInicio = new cNodo<T>(value);
                iTamano = 1;
            }
            else
            {
                var nNodoAuxiliar = new cNodo<T>(value);
                var nNodoActual = nInicio;
                nNodoAuxiliar.nSiguiente = nInicio;
                nInicio = nNodoAuxiliar;
                //nNodoActual.nSiguiente = nNodoAuxiliar;
                //nNodoAuxiliar.nAnterior = nNodoActual;
                iTamano++;
            }
        }
        public void Buscar(T value)
        {
            throw new NotImplementedException();
        }
        public void Eliminar(T value)
        {
            throw new NotImplementedException();
        }
        public IEnumerator<T> GetEnumerator()
        {
            var nNodoActual = nInicio;
            while (nNodoActual != null)
            {
                yield return nNodoActual.sInformacion;
                nNodoActual = nNodoActual.nSiguiente;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
