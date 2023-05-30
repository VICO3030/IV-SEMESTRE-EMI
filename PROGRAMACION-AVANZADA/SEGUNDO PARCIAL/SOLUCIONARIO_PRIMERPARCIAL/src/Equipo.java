import Librerias.PrograAvan.NoLineal.ArbolBinario;

import java.util.Arrays;

public class Equipo {
    private String nombre;
    private int planilla[];
    private ArbolBinario<Integer , Jugador> actual = new ArbolBinario<>();

    public Equipo() {
    }

    public Equipo(String nombre, int[] planilla) {
        this.nombre = nombre;
        this.planilla = planilla;
        this.actual = new ArbolBinario<>();
    }
    public void crear_Actual(Integer  num , Jugador j){
        actual.insertar(num , j);
    }
    public Jugador get_jugador(Integer n){
        Jugador x =actual.get_element_by_llave(n);
        x.setCant_pos_adelante(x.getCant_pos_adelante()+1);
        return x;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int[] getPlanilla() {
        return planilla;
    }

    public void setPlanilla(int[] planilla) {
        this.planilla = planilla;
    }

    @Override
    public String toString() {
        return "Equipo{" +
                "nombre='" + nombre + '\'' +
                ", planilla=" + Arrays.toString(planilla) +
                '}';
    }
}
