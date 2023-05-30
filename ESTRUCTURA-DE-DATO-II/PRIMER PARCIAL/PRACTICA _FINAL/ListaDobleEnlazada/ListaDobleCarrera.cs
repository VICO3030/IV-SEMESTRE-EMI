using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDobleEnlazada
{
    class ListaDobleCarrera
    {
        NodoCarrera cabeza, nuevo;

        public ListaDobleCarrera()
        {
            cabeza = null;
            nuevo = null;
        }
        public NodoCarrera get_Cabeza()
        {
            return cabeza;
        }
        public NodoCarrera get_Nuevo()
        {
            return nuevo;
        }
        public void crearCarrera(int nbici, float tiempo, string lugar, DateTime fecha)
        {
            nuevo = new NodoCarrera();
            nuevo.set_nBici(nbici);
            nuevo.set_tiempo(tiempo);
            nuevo.set_lugar(lugar);
            nuevo.set_fecha(fecha);
            nuevo.set_ant(null);
            nuevo.set_sig(null);
        }
        public void agregar(int nbici, float tiempo, string lugar, DateTime fecha)
        {
            crearCarrera(nbici,tiempo,lugar,fecha);
            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                //insertar al final
                /*NodoCarrera punt = cabeza;
                while (punt.get_sig() != null)
                {
                    punt = punt.get_sig();
                }
                punt.set_sig(nuevo);
                nuevo.set_ant(punt);*/

                //insertar al inicio
                nuevo.set_sig(cabeza);
                cabeza.set_ant(nuevo);
                cabeza = nuevo;
            }
        }
        //ordenamiento por carrera
        public void Ordenamiento()
        {
            float tiempo;//numero 
            NodoCarrera punt = cabeza;
            NodoCarrera i;
            NodoCarrera j = cabeza.get_sig();
            while (j != null)
            {
                tiempo = j.get_tiempo();
                i = j.get_ant();
                while (i != null && i.get_tiempo() > tiempo)
                {
                    NodoCarrera aux = i.get_sig();
                    aux.set_tiempo(i.get_tiempo());

                    //i.get_sig().set_tiempo((i.get_tiempo()));
                    i = i.get_ant();
                 
                }
              /*  if (i == null)
                {
                    i = cabeza;
                    i.set_tiempo(j.get_tiempo());
                }*/
         
                    i.get_sig().set_tiempo(tiempo);
                
               //para la siguiente clase el buscar y eleminar
                
            }
        }
    }
}
