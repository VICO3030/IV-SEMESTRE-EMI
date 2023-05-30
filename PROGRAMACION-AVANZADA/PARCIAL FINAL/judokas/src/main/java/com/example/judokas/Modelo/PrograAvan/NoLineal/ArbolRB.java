package com.example.judokas.Modelo.PrograAvan.NoLineal;

import com.example.judokas.Modelo.PrograAvan.Lineal.Cola;
import com.example.judokas.Modelo.PrograAvan.Lineal.Pila;

public class ArbolRB<Llave extends Comparable<Llave>, Valor> {
    private static final boolean ROJO = true;
    private static final boolean NEGRO = false;
    private Nodo raiz;
    private Pila<Nodo> p ;
    private Cola<Nodo> c ;

    public class Nodo {
        public Llave llave;
        public Valor valor;
        private Nodo izquierda, derecha;
        private boolean color;
        private int tam;

        public Nodo(Llave llave, Valor val, boolean color, int size) {
            this.llave = llave;
            this.valor = val;
            this.color = color;
            this.tam = size;

        }

        @Override
        public String toString() {
            return "Nodo{" +
                    "llave=" + llave +
                    ", valor=" + valor +
                    '}';
        }
    }

    public ArbolRB() {
        c=new Cola<>();
        p=new Pila<>();
    }

    private boolean es_rojo(Nodo x) {
        if (x == null) return false;
        return x.color == ROJO;
    }

    private int get_tam(Nodo x) {
        if (x == null) return 0;
        return x.tam;
    }

    public int get_tam() {
        return get_tam(raiz);
    }

    public boolean es_vacio() {
        return raiz == null;
    }


    /*********************** rutinas arbol ***********/
    public Valor getValorByLlave(Llave llave) {
        return getValorByLlave(raiz, llave);
    }

    private Valor getValorByLlave(Nodo x, Llave llave) {
        while (x != null) {
            int cmp = llave.compareTo(x.llave);
            if (cmp < 0) x = x.izquierda;
            else if (cmp > 0) x = x.derecha;
            else return x.valor;
        }
        return null;
    }

    public Nodo getNodoByLlave(Llave llave) {
        return getNodoByLlave(raiz, llave);
    }

    private Nodo getNodoByLlave(Nodo x, Llave llave) {
        while (x != null) {
            int cmp = llave.compareTo(x.llave);
            if (cmp < 0) x = x.izquierda;
            else if (cmp > 0) x = x.derecha;
            else return x;
        }
        return null;
    }

    public boolean contiene(Llave llave) {
        return getValorByLlave(llave) != null;
    }

    /***************** INSERTAR ***************************************/
    public void insertar(Llave llave, Valor val) {
        raiz = insertar(raiz, llave, val);
        raiz.color = NEGRO;
    }

    private Nodo insertar(Nodo x, Llave llave, Valor val) {
        if (x == null) return new Nodo(llave, val, ROJO, 1);

        int cmp = llave.compareTo(x.llave);
        if (cmp < 0) x.izquierda = insertar(x.izquierda, llave, val);
        else if (cmp > 0) x.derecha = insertar(x.derecha, llave, val);
        else x.valor = val;

        if (es_rojo(x.derecha) && !es_rojo(x.izquierda)) x = rotarIzquierda(x);
        if (es_rojo(x.izquierda) && es_rojo(x.izquierda.izquierda)) x = rotarDerecha(x);
        if (es_rojo(x.izquierda) && es_rojo(x.derecha)) cambiar_color(x);
        x.tam = get_tam(x.izquierda) + get_tam(x.derecha) + 1;

        return x;
    }

    /*********************** rotaciones *****************************************************/

    private Nodo rotarDerecha(Nodo x) {
        // assert (h != null) && isRed(h.left);
        Nodo aux = x.izquierda;
        x.izquierda = aux.derecha;
        aux.derecha = x;
        aux.color = aux.derecha.color;
        aux.derecha.color = ROJO;
        aux.tam = x.tam;
        x.tam = get_tam(x.izquierda) + get_tam(x.derecha) + 1;
        return aux;
    }

    private Nodo rotarIzquierda(Nodo x) {
        Nodo aux = x.derecha;
        x.derecha = aux.izquierda;
        aux.izquierda = x;
        aux.color = aux.izquierda.color;
        aux.izquierda.color = ROJO;
        aux.tam = x.tam;
        x.tam = get_tam(x.izquierda) + get_tam(x.derecha) + 1;
        return aux;
    }

    private void cambiar_color(Nodo x) {
        x.color = !x.color;
        x.izquierda.color = !x.izquierda.color;
        x.derecha.color = !x.derecha.color;
    }

