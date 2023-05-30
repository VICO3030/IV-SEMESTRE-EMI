using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Pila
    {
        Nodo tope, nuevo;
        public Pila()
        {
            tope = null;
            nuevo = null;

        }
        //Creamos el nodo
        public void crear_nodo(int i  , string nom ,int nroLotes)
        {
            nuevo = new Nodo();
            nuevo.Autonum1 = i;
            nuevo.NomProduc = nom;
            nuevo.NroLotes = nroLotes;
            nuevo.Sig = null;
        }
        //metodo de apilacion
        public string Apilar(int i  , string nom , int nroLotes)
        {
            crear_nodo(i, nom, nroLotes);
            nuevo.Sig = tope;
            tope = nuevo;
            return "SE REGISTRO PRODUCTO  : " + nom;
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
