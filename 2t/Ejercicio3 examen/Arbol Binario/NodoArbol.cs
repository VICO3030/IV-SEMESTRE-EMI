using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class NodoArbol
    {
        int dato;
        NodoArbol izq;
        NodoArbol der;

        public NodoArbol()
        {
            this.dato = 0;
            this.izq = null;
            this.der = null;
        }

        public int Dato { get => dato; set => dato = value; }
        public NodoArbol Izq { get => izq; set => izq = value; }
        public NodoArbol Der { get => der; set => der = value; }
    }

}

