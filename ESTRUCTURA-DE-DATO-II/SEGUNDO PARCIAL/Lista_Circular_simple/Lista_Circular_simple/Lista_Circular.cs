using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Circular_simple
{
    class Lista_Circular
    {
        NodoCircular cabeza, nuevo, ultimo;
        public Lista_Circular()
        {
            ultimo = null;
            cabeza = null;
            nuevo = null;

        }
        public NodoCircular  Get_cabeza()
        {
            return cabeza;
        }
        public NodoCircular Get_nuevo()
        {
            return nuevo;
        }
        public NodoCircular Get_ultimo()
        {
            return ultimo;
        }
        //creamos el Nodo
        public void CrearNodo(int num)
        {
            nuevo = new NodoCircular();
            nuevo.Set_num(num);
            nuevo.Set_sig(null);
        }
        //public agregamos a la lista 
        public void Agregarlista(int num)
        {
            CrearNodo(num);
            if (cabeza == null)
            {
                //En resumen se apunta a si mismo
                cabeza = nuevo;
                ultimo = nuevo;
                ultimo.Set_sig(cabeza);
            }
            else
            {
                ultimo.Set_sig(nuevo);
            }
            ultimo = nuevo;
            ultimo.Set_sig(cabeza);
        }
        //Funcion para eleminar el numero 
        public Boolean vacia()
        {
            return (cabeza !=null );
        }
       public Boolean eleminar(int num)
        {
            NodoCircular punt = cabeza;
            NodoCircular aux;
            Boolean encontrado = false;
            if (vacia())
            {   //no haya un solo nodo
                while (punt.Get_enlace()!=cabeza && !encontrado)
                {
                    aux = punt.Get_enlace();
                    encontrado = (aux.Get_num() == num);
                    if (!encontrado)
                    {
                        punt = punt.Get_enlace();
                    }
                }
                aux = punt.Get_enlace();
                encontrado = (aux.Get_num() == num);
                if (encontrado)
                {
                    if(cabeza == cabeza.Get_enlace())
                    {
                        cabeza = null;
                    }
                    else
                    {
                        if(aux == cabeza)
                        {
                            cabeza = punt;
                        }
                        punt.Set_sig(aux.Get_enlace());
                        
                        aux = null;
                    }
                }
            }
            return encontrado;
        }
        //metodo de ordenamiento por burbuja
        public void Ordenamiento()
        {
            NodoCircular actual = cabeza;
            int aux;
            NodoCircular j = new NodoCircular();
            do
            {
                j = actual.Get_enlace();
                while (j != cabeza)
                {
                    if (actual.Get_num() > j.Get_num())
                    {
                        aux = actual.Get_num();
                        actual.Set_num(j.Get_num());
                        j.Set_num(aux);    
                    }
                    j = j.Get_enlace();
                }

                actual = actual.Get_enlace();
            } while (actual!= cabeza);

        }

        //metodo de insertar 
        public void insertar(int num)
        {
            CrearNodo(num);
            NodoCircular ant = ultimo;
            NodoCircular act = cabeza;
            if(nuevo.Get_num() < cabeza.Get_num())
            {   
                nuevo.Set_sig(cabeza);
                cabeza = nuevo;
                ultimo.Set_sig(cabeza);

            }
            else
            {
                if (nuevo.Get_num() > ultimo.Get_num())
                {
                    ultimo.Set_sig(nuevo);
                    ultimo = nuevo;
                    ultimo.Set_sig(cabeza);
                }
                else
                {
                    while (act.Get_num() < nuevo.Get_num())
                    {
                        ant = act;
                        act = act.Get_enlace();
                        
                    }
                    ant.Set_sig(nuevo);
                    nuevo.Set_sig(act);
                }
            }
            
        }

     }
}

