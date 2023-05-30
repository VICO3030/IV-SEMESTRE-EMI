using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer04_Cola
{
    class Nodo_Cola
    {
        string nombreDo;
        Nodo_Cola sig;
        int nroHojas;
        string calidad;
        double tiempo;
        string color;
        public Nodo_Cola()
        {
            nombreDo = "";
            nroHojas = 0;
            calidad = "";
            tiempo = 0;
            sig = null;
            color = "";
        }
        //creando los Setters
        public void Set_nombreDoc(string _nombre)
        {
            nombreDo = _nombre;
        }
        public void Set_nroHojas(int nro)
        {
            nroHojas = nro;
        }
        public void Set_calidad(string cal)
        {
            calidad = cal;
        }
        public void Set_sig(Nodo_Cola sigg)
        {
            sig = sigg;
        }
        public void Set_tiempo(double tiem)
        {
            tiempo = tiem;
        }
        public void Set_Color(string _col)
        {
            color = _col;
        }
        //Creamos los getters
        public string Get_nomDoc() { return nombreDo; }
        public int Get_nroHoj() { return nroHojas; }
        public string Get_calidad() { return calidad; }
        public Nodo_Cola Get_sig() { return sig;  }
        public double Get_tiempo() { return tiempo; }
        public string Get_color() { return color; }
    }
}
