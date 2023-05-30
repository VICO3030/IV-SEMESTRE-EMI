using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class Arbol
    {
        nodo raiz, nuevo, aux;
        public Arbol()
        {
            raiz = null;
            nuevo = null;
            aux = null;
        }
        public void crear_nodo(int d)
        {
            nuevo = new nodo();
            nuevo.Dato = d;
        }
        public nodo get_Raiz()
        {
            return raiz;
        }
        public void agregar(int d,nodo aux)
        {
            if (raiz==null)
            {
                crear_nodo(d);
                raiz = nuevo;
            }
            else
            {
                if(d>aux.Dato)
                {
                    if(aux.Der!=null)
                    {
                        agregar(d, aux.Der);
                    }
                    else
                    {
                        crear_nodo(d);
                        aux.Der = nuevo;
                    }
                }
                else
                {
                    if(aux.Iz!=null)
                    {
                        agregar(d, aux.Iz);
                    }
                    else
                    {
                        crear_nodo(d);
                        aux.Iz = nuevo;
                    }
                }
            }
        }
        public void buscar_elim(int dato,ref nodo ant, ref nodo actual)
        {
            if(actual!=null)
            {
                if(actual.Dato!=dato)
                {
                    ant = actual;
                    if(dato>actual.Dato)
                    {
                        actual = actual.Der;
                        buscar_elim(dato,ref ant,ref actual);
                    }
                    else
                    {
                        actual = actual.Iz;
                        buscar_elim(dato, ref ant, ref actual);
                    }
                }
            }
        }
        public bool buscar(int dato, nodo arbol,ref int c)
        {
            if (arbol != null)
            {
                if(arbol.Dato==dato)
                {
                    return true;
                }
                else
                {
                    if(dato>arbol.Dato)
                    {
                        c++;
                        Estatica.C.encolar(arbol);
                        return buscar(dato, arbol.Der,ref c);
                    }
                    else
                    {
                        c++;
                        Estatica.C.encolar(arbol);
                        return buscar(dato, arbol.Iz, ref c);
                    }
                }
            }
            else
            {
                return false;
            }
        }
        public void elim_2_hijos(nodo actual,nodo borrar,nodo ant)
        {
            if(borrar.Der!=null)
            {
                elim_2_hijos(actual, borrar.Der,borrar);
            }
            else
            {
                actual.Dato = borrar.Dato;
                if (borrar.Iz != null)
                {
                    elim_1_hijo(borrar, ant);
                }
                else
                {
                    elim_hoja(ant, borrar);
                }
            }
        }
        public void elim_hoja(nodo ant,nodo actual)
        {
            if (ant.Dato < actual.Dato)
            {
                ant.Der = null;
            }
            else
            {
                ant.Iz = null;
            }
        }
       public void elim_1_hijo(nodo actual,nodo ant)
        {
            nodo aux;

            if (actual.Der != null)
            {
                aux = actual.Der;

            }
            else
            {
                aux = actual.Iz;


            }
            if (ant.Der == actual)
            {
                ant.Der = null;
                actual.Der = null;
                ant.Der = aux;
            }
            else
            {
                ant.Iz = null;
                actual.Der = null;
                ant.Iz = aux;
            }
        }
        public bool eliminar(int num)
        {
            nodo ant=null, actual=raiz;
            buscar_elim(num, ref ant, ref actual);
            if(actual!=null && actual.Iz==null && actual.Der==null)
            {
                elim_hoja(ant, actual);
                return true;
            }
            else
            {
                if (actual != null && (actual.Iz != null && actual.Der == null) || (actual.Iz == null && actual.Der != null))
                {
                    elim_1_hijo(actual,ant);
                    return true;

                }
                else
                {
                    if(actual!=null && actual.Der!=null && actual.Iz!=null)
                    {
                        elim_2_hijos(actual, actual.Iz, actual);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                
            }


        }

        public void nivelmax(nodo r, int num, ref int a)
        {

            if (r.Iz != null)
            {
                nivelmax(r.Iz, num + 1, ref a);
            }
            if (r.Der != null)
            {
                nivelmax(r.Der, num + 1, ref a);
            }
            if (num > a) a = num;
        }
        public int altura(int num)
        {
            int nMax = 0;
            nivelmax(raiz, 0, ref nMax);
            return nMax - nivel(num);
        }
        public int nivel(int num)
        {
            nodo r = raiz;
            int cont = 0;
            while (true)
            {
                if (num == r.Dato)
                {

                    return cont;
                }
                if (r.Dato > num)
                {

                    r = r.Iz;
                    cont++;
                }
                if (r.Dato < num)
                {

                    r = r.Der;
                    cont++;
                }
                

            }
            return 123456;
        }


    }

}
