using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
namespace Arbol_Binario
{
    class Arbol
    {
        Nodo_Arbol raiz, nuevo;
        public int c;

        public Arbol()
        {
            this.raiz = null;
            this.nuevo = null;
            
        }
        public void Crear_Nodo(int d)
        {
            nuevo = new Nodo_Arbol();
            nuevo.Dato = d;//set
            nuevo.Punt_dere = null;
            nuevo.Punt_izq = null;
            //todos estos son setters
        }
        //creamos el arbol
        public Boolean existe(int busqueda)
        {
            return existe(raiz, busqueda);
        }

        public Boolean existe(Nodo_Arbol n, int busqueda)
        {
            if (n == null)
            {
                return false;
            }
            if (n.Dato == busqueda)
            {
                return true;
            }
            else if (busqueda < n.Dato)
            {
                return existe(n.Punt_izq, busqueda);
            }
            else
            {
                return existe(n.Punt_dere, busqueda);
            }

        }

        public void insertar_Arbol(int dato)
        {
            if (this.raiz == null)
            {
                Crear_Nodo(dato);
                this.raiz = nuevo;
            }
            else
            {
                Nodo_Arbol punt = raiz;
                insertar_nodo(dato, raiz);
            }
        }

        private void insertar_nodo(int dato, Nodo_Arbol punt)
        {
            if (dato < punt.Dato)
            {
                if (punt.Punt_izq == null)
                {
                    Crear_Nodo(dato);
                    punt.Punt_izq = nuevo;
                }
                else
                {
                    insertar_nodo(dato, punt.Punt_izq);
                }
            }
            else
            {
                if (punt.Punt_dere == null)
                {
                    Crear_Nodo(dato);
                    punt.Punt_dere = nuevo;
                }
                else
                {
                    insertar_nodo(dato, punt.Punt_dere);
                }

            }
        }

        public Nodo_Arbol devolver_raiz()
        {
            return raiz;

        }   
        //metodo de eleminar
        public Boolean Eleminar(int dato)
        {
            Nodo_Arbol auxiliar = raiz;
            Nodo_Arbol padre = raiz;
            Boolean esHijoIzq = true;
            while (auxiliar.Dato != dato)
            {
                padre = auxiliar;
                //caso de que sea menor que la raiz
                if (dato < auxiliar.Dato)
                {
                    esHijoIzq = true;
                    auxiliar = auxiliar.Punt_izq;
                }
                else
                {
                    esHijoIzq = false;
                    auxiliar = auxiliar.Punt_dere;
                }
                //otro caso que llego al final y que jamas encontro al nodo que andaba buscando
                if (auxiliar == null)
                {
                    return false;
                }
            }
            //fin del while
            if (auxiliar.Punt_dere == null && auxiliar.Punt_izq == null)//quiere decir que es hoja
            {
                if (auxiliar == raiz)
                {
                    raiz = null;
                }
                else
                {//caso de que es hijo izq
                    if (esHijoIzq)
                    {
                        padre.Punt_izq = null;

                    }
                    else
                    {
                        padre.Punt_dere = null;
                    }
                }
            }
            else
            {
                if (auxiliar.Punt_dere == null)
                {

                    if (auxiliar == raiz)
                    {
                        raiz = raiz.Punt_izq;
                    }
                    else
                    {//caso de que es hijo izq
                        if (esHijoIzq)
                        {
                            padre.Punt_izq = auxiliar.Punt_izq;

                        }
                        else
                        {
                            padre.Punt_dere = auxiliar.Punt_izq;
                        }
                    }
                }
                else
                {
                    if (auxiliar.Punt_izq == null)
                    {
                        if (auxiliar == raiz)
                        {   raiz = raiz.Punt_dere;
                        }
                        else
                        {//caso de que es hijo izq
                            if (esHijoIzq)
                            {
                                padre.Punt_izq = auxiliar.Punt_dere;

                            }
                            else
                            {
                                padre.Punt_dere = auxiliar.Punt_izq;
                            }
                        }

                    }
                    else
                    {
                        Nodo_Arbol reemplazo = obtenerReemplazo(auxiliar);
                        if (auxiliar == raiz)
                        {
                            raiz = reemplazo;

                        }
                        else
                        {
                            if (esHijoIzq)
                            {
                                padre.Punt_izq = reemplazo;

                            }
                            else
                            {
                                padre.Punt_dere = reemplazo;
                            }
                            reemplazo.Punt_izq = auxiliar.Punt_izq;

                        }
                        
                    }
                }


                }
            return true;
        }
        //metodo  encargado de devolvernos el nodo reemplazo
        private Nodo_Arbol obtenerReemplazo(Nodo_Arbol NodoReemp)
        {
            Nodo_Arbol reemplazarPadre = NodoReemp;
            Nodo_Arbol reemplazo = NodoReemp;
            Nodo_Arbol auxiliar = NodoReemp.Punt_dere;
            while (auxiliar != null)
            {
                reemplazarPadre = reemplazo;
                reemplazo = auxiliar;
                auxiliar = auxiliar.Punt_izq;

            }
            //pequena validacion
            if (reemplazo != NodoReemp.Punt_dere)
            {
                reemplazarPadre.Punt_izq = reemplazo.Punt_dere;
                reemplazo.Punt_dere = NodoReemp.Punt_dere;


            }
            return reemplazo;
        }

        
        //metodo para contar hojas
        public Double ContarHoja()
        {
            c = 0;
            Contar_Hoja(raiz);
            return c;

        }

