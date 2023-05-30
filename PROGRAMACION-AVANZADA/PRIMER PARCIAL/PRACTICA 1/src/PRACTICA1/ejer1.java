package PRACTICA1;
import java.util.Scanner;
public class ejer1 {
    public static void main(String[] args) {
        Scanner pedir =new Scanner(System.in);
        int num,segundo,primero,sumadigitos;
        int numeroOriginal;
        int segundosumadigitos;

        //pedir el numero y verificacion para
        do{
            System.out.print("Ingrese un numero de un digito o dos : ");
            num= pedir.nextInt();
            if(num<0 || num>99){//coondicion que no pase de un o dos digitos
                System.out.println("!ERROR, vuelva a introducir el numero");
            }
        }while(num<0 || num>99);


        int num1,con=0;
        //Ingreso numero
        System.out.println("Numero ingresado es : "+num);
        numeroOriginal = num;//guardamos el numero original en otra variable
        boolean control = false;
        do{

            primero=num/10; //del num primer digito
            segundo=num%10;//del num el segundo digito
            sumadigitos=primero+segundo; //sumamos los digitos
            System.out.println("Resultado de la suma de los digitos es de : "+sumadigitos);//suma de los dos digitos
            segundosumadigitos = sumadigitos%10; //segndo numero de la suma

            //combinacion de los digitos
            //6 y 8
            num1= segundo*10+segundosumadigitos;
            System.out.println("combinacion de los digitos es de : "+num1);
            con++;

            if(numeroOriginal != num1){//numero original 26 =! 68
                num=num1;  //asignamosnum=68;
            }
            else{
                control = true;
            }
        }while(!control);

        System.out.println("La cantidad de veces que debera recoore son "+con);
    }
}