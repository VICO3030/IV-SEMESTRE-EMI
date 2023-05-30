using System;
namespace Lista_Doblemente_Enlazadas
{
    
    class DobleCarrera
    {
        Nodo_Carrera cabeza1, nuevo1;
         public  DobleCarrera()
        {
          cabeza1= null;
          nuevo1=null;
        }

        public void crearCarrera(int nbici, float tiempo, string lugar, DateTime fecha)
        {
            nuevo1 = new Nodo_Carrera();
            nuevo1.Set_nBici(nbici);
            nuevo1.Set_lugar(lugar);
            nuevo1.Set_tiempo(tiempo);
            nuevo1.Set_fecha(fecha);
            nuevo1.Set_Ant(null);
            nuevo1.Set_Sig(null);
        }

        public void Agregar(int nbici, float tiempo, string lugar, DateTime fecha)
        {
            
            crearCarrera( nbici,  tiempo,  lugar, fecha);

            if (cabeza1 == null)
            {
                cabeza1 = nuevo1;   
            }
            else
            {
                /* Nodo_Carrera punt = cabeza;

                 while (punt.get_Sig() != null)
                 {
                     punt = punt.get_Sig();
                 }
                 punt.Set_Sig(nuevo);
                 nuevo.Set_Ant(punt);*/
                 //insertar al inicio
                nuevo1.Set_Sig(cabeza1);
                cabeza1.Set_Ant(nuevo1);
                cabeza1 = nuevo1;
                    
            }
        }

    }


}
