import java.util.ArrayList;
import java.util.List;
public class Nodo<T> {
    private T  item;//tipo de dato que thay ya sea String  , Integer  , DOuble etc ,

    //list  llava utin
    private List<Arista<T>> enlaces ; //una lista de enlaces

    public Nodo(T item) {
        this.item = item;
    }
    //solo con el item

    //getters y Setter de     los atributos
    public T getItem() {
        return item;
    }

    public void setItem(T item) {
        this.item = item;
    }

    public List<Arista<T>> getEnlaces() {
        return enlaces;
    }

    public void setEnlaces(List<Arista<T>> enlaces) {
        this.enlaces = enlaces;
    }
    //terminacion de los getter y setters



    //vamos hacer como un conectar  , aqui lo que vamos hacer es anadir las aristas los enlaces por si  acaso
    public void add_enlace(Arista<T> a){//los parametro son Arista(origen  ,  destino , costo)
        if(enlaces==null){
            enlaces = new ArrayList<>();//albergando los nodos
        }
        //luefgo se ha instanciado anado
        enlaces.add(a);
    }
    //va mostrar las lista que tengo nuestro contenido
    @Override
    public String toString() {
        return "\n{" +
                "item=" + item +
                ", enlaces=" + enlaces +
                '}'+"\n";
    }
}
