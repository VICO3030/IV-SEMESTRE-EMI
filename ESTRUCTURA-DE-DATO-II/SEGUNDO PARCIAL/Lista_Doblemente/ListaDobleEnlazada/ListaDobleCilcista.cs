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
            NodoCiclista actual = cabeza;
            NodoCiclista aux = null;
            NodoCiclista aux2 = null;
            while (punt.get_sig() != null && punt.get_ant() != null)
            {

                //primer caso si esta en el inicio
                if (punt == cabeza && punt.get_ant() == null)
                {
                    cabeza = cabeza.get_sig();
                    cabeza.set_ant(null);
                    punt.set_sig(null);
                    punt.set_ant(null);

                }
                else
                {   //segundo caso si esta en el final
                    if (punt == nuevo && punt.get_sig() == null)
                    {
                        nuevo = nuevo.get_ant();
                        nuevo.set_sig(null);
                        punt.set_ant(null);
                        punt.set_sig(null);
                    }
                    else
                    {
                        aux2 = punt.get_ant();
                        aux = punt.get_sig();
                        aux2.set_sig(aux);
                        aux.set_ant(aux2);
                        punt.set_ant(null);
                        punt.set_sig(null);
                    }
                }
            }
        }
            public void eleminarNom(string nombre)
        {
            NodoCiclista punt = cabeza;
            NodoCiclista aux = punt;
            NodoCiclista aux2 = null;
            NodoCiclista aux3 = null;
            while ( (aux.get_sig()==null && aux.get_ant()==null))
            {
                aux = punt;
                if(nombre ==punt.get_nomCic() && punt.get_ant() == null)
                {
                    cabeza = cabeza.get_sig();
                    punt = punt.get_sig();
                    aux.set_sig(null);
                    aux.set_ant(null);
                }
                else
                {
                    if(nombre ==punt.get_nomCic()&& punt.get_sig() == null)
                    {
                        nuevo = nuevo.get_ant();
                        nuevo.set_sig(null);
                        punt = nuevo;
                        aux.set_sig(null);
                        aux.set_ant(null);

                    }
                    else
                    {
                        if(nombre== punt.get_nomCic())
                        {
                            aux3 = punt.get_ant();
                            aux2 = punt.get_sig();
                            aux3.set_sig(aux2);
                            aux2.set_ant(aux3);
                            aux.set_ant(null);
                            aux2.set_sig(null);
                            punt = punt.get_sig();
                            
                        }
                    }
                }
            }
        }
        public void eleminar02(string nombre)
        {
            NodoCiclista punt = cabeza;
            Boolean encontrado = false;

            while(punt !=null && !encontrado)
            {
                encontrado = (punt.get_nomCic() == nombre);
                if (!encontrado)
                {
                    punt = punt.get_sig();
                }
            }
            if(encontrado)
            {
                if(punt== cabeza)
                {
                    cabeza = punt.get_sig();
                }
                else
                {
                    punt.get_ant().set_sig(punt.get_sig());
                    if(punt.get_sig()!= null)
                    {
                                     punt.get_sig().set_ant(punt.get_ant());
                    }
                }
                punt = null;
            }
           
        }



       }


  }

