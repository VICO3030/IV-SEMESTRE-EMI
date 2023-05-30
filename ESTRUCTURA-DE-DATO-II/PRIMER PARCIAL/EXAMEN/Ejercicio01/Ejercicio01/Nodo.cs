using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Nodo
    {
        int num;
        Nodo enlace;
        public Nodo()
        {
            num = 0;
            enlace = null;
        }
        public void  Set_num(int _num)
        {
            num = _num;
        }   
        public void Set_enlace(Nodo _enlace)
        {
            enlace = _enlace;
        }
        //getters 
        public int Get_num()
        {
            return num;
        }
        public Nodo Get_enlace()
        {
            return enlace;
        }
    }
}
