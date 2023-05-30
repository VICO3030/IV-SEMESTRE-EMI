using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Baketball
{
    class Lista_basketball
    {
        Nodo cabeza, nuevo;
        public Lista_basketball()
        {
            cabeza = null;
            nuevo = null;
        }

        //creamos el nodo
        public void Crear_Nodo(string nom , int cant_Anillos)
        {
            nuevo = new Nodo(); //iniciamos en null
            nuevo.set_Equipo(nom); //guardamos el nombre
            nuevo.set_Cant(cant_Anillos);
            nuevo.set_Enlace(null);

        }
        public void crear_lista(string nombre , int cant_anillos)
        {   //mostramos el Nodo en la lista
            Nodo punt; //apuntamos para guardar la direccion
            if( cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                punt = cabeza;
                while(punt.get_enlace() != null)
                {
                    punt = punt.get_enlace();

                }
                punt.set_Enlace(nuevo);
               
            }

        }
        public Nodo get_cabeza()
        {
            return cabeza;
        }
        
       
    }
}
