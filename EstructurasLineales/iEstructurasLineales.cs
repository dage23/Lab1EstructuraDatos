using System;
using System.Collections.Generic;
using System.Text;

namespace EstructurasLineales
{
    interface iEstructurasLineales<T>
    {
        void Agregar(T value);
        void Buscar(T value);
        void Eliminar(T value);
    }
}
