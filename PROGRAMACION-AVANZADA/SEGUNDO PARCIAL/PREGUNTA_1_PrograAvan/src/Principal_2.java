
//Principal Inciso b)

import static PrograAvan.Lineal.Ordenamiento.merge_sort;

public class Principal_2 {
    public static void main(String[] args) {
        Jugador[] vj = new Jugador[5];

        vj[0] = new Jugador("Ronaldo", 10);
        vj[1] = new Jugador("Messi", 9);
        vj[2] = new Jugador("Ricardo", 7);
        vj[3] = new Jugador("Ronaldhino", 1);
        vj[4] = new Jugador("Roberto", 4);

        Equipo e1 = new Equipo("Barcelona", vj);

        for(int i = 0; i< vj.length; i++){
            System.out.println(vj[i]);
        }

        merge_sort(e1.getA());

        System.out.println();

        for(int i = 0; i< vj.length; i++){
            System.out.println(vj[i]);
        }

    }
}
