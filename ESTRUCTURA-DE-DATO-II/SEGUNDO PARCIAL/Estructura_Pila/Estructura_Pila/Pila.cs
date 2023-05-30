using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Pila
{
    class Pila
    {
        Nodo tope, nuevo;
        public Pila()
        {
            tope = null;
            nuevo = null;

        }
        public void Crear_nodo(int n)
        {
            nuevo = new Nodo();
            nuevo.set_dato(n);
            nuevo.set_sig(null);

        }
        public Nodo Get_tope()
        {
            return tope;
        }
        public string Apilar(int n)//agregar
        {
            Crear_nodo(n);
            nuevo.set_sig(tope);
            tope = nuevo;
            return "EL NUMERO FUE APILADO!";
        }
        public Nodo Desapilar()//Eleminamos toda la pila
        {
            Nodo aux;
            aux = tope;
            tope = tope.get_sig();
            aux.set_sig(null);
            return aux;
        } 
        public Boolean estaVacio()
        {
            return tope == null;
        }


        
    
    }
}
