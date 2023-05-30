using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doblemente_Circulares
{
    class LISTADOBLEMENTE
    {
        NodoCircular cabeza, ultimo, nuevo; 
        public LISTADOBLEMENTE()
        {
            cabeza = null;
            ultimo = null;
            nuevo = null;
        }
        //Creamos los Getters
        public NodoCircular Get_cabeza()
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


        //Agregamos a  la lista 
        //Creamos el primero Nodo
        public void Agregar_lista(int num)
        {
            NodoCircular nuevo = new NodoCircular();
            nuevo.Set_num(num);
            if (cabeza == null)
            {
                cabeza = nuevo;
                ultimo = nuevo;
                cabeza.Set_sig(cabeza);
                ultimo.Set_ant(ultimo);
              //  ultimo = nuevo;
            }
            else
            {
                ultimo.Set_sig(nuevo);
                nuevo.Set_sig(cabeza);
                nuevo.Set_ant(ultimo);
                ultimo = nuevo;
                cabeza.Set_ant(ultimo);              
            }       
        }
        //Funcion para Eleminar Nodo
        public Boolean Eleminar(int num)
        {
            NodoCircular actual = cabeza;
            NodoCircular anterior = ultimo;
            Boolean encontrado = false;
            do
            {

                if(actual.Get_num() == num)
                {
                    if(actual == cabeza)
                    {
                        cabeza = cabeza.Get_sig();
                        ultimo.Set_sig(cabeza);
                        cabeza.Set_ant(ultimo);
                        
                    }
                    else
                    {
                           if(actual == cabeza)
                        {
                            ultimo = anterior;
                            cabeza.Set_ant(ultimo);
                            ultimo.Set_sig(cabeza);
                            
                        }
                        else
                        {
                            anterior.Set_sig(actual.Get_sig());
                            actual.Get_sig().Set_ant(anterior);
                            
                        }
                    }
                    encontrado = true;
                }
                anterior = actual;
                actual = actual.Get_sig();
            } while (actual != cabeza  && encontrado ==false);
            return encontrado;
        }

        
    }
}
