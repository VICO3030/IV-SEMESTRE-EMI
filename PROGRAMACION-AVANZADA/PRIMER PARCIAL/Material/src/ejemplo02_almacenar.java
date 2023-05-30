import Ejemplo_Empleado.Empleado;
import Ejemplo_Empleado.EmpleadoComision;
import Ejemplo_Empleado.EmpleadoJornal;
import Ejemplo_Empleado.EmpleadoSalario;
import PrograAvan.Lineal.Lista;
import PrograAvan.Persistencia.Persistencia;

import java.io.IOException;

public class ejemplo02_almacenar {
    public static void main(String[] args) throws IOException {
        // crear lista de empleados
        Lista<Empleado> planilla = new Lista<>();
        Persistencia archivo = new Persistencia();

        planilla.insertar(new EmpleadoComision("Juan", "Perez", "1234", 2000, 0.4));
        planilla.insertar(new EmpleadoComision("Luis", "Gonzales", "1234", 2000, 0.4));
        planilla.insertar(new EmpleadoJornal("Ana", "Tapia", "1234", 2000, 0.4));
        planilla.insertar(new EmpleadoJornal("Maria", "Heredia", "1234", 2000, 0.4));
        planilla.insertar(new EmpleadoSalario("Jorge", "Rosales", "1234", 2000));
        planilla.insertar(new EmpleadoSalario("Juanita", "Aranibar", "1234", 2000));
        planilla.insertar(new EmpleadoComision("Joselito", "Cuadros", "1234", 2000, 0.4));
        planilla.insertar(new EmpleadoSalario("Sandra", "Carrafa", "1234", 2000));

        // almacenar la planilla de empleados
        archivo.almacenar("empleados.dat", planilla);
    }
}
