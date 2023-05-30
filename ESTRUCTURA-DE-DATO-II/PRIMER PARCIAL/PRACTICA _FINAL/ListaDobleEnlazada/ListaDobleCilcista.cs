using System;
namespace ListaDobleEnlazada
{
    class ListaDobleCilcista
    {
        NodoCiclista cabeza, nuevo;

        public ListaDobleCilcista()
        {
            cabeza = null;
            nuevo = null;
        }
        public NodoCiclista get_cabeza()
        {
            return cabeza;
        }
        public NodoCiclista get_nuevo()
        {
            return nuevo;
        }
        public void crearCiclista(int nBici,string nom,string cat)
        {
            nuevo = new NodoCiclista();
            nuevo.set_nBici(nBici);
            nuevo.set_nomCic(nom);
            nuevo.set_cat(cat);
            nuevo.set_ant(null);
            nuevo.set_sig(null);
        }
        public void agregar(int nBici,string nom,string cat)
        {
            crearCiclista(nBici, nom, cat);
            if(cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoCiclista punt = cabeza;
                while(punt.get_sig() != null)
                {
                    punt = punt.get_sig();
                }
                punt.set_sig(nuevo);
                nuevo.set_ant(punt);
            }
        }
        public NodoCiclista existe_nBici(int nBici)
        {
            NodoCiclista punt = cabeza;
            while(punt != null)
            {
                if (punt.get_nBici() == nBici) 
                    return punt;
                punt = punt.get_sig();
            }
            return punt;
        }
        //Existe por su Busqueda
        public NodoCiclista existe_nom(string nom)
        {
            NodoCiclista punt = cabeza;
            while (punt != null)
            {
                if (punt.get_nomCic() == nom)
                    return punt;
                punt = punt.get_sig();
            }
            return punt;
        }
        //modificar
        public NodoCiclista Modificar(string nom)
        {
            NodoCiclista punt = cabeza;
            while (punt != null)
            {
                if (punt.get_nomCic()==nom)
                {

                    return punt;//retorna la direccin del Nodo o  del nombre  para ubicarse
                }   
                punt = punt.get_sig();
            }
            return punt;//retorna NULL si no existe 
            //usa una sola direccioon de memoria del static 
        }
        public NodoCiclista Modificar2(string BusNom, int nro)
        {
            NodoCiclista punt = cabeza;
            while (punt != null)
            {
                if (punt.get_nomCic() == BusNom)
                {
                    punt.set_nBici(nro);
                    return punt;//retorna la direccin del Nodo o  del nombre  para ubicarse
                }
                punt = punt.get_sig();
            }
            return punt;//retorna NULL si no existe 
            //usa una sola direccioon de memoria del static 
        }

        public void Eleminar(NodoCiclista punt)
        {
            NodoCiclista y = cabeza;
            NodoCiclista ant = cabeza.get_ant();
            NodoCiclista sig = cabeza.get_sig();
            while (y != null)
            {
                if(cabeza.get_nBici()== punt.get_nBici())
                {
                    cabeza = cabeza.get_sig();
                    y.set_sig(null);
                    if (cabeza != null)
                    {
                        cabeza.set_ant(null);
                    }
                }
                else
                {


                }
            }

        }


    }
}
