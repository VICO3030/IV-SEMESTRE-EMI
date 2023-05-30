public class Ejercicio02 {
    public static void main(String[] args) {
        Jugador[] planilla  = new Jugador[];
        planilla[0] = new Jugador("luis ",3);
        planilla[1] = new Jugador("pedro ",6);
        planilla[2] = new Jugador("juan ",5);
        planilla[3] = new Jugador("pampeno ",4);
        planilla[4] = new Jugador("judas ",7);
        planilla[5] = new Jugador("fulano ",8);

        Equipo e = new Equipo("atletico",planilla);



    }

}
