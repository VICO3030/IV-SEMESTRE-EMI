import Librerias.PrograAvan.Lineal.Ordenamiento;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Ejercicio01 {
    public static void main(String[] args)throws FileNotFoundException {
        Scanner lector  = new Scanner(new File("caso01.txt"));
        //llenamos la cantidad
        int num_atacantes  = lector.nextInt();
        Dectectado[] atacantes = new Dectectado[num_atacantes] ;
        int num_defensa = lector.nextInt();
        Dectectado [] defensa =  new Dectectado[num_defensa];


        String equipo1 = lector.next();
        String equipo2 = lector.next();

        for(int i =0 ; i<num_atacantes ; i++){
            atacantes[i]= new Dectectado();
            atacantes[i].setDistancia(lector.nextInt());
        }

        for( int i=0 ; i<num_atacantes ; i++){
            atacantes[i].setCamiseta(lector.nextInt());
        }
        for(int i= 0  ; i <num_defensa ; i++){
            defensa[i]=  new Dectectado();
            defensa[i].setDistancia(lector.nextInt());
        }
        for( int i=0 ; i<num_defensa ; i++){
            defensa[i].setCamiseta(lector.nextInt());
        }
        Ordenamiento.merge_sort(atacantes);
        Ordenamiento.merge_sort(defensa);
        if(atacantes[0].compareTo((defensa[1]))>0){
            System.out.println("S"+atacantes[0].getCamiseta());
        }else{
            System.out.println("N");
        }



    }
}
