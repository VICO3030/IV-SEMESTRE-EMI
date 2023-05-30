using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Lista
    {
        Nodo cabeza, nuevo;
        public Lista()
        {
            cabeza = null;
            nuevo = null;

        }
        public Nodo get_cabeza()
        {
            return cabeza;//primero
        }
        //creamos el nodo
        public void crear_nodo( int nro)
        {
            nuevo = new Nodo(); 
            nuevo.Set_num(nro);
            nuevo.Set_enlace(null);
        }
        public void crear_lista(int num)
        {
            Nodo punt;
            crear_nodo(num);
            //preguntamos 
            if (cabeza == null)//cuando no hay ningun Nodo
            {
                cabeza = nuevo;   //cabeza vaya a la direccion del nuevo 
            }
            else
            {
                punt = cabeza;
                while (punt.Get_enlace() != null)
                {
                    punt = punt.Get_enlace();
                }
                //hay que elazarlo al puntero 
                punt.Set_enlace(nuevo);//direccion de memoria apunta
            }
        }

      

    }
}
