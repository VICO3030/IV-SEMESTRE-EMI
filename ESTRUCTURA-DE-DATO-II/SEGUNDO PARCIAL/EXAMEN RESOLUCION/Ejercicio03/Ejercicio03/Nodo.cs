using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Nodo
    {
        int cant;
        Nodo sig;
        int CI;
        public Nodo()
        {
            cant = 0;
            CI = 0;
        }

        public int Cant
        {
            get
            {
                return cant;
            }

            set
            {
                cant = value;
            }
        }

        internal Nodo Sig
        {
            get
            {
                return sig;
            }

            set
            {
                sig = value;
            }
        }

        public int CI1
        {
            get
            {
                return CI;
            }

            set
            {
                CI = value;
            }
        }
    }
}
