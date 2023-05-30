using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Colas
{
    class Cola
    {
        nodo frente, ultimo;

        public Cola()
        {
            frente = null;
            ultimo = null;
        }
        public void encolar(string n,int h,string c,string cal,string e,float t)
        {
            if (frente == null)
            {
                frente = new nodo();
                frente.Nombre = n;
                frente.Hojas = h;
                frente.Color = c;
                frente.Calidad = cal;
                frente.Estado = e;
                frente.Tiempo = t;
                frente.Enlace = null;
                ultimo = frente;
            }
            else
            {
                ultimo.Enlace = new nodo();
                ultimo.Enlace.Nombre = n;
                ultimo.Enlace.Hojas = h;
                ultimo.Enlace.Color = c;
                ultimo.Enlace.Calidad = cal;
                ultimo.Enlace.Estado = e;
                ultimo.Enlace.Tiempo = t;
                ultimo.Enlace.Enlace = null;
                ultimo = ultimo.Enlace;
            }
        }
        public nodo buscar(string n)
        {
            nodo x = frente;
            while (x != null)
            {
                if (x.Nombre == n)
                {
                    return x;
                }
                x = x.Enlace;
            }
            return null;
        }
        public nodo desencolar()
        {
            nodo aux = frente;
            frente = frente.Enlace;
            aux.Enlace = null;
            return aux;
        }
        public nodo get_frente()
        {
            return frente;
        }
        public nodo get_ultimo()
        {
            return ultimo;
        }
        public bool esta_vacia()
        {
            return frente == null;
        }
    }
}
