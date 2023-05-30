using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02_Pila
{
    class Pila
    {
        Nodo tope, nuevo;
        public Pila()
        {
            tope = null;
            nuevo = null;
        }
        public void crear_nodo(int cod , int stock , float precio , string descrip)
        {
            nuevo = new Nodo();
            nuevo.Set_Codigo(cod);
            nuevo.Set_stok(stock);
            nuevo.Set_Precio(precio);
            nuevo.Set_descripcion(descrip);
            nuevo.Set_sig(null);
        }
        public string Apilar(int cod, int stock, float precio, string descrip)
        {
            crear_nodo(cod, stock, precio, descrip);
            nuevo.Set_sig(tope);
            tope = nuevo;
            return "SE REGISTRO LA VENTA";
        }
        public Nodo Desapilar()//Eleminamos toda la pila
        {
            Nodo aux;
            aux = tope;
                tope = tope.Get_sig();
            aux.Set_sig(null);
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
