using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Cola
{
    class Nodo_Cola
    {
        int dato;
        Nodo_Cola sig;
        public Nodo_Cola()
        {
            dato = 0;
            
        }No
        public void Set_dato(int d)
        {
            dato = d;
        }
        public void Set_sig(Nodo_Cola _sig)
        {
            sig = _sig;
        }
        public int Get_dato()
        {
            return dato;
        }
        public Nodo_Cola Get_sig()
        {
            return sig;
        }
    }
}
