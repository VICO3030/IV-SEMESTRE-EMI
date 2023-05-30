package union_find;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {
        Scanner lector = new Scanner (new File("casoUF02.txt"));
        int tam;
        //
        tam=lector.nextInt();
          int a ;
        int  b ;
        grupos mostrar = new grupos(tam);
        
        System.out.println(mostrar.conectados(9,1));
        System.out.println("Numero grupos :"+mostrar.get_num_grupos());
        //creamos el cronometro
        Cronometro timer= new Cronometro();

        while(lector.hasNext()){
         a = lector.nextInt();
         b = lector.nextInt();
         mostrar.conectar(a,b);
        }
        //el tiempo que se tarda een ver ele texto en la cantenacion
        System.out.println("impresion de la compilacion :"+timer.get_tiempo());


        System.out.println(mostrar.conectados(9, 1));
        System.out.println("Numero grupos :"+mostrar.get_num_grupos());

        //hacer el papa del bichoooo 
    }
    
}
