import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

    //ejercicio de peses
public class Ejercicio01 {//la clase debe tener el mismo nombre que el archivo

    public static void main(String[] args) throws FileNotFoundException {
        Scanner pedir = new Scanner(new File("Caso020.txt"));
        int may , men , nums;

        //leemos las variables
        men = pedir.nextInt();
        may = pedir.nextInt();
        nums = pedir.nextInt();

        //instancias creamos un vector
        int cant[] =new int [nums];
        //leemos cada elemento de nuestro vector
        for(int i=0 ; i <nums ; i++){
            cant[i] =  pedir.nextInt();
        }
        //mostramos resultado
        System.out.println("la cantidad de peces que entrearan son : "+resolucion(men,may,cant));



    }



    public static int resolucion(int menor , int mayor  , int []peces){
        int resultado=0;
        for(int i=menor ; i<=mayor ; i++){

            for(int p=0 ; p<peces.length ; p++){//legth numero de cadenas que tiene un caracter
                    if( ((i <= (0.5*peces[p])) && (i >=(0.1*peces[p])) ) || ((peces[p] <= (0.5*i)) && (peces[p] >= (0.1*i)) ) ){
                        break;
                    }
                    if( p == peces.length-1){
                        resultado++;
                    }

            }
        }
        return resultado;
    }

}
