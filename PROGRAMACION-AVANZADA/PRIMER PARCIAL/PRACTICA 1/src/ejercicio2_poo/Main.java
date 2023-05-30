package ejercicio2_poo;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int num,num2;
        Scanner pedir =new Scanner(System.in);
        System.out.println("Ingrese el primer numero : ");
        num= pedir.nextInt();
        System.out.println("Ingrese el segundo numero : ");
        num2=pedir.nextInt();
        
        Fraccion mostrar =new Fraccion(num,num2);
        System.out.println("La suma es de : "+mostrar.Sumar(num, num2));
        System.out.println("La multiplicacion es de : "+mostrar.Multiplicar());
        System.out.println("La division es de  : "+mostrar.Dividir());
        System.out.println("El numero mayor es : "+mostrar.Comparar());
        mostrar.Simplificar(num, num2);    
    }
}
