package Ejercicio01_Clave;

public class Clave {
    private String grupo;
    private String vec[];
    private int total;
    private int tam;

    public Clave(String grupo) {
        this.grupo = grupo;
        total=0;
        tam=0;
        vec= grupo.split(" ");
    }
    public static int Suma( String m,int n){
        int a1,sum=0;
        for(int j=0 ;j<m.length() ; j++){
            a1 = m.charAt(j) -65;
            sum = sum + a1 + n+ j;
        }
        return sum;
    }
    public static void Mostrar(String vec[] , int tam){
        int total=0;
        for(int i =  0 ; i<vec.length;i++){
            total = Suma(vec[i],tam) + total;
            tam++;
        }
        System.out.println("La cantidad  total es de : "+total);

    }



}
