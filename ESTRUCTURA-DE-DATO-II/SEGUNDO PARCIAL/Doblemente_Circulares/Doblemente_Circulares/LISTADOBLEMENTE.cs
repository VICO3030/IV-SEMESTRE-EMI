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
        public Boolean EleminarActul(int num)
        {
            NodoCircular actual = cabeza;
            NodoCircular ant = ultimo;
            Boolean encontrado = false;
            do
            {
                if (actual.Get_num() == num)
                {
                    if(cabeza == ultimo && num==cabeza.Get_num() && num == ultimo.Get_num())
                    {
                        cabeza = null;
                        ultimo = null;
                    }
                    else
                    {
                        if (actual == cabeza)
                        {
                            ant = ant.Get_sig();
                            cabeza = cabeza.Get_sig();
                            ultimo.Set_sig(cabeza);
                            cabeza.Set_ant(ultimo);
                            ant.Set_ant(null);
                            ant.Set_sig(null);

                        }
                        else
                        {
                            if (actual == ultimo)
                            {
                                cabeza.Set_ant(ant);
                                ultimo = ultimo.Get_ant();
                                ultimo.Set_sig(cabeza);
                                actual.Set_ant(null);
                                actual.Set_sig(null);

                            }
                            else
                            {
                                ant.Set_sig(actual.Get_sig());
                                actual.Get_sig();
                                actual.Set_ant(ant);



                            }
                        }

                    }

                    encontrado = true;
                }
                ant = actual;
                actual = actual.Get_sig();
            } while (actual != cabeza && encontrado==false);
            return encontrado;
        }
        //Metodo de Ordenar por Inserccion
        public void Ordenamiento()
        {
            int num;
            NodoCircular i;
            NodoCircular j = cabeza;
            do
            {
                num = j.Get_num();
                i = j.Get_ant();
                while (i != ultimo && i.Get_num() > num)
                {
                    i.Get_sig().Set_num((i.Get_num()));

                    i = i.Get_ant();

                }
                //primer caso de la cabeza 
              /*  if (i == null)
                {
                    //i.set_sig(cabeza);
                    i = cabeza;
                    i.Set_num(num);
                    //  i.set_lugar(lugar);
                }
                else
                {*/
                    i.Get_sig().Set_num(num);
                

                j = j.Get_sig();
                //para la siguiente clase el buscar y eleminar
            } while (j != cabeza);
        }
        //Funcion para eleminar 
        public void Insertar(int num)
        {
            NodoCircular punt = cabeza;
            NodoCircular ant = ultimo;
            NodoCircular desp = cabeza.Get_sig();
            NodoCircular nuevo = new NodoCircular();
            nuevo.Set_num(num);
            Boolean encontrado = false;
            if (nuevo.Get_num() < cabeza.Get_num())
            {   
                nuevo.Set_ant(ultimo);
                
                cabeza.Set_ant(nuevo);
                ultimo.Set_sig(nuevo);
                nuevo.Set_sig(cabeza);
                cabeza = cabeza.Get_ant();
            }
            else
            {
                if (nuevo.Get_num() > ultimo.Get_num())
                {
                    nuevo.Set_ant(ultimo);
                    cabeza.Set_ant(nuevo);
                    ultimo.Set_sig(nuevo);
                    
                    nuevo.Set_sig(cabeza);
                    
                    ultimo = ultimo.Get_sig();
                }
                else
                {
                    while (punt.Get_num() < nuevo.Get_num())
                    {

                        ant = punt;
                        punt = punt.Get_sig();
                        desp = punt.Get_sig();
                    }
                    ant.Set_sig(nuevo);
                    nuevo.Set_ant(ant);
                    nuevo.Set_sig(punt);
                    punt.Set_ant(nuevo);

                }
            }

        }
        
    }
} 
