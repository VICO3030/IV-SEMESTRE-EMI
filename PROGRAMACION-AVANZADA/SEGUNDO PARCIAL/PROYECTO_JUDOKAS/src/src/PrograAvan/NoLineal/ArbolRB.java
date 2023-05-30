package PrograAvan.NoLineal;

import PrograAvan.Lineal.Cola;
import PrograAvan.Lineal.Pila;

public class ArbolRB<Llave extends Comparable<Llave>, Valor> {
    private static final boolean ROJO = true;
    private static final boolean NEGRO = false;
    private Nodo raiz;
    private Pila<Nodo> p ;
    private Cola<Nodo> c;
    private class Nodo {
        private Llave llave;
        private Valor valor;
        private Nodo izq, der;
        private boolean color;


        private int tam;

        public Nodo(Llave llave, Valor val, boolean color, int size) {
            this.llave = llave;
            this.valor = val;
            this.color = color;
            this.tam = size;
            p=new Pila<>();
            c= new Cola<>();
        }
    }

    public ArbolRB() {
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
            if (cmp < 0) x = x.izq;
            else if (cmp > 0) x = x.der;
            else return x.valor;
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
        if (cmp < 0) x.izq = insertar(x.izq, llave, val);
        else if (cmp > 0) x.der = insertar(x.der, llave, val);
        else x.valor = val;

        if (es_rojo(x.der) && !es_rojo(x.izq)) x = rotarIzquierda(x);
        if (es_rojo(x.izq) && es_rojo(x.izq.izq)) x = rotarDerecha(x);
        if (es_rojo(x.izq) && es_rojo(x.der)) cambiar_color(x);
        x.tam = get_tam(x.izq) + get_tam(x.der) + 1;

        return x;
    }
    /*********************** rotaciones *****************************************************/

    private Nodo rotarDerecha(Nodo x) {
        // assert (h != null) && isRed(h.left);
        Nodo aux = x.izq;
        x.izq = aux.der;
        aux.der = x;
        aux.color = aux.der.color;
        aux.der.color = ROJO;
        aux.tam = x.tam;
        x.tam = get_tam(x.izq) + get_tam(x.der) + 1;
        return aux;
    }

    private Nodo rotarIzquierda(Nodo x) {
        Nodo aux = x.der;
        x.der = aux.izq;
        aux.izq = x;
        aux.color = aux.izq.color;
        aux.izq.color = ROJO;
        aux.tam = x.tam;
        x.tam = get_tam(x.izq) + get_tam(x.der) + 1;
        return aux;
    }

    private void cambiar_color(Nodo x) {
        x.color = !x.color;
        x.izq.color = !x.izq.color;
        x.der.color = !x.der.color;
    }

    private Nodo rojo_a_izquierda(Nodo x) {
        cambiar_color(x);
        if (es_rojo(x.der.izq)) {
            x.der = rotarDerecha(x.der);
            x = rotarIzquierda(x);
            cambiar_color(x);
        }
        return x;
    }

    private Nodo rojo_a_derecha(Nodo x) {
        cambiar_color(x);
        if (es_rojo(x.izq.izq)) {
            x = rotarDerecha(x);
            cambiar_color(x);
        }
        return x;
    }

    private Nodo balancear(Nodo x) {
        if (es_rojo(x.der)) x = rotarIzquierda(x);
        if (es_rojo(x.izq) && es_rojo(x.izq.izq)) x = rotarDerecha(x);
        if (es_rojo(x.izq) && es_rojo(x.der)) cambiar_color(x);
        x.tam = get_tam(x.izq) + get_tam(x.der) + 1;
        return x;
    }

    //DOS TIPOS PARA MOSTRAR  ---> AMPLITUD  , PROFUNDIDAD
    //metodos de mostrar como metodo normal para que despues sea iterable
    public void Profuncidad(){
        Nodo aux;
        p.empilar(raiz);
        while (!p.esta_vacia()){
            aux= p.desempilar();
            System.out.println("\t"+aux.llave);
            if(aux.izq!=null)
                p.empilar(aux.izq);
            if(aux.der !=  null)
                p.empilar(aux.der);
        }
    }
    public void Balanceado(){
        Nodo aux;
        c.encolar(raiz);
        while (!c.esta_vacio()){
            aux = c.desencolar();
            System.out.println("\t"+aux.llave);
            if(aux.izq!=null) c.encolar(aux.izq);
            if(aux.der!= null) c.encolar(aux.der);
        }

    }
}