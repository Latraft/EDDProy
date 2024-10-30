using System;
using System.Collections.Generic;
using System.Linq;

namespace EDDemo.Estructuras_No_Lineales.Clases
{


    public class NodoBusqueda
    {

        public bool Busqueda(int valor, NodoBinario nodo)
        {
            if (nodo == null)
                return false;

            if (nodo.Dato == valor)
                return true;
            else if (valor < nodo.Dato)
                return Busqueda(valor, nodo.Izq);
            else
                return Busqueda(valor, nodo.Der);
        }


        public HashSet<int> ObtenerValoresNoRepetidos(NodoBinario nodo, HashSet<int> valores)
        {
            if (nodo == null)
                return valores;


            if (valores.Add(nodo.Dato))
            {
                ObtenerValoresNoRepetidos(nodo.Izq, valores);
                ObtenerValoresNoRepetidos(nodo.Der, valores);
            }

            return valores;
        }
    }
}
