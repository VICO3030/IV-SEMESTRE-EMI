package com.example.judokas.Modelo;

import com.example.judokas.Modelo.PrograAvan.Lineal.Lista;
import com.example.judokas.Modelo.PrograAvan.NoLineal.ArbolRB;

import java.util.Comparator;
import java.util.Iterator;
import java.util.Spliterator;
import java.util.function.Consumer;

public class Club implements Comparable {
    String nombre;
    String personeria;
    String direccion;
    ArbolRB<Integer, JUDOKA> judokas;
    int num_int;

    public Club(String nombre, String personeria, String direccion) {
        this.nombre = nombre;
        this.personeria = personeria;
        this.direccion = direccion;
        this.judokas = new ArbolRB<Integer, JUDOKA>();
        this.num_int = 0;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getPersoneria() {
        return personeria;
    }

    public void setPersoneria(String personeria) {
        this.personeria = personeria;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public ArbolRB<Integer,JUDOKA> getJudokas() {
        return judokas;
    }
    public void actualizar_num_int(){
        num_int++;
    }

    public void anadir_Judoka(JUDOKA judoka) {
        actualizar_num_int();
        judokas.insertar(num_int,judoka);
    }

    public void mostrar_rango(int min, int max){
        for(int i = min; i<=max; i++){
            System.out.println(judokas.getValorByLlave(i));
        }
    }


    //METODO PARA DEVOLVER TODOS LOS INTEGRANTES DE UNA CATEGORIA DADO UN CLUB
    public Lista<JUDOKA> obtener_cates(String cat){
        Lista<JUDOKA> judcat = new Lista<>();
            int i = judokas.get_tam();
            for(int j = 1; j<= i; j++){
                JUDOKA x = judokas.getValorByLlave(j);
                if(x.getCategoria() == cat){
                    judcat.insertar(x);
                }
            }
            return judcat;
    }

    public void mostrarJudokas()
    {
        judokas.amplitud();
    }

    @Override
    public String toString() {
        return "Club{" +
                "nombre='" + nombre + '\'' +
                ", personeria='" + personeria + '\'' +
                ", direccion='" + direccion + '\'' +
                '}';
    }

    @Override
    public int compareTo(Object o) {
        Club otro = (Club) o;
        if(this.getJudokas().get_tam() > otro.getJudokas().get_tam()) return 1;
        else if(this.getJudokas().get_tam() < otro.getJudokas().get_tam()) return -1;
        return 0;
    }
}
