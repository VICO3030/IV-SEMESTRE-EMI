import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class ejer1 {
    public static void main(String[] args) throws FileNotFoundException {
        Scanner pedir =new  Scanner(new File("Caso01.txt"));
        int n;
        while(pedir.hasNext()){
            //recorrer para todo el texto cada linea
            n =  pedir.nextInt();
            System.out.println(numeros(n));
        }
    }
    public static int numeros(int i){
        int u , d;
        int res= i ;
        int cont=0;

        do{
            u=res %10;
            d=res /10;
            res = u+d;
            res= u*10+(res%10);
            cont++;
        }while(res != i);
        return cont;
    }



}
