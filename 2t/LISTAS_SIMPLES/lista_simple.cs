using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS_SIMPLES
{
   public class lista_simple
    {
        Nodo cabeza, nuevo;
        public lista_simple()
        {
            cabeza = null;
            nuevo = null;

        }
        /// <summary>
        /// Crea un nuevo nodo para empezar a crear la lista
        /// </summary>
        /// <param name="nom">nombre del estudiante</param>
        /// <param name="ed">promedio del estudiante</param>
        public void crear_nodo(string nom, int ed)
        {
            nuevo = new Nodo();
            nuevo.set_nombre(nom);
            nuevo.set_edad(ed);
            nuevo.set_enlace(null);

        }
        /// <summary>
        /// Crea la lista con los nodos creados 
        /// </summary>
        /// <param name="nom">Nombre de la persona</param>
        /// <param name="ed">Edad de la persona</param>
        public void crear_lista(string nom, int ed)
        {
            Nodo punt;
            crear_nodo(nom, ed);
            if (search(nom) == false)
            {
                if (cabeza == null)
                {
                    cabeza = nuevo;

                }
                else
                {
                    punt = cabeza;
                    while (punt.get_enlace() != null)
                    {
                        punt = punt.get_enlace();
                    }
                    punt.set_enlace(nuevo);
                }
            }

        }
        public bool search(string nombre)
        {
            Nodo punt = cabeza;
            while(punt != cabeza)
            {
                if(punt.get_nombre().ToLower() == nombre.ToLower())
                {
                    return true;
                }
                punt = punt.get_enlace();
            }
            return false;
        }
        /// <summary>
        /// cabeza
        /// </summary>
        /// <returns>cabeza de la pila</returns>
         public Nodo get_cabeza()
        {
            return cabeza;
        }
        /// <summary>
        ///    saca una media de todas las edades de la lista actual
        /// </summary>
        /// <returns>media de las edades de la lista</returns>
       
       
        public void deleteNode(int prom)
        {
            Nodo ant = new Nodo();
            Nodo actual = cabeza;
            while(actual != null)
            {
                if(cabeza.get_edad() == prom)
                {
                    cabeza = cabeza.get_enlace();
                    actual.set_enlace(null);
                    return;
                }
                else if(actual.get_edad() == prom)
                {
                    ant.set_enlace(actual.get_enlace());
                    actual.set_enlace(null);
                    return;
                }
                ant = actual;
                actual = actual.get_enlace();   
            }
        }
    }
}
