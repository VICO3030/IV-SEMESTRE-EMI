import java.util.Arrays;

public class Grupo02 {
    private int[] padres;
    private int cantidad_grupos;

    //constructor inicializamos
    public Grupo02(int num){
        this.cantidad_grupos=num;
        padres = new int[num];

        //llenamos en el vector con sus mismo indices
        for(int i=0 ;i<cantidad_grupos ; i++){
            padres[i]=i;
        }
    }
    //encontramos el papa de la posicion cuando v[1]=1 sabremos que es el papa
    public int getCantidad_grupos(int p){
        while(p!= padres[p]){
            p=padres[p];
        }
        return p ;
    }
    //vemos si estamos conectados
    public boolean conectados(int p , int q){
        return getCantidad_grupos(p)==getCantidad_grupos(q);
    }
    //conectamos los numeros
    public void conectar(int p  ,int q){
        int pId = getCantidad_grupos(p);
        int qId = getCantidad_grupos(q);
        if(pId == qId){
            System.out.println("Esta conectados :"+p+" y"+q);
        }
        else{
            padres[pId]= qId;
            cantidad_grupos--;
        }

    }
    @Override
    public String toString() {
        return "Grupo02{" +
                "padres=" + Arrays.toString(padres) +
                ", cantidad_grupos=" + cantidad_grupos +
                '}';
    }
}
