using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionColas
{
    class Nodo
    {
        string nombre;
        int hojas;
        string color;
        string calidad;
        double tiempo;
        string estado;
        Nodo siguiente;
        public Nodo()
        {
            nombre = "";
            hojas = 0;
            color = "";
            calidad = "";
            tiempo = 0;
            estado = "";
            siguiente = null;
        }
        public void setNombre(string nom)
        {
            nombre = nom;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setHojas(int hoja)
        {
            hojas = hoja;
        }
        public int getHojas()
        {
            return hojas;
        }
        public void setColor(string col)
        {
            color = col;
        }
        public string getColor()
        {
            return color;
        }
        public void setCalidad(string cal)
        {
            calidad = cal;
        }
        public string getCalidad()
        {
            return calidad;
        }
        public void setTiempo(double time)
        {
            tiempo = time;
        }
        public double getTiempo()
        {
            return tiempo;
        }
        public void setEstado(string est)
        {
            estado = est;
        }
        public string getEstado()
        {
            return estado;
        }
        public void setSiguiente(Nodo sig)
        {
            siguiente = sig;
        }
        public Nodo getSiguiente()
        {
            return siguiente;
        }

    }
}
