using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Colas
{
    class nodo
    {
        string nombre;
        int hojas;
        string color;
        string calidad;
        float tiempo;
        string estado;
        nodo enlace;
        public nodo()
        {
            nombre = "";
            hojas = 0;
            color = "";
            calidad = "";
            tiempo = 0;
            estado = "";
            enlace = null;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Hojas
        {
            get { return hojas; }
            set { hojas = value; }
        }
        public float Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Calidad
        {
            get { return calidad; }
            set { calidad = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public nodo Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }
}
