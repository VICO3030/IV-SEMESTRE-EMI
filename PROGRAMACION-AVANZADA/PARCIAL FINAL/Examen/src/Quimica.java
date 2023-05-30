import java.util.Scanner;

public class Quimica {
    public static void main(String[] args) {
        Scanner pedir =  new Scanner(System.in);
        String linea;
        int i=0 , tam;
        System.out.println("ingrese la  palabra :");
        linea  = pedir.nextLine();
        tam  = linea.length();
        System.out.println(tam);

       while(i<tam){
           char  car ;
           car=linea.charAt(i);
           System.out.print(car);
           i++;
           if(car=='a'||car=='e'||car=='i'||car=='o'||car=='u'){
                i=i+2;
           }

       }

    }
}
