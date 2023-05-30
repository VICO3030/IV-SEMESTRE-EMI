import java.util.Arrays;

public class Grupo02 {
    private int [] padres ;//ya no vana ser ids sino vana ser los papas
    //pero en la comprension del algoritmo por eso ponemos padres
    private int num_grupos;

    public Grupo02(int num_grupos) {

        this.num_grupos = num_grupos;
        padres= new int [num_grupos];
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
        if(pId == qId){
            return;
        }
        padres[pId] =qId;
        num_grupos--;
    }

    @Override
    public String toString() {
        return "Grupo02{" +
                "padres=" + Arrays.toString(padres) +
                ", num_grupos=" + num_grupos +
                '}';
    }
}
