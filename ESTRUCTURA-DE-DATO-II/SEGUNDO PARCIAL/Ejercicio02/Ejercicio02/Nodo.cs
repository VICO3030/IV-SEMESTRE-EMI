using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Nodo
    {
        Nodo sig;
        int nroLotes;
        string nomProduc;
        int Autonum;

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

        public int NroLotes
        {
            get
            {
                return nroLotes;
            }

            set
            {
                nroLotes = value;
            }
        }

        public string NomProduc
        {
            get
            {
                return nomProduc;
            }

            set
            {
                nomProduc = value;
            }
        }

        public int Autonum1
        {
            get
            {
                return Autonum;
            }

            set
            {
                Autonum = value;
            }
        }

        public Nodo()
        {
            nroLotes = 0;
            nomProduc = "";
            Autonum = 0;
        }

    }
}
