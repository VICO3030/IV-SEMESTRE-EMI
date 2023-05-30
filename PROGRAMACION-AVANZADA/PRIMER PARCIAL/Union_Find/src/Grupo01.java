import java.util.Arrays;

public class Grupo01 {
    private int vec[];//creamos el vector
    private int nrogrupos;

    //incializamos el constructor
    public Grupo01(int nodos){
        this.nrogrupos=nodos;//numero dde grupos que vamos a tener
        vec = new int[nodos];

        //llenamos nuestro vector con sus mismos indices
        for(int i= 0  ;i <nodos ; i++){
            vec[i]=i;
        }
    }

    //getters
    public int get_Grupos(int p){
        return vec[p];
    }


    //verificamos si estan conectados
    public boolean conectados (int p , int q){
        return get_Grupos(p)==get_Grupos(q);
    }

    //conectar
    public void conectar(int p , int q){
         if(conectados(p,q)){
             System.out.println("Estan conectados");

        }
         else{
            int n=get_Grupos(p);
            for(int i=0 ; i <vec.length ; i++){
                if(vec[i]==n){
                        vec[i]= get_Grupos(q);
                }
            }
            nrogrupos--;
         }
    }

    //mostramos con un toString
    @Override
    public String toString() {
        return "Grupo01{" +
                "vec=" + Arrays.toString(vec) +
                ", nrogrupos=" + nrogrupos +
                '}';
    }
}
