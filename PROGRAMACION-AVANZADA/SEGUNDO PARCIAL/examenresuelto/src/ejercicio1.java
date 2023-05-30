import PrograAvan.Lineal.Ordenamiento;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;


public class ejercicio1 {
    public static void main(String[] args) throws FileNotFoundException {
        Scanner lector = new Scanner(new File("caso01.txt"));//para llamar un archivo de texto y usar sus datos con lector xd
        int num_atacantes = lector.nextInt();
        Detectado[] atacantes = new Detectado[num_atacantes];
        int num_defensas= lector.nextInt();
        Detectado[] defensas=new Detectado[num_defensas];
        String equipo1= lector.next();
        String equipo2= lector.next();

        for(int i=0;i<num_atacantes;i++){
            atacantes[i]=new Detectado();
            atacantes[i].setDistancia(lector.nextInt());

        }
        for(int i =0;i<num_atacantes;i++){
            atacantes[i].setCamiseta(lector.nextInt());//para que leea la camisa del txt
        }
        for(int i =0;i<num_defensas;i++){
            defensas[i]= new Detectado();
            defensas[i].setDistancia(lector.nextInt());//este lector leee del txt

        }
        for(int i =0;i<num_defensas;i++){
            defensas[i].setCamiseta(lector.nextInt());//para que leea la camisa del txt
        }

        Ordenamiento.merge_sort(atacantes);//necesitan ser comparables en detectados implements comparabl e
        Ordenamiento.merge_sort(defensas);

        if(atacantes[0].compareTo(defensas[1])>0){
            System.out.println("S " +atacantes[0].getCamiseta());
        }
        else{
            System.out.println(" N ");
        }
    }
}
