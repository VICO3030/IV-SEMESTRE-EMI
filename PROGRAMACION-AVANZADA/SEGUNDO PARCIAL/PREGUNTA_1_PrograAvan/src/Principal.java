
//PRINCIPAL INCISO a)

import javax.swing.*;
import java.util.Arrays;
import java.util.Scanner;

public class Principal {
    public static void main(String[] args) {

        boolean band = false;

        int A, D;
        String c1, c2;
        int [] a;
        int [] d;
        int [] da;
        int [] dd;

        Scanner scan = new Scanner(System.in);

        //SE INSERTA POR TECLADO SOLO LOS NUMEROS DE JUGADORES DE ATACANTES Y DEFENSORES, Y LOS NOMBRES

        do {
            A = scan.nextInt();
            D = scan.nextInt();

            if (A < 2 || A > 11 || D < 2 || D > 11) {
                throw new IllegalArgumentException("Ingrese una cantidad valida de jugadores");
            }
        }while(A < 2 || A > 11 || D < 2 || D > 11);

        a = new int[A];
        d = new int [D];
        dd = new int[D];
        da = new int[A];

        c1 = scan.next();
        c2 = scan.next();


        // SE INSERTAN Y MUESTRAN DE FORMA RANDOM LAS DISTANCIAS Y LOS NUMEROS DE JUGADORES

        int jug, dis;


        for (int i =0; i< A; i++){
            dis = (int) Math.floor(Math.random()*(600-400+1) + 400);
            da[i] = dis;
            System.out.print(da[i] + " ");
        }
        System.out.println();

        for (int i =0; i<A; i++){
            jug = (int) Math.floor(Math.random()*(12-2+1) + 2);
            a[i] = jug;
            System.out.print(a[i] + " ");
        }
        System.out.println();

        for (int i =0; i<D; i++){
            dis = (int) Math.floor(Math.random()*(600-400+1) + 400);
            dd[i] = dis;
            System.out.print(dd[i] + " ");
        }
        System.out.println();

        for (int i =0; i<D; i++){
            jug = (int) Math.floor(Math.random()*(12-2+1) + 2);
            d[i] = jug;
            System.out.print(d[i]+ " ");
        }
        System.out.println();

        int adelanto = comparar(da,dd);

        if(adelanto >= 0)
        {
            System.out.printf("S" + a[adelanto]);
        }
        else{
            System.out.printf("N");
        }

        }

        public static int comparar(int []a, int []b){
        int pos_men = -1;

            Arrays.sort(b);
            //Ordenando, la distancia menor siempre es el arquero, comparamos con el primer

            for (int i = 0; i<a.length; i++){
                if(a[i]<b[1]){
                    pos_men = i;
                }
            }
                return pos_men;
        }

        /*
        CASO DE PRUEBA
        4 5
        EquipoA EquipoB
        450 498 486 565
        6 5 3 7
        505 592 499 489 488
        2 10 5 11 7

        S3  (Devuelve que si hay adelando y el numero de camiseta del jugador adelantado)

         */
    }
