using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS_SIMPLES
{
    class LISTA_SIMPLE
    {
        /*nuestra lista esa compuesta por
        puntero nos indica la direccioon  de memoria cuando creamos la primer ves
        CABEZA  A PUNTA A  : NULL y por tanto no tiende nodos*/
        Nodo cabeza, nuevo; 
        public LISTA_SIMPLE()
        {
            cabeza = null;
            nuevo = null;

        }
        //creamos el nodo
        public void crear_nodo(string _nom , int _edad)
        {
            nuevo = new Nodo(); //nuevo crea nodo
            nuevo.set_Nombre(_nom);//asignamos el nombre
            nuevo.set_Edad(_edad);//la edada
            nuevo.set_enlace(null);//y como es primero nodo la direccioon va ser null
           
        }
        public void crear_lista(string nom, int edad)
        {
            Nodo punt;
            //si mi lista esta vacia y si mi nodo tiene datos poner al final 
            crear_nodo(nom, edad);
            //preguntamos 
            if(cabeza == null)//cuando no hay ningun Nodo
            {
                cabeza = nuevo;   //cabeza vaya a la direccion del nuevo 
            }
            else
            {
                punt = cabeza;
                while (punt.get_enlace() != null)
                {
                    punt = punt.get_enlace();
                }
                //hay que elazarlo al puntero 
                punt.set_enlace(nuevo);//direccion de memoria apunta
            }
        }
        public Nodo get_cabeza()
        {
            return cabeza;//primero
        }
        public int Edad_prom()
        {
            int prom_edad=0,acum=0, cont=0;
            Nodo punt = cabeza;

            while (punt != null)
            {  
                acum = acum + punt.get_Edad();
                cont++;
                punt = punt.get_enlace();//que recorra nodo en nodo hazta que llegue en nulll
                
            }
            prom_edad = acum / cont ;

            return prom_edad;


        }
        //menor mostrar en int , tanto como el nombre en string
        public int  Menor()
        {
            int menor = 100;
            Nodo punt = cabeza;
            while (punt != null)
            {
                if (punt.get_Edad() < menor)
                {
                    menor = punt.get_Edad();//comparamos y guardamos en la variale menor
                }

                punt = punt.get_enlace();//que recorra nodo en nodo hazta que llegue en nulll

            }
            return menor;
        }

        public string MenorNOMBRE()
        {
            int menor = 100;
            string menorNom = "";
            Nodo punt = cabeza;
            while(punt != null)
            {
                if (punt.get_Edad() < menor)
                {
                    menorNom = punt.get_nombre();
                    menor = punt.get_Edad();
                }
                punt = punt.get_enlace();
            }
            return menorNom;
        }

        //Mayor de la nota mstramos tanto como el nombre string   y  la  nota en int
     public string MayorNOMBRE()
        {
            int mayor =0;
            string mayorNom="";
            Nodo punt = cabeza;
            while (punt != null)
            {
                if (punt.get_Edad() > mayor)
                {
                    mayorNom = punt.get_nombre();
                    mayor = punt.get_Edad();
                    
                }

                punt = punt.get_enlace();//que recorra nodo en nodo hazta que llegue en nulll

            }
            return mayorNom;

        }
            
        public int Mayor()
        {
            int  mayor = 0;
            Nodo punt = cabeza;
            while (punt != null)
            {
                if (punt.get_Edad() > mayor)
                {
                    mayor = punt.get_Edad();
                }

                punt = punt.get_enlace();//que recorra nodo en nodo hazta que llegue en nulll

            }
            return mayor;
        }

        public void Ordenamiento()
        {
            Nodo punt = cabeza;//iterador i 
          //  Nodo aux = new Nodo();
            Nodo j =new Nodo();
            int aux;
            string aux2;
            while(punt  != null)
            { 
                //inicializo mi
                j = punt.get_enlace(); //nuevo nodo va inicializar un nodo mas
                //adelante que el otro
                while(j != null )
                {
                   
                    if (punt.get_Edad() > j.get_Edad())
                    {
                        aux = punt.get_Edad();
                        aux2 = punt.get_nombre();
                        punt.set_Edad(j.get_Edad());
                        punt.set_Nombre(j.get_nombre());
                        j.set_Edad(aux);
                        j.set_Nombre(aux2);
                        
                    }
                    j=j.get_enlace();
                }
                punt = punt.get_enlace();
            }
        }
        //ordenamiento com cadenas
        public void Ordenamiento_Cad()
        {
            Nodo punt = cabeza;//iterador i 
            // Nodo aux = new Nodo();
            int aux;
            string aux2;
            Nodo j = new Nodo();
            while (punt != null)
            {
                //inicializo mi
                j = punt.get_enlace();
                while (j != null)
                {

                    if (punt.get_nombre().CompareTo(j.get_nombre()) > 0)
                    {
                        aux = punt.get_Edad();
                        aux2 = punt.get_nombre();
                        punt.set_Edad(j.get_Edad());
                        punt.set_Nombre(j.get_nombre());
                        j.set_Edad(aux);
                        j.set_Nombre(aux2);
                    }
                    j = j.get_enlace();
                }
                punt = punt.get_enlace();
            }
        }


        //buscamo si existe o no 
        public bool Buscar(string BusNom)
        {
            Nodo punt = cabeza;
            while(punt != null)
            {
                if (punt.get_nombre() == BusNom)
                {
                    return true;
                }
                punt = punt.get_enlace();
            }
            return false;
            //usa una sola direccioon de memoria del static 
        }

        public Nodo Modificar2(string BusNom , int edad)
        {        
            Nodo punt = cabeza;
            while (punt != null)
            {
                if (punt.get_nombre() == BusNom)
                {
                    punt.set_Edad(edad);
                    return punt;//retorna la direccin del Nodo o  del nombre  para ubicarse
                }
                punt = punt.get_enlace();
            }
            return punt;//retorna NULL si no existe 
            //usa una sola direccioon de memoria del static 
        }
        public Nodo Modificar(string BusNom)
        {
            Nodo punt = cabeza;
            while (punt != null)
            {
                if (punt.get_nombre() == BusNom)
                {
                    
                    return punt;//retorna la direccin del Nodo o  del nombre  para ubicarse
                }
                punt = punt.get_enlace();
            }
            return punt;//retorna NULL si no existe 
            //usa una sola direccioon de memoria del static 
        }
        //eleminacion por nombre 
        

        //Insertar de inicio
        public void InsertarInicio(int edad,string nom)
        {
            Nodo punt = cabeza;
            Nodo nuevo;
            
            while (punt == null)
            {
                if (punt == null)
                {
                       

                }
                punt = punt.get_enlace();
            }
        }
        //Insertar Nodo final
       public void InsertarFinal(string nom , int edad)
        {
            Nodo punt = cabeza;
            if (punt.get_enlace() == null)//estamos en el ultimo
            {
                punt = nuevo;
                punt = punt.get_enlace();

            } else
                while (punt != null)
                {
                    nuevo.set_Edad(edad);
                    nuevo.set_Nombre(nom);

                }
            punt = punt.get_enlace();
          }
        
       /* public void InsertarPosicion(int edad)
        {
            Nodo punt = cabeza;
            Nodo punt2 = punt.get_enlace();
            while( punt != null)
            {
                if (edad < punt.get_Edad())
                {
                    punt.set_enlace(nuevo);
                    nuevo.set_enlace(punt2);
                }
               punt =  punt.get_enlace();
            }

        }*/




    }
}
