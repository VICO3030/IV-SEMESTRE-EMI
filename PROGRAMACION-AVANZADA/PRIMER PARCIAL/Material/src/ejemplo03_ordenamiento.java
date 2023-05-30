import Ejemplo_Empleado.Empleado;
import Ejemplo_Empleado.EmpleadoComision;
import Ejemplo_Empleado.EmpleadoJornal;
import Ejemplo_Empleado.EmpleadoSalario;
import PrograAvan.Lineal.Ordenamiento;

public class ejemplo03_ordenamiento {
    public static void main(String[] args) {
        // creamos un array de empleados, (diferentes empleados)
        Empleado[] planilla = new Empleado[8];
        planilla[0] = new EmpleadoComision("Juan", "Perez", "1234", 2000, 0.4);
        planilla[1] = new EmpleadoComision("Luis", "Gonzales", "1234", 2000, 0.4);
        planilla[2] = new EmpleadoJornal("Ana", "Tapia", "1234", 2000, 0.4);
        planilla[3] = new EmpleadoJornal("Maria", "Heredia", "1234", 2000, 0.4);
        planilla[4] = new EmpleadoSalario("Jorge", "Rosales", "1234", 2000);
        planilla[5] = new EmpleadoSalario("Juanita", "Aranibar", "1234", 2000);
        planilla[6] = new EmpleadoComision("Joselito", "Cuadros", "1234", 2000, 0.4);
        planilla[7] = new EmpleadoSalario("Sandra", "Carrafa", "1234", 2000);

        // ordenamos la planilla por el monto a pagar (get_pago)
        // para lo cual Empleado implementa la interface Comparable
        // compareTo
        Ordenamiento.merge_sort(planilla);

        for(Empleado e: planilla){
            System.out.println(e.get_pago());

        }

    }
}
