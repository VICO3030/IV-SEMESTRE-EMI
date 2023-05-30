using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simple
{
    class Lista
    {
        Nodo cabeza, nuevo;
        public Lista()
        {
            cabeza = null;
            nuevo = null;
        }
        public void Setnuevo(Nodo _nuevo)
        {
            nuevo = _nuevo;
        }
        public void Setcabeza(Nodo _cabeza)
        {
            cabeza = _cabeza;
        }
        public Nodo Getcabeza()
        {
            return cabeza;
        }
        public Nodo Getnuevo()
        {
            return nuevo;
        }
        public void crear_nodo(string usuario  , int codigo)
        {
            nuevo = new Nodo();
            nuevo.SetUsuario(usuario);
            nuevo.SetCodigo(codigo);
            nuevo.SetEnlace(null);
        }
        public void Agregar_lista(string usuaio  , int cod)
        {
            Nodo punt = cabeza;
            crear_nodo(usuaio, cod);
            if(cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                punt = cabeza;
                while (punt.GetEnlace() != null)
                {
                    punt = punt.GetEnlace();
                }
            }
        }
       
    }
}
