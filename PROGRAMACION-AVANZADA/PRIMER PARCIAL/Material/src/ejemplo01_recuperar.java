import PrograAvan.Lineal.Lista;
import PrograAvan.Persistencia.Persistencia;

import java.io.IOException;

public class ejemplo01_recuperar {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        Persistencia file = new Persistencia();
        Lista<String> demo = new Lista<>();
        // recuperamos la lista del archivo demo.dat
        demo = (Lista)file.recuperar("demo.dat");

        for(String cad : demo){
            System.out.println(cad);
        }


    }
}
