using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Doblemente_Enlazadas
{
    class Doble_Ciclista
    {
        Nodo_Ciclista cabeza_ciclista, nuevo_ciclista;
        public Doble_Ciclista()
        {
            cabeza_ciclista = null;
            nuevo_ciclista = null;
        }
        public Nodo_Ciclista get_Cabeza()
        {
            return cabeza_ciclista;
        }
        public Nodo_Ciclista get_Nuevo()
        {
            return nuevo_ciclista;
        }
        public void Crear_ciclista(int nro  , string nom , string categoria)
        {
            nuevo_ciclista= new Nodo_Ciclista();
            nuevo_ciclista.Set_NBici(nro);
            nuevo_ciclista.Set_nombre(nom);
            nuevo_ciclista.Set_Categoria(categoria);
            nuevo_ciclista.Set_Ant(null);
            nuevo_ciclista.Set_Sig(null);       
        }
        public void registrar_lista(int num , string nom , string categoria)
        {
            Crear_ciclista(num, nom, categoria);
            if (cabeza_ciclista == null)
            {
                //tiene que ser el primer ciclista
                cabeza_ciclista = nuevo_ciclista;
            }
            else
            {
                //necestiamos doble punteroo 
                Nodo_Ciclista punt = cabeza_ciclista;
                while(punt.get_Sig() != null)
                {
                    punt = punt.get_Sig();

                }
                punt.Set_Sig(nuevo_ciclista);
                nuevo_ciclista.Set_Ant(punt);
            }
        }
        public Nodo_Ciclista existeBici(int bici)
        {
            Nodo_Ciclista punt = cabeza_ciclista;
            while(punt != null)
            {
                if (punt.get_Nbici() == bici)
                {
                    return punt;
                }
                punt = punt.get_Sig();
            }
            return punt; 
        }
    }
}
