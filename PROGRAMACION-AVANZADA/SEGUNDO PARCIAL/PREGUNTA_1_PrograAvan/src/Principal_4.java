
//INCISO d)

import PrograAvan.Lineal.Lista;

public class Principal_4 {

    public static void main(String[] args) {

        //El metodo devuelve cualquier elemento de la lista.

        Jugador j1 = new Jugador("Roberto", 5);
        Jugador j2 = new Jugador("Rodrigo", 3);
        Jugador j3 = new Jugador("Mateo", 6);
        Jugador j4 = new Jugador("Pedro", 8);

        Lista<Jugador> l1 = new Lista<>();

        l1.insertar(j1);
        l1.insertar(j2);
        l1.insertar(j3);
        l1.insertar(j4);

        // MOSTRAMOS LISTA COMPLETA

        l1.mostrar_lista(); //(IMPLEMENTADO EN LA LIBRERIA DE LISTA)
        System.out.println();

        l1.eliminar(0);//(IMPLEMENTADO EN A LIBRERIA LISTA)

        l1.mostrar_lista(); //(IMPLEMENTADO EN A LIBRERIA LISTA)
        System.out.println();
        // ELIMINAR PRIMER ELEMENTO

        l1.eliminar(l1.getTam()-1);//(IMPLEMENTADO EN A LIBRERIA LISTA)

        l1.mostrar_lista();//(IMPLEMENTADO EN A LIBRERIA LISTA)
        System.out.println();
        // ELIMINAR ULTIMO ELEMENTO
    }

}
