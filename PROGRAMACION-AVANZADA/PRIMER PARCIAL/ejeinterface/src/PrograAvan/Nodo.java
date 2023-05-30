package PrograAvan;

import java.io.Serializable;

public class Nodo <T> implements Serializable {
    //para no cambiar la lista , lo unico que cambia es el tipo de dato  item va ser T  para ser generico
    //T --> va ser generico para los atributos
    public T item;
    public Nodo enlace ;
}
