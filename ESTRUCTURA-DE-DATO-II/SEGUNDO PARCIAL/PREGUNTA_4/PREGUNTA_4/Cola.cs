using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREGUNTA_4
{
    class Cola
    {
        Nodo frente, final, nuevo;

        public Cola()
        {
            frente = null;
            final = null;
            nuevo = null;
        }

        public void nuevo_nodo(string nom, int h, string calcol)
        {
            nuevo = new Nodo();
            nuevo.setNombre(nom);
            nuevo.setHojas(h);
            nuevo.SetCalidadColor(calcol);
            nuevo.setSiguiente(null);
        }

        public void encolar(string nom, int h, string calcol)
        {
            nuevo_nodo(nom, h, calcol);
            if (final == null)
            {
                frente = nuevo;
            }
            else
            {
                final.setSiguiente(nuevo);
            }
            final = nuevo;
        }

        public Nodo desencolar()
        {
            Nodo aux = frente;
            frente = frente.getSiguiente();
            aux.setSiguiente(null);
            if (aux == final)
            {
                final = null;
            }
            return aux;
        }

        public Nodo Buscar(int dato)
        {
            Nodo aux = frente;

            while (aux != null)
            {
                if (aux.getHojas() == dato)
                {
                    return aux;
                }
                aux = aux.getSiguiente();
            }
            return null;
        }


        public void eliminar(int dato)
        {
            Nodo B = Buscar(dato);
            Nodo ant = frente;

            if (frente == final)
            {
                frente = null;
                final = null;
            }

            else
            {
                if (B == frente)
                {
                    frente = B.getSiguiente();
                    B.setSiguiente(null);
                }

                else
                {
                    while (ant.getSiguiente() != B)
                    {
                        ant = ant.getSiguiente();
                    }

                    if (B == final)
                    {
                        final = ant;
                        ant.setSiguiente(null);
                    }
                    else
                    {
                        ant.setSiguiente(B.getSiguiente());
                        B.setSiguiente(null);
                    }

                }
            }

        }

        public int getTiempoTotal()
        {
            int con = 0;
            Nodo cab = frente;
            while(cab != null)
            {
                con = con + cab.getTiempohoja() * cab.getHojas();
                cab = cab.getSiguiente();
            }
            return con;
        }

        public Nodo getFinal()
        {
            return final;
        }

        public Nodo getFrente()
        {
            return frente;
        }
    }
}
