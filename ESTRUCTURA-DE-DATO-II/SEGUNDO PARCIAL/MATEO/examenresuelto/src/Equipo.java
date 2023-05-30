import PrograAvan.Lineal.Ordenamiento;
import PrograAvan.NoLineal.ArbolBinario;

import java.util.Arrays;

public class Equipo {
    private String nombre;
    private jugador[] plantilla;
    private ArbolBinario<Integer,jugador> actual =new ArbolBinario<>();

    public Equipo(String nombre, jugador[] plantilla) {
        this.nombre = nombre;
        this.plantilla = plantilla;
        this.actual=new ArbolBinario<>();
    }

    public Equipo(String nombre) {
        this.nombre = nombre;
    }

    //el integer es pa la llave
    public void crear_actual(Integer num,jugador j){
        actual.insertar(num,j);
    }
    public jugador get_jugador(Integer n){
        jugador x = actual.get_element_by_llave(n);
        x.setCant_pos_adel(x.getCant_pos_adel());
        return actual.get_element_by_llave(n);
    }
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public jugador[] getPlantilla() {
        return plantilla;
    }

    public void setPlantilla(jugador[] plantilla) {
        this.plantilla = plantilla;
    }

    public void ordenar_plantel(){
        Ordenamiento.merge_sort(this.plantilla);
    }


    @Override
    public String toString() {
        return "Equipo{" +
                "nombre='" + nombre + '\'' +
                ", plantilla=" + Arrays.toString(plantilla) +
                '}';
    }
}
