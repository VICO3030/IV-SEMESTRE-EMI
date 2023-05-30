import LigaModel.Equipo;
import LigaModel.Jugador;
import PrograAvan.NoLineal.ArbolRB;

public class Main {
    public static void main(String[] args) {
    /*    Jugador j1 = new Jugador("Juan", 2000,23);
        Jugador j2 = new Jugador("Luis", 1999,21);
        Jugador j3 = new Jugador("Jose", 2005,13);
        Jugador j4 = new Jugador("Pedro", 1997,43);
        Jugador j5 = new Jugador("Ana", 2000,27);

        Equipo e1 = new Equipo("Asaji");

    /   e1.enlistar(j1);
        e1.enlistar(j2);
        e1.enlistar(j3);
        e1.enlistar(j4);
        e1.enlistar(j5);

*/
        ArbolRB<Integer, String> lista = new ArbolRB<>();
        lista.insertar(7,"leandro");
        lista.insertar(5,"juan");
        lista.insertar(9,"victor");
        lista.insertar(4,"edith");
        lista.insertar(6,"fulano");
        lista.insertar(8,"messi");
        lista.insertar(10,"pablo");
        System.out.println("----------------------------");
        lista.Profuncidad();
        System.out.println("----------------------------");
        lista.Balanceado();



    }
}