public class ejercicio3 {
    public static void main(String[] args) {
        Equipo e=new Equipo("atletico");
        e.crear_actual(15,new jugador("luis",30));
        e.crear_actual(10,new jugador("juan",5));
        e.crear_actual(27,new jugador("pedro",9));
        e.crear_actual(12,new jugador("luacas",31));
        e.crear_actual(6,new jugador("marcos",27));
        e.crear_actual(13,new jugador("jose",13));
        e.crear_actual(7,new jugador("joel",93));
        e.crear_actual(19,new jugador("Elbicho",43));
        e.crear_actual(40,new jugador("suanco",63));
        e.crear_actual(5,new jugador("marto",24));
        e.crear_actual(1,new jugador("mattos",12));
        //las laves no se pueden repetir

        System.out.println(e.get_jugador(6));
    }
}
