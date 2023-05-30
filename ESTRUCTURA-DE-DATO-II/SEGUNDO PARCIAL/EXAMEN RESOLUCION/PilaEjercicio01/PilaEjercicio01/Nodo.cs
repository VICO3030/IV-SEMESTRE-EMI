using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaEjercicio01
{
    class Nodo
    {
        int num;
        Nodo sig;
        public Nodo()
        {
            num = 0;

        }

        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
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
    }
}
