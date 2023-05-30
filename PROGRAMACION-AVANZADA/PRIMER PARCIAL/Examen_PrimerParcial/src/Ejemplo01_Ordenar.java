import Librerias.PrograAvan.Lineal.Ordenamiento;

public class Ejemplo01_Ordenar {
    public static void main(String[] args) {
        // creamos un array de empleados, (diferentes empleados)
        Juego[] planilla = new Juego[2];
        planilla[0] = new Juego(3,2,"EquipoA","EquipoB");
        planilla[1] = new Juego(4,8,"WILSTERMAN","BOLIVAR");

        // ordenamos la planilla por el monto a pagar (get_pago)
        // para lo cual Empleado implementa la interface Comparable
        // compareTo
        Ordenamiento.merge_sort((Comparable[]) planilla);

        for(Juego e: planilla){
            System.out.println(e.pedir);
        }
    }
}
