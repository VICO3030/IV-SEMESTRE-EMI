public class Ejercicio03 {

    public static int multiplos(int mini , int maxi , int factor){
        int cont=0;
        for(int i =  mini ; i<=maxi ; i++){
            if(factor% i ==0){
                cont++;
            }
        }
        return cont;
    }
}
