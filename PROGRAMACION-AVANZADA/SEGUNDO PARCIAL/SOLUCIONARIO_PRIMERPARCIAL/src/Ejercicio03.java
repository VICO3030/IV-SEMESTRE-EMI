public class Ejercicio03 {
    public static void main(String[] args) {
        Equipo e = new Equipo("wilsterman");
        e.crear_Actual(18,new Jugador("luis ",3));
        e.crear_Actual(20,new Jugador("pedro ",8));

        e.crear_Actual(11,new Jugador("fulano",9));

        e.crear_Actual(15,new Jugador("leo ",5));




    }
}
