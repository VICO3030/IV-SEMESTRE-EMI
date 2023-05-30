using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doblemente_Circulares
{
    class NodoCircular
    {
        int num;
        NodoCircular sig, ant;
        public NodoCircular()
        {
            num = 0;
            sig = null;
            ant = null;
        }
        //Creamos los Setters
        public void Set_num(int _num)
        {
            num = _num;
        }
        public void Set_sig(NodoCircular _sig)
        {
            sig = _sig;
        }
        public void Set_ant(NodoCircular _ant)
        {
            ant = _ant;
        }
        //Creamos los Getters
        public int Get_num()
        {
            return num;
        }
        public NodoCircular Get_sig()
        {
            return sig;
        }
        public NodoCircular Get_ant()
        {
            return ant;
        }
    }
}