        //metodo de contar hojas 
        private void Contar_Hoja(Nodo_Arbol auxiliar)
        {
            if (auxiliar != null)
            {
                if(auxiliar.Punt_izq==null && auxiliar.Punt_dere == null)
                {
                    c++;
                }
                Contar_Hoja(auxiliar.Punt_izq);
                Contar_Hoja(auxiliar.Punt_dere);
            }
        }

        //metodo de graficar 
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400; // Posiciones de la raíz del árbol
            int y = 75;
            if (raiz == null)
                return;
            raiz.PosicionNodo(ref x, y); //Posición de cada nodo
            raiz.DibujarRamas(grafo, Lapiz); //Dibuja los Enlaces entre nodos
                                             //Dibuja todos los Nodos
            raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }




        public int x1 = 400;
        // Posiciones iniciales de la raíz del árbol
        public int y2 = 75;
        // Función para Colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen
       Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, raiz.Punt_izq, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000);
                    // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, raiz.Punt_dere, post, inor, preor);
                }
            }
            else
            if (preor == true)
            {
                if
                (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000);
                    // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz,raiz.Punt_izq, post,
                     inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, raiz.Punt_dere, post,
                    inor, preor);
                }
            }
            else
            if
            (post == true)
            {
                if
                (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, raiz.Punt_izq, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, raiz.Punt_dere, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }

        public void nivelmax(Nodo_Arbol r, int num, ref int a)
        {

            if (r.Punt_izq != null)
            {
                nivelmax(r.Punt_izq, num + 1, ref a);
            }
            if (r.Punt_dere != null)
            {
                nivelmax(r.Punt_dere, num + 1, ref a);
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
            Nodo_Arbol r = raiz;
            int cont = 0;
            while (true)
            {
                if (num == r.Dato)
                {

                    return cont;
                }
                if (r.Dato > num)
                {

                    r = r.Punt_izq;
                    cont++;
                }
                if (r.Dato < num)
                {

                    r = r.Punt_dere;
                    cont++;
                }


            }
            return 123456;
        }





        public bool buscar(int dato, Nodo_Arbol punt, ref int c)
        {
            if (punt != null)
            {
                if (punt.Dato == dato)
                {
                    return true;
                }
                else
                {
                    if (dato > punt.Dato)
                    {
                        c++;
                        Estatica.C.encolar(punt);
                        return buscar(dato, punt.Punt_dere, ref c);
                    }
                    else
                    {
                        c++;
                        Estatica.C.encolar(punt );
                        return buscar(dato, punt.Punt_izq, ref c);
                    }
                }
            }
            else
            {
                return false;
            }
        }












    }
}

