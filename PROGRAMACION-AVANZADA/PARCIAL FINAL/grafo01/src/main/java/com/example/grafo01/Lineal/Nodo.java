package com.example.grafo01.Lineal;

import java.io.Serializable;

public class Nodo<T> implements Serializable {
    public T item;
    public Nodo<T> enlace;
}
