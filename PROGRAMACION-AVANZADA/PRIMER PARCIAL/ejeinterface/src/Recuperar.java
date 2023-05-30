import PrograAvan.Lista;

import java.io.FileInputStream;

import java.io.IOException;
import java.io.ObjectInputStream;

public class Recuperar {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        Lista<Empleado> recuperado = new Lista<>();
        FileInputStream arch = new FileInputStream("planilla.dat");
        ObjectInputStream ois  = new ObjectInputStream(arch);


        recuperado  = (Lista )ois.readObject();
        ois.close();
        for(Empleado g: recuperado){
            System.out.println(g);
        }
    }
}
