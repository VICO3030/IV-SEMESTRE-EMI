using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Nodo
    {
        int dato;
        Nodo sig;
        Nodo ant;
        public Nodo()
        {
            dato = 0;
     
        }
        public void set_Dato(int dato)
        {
            this.dato = dato;
        }
        public void set_ant(Nodo ant)
        {
            this.ant = ant;
        }
        public void set_sig(Nodo sig)
        {
            this.sig = sig;
        }
        public Nodo get_ant()
        {
            return ant;
        }
        public Nodo get_sig()
        {
            return sig;
        }
        public int getDato()
        {
            return dato;
        }
    }
}
