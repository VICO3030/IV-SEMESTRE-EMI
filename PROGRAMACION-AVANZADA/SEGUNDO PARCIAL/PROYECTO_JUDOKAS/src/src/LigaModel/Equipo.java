package LigaModel;

import PrograAvan.NoLineal.ArbolRB;

public class Equipo {
    int id_equipo;
    String nombre;
    ArbolRB<Integer, Jugador> plantel;

    public Equipo(String nombre) {
        this.nombre = nombre;
        plantel = new ArbolRB<>();
    }
 /*   public void enlistar(Jugador j){
        int m;
        if (plantel.get_tam() == 0){
            m = 0;
        }
        else{
            m = plantel.get_max_index();}

        j.setId_jugador(m + 1);
        plantel.insertar(j.getId_jugador(), j);
    }*/

    public int getId_equipo() {
        return id_equipo;
    }

    public void setId_equipo(int id_equipo) {
        this.id_equipo = id_equipo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public ArbolRB<Integer, Jugador> getPlantel() {
        return plantel;
    }

    public void setPlantel(ArbolRB<Integer, Jugador> plantel) {
        this.plantel = plantel;
    }

    @Override
    public String toString() {
        return "Equipo{" +
                "id_equipo=" + id_equipo +
                ", nombre='" + nombre + '\'' +
                ", plantel=" + plantel +
                '}';
    }
}
