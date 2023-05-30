public class Ejercicio02 {
    public static Long residuo9(String i){
        int n = i.length();//tengo el tamano de la cadena de digitos
        long s =0L;
        for(int j=0 ; j<n ; j++ ){
            s +=(long) (i.charAt(j) - '0');
        }
        return s%9;
    }
}
