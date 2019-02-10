using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lEstructurasLineales
{
    interface iEstructuraDatosLineales<T>
    {
        void Agregar(T value);
        bool Buscar(T value);
        void Eliminar(T value);
    }
}
