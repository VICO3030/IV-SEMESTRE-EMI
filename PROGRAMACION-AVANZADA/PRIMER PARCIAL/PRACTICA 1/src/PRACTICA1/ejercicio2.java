package PRACTICA1;

import java.util.Scanner;

public class ejercicio2 {
     
    public static void main(String[] args) {
        int num;
           Scanner pedir= new Scanner (System.in);
        System.out.print("ingrese el numero : ");
        num = pedir.nextInt();
        //proceso
        System.out.print("La longitud de mis numeros son :"+ContarDigitos(num));
        Sumatoria(num); 
        
    
   /* long a[];
    int tam;
        System.out.println("Ingrese la cantidad de susdigitos");
        for(int i=0 ; i<tam ; i++){
         a[
        
    }*/
    }
    //medimos la longitud de nuestro problema 
    public static int ContarDigitos(int num){
        int div, con,res;
        div=10;
        con=0;
        res=0;
        do{
            res=num/div;
            con++;
            div= div *10;
        }while(res>=1);
        return con;
    }
    
    
  /*  public static void printSet(long[] a){
        long sizePset = (long)Math.pow(2, a.length);
        arreglo = new String[(int) sizePset];
        fillVector(arreglo);
        for(int i = 0; i < sizePset; i++){
            for(int j = 0; j < a.length; j++){
                if((i & (1 << j)) > 0){
                    arreglo[i] += String.valueOf(a[j]);
                }
            }
        }
    }*/
   public static void Sumatoria(int num){
        int c1 ,c2,c3,c4,c5,c6,c7;
        c1=num/10;
        c2=num/100;
        c3=num%10;
        c4=num%100;
        c5 =c2*10+c3;
        c6=num/10%10; 
        System.out.println("\nCombinacion de nuestro numero");//123
        System.out.println(num);//123
        System.out.println(c1);//12
        System.out.println(c2);//1
        System.out.println(c3);//3
        System.out.println(c4);//23
        System.out.println(c5);//13
        System.out.println(c6);//2
            

        int S;
        S=num+c1+c2+c3+c4+c6+c5;
        System.out.println("La suma total es de  S: "+S);
        System.out.println("El resto de la division de S/9 es  :"+S%9);
   }
}
