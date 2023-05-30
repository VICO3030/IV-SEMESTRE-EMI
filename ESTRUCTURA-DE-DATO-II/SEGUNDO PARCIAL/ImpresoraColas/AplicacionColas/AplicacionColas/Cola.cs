using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionColas
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
        public void crearNodo(string nombre, int hojas, string color, string calidad, double tiempo, string estado)
        {
            nuevo = new Nodo();
            nuevo.setNombre(nombre);
            nuevo.setHojas(hojas);
            nuevo.setColor(color);
            nuevo.setCalidad(calidad);
            nuevo.setTiempo(tiempo);
            nuevo.setEstado(estado);
            nuevo.setSiguiente(null);
        }
        public void encolar(string nombre, int hojas, string color, string calidad, double tiempo, string estado)
        {
            crearNodo(nombre, hojas, color, calidad, tiempo, estado);
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.setSiguiente(nuevo);
                final = nuevo;
            }
        }
        public Nodo desencolar()
        {
            Nodo aux = frente;
            frente = frente.getSiguiente();
            aux.setSiguiente(null);
            return aux;
        }
        public Nodo getFrente()
        {
            return frente;
        }
        public Nodo getFinal()
        {
            return final;
        }
        public Boolean Estavacio()
        {
            return frente == null;
        }
    }
}
