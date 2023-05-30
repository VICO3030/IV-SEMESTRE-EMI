package PRACTICA1;

import java.util.Scanner;

public class ejercicio5 {
    public static Scanner pedir = new Scanner(System.in);
    
    
   /* public static  void llenar(int cajas[], int items[]){
        //pedimos las dimensiones de la caja
         System.out.println("Ingrese las dimesiones de la caja x y z ");
        for (int i =0 ;i<3 ;i++){
            cajas[i]=pedir.nextInt();
             pedir.nextLine();//       
        }
        //pedimos las dimensiones de la Items
        System.out.println("Ingrese las dimesiones de la Items x y z ");
        for (int j =0 ;j<3 ;j++){    
            items[j]=pedir.nextInt();
            pedir.nextLine();//
        } 
    }*/
  
   public static int Calcular(int cajas[], int items[]){
       int x = 0,y=0,z = 0;
       int res_x=Integer.MAX_VALUE , res_y=Integer.MAX_VALUE,res_z=Integer.MAX_VALUE;//para agarrar el mayor valor MAX_VALUE
        for(int i=0 ; i<3 ;i++){
            for(int j=0 ; j<3 ; j++){
                if(j==0 &&(cajas[i]%items[j]<res_x) ){
                    res_x=cajas[i]%items[j];
                    x=cajas[i]/items[j];
                }
                else if(j==1 && (cajas[i]%items[j]<res_y)){
                    res_y=cajas[i]%items[j];
                    y=cajas[i]/items[j];
                }
                else  if(j==2 && (cajas[i]%items[j] < res_z)){
                    res_z=cajas[i]%items[j];
                    z=cajas[i]/items[j];
                }
            }
        }
        return x*y*z;
   } 
     
     public static void main(String[] args) {
        
        int cajas[]={913 ,687, 783};
        int items[]={ 109 ,93 ,53};
        //llenar(cajas,items);
        System.out.print("La cantidad es de : "+Calcular(cajas,items));
         System.out.println("");
        
    } 
     
     
}
