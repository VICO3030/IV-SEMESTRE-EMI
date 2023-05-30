using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class noodo
    {
        nodo dato;
        noodo enlace;
        public noodo()
        {
            dato = null;
            enlace = null;
        }

        public nodo Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public noodo Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
