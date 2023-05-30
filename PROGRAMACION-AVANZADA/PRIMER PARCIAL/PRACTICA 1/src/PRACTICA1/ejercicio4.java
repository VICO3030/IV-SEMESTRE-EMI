package PRACTICA1;

import java.util.Scanner;


public class ejercicio4 {
    public static void main(String[] args) {
        Scanner pedir =  new Scanner(System.in);
        int palillos;
        System.out.print("Ingrese la cantidad de palillos : ");
        palillos= pedir.nextInt();
        Area(palillos);
        
    }
    
    
    public static  void  Area(int palillo){
        float Area;
        Area = palillo*palillo/16;
        
        if(Area%2 ==0 || Area ==1 ){
            System.out.println("El area es "+Area);
        }
        else{
            System.out.println("El area es de: "+(Area-1));
        }
    }
}
