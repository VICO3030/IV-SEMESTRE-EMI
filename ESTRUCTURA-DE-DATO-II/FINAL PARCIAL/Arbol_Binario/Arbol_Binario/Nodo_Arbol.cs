using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arbol_Binario
{
    class Nodo_Arbol
    {
        int dato;
        Nodo_Arbol HijoIzq;
        Nodo_Arbol HijoDere;

        //metodos
        public int altura;
        public int nivel;
        public Rectangle nodo; //para dibujar el nodo del árbol
                               //Variable que definen el tamaño de los círculos que representan los nodos del árbol
        private const int Radio = 30;
        //Variable para el manejo de distancia horizontal
        private const int DistanciaH =80;
        //variable para el manejo de distancia vertical
        private const int DistanciaV = 10;
        //variable para manejar posición eje X 
        private int CoordenadaX;
        //variable para manejar posición eje Y 
        private int CoordenadaY;
        Graphics col;
        public Nodo_Arbol()
        {
            Dato = 0;
            HijoDere = null;
            HijoIzq = null;



        }
        public int Dato
        {
            get
            {
                return dato;
            }

            set
            {
                dato = value;
            }
        }

        public Nodo_Arbol Punt_izq
        {
            get
            {
                return HijoIzq;
            }

            set
            {
                HijoIzq = value;
            }
        }

        public Nodo_Arbol Punt_dere
        {
            get
            {
                return HijoDere;
            }

            set
            {
                HijoDere = value;
            }
        }



        //metodos para dibujar el arbol binario 
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);
            //obtiene la posición del sub-árbol izquierdo
            if (HijoIzq!= null)
            {
                HijoIzq.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if ((HijoIzq!= null) && (HijoDere != null))
            {
                xmin += DistanciaH;
            }
            //si existe nodo derecho y el nodo izquierdo deja un espacio entre ellos
            if (HijoDere != null)
            {
                HijoDere.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if (HijoIzq!= null && HijoDere != null)
                CoordenadaX = (int)((HijoIzq.CoordenadaX + HijoDere.CoordenadaX) / 2);
            else
            if (HijoIzq!= null)
            {
                aux1 = HijoIzq.CoordenadaX;
                HijoIzq.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if (HijoDere != null)
            {
                aux2 = HijoDere.CoordenadaX;
                //no hay nodo izquierdo, centrar en nodo derecho
                HijoDere.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2); xmin += Radio;
            }
        }
        //Función para dibujar las ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if
            (HijoIzq != null)
            // Dibujará rama izquierda
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY,
               HijoIzq.CoordenadaX, HijoIzq.CoordenadaY);
                HijoIzq.DibujarRamas(grafo, Lapiz);
            }
            if
            (HijoDere != null)
            // Dibujará rama derecha
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY,
              HijoDere.CoordenadaX, HijoDere.CoordenadaY);
                HijoDere.DibujarRamas(grafo, Lapiz);
            }
        }
        //Función para dibujar el nodo en la posición especificada
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush
       RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            col = grafo;
            // Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (
           int)(CoordenadaY - Radio / 2), Radio, Radio);
            Rectangle prueba = new Rectangle((int)(CoordenadaX - Radio / 2),
           (int)(CoordenadaY - Radio / 2), Radio, Radio);
            grafo.FillEllipse(encuentro, rect);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);
            // Para dibujar el nombre del nodo, es decir el contenido
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(dato.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY,
           formato);
            //Dibuja los nodos hijos derecho e izquierdo.
            if (HijoIzq!= null)
            {
                HijoIzq.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz,
               encuentro);
            }
            if (HijoDere != null)
            {
                HijoDere.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
        }
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz)
        {
            //Dibuja el contorno del nodo.
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (
           int)(CoordenadaY - Radio / 2), Radio, Radio);
            Rectangle prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY
           - Radio / 2), Radio, Radio);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);
            //Dibuja el nombre
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(dato.ToString(), fuente, RellenoFuente, CoordenadaX, CoordenadaY,
           formato);
        }



        //Verificar altura del árbol
        private static int Alturas(Nodo_Arbol t)
        {
            return t == null ? -1 : t.altura;
        }
        public void encontrado(Nodo_Arbol t)
        {
            Rectangle rec = new Rectangle(t.CoordenadaX, t.CoordenadaY, 40, 40);
        }
    }

 
}
