public class jugador implements Comparable{
    private String nombre;
    private int cant_pos_adel;

    public jugador(String nombre, int cant_pos_adel) {
        this.nombre = nombre;
        this.cant_pos_adel = cant_pos_adel;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCant_pos_adel() {
        return cant_pos_adel;
    }

    public void setCant_pos_adel(int cant_pos_adel) {
        this.cant_pos_adel = cant_pos_adel;
    }

    @Override
    public int compareTo(Object o) {
        jugador otro= (jugador) o;
        if(this.cant_pos_adel>otro.getCant_pos_adel()){
            return 1;
        }
        else if(this.cant_pos_adel< otro.getCant_pos_adel()){
            return -1;
        }
        return 0;
    }

    //sin esto solo muestra codigo del puntero al llamarol xd
    //si osi pa mostrar
    @Override
    public String toString() {
        return "jugador{" +
                "nombre='" + nombre + '\'' +
                ", cant_pos_adel=" + cant_pos_adel +
                '}';
    }
}
