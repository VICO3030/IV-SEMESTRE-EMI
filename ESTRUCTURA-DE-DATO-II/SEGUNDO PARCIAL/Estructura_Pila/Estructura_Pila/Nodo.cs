using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Pila
{
    //una pila auxiliar para mostrar 
    class Nodo
    {
        int dato;
        Nodo sig;
        public Nodo()
        {
            dato = 0;
        }
        //setters
        public void set_dato(int _dato)
        {
            dato = _dato;
        }
        public void set_sig(Nodo _sig)
        {
            sig = _sig;
        }
        //getters
        public int get_dato()
        {
            return dato;
        }
        public Nodo get_sig()
        {
            return sig;
        }
    }
}
