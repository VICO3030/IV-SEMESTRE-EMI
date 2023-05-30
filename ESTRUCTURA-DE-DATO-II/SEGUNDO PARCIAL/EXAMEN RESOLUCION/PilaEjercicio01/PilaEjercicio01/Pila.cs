using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaEjercicio01
{
    class Pila
    {
        Nodo tope, nuevo;
        public Pila()
        {
            tope = null;
            nuevo = null;
        }
        //creamos el primer nodo
        public void Crear_Nodo(int num)
        {
            nuevo = new Nodo();
            nuevo.Num = num;
            nuevo.Sig = null;
        }
        //Apilamos a la pila el Nodo
        public string Apilar(int num)
        {
            Crear_Nodo(num);
            nuevo.Sig = tope;
            tope = nuevo;
            return "Se registro Correctamente";
        }
        public Nodo Desapilar()
        {
            Nodo aux;
            aux = tope;
            tope = tope.Sig;
            aux.Sig = null;
            return aux;
        }
        public Boolean estaVacio()
        {
            return tope == null;
        }
        public Nodo Get_tope()
        {
            return tope;
        }
    }
}
