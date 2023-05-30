using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Doblemente
    {
        Nodo cabeza, nuevo;
        public Doblemente()
        {
            cabeza = null;
            nuevo = null;

        }
        public Nodo get_cabeza()
        {
            return cabeza;
        }
        public Nodo get_nuevo()
        {
            return nuevo;
        }
        public void crearCiclista(int dato)
        {
            nuevo = new Nodo();
            nuevo.set_Dato(dato);

            nuevo.set_ant(null);
            nuevo.set_sig(null);
        }
        public void agregar(int dato)
        {
            crearCiclista(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo punt = cabeza;
                while (punt.get_sig() != null)
                {
                    punt = punt.get_sig();
                }
                punt.set_sig(nuevo);
                nuevo.set_ant(punt);
            }
        }
    }
}
