using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_simple
{
    class NodoCircular
    {
        int num;
        NodoCircular sig;
        public NodoCircular()
        {
            num = 0;
        }
        //setters 
        public void Set_num(int _num)
        {
            num = _num;
        }
        public void Set_sig(NodoCircular sigui)
        {
            sig = sigui;
        }
        //getters 
        public int Get_num()
        {
            return num;
        }
        public NodoCircular Get_enlace()
        {
            return sig;
        }
    }
}
