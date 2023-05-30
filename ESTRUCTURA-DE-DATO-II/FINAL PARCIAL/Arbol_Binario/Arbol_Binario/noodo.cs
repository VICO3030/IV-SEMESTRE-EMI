using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class noodo
    {
        Nodo_Arbol dato;
        noodo enlace;
        public noodo()
        {
            dato = null;
            enlace = null;
        }

        public Nodo_Arbol Dato
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
