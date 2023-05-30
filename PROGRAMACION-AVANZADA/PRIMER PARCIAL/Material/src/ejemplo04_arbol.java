import Ejemplo_Empleado.Empleado;
import Ejemplo_Empleado.EmpleadoComision;
import Ejemplo_Empleado.EmpleadoJornal;
import Ejemplo_Empleado.EmpleadoSalario;
import PrograAvan.NoLineal.ArbolBinario;

public class ejemplo04_arbol {
    public static void main(String[] args) {
        ArbolBinario<Integer, Empleado> planilla = new ArbolBinario<>();

        planilla.insertar(25, new EmpleadoComision("Juan", "Perez", "1234", 2000, 0.4));
        planilla.insertar(18,new EmpleadoComision("Luis", "Gonzales", "1234", 2000, 0.4));
        planilla.insertar(27, new EmpleadoJornal("Ana", "Tapia", "1234", 2000, 0.4));
        planilla.insertar(20, new EmpleadoJornal("Maria", "Heredia", "1234", 2000, 0.4));
        planilla.insertar(15, new EmpleadoSalario("Jorge", "Rosales", "1234", 2000));
        planilla.insertar(30, new EmpleadoSalario("Juanita", "Aranibar", "1234", 2000));
        planilla.insertar(5, new EmpleadoComision("Joselito", "Cuadros", "1234", 2000, 0.4));
        planilla.insertar(21, new EmpleadoSalario("Sandra", "Carrafa", "1234", 2000));

        System.out.println(planilla.get_tam());

        System.out.println(planilla.get_element_by_llave(30));
        System.out.println(planilla.get_element_by_llave(5));
    }
}
