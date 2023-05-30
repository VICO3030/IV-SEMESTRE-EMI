package Lineal_;

import java.util.Iterator;
import java.util.NoSuchElementException;

public class Cola <T> implements  Iterable<T>{
    //TEMPLEATE T  hay en c++ , facilitaba el orientado a objetos
    private T item;
    private Nodo<T> ultimo;
    private Nodo<T> primero;
    private int tam;

    public Cola() {
        primero = null;
        ultimo = null;
        tam=0;
    }

    public boolean Esta_vacio(){
        return primero ==null;
    }

    public void Encolar(T item){
        //personajes , y todos son de la familia personaje
        Nodo<T> ultimo_anterior = ultimo;
        ultimo=new Nodo();
        ultimo.item = item;
        ultimo.enlace = null;

        if(Esta_vacio()){
            primero=ultimo;
        }
        else{
            ultimo_anterior.enlace = ultimo;
        }
        tam++;
    }

    public T Desencolar(){
        if(Esta_vacio()){
            throw new NoSuchElementException("ERROR COLA ESTA VACIA !!!");
        }
        T result = primero.item;
        primero = primero.enlace;
        tam--;
        if(Esta_vacio()){
            ultimo = null;
        }
        return result;
    }
//miyagui d
    @Override
    public Iterator<T> iterator(){
        return new ListIterator(primero);
    }

    private class ListIterator implements Iterator<T> {
        private Nodo<T> actual;

        @Override
        public void remove() {
            Iterator.super.remove();
        }
        public ListIterator(Nodo<T> actual) {
            this.actual = actual;
        }
         /*   @Override
        public void forEachRemaining(Consumer<? super T> action) {
            Iterator.super.forEachRemaining(action);
        }*/

        @Override
        public boolean hasNext() {
            return actual != null;
        }

        @Override
        public T next() {
            if (!hasNext()){
                throw new NoSuchElementException("no hay elementos");
            }
            T d = actual.item;
            actual = actual.enlace;
            return d;
        }
    }
    @Override
    public String toString() {
        StringBuilder cad = new StringBuilder();    //constructor de cuerdas
        for (T d : this){
            cad.append(d);
            cad.append(" ");
        }
        return cad.toString();
    }
}

