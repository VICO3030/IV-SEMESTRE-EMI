package PRACTICA1;
import java.util.Scanner;

public class ejer3 {
    public static void main(String[] args) {
        Scanner pedir = new Scanner(System.in);
        int min, max, factor;
        //ingresamos las entradas de las variables
        System.out.print("Ingrese el numero minimo : ");
        min = pedir.nextInt();
        System.out.print("Ingrese el numero maximo : ");
        max = pedir.nextInt();
        System.out.print("Ingrese el numero factor: ");
        factor = pedir.nextInt();

        //recorremos el ciclo de los numeos ingresados max y min
        int cont = 0;//contador para los numeros  que  son divisibles por el factor
        for (int i = min; i < max + 1; i++) {
            if (i % factor == 0) {//si son divisibles
                cont++;
            }

        }
        System.out.println("La cantidad de los numeros que son divisble  son: " + cont);

    }
}