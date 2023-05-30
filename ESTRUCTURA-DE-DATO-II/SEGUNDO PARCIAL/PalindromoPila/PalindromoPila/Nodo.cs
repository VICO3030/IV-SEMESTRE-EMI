using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromoPila
{
    class Nodo
    {
        char dat;
        Nodo sig;

        public Nodo()
        {
            dat = ' ';
        }

        public char Dat
        {
            get
            {
                return dat;
            }

            set
            {
                dat = value;
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
