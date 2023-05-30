import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        int h,m,s;


        System.out.println("INGRESE LA HORA:");
        h=sc.nextInt();
        System.out.println("INGRESE LOS MINUTOS:");
        m=sc.nextInt();
        System.out.println("INGRESE LOS SEGUNDOS:");
        s=sc.nextInt();
        Tiempo t1 =  new Tiempo(h,m,s);
        t1.Mostrar();


    }
}
