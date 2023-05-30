import PrograAvan.Lista;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;

public class Guardar {
    public static void main(String[] args) throws IOException {
        Lista<Gerente> planilla = new Lista<>();
        planilla.Insertar(new Gerente(123 , "5698"));
        planilla.Insertar(new Gerente(123 , "5698"));
        planilla.Insertar(new Gerente(123 , "5698"));
        FileOutputStream arch = null;
        arch = new FileOutputStream("planilla.dat");
        ObjectOutputStream oss = new ObjectOutputStream(arch);
        oss.writeObject(planilla);
    }
}
