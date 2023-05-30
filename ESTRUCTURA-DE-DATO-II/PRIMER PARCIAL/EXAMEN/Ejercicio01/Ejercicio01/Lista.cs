using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Lista
    {
        Nodo cabeza, nuevo;
        public Lista()
        {
            cabeza = null;
            nuevo = null;

        }
        public Nodo get_cabeza()
        {
            return cabeza;//primero
        }
        //creamos el nodo
        public void crear_nodo( int nro)
        {
            nuevo = new Nodo(); 
            nuevo.Set_num(nro);
            nuevo.Set_enlace(null);
        }
        public void crear_lista(int num)
        {
            Nodo punt;
            crear_nodo(num);
            //preguntamos 
            if (cabeza == null)//cuando no hay ningun Nodo
            {
                cabeza = nuevo;   //cabeza vaya a la direccion del nuevo 
            }
            else
            {
                punt = cabeza;
                while (punt.Get_enlace() != null)
                {
                    punt = punt.Get_enlace();
                }
                //hay que elazarlo al puntero 
                punt.Set_enlace(nuevo);//direccion de memoria apunta
            }
        }
        //verificamos si el numero existe en la lista 
        public Boolean Buscar(int nro)
        {
            Nodo punt = cabeza;
            while(punt!= null)
            {
                if (punt.Get_num() == nro)
                {
                    return true;
                }
                punt = punt.Get_enlace();
            }
            return false;
        }

        public string  Eleminar(int n)
        {
            Nodo Actual = cabeza;
            Nodo Anterior = null;
            Nodo AUX = null;
            int cont = 0;
            while(Actual!= null)
            {
                AUX = Actual;

                if(cabeza.Get_num()==n && Actual == cabeza)
                {
                    cabeza = cabeza.Get_enlace();
                    Anterior = Actual;
                    Actual = Actual.Get_enlace();
                    AUX.Set_enlace(null);
                    cont++;
                }
                else
                {
                    if (Actual.Get_num() == n)
                    {
                        Anterior.Set_enlace(Actual.Get_enlace());
                        Actual = Actual.Get_enlace();
                        AUX.Set_enlace(null);
                        cont++;
                    }
                    else
                    {
                        Anterior = Actual;
                        Actual = Actual.Get_enlace();
                    }
                }
            }
            return "hola";
        }
        





    }
}
