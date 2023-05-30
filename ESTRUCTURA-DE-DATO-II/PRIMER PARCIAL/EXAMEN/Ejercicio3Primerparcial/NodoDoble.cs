using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Primerparcial
{
     class NodoDoble
    {
        char p;
        NodoDoble sig;
        NodoDoble ant;
        public NodoDoble()
        {
            p=' ';
            ant = null;
            sig = null;

        }

        
        public void setP(char cat)
        {
            p = cat;
        }
        public void setAnterior(NodoDoble punt)
        {
            ant = punt;
        }
        public void setSiguiente(NodoDoble punt)
        {
            sig = punt;
        }
       
        public char getP()
        {
            return p;
        }
        public NodoDoble getAnterior()
        {
            return ant;
        }
        public NodoDoble getSiguiente()
        {
            return sig;
        }
    }
}
