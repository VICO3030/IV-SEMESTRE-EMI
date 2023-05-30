import java.io.IOException;
import Librerias.PrograAvan.Lineal.Lista;
import Librerias.PrograAvan.Persistencia.Persistencia;

public class Almacenar {
    public static void main(String[] args) throws IOException {
        Lista<Juego> planilla= new  Lista<>();
        Persistencia archivo = new Persistencia();

        Juego juego ;
        planilla.insertar(new Juego(3, 2,"EquipoA", "EquipoB"));
  //      planilla.insertar(juego.pedir());
     //   planilla.insertar(juego.FueradeJuego());


        //almacenamos los jugadores
        archivo.almacenar("Juego.txt", planilla);
    }
}
