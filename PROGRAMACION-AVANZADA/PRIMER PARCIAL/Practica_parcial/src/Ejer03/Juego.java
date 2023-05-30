package Ejer03;

import java.util.Scanner;

public class Juego {
    Scanner pedir = new Scanner(System.in);
   public String Cant_jugadores = "TWWW LTWW LLTW LLLT";
    private String resul[];
    private  int p;
    private int q;

    public Juego() {
    }

    public Juego(String cant_jugadores, String[] resul, int p, int q) {

        Cant_jugadores = cant_jugadores;
        this.resul = resul;
        this.p = p;
        this.q = q;
    }
    public void Convertir (){

        resul = Cant_jugadores.split(" ");
        System.out.println("Ingrese  p :");
        p= pedir.nextInt();
        System.out.println("Ingrese q");
        q= pedir.nextInt();
        char conflictos;
        int resultado;
        for(int i=0 ; i<resul.length;i++){
            int Cal_gana = (resul.length)-1 * p/100;
            int Cal_pierde = resul.length-1 *q/100;
            int numgana=0, numPierde=0;
           for(int j=0 ; j<resul[i].length() ; j++){

               char c;
               c=resul[i].charAt(j);
               if(c=='W')numgana++;
               else if(c=='L') numPierde++;
               if (numgana >= Cal_gana && numPierde >=Cal_pierde) continue;
               else resultado=i;break;
           }
         //   System.out.println(resultado);

        }


    }
}
