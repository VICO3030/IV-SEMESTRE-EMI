using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1
{
    class Lista_Circular
    {
        NodoCircular cabeza, nuevo, ultimo;
        public Lista_Circular()
        {
            ultimo = null;
            cabeza = null;
            nuevo = null;

        }
        public NodoCircular Get_cabeza()
        {
            return cabeza;
        }
        public NodoCircular Get_nuevo()
        {
            return nuevo;
        }
        public NodoCircular Get_ultimo()
        {
            return ultimo;
        }
        //creamos el Nodo
        public void CrearNodo(int num)
        {
            nuevo = new NodoCircular();
            nuevo.Set_num(num);
            nuevo.Set_sig(null);
        }
        //public agregamos a la lista 
        public void Agregarlista(int num)
        {
            CrearNodo(num);
            if (cabeza == null)
            {
                //En resumen se apunta a si mismo
                cabeza = nuevo;
                ultimo = nuevo;
                ultimo.Set_sig(cabeza);
            }
            else
            {
                ultimo.Set_sig(nuevo);
            }
            ultimo = nuevo;
            ultimo.Set_sig(cabeza);
        }
        //Funcion para eleminar el numero 
        public Boolean vacia()
        {
            return (cabeza != null);
        }
    }
}
