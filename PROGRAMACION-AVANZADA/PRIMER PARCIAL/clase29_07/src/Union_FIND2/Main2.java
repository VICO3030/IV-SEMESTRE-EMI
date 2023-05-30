
package Union_FIND2;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import union_find.Cronometro;
import union_find.grupos;

public class Main2 {
    public static void main(String[] args) throws FileNotFoundException {
        
        Scanner lector = new Scanner (new File("casoUF01.txt"));
        int tam;
        //
      
        int a ;
        int b;
        tam=lector.nextInt();
        Grupo02 mostrar = new Grupo02(tam);
        Cronometro timer= new Cronometro();

        //creamos el cronometro 
        

        while(lector.hasNext()){
         a = lector.nextInt();
         b = lector.nextInt();
         mostrar.conectar(a,b);
        }
        //el tiempo que se tarda een ver ele texto en la cantenacion
        System.out.println("impresion de la compilacion :"+timer.get_tiempo());


        System.out.println(mostrar.conectados(9, 1));
        System.out.println("Numero grupos :"+mostrar.getNum_grupos());

        //hacer el papa del bichoooo 
    }
}
