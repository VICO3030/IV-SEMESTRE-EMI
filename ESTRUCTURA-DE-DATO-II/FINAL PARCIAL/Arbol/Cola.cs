using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class Cola
    {
        noodo frente, ultimo;

        public Cola()
        {
            frente = null;
            ultimo = null;
        }
        public void encolar(nodo dato)
        {
            if (frente == null)
            {
                frente = new noodo();
                frente.Dato = dato;
                frente.Enlace = null;
                ultimo = frente;
            }
            else
            {
                ultimo.Enlace = new noodo();
                ultimo.Enlace.Dato = dato;
                ultimo.Enlace.Enlace = null;
                ultimo = ultimo.Enlace;
            }
        }
       
        public noodo desencolar()
        {
            if(frente!=null)
            {
                noodo aux = frente;
                frente = frente.Enlace;
                aux.Enlace = null;
                return aux;
            }
            else
            {
                return null;
            }
        }
        public noodo get_frente()
        {
            return frente;
        }
        public noodo get_ultimo()
        {
            return ultimo;
        }
        public bool esta_vacia()
        {
            return frente == null;
        }
    }
}
