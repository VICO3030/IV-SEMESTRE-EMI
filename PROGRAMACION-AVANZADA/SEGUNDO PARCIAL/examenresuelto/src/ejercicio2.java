public class ejercicio2 {
    public static void main(String[] args) {
        jugador[] plantilla=new jugador[11];
        plantilla[0]=new jugador("luis",30);
        plantilla[1]=new jugador("juan",5);
        plantilla[2]=new jugador("pedro",9);
        plantilla[3]=new jugador("luacas",31);
        plantilla[4]=new jugador("marcos",23);
        plantilla[5]=new jugador("jose",13);
        plantilla[6]=new jugador("joel",93);
        plantilla[7]=new jugador("Elbicho",43);
        plantilla[8]=new jugador("suanco",63);
        plantilla[9]=new jugador("marto",24);
        plantilla[10]=new jugador("mattos",12);

        Equipo e =new Equipo("Atletico",plantilla);
        e.ordenar_plantel();
        System.out.println(e);

    }
}
