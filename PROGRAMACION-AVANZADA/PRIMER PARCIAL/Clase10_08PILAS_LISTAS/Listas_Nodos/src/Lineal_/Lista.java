package Lineal_;

import java.util.Iterator;
import java.util.NoSuchElementException;

public class Lista <T> implements Iterable<T> {
    //interfaz como cuando haciamos en c++ de declarar  , ahora lo que vamos hacer es pvolver familiar T, como una  herencia Iterables
    //template  tipo de dato cualquiera cosa pero que empieze con mayuscula

    private int tam;//atributo de  la lista
    private Nodo cabeza;

 //cponstructor , inicia  lista vacia  (cabeza = null) , con 0 elementos (tam=0)
    public Lista() {
        cabeza=null;
        tam = 0 ;
    }

    public int getTam() {
        return tam;
    }
    //verificar si la lista esta vacia
    public boolean Esta_vacia(){
        return cabeza ==null;
    }
    //el iterador T , podemos hacer algun proceso
    //java nos proporciona una familia , solo tenemos que explicar como va  terminar
    //insercion


    public void Insertar(T dato){
        //copiamos al auxiliar , y al nodo le sobreescribimos
        Nodo antiguo = cabeza; //
        cabeza = new Nodo();//la direcion en antiguo
        cabeza.item = dato;     //la direccion al nuevo item
        cabeza.enlace = antiguo;
        tam++;


    }
    //vamos hacer un recorruido
    public void Mostrar(){
        while (cabeza != null){
            System.out.println(cabeza.item +" " );
            cabeza = cabeza.enlace;

        }
    }
    private Nodo<T> anadir (Nodo <T>x , T item){
        if(x== null){
            x= new Nodo <>();
            x.item = item;
            x.enlace = null;
            tam++;
            return x;
        }
        x.enlace = anadir(x.enlace  ,item);
        return x;
    }


    @Override
    public Iterator<T> iterator() {
        return new Lista_Iterador(cabeza);
    }

    private class Lista_Iterador implements Iterator<T>{
        private Nodo<T> actual;
        public Lista_Iterador(Nodo<T> primero){
            actual = primero;
        }
        //automaticamente lo va manejar Iterator
        @Override
        public boolean hasNext() {
            return actual != null;
        }

        @Override
        //para recorrer entre el proceso
        public T next() {
            if(!hasNext()){
                throw  new NoSuchElementException();
            }
            T items  = actual.item;;
            actual= actual.enlace;
            return items;
        }

        @Override
        public void remove() {
           // Iterator.super.remove();
        }
        //en lista  los perros que tienen 3 vacunas
    }
}
