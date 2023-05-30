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
        public void crearCarrera(int nbici, float tiempo,  DateTime fecha)
        {
            nuevo = new NodoCarrera();
            nuevo.set_nBici(nbici);
            nuevo.set_tiempo(tiempo);
         //   nuevo.set_lugar(lugar);
            nuevo.set_fecha(fecha);
            nuevo.set_ant(null);
            nuevo.set_sig(null);
        }
        public void agregar(int nbici, float tiempo,  DateTime fecha)
        {
            crearCarrera(nbici,tiempo, fecha);
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
            DateTime fecha;
            int  lugar;

            NodoCarrera punt = cabeza;  
            NodoCarrera i;
            NodoCarrera j = cabeza.get_sig();
            while (j != null)
            {
                tiempo = j.get_tiempo();
                fecha = j.get_fecha();
               // lugar = j.get_lugar();

                i = j.get_ant();
                while (i != null && i.get_tiempo() > tiempo)
                {

                    i.get_sig().set_tiempo((i.get_tiempo()));
                    //
                    i.get_sig().set_lugar((i.get_lugar()));
                    i.get_sig().set_fecha((i.get_fecha()));
                    i = i.get_ant();
                 
                }
                //primer caso de la cabeza 
               if (i == null)
                {
                    //i.set_sig(cabeza);
                    i = cabeza;
                   i.set_tiempo(tiempo);
                    i.set_fecha(fecha);
                  //  i.set_lugar(lugar);
                }
                else
                {
                    i.get_sig().set_tiempo(tiempo);
                   // i.get_sig().set_lugar(lugar);
                    i.get_sig().set_fecha(fecha);
                }   
         
                
                
               j = j.get_sig();
               //para la siguiente clase el buscar y eleminar
                
            }
        }

        public void llenarlugar()
        {
            NodoCarrera punt = cabeza;
            NodoCarrera punt2 = cabeza;
            int i = 1;
            while (punt != null)
            {
                punt.set_lugar(i.ToString());
                punt = punt.get_sig();
                i++;    

            }     
        }
        public void Descalificados()
        {
            NodoCarrera punt = cabeza;
            while(punt != null)
            {
                if (int.Parse(punt.get_lugar()) > 10)
                {
                    punt.set_lugar("Descalificado!");
                    
                }
                punt = punt.get_sig();

            }
        }
       

    }
}
