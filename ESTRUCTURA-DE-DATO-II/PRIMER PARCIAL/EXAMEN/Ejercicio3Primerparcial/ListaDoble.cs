using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Primerparcial
{
     class ListaDoble
    {
        NodoDoble cabezaCi, nuevoCi;
        public ListaDoble()
        {
            this.cabezaCi = null;
            this.nuevoCi = null;
        }
        public NodoDoble getCabezaCI()
        { return this.cabezaCi; }
        public NodoDoble getNuevoCI()
        { return this.nuevoCi; }
        public void crearlista( char cat)
        {
            nuevoCi = new NodoDoble();
            nuevoCi.setP(cat);
            nuevoCi.setAnterior(null);
            nuevoCi.setSiguiente(null);
        }
        public string registrarLista(char cat)
        {
            crearlista(cat);
            if (cabezaCi == null)
            {
                cabezaCi = nuevoCi;
            }
            else
            {
                NodoDoble punt = cabezaCi;
                while (punt.getSiguiente() != null)
                {
                    punt = punt.getSiguiente();
                }
                punt.setSiguiente(nuevoCi);
                nuevoCi.setAnterior(punt);
            }
            return "SE REGISTRO CON EXITO";
        }
        public bool palindromo()
        {
            NodoDoble punt2 = cabezaCi;
            while (punt2.getSiguiente() != null)
            {
                punt2 = punt2.getSiguiente();
            }
            NodoDoble punt = cabezaCi;
            while (punt.getSiguiente() != null)
            {
                if(punt.getP()==punt2.getP())
                {
                    punt = punt.getSiguiente();
                    punt2 = punt2.getAnterior();
                }
                 else
                {
                    return false;
                }
            }
            return true;
        }

    }
}