    private Nodo rojo_a_izquierda(Nodo x) {
        cambiar_color(x);
        if (es_rojo(x.derecha.izquierda)) {
            x.derecha = rotarDerecha(x.derecha);
            x = rotarIzquierda(x);
            cambiar_color(x);
        }
        return x;
    }

    private Nodo rojo_a_derecha(Nodo x) {
        cambiar_color(x);
        if (es_rojo(x.izquierda.izquierda)) {
            x = rotarDerecha(x);
            cambiar_color(x);
        }
        return x;
    }

    private Nodo balancear(Nodo x) {
        if (es_rojo(x.derecha)) x = rotarIzquierda(x);
        if (es_rojo(x.izquierda) && es_rojo(x.izquierda.izquierda)) x = rotarDerecha(x);
        if (es_rojo(x.izquierda) && es_rojo(x.derecha)) cambiar_color(x);
        x.tam = get_tam(x.izquierda) + get_tam(x.derecha) + 1;
        return x;
    }

    public Nodo get_nodo_by_llave_anterior(Llave l){
        return get_nodo_by_llave_anterior(raiz,l);
    }

    public Nodo get_nodo_by_llave_anterior(Nodo x, Llave l){
        if(x == null){
            return null;
        }
        int cmp = l.compareTo(x.llave);
        if(cmp<0){
            if(x.izquierda.llave == l){ return x;}
            return getNodoByLlave(x.izquierda, l);
        }
        else if(cmp > 0){
            if(x.derecha.llave == l) return x;
            return getNodoByLlave(x.derecha, l);

        }
        else return null;
    }

    public void eliminar_nodo_by_llave(Llave l){
        // EL METODO ELIMINA EN BASE A LA LLAVE DEL NODO

        Nodo e = get_nodo_by_llave_anterior(l);

        // RECUPERAMOS EL NODO ANTERIOR AL QUE QUEREMOS ELIMINAR PARA TENER LOS ENLACES

        Nodo aux;

        //  EL NODO AUXILIAR TOMA EL VALOR DEL NODO QUE QUEREMOS ELIMINAR

        if(e.izquierda.llave == l){
            aux = e.izquierda;
            if(aux.izquierda == null){
                e.izquierda = aux.derecha;
                // SI EL LADO IZQUIERDO DEL NODO QUE QUEREMOS ELIMINAR ESTA VACIO
                // ENTONCES SE CONECTA DIRECTAMENTE CON EL DERECHO EL NODO ANTERIOS
            }
            else{
                // SI LOS 2 LADOS TIENEN CONECCIONES

                e.izquierda = aux.derecha;
                // EL LADO IZQUIERDO DEL NODO ANTERIOR TOMA EL VALOR DEL LADO DERECHO, PORQUE ES EL MAYOR
                Nodo aux2 = aux.izquierda;
                while(e.izquierda!= null){
                    e = e.izquierda;
                }
                e.izquierda = aux2;
            }
        }
        else{
            aux = e.derecha;
            if(aux.derecha == null){
                e.derecha = aux.izquierda;

                // SI EL LADO DERECHO DEL NODO QUE QUEREMOS ELIMINAR ESTA VACIO
                // ENTONCES SE CONECTA DIRECTAMENTE CON EL IZQUIERDO EL NODO ANTERIOS

            }
            else{

                // SI LOS 2 LADOS TIENEN CONECCIONES

                e.derecha = aux.izquierda;

                // EL LADO DERECHO DEL NODO ANTERIOR TOMA EL VALOR DEL LADO IZQUIERDO, PORQUE ES EL MENOR

                Nodo aux2 = aux.derecha;
                while(e.derecha != null){
                    e = e.derecha;
                }
                e.derecha = aux2;
            }
        }
    }


    public void profundidad(){

        Nodo aux;
        p.empilar(raiz);
        while(!p.esta_vacia())
        {
            aux=p.desempilar();
            System.out.println(aux.valor + " { Id: " + aux.llave + " } ");
            if(aux.izquierda!=null) p.empilar(aux.izquierda);
            if(aux.derecha!=null) p.empilar(aux.derecha);
        }
    }
    public void amplitud()
    {
        Nodo aux;
        c.encolar(raiz);
        while(!c.esta_vacio())
        {
            aux=c.desencolar();
            if(aux != null) {
                System.out.println( aux.valor + " { Id: " + aux.llave + " } ");
                if(aux.izquierda!=null) c.encolar(aux.izquierda);
                if(aux.derecha!=null) c.encolar(aux.derecha);
            }
        }
    }

    @Override
    public String toString() {
        return "ArbolRB{" +
                "raiz=" + raiz+
                '}';
    }
}