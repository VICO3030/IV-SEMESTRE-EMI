using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1__examen1p
{
    class Listas_Simples
    {
         Nodo cabeza, nuevo;

        public Listas_Simples()
        {
            cabeza = null; nuevo = null;
        }
        public void crear_nodo(int numero)
        {
            nuevo = new Nodo(); //se crea parametros y se le da la direccion de memoria 
  /*!!*/    nuevo.set_numeros(numero);
            nuevo.set_enlace(null);
        }
        public Nodo get_cabeza()
        {
            return cabeza;

        }
        public void crear_lista(int numero)
        {
            Nodo punt;
            crear_nodo(numero);
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
        
        /* public void lista_L(string nombre){
         Nodo ant = new Nodo();
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (cabeza.get_nombre().ToLower() == nombre.ToLower())
                {
                    cabeza = cabeza.get_enlace();
                    actual.set_enlace(null);
                    return;
                }
                else if (actual.get_nombre().ToLower() == nombre.ToLower())
                {
                    ant.set_enlace(actual.get_enlace());
                    actual.set_enlace(null);
                    return;
                }
                ant = actual;
                actual = actual.get_enlace();
            }
         */
    }





}
