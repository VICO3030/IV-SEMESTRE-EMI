public class Equipo{
    String nombre;
    Jugador [] a;

    public Equipo(String nombre, Jugador[] a) {
        this.nombre = nombre;
        this.a = a;
    }

    public Jugador[] getA() {
        return a;
    }
}
