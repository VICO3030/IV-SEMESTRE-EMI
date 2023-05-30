import Ejemplo_Empleado.Empleado;
import PrograAvan.Lineal.Lista;
import PrograAvan.Persistencia.Persistencia;

import java.io.IOException;

public class ejemplo02_recuperar {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        Persistencia archivo = new Persistencia();
        Lista<Empleado> planilla = new Lista<>();

        planilla = (Lista) archivo.recuperar("empleados.dat");

        for (Empleado e : planilla){
            System.out.println(e);
        }
    }
}
