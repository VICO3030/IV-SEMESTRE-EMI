import java.util.Scanner;

public class Juego {
    Scanner pedir = new Scanner(System.in);
    private int cantDefen;
    private int cantAtacant;
    private String equipoDefen;
    private String equipoAtacant;
    private int vecDefen[];
    private int vecAtacan[];
    private int Camisas_Ataca[];
    private int Camisas_Defen[];

    public Juego(int cantDefen, int cantAtacant, String equipoDefen, String equipoAtacant) {
        this.cantDefen = cantDefen;
        this.cantAtacant = cantAtacant;
        this.equipoDefen = equipoDefen;
        this.equipoAtacant = equipoAtacant;

        vecDefen = new int[cantDefen];
        vecAtacan = new int[cantAtacant];

        Camisas_Ataca = new int[cantAtacant];
        Camisas_Defen = new int[cantDefen];
    }

    public void llenardefe() {
        //llenamos los tamanos tanto como Defensor como atacante
        for (int i = 0; i < cantDefen; i++) {
            System.out.print("Ingrese el distancia de defensor " + (i + 1)+" :");
            vecDefen[i] = pedir.nextInt();
        }
        for (int i = 0; i < cantAtacant; i++) {
            System.out.print("Ingrese el distancia de atacante " + (i + 1)+" :");
            vecAtacan[i] = pedir.nextInt();
        }
        //llenamos el numero de camisetas de cada jugador
        for (int i = 0; i < cantDefen; i++) {
            System.out.print("Ingrese el Numero del defensor " + (i + 1)+" :");
            Camisas_Defen[i] = pedir.nextInt();
        }
        for (int i = 0; i < cantAtacant; i++) {
            System.out.print("Ingrese el Numero del atacante " + (i + 1)+" :");
            Camisas_Ataca[i] = pedir.nextInt();
        }

        //llenamos los nombres de los equipos
        System.out.println(equipoDefen + " | " + equipoAtacant);

    }
    public void FueradeJuego() {
        int mayor = 0 , juga=0,camiseta=0;
       for (int i = 0; i <cantAtacant; i++) {
            for (int j = 0; j < cantAtacant; j++) {
                if (vecAtacan[i] > mayor) {
                    juga=i;
                    mayor = vecAtacan[i];

                }
                while (juga !=j){
                    if(juga==j)
                     camiseta=Camisas_Defen[j];
                }
            }

        }
        System.out.println("El mayor jugador"+(juga+1)+"con la distancia "+mayor+"numero camisseta "+camiseta);



    }
}

