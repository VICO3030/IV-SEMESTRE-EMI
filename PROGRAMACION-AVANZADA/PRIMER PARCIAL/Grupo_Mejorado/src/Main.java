import java.io.File;
import java.util.Scanner;
import java.io.FileNotFoundException;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {
 /*       Grupos01 g1 = new Grupos01(10);
        System.out.println(g1);//mostramos los grupos

        g1.conectar(3,8);
        g1.conectar(0,7);
        System.out.println("---------------------------");
        System.out.println(g1);
        g1.conectar(0,8);
        System.out.println("------------------------------=");
        System.out.println(g1);*/

       Grupo02 g1 = new Grupo02(10);
        System.out.println(g1);//mostramos los grupos

        g1.conectar(3,8);
        g1.conectar(0,7);
        System.out.println("---------------------------");
        System.out.println(g1);
        g1.conectar(0,8);
        System.out.println("------------------------------=");
        System.out.println(g1);





      /*  Scanner lector = new Scanner(new File("CasoUF01.txt"));
        Grupos03 g1= new Grupos03(lector.nextInt());

        while(lector.hasNext()){
            g1.conectar(lector.nextInt()  , lector.nextInt());
        }
        System.out.println(g1);
*/
    }


}
