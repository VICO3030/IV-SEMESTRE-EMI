import PrograAvan.Lineal.Lista;
import PrograAvan.Persistencia.Persistencia;

import java.io.IOException;

public class ejemplo01_almacenar {
    public static void main(String[] args) throws IOException {
        // creamos una lista de string
        Lista<String> lista = new Lista<>();
        lista.insertar("Juan");
        lista.insertar("Luis");
        lista.insertar("Jose");
        lista.insertar("Pedro");
        lista.insertar("Maria");
        lista.insertar("Ana");
        lista.insertar("Andrea");
        lista.insertar("Yoss");

        // instanciamos nuestra clase para guardar nuestra lista de objetos
        Persistencia file = new Persistencia();
        file.almacenar("demo.dat", lista);
    }
}
