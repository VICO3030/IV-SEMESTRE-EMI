import java.util.ArrayList;
import java.util.List;

public class Grafo<T> {
    private List<Nodo<T>>  nodos;
    public void addNodo(Nodo<T> n){
        if(nodos ==null){
            nodos=new ArrayList<>();

        }
        nodos .add(n);
    }

    public List<Nodo<T>> getNodos(){
        return  nodos;
    }
    public Nodo<T> getNodoByItem(T item){
        List<Nodo<T>> nodos  = this.getNodos();
        for(Nodo<T> n : nodos){
            if(n.getItem().equals(item)){
                return  n;
            }

        }
        return null;
    }

    //metodo de cuantos recorridos tiene que hacer de un destino a otro
    //cual es el camino mas corto para llegar
    public void Recorrido(Nodo<T> origen  , Nodo<T> destino){
      //  if(origen.getEnlaces()){


      //  }

    }

    @Override
    public String toString() {
        return "\nGrafo{" +
                "nodos=" + nodos +
                '}'+"\n";
    }
}
