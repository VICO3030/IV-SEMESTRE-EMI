import java.util.Arrays;

public class Grupos03 {
    //un vector para ver los tamanos de los vectores
    private int [] padres;
    private int [] tamanos;
    private int num_grupos;


    public Grupos03(int num_grupos) {
        this.num_grupos = num_grupos;
        padres = new int[num_grupos];
        tamanos = new int[num_grupos];
        for(int i=0 ; i<num_grupos ;i++){
            padres[i]=i;
        }
    }

    public int getNum_grupos(int p ){//encontramos al papa cuando la posicion es igual al contenido
        while(p!=  padres[p]){ //hacemos un recorrido
            p= padres[p];
        }
        return p;
    }

    public boolean conectados(int  p  , int q){
        return getNum_grupos(p)== getNum_grupos(q);
    }

    public void conectar(int p,int q ){
        int pId = getNum_grupos(p);
        int qId = getNum_grupos(q);
        if(pId ==qId) return;
        if(tamanos[pId] < tamanos[qId]){
            padres[pId]= qId;
            tamanos[qId] += tamanos[pId];
        }
        else{
            padres[pId]  =  qId;
            tamanos[pId] += tamanos[pId];
        }
        padres[pId] =qId;
        num_grupos--;
    }

    @Override
    public String toString() {
        return "Grupos03{" +
                "padres=" + Arrays.toString(padres) +
                ", num_grupos=" + num_grupos +
                '}';
    }
}
