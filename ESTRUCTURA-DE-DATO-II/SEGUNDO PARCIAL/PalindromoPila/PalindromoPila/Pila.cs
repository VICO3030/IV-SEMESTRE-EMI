using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromoPila
{
    class Pila
    {
        Nodo tope, nuevo;
        public Pila()
        {
            tope = null;
            nuevo = null;
        }
        //creamor el metodo de apilamiento ya que el ultimo en ingresar es el ultimo en salir
        public void  crear_Nodo(char dat)
        {
            nuevo = new Nodo();
            nuevo.Dat = dat;
            nuevo.Sig = null;

        }
        //creamos el apilar qeu va ser la pila 
        public string Apilar(char dat)
        {
            crear_Nodo(dat);
            nuevo.Sig = tope;
            tope = nuevo;
            return "SE REGISTRO EL DATO CORRECTAMENTE !!";
        }
        //metodo de Desapilar
        public Nodo Desapilar()//Eleminamos toda la pila
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
