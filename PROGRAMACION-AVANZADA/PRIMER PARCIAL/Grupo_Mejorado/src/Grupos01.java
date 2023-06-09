import java.util.Arrays;

public class Grupos01 {
    private int [] ids;//creamos el vector
    private int num_grupos;//algunas conversiones son importantes de seguir , como estar en mayus

    public Grupos01(int nodos) {
        this.num_grupos = nodos;//numero de grupos va ser el numero de nodos
        ids = new int [nodos];

        for(int i=0 ; i <nodos;i++){
            ids[i]=i;
        }
    }

    //incializamos  donde cada uno va
    public int get_grupos(int p)  {
        return ids[p];
    }
    public boolean conectados (int p  , int q){
        return get_grupos(p)==get_grupos(q);
    }
    public void conectar(int p , int q ){
        if(conectados(p,q)){
            return ;
        }
        int idp = get_grupos(p);
        for( int i=0 ; i<ids.length ; i++){
            if(ids[i] == idp){
                ids[i]= get_grupos(q);
            }
        }
        num_grupos--;
    }

    public int getNum_grupos() {
        return num_grupos;
    }

    @Override
    public String toString() {
        return "Grupos01{" +
                "ids=" + Arrays.toString(ids) +
                ", num_grupos=" + num_grupos +
                '}';
    }
}
