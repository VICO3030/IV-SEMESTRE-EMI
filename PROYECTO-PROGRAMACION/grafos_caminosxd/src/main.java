import java.util.LinkedList;
import java.util.List;

public class main {
    public static void main(String[] args) {
        boolean xd=false;
        Grafo grafo=new Grafo(xd);
        grafo.agregarArista("A","B",15);
        grafo.agregarArista("B","C",20);
        grafo.agregarArista("A","E",30);
        grafo.agregarArista("E","C",14);
        grafo.agregarArista("A","C",28);
        System.out.println(grafo.dijkstra("A"));

        //todos los caminos de A a C
        System.out.println(grafo.caminos("A","C"));

        //System.out.println(grafo);
    }
}
