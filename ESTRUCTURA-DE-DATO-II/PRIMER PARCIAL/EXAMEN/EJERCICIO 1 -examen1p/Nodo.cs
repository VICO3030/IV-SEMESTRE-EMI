using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1__examen1p
{
    class Nodo
    {
        int numeros;
        Nodo enlace;
        public Nodo()
        {
            numeros = 0;
            enlace = null;
        }
        public void set_numeros(int numero)
        {
            numeros = numero;
        }
        public void set_enlace(Nodo punt)
        {
            enlace = punt;
        }
        public int get_numero()
        {
            return numeros;
        }
        public Nodo get_enlace()
        {
            return enlace;
        }
    }
}
