using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class nodo
    {
        int dato;
        nodo iz, der;
        public nodo()
        {
            dato = 0;
            iz = null;
            der = null;
        }
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public nodo Iz
        {
            get { return iz; }
            set { iz = value; }
        }
        public nodo Der
        {
            get { return der; }
            set { der = value; }
        }
    }
}
