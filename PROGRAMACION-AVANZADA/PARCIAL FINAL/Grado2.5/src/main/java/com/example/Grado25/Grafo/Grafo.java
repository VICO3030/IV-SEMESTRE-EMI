package com.example.Grado25.Grafo;





import com.example.Grado25.Lineal.Lista;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.PriorityQueue;
import java.util.Queue;
import java.util.Scanner;

public class Grafo {
    private int vertice ;
    private int enlaces;
    private Lista<Arista>[] conexion;//listas de  aristas
    private int [] vienenn;//quienes estan conectados

    //solo vamos hacer la llamada de los verticces
    public Grafo(int vertice) {
        this.vertice = vertice;
        this.enlaces = 0;
        this.vienenn = new int [vertice];//incializamos el vector de lo vertices
        conexion = new Lista[vertice];

        for(int  i=0  ;i <vertice ; i++){
            conexion[i] =  new Lista<>();

        }
        //conexion de las listas

    }
    //insertr al Grafo
    public Grafo(Grafo g ){
        this(g.vertice);
        this.enlaces = g.enlaces;
        //llamamos al vector
        //un grafo de otro grafo estamos creando  , referencia las direcciones
        for(int  i = 0  ; i <g.vertice ; i++){
            this.vienenn[i] = g.vienenn[i];
        }
        //copiamos los vertices
        for(int  j= 0 ; j<g.vertice ; j++){
            Lista <Arista>  l =  new Lista<>();
            //para cada uno se creara la pila
            for(Arista a : g.conexion[j]){
                //en la pila se va ir guardand o  , para que no se invierta
                l.insertar(a);
            }
        }
    }

    //public
    public void addArista(Arista a ){
        int o =  a.getOrigen();
        int d =  a.getDestino();
        conexion[o].insertar(a);//estamos incertando
        vienenn[d]++;
        enlaces++;
    }

    public int getVertice() {
        return vertice;
    }

    public void setVertice(int vertice) {
        this.vertice = vertice;
    }

    public int getEnlaces() {
        return enlaces;
    }

    public void setEnlaces(int enlaces) {
        this.enlaces = enlaces;
    }

    public Lista<Arista>[] getConexion() {
        return conexion;
    }

    public void setConexion(Lista<Arista>[] conexion) {
        this.conexion = conexion;
    }

    public int[] getVienenn() {
        return vienenn;
    }

    public void setVienenn(int[] vienenn) {
        this.vienenn = vienenn;
    }

    @Override
    public String toString() {
        StringBuilder  e  =  new StringBuilder();//clase facilmente que te va permitir anadir
        e.append(this.vertice + " " +this.enlaces +"\n");
        for(int i= 0 ; i <this.vertice ; i++){
            e.append(i+" : ");
            for(Arista  a : conexion[i]){
                e.append(a+" ");
            }
            e.append("\n");
        }

        return (e.toString());
    }

    public static void main(String[] args) throws FileNotFoundException {
        Queue<Integer>  cp  = new PriorityQueue<>();
        Scanner  lector  =  new Scanner(new File("grafo01.txt"));
        Grafo  g  = new Grafo(8);
        while(lector.hasNext()){
            g.addArista(new Arista(lector.nextInt() , lector.nextInt(), lector.nextDouble()));
        }
        System.out.println(g);
       /* cp.add(98);
        cp.add(1);
        cp.add(8);
        cp.add(20);
        cp.add(11);
        while(!cp.isEmpty()){
            System.out.println(cp.poll());
        }*/



    }

}
