public class Jugador implements  Comparable {
    private String nombre;
    private int cant_pos_adelante;

    public Jugador(String nombre, int cant_pos_adelante) {
        this.nombre = nombre;
        this.cant_pos_adelante = cant_pos_adelante;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getCant_pos_adelante() {
        return cant_pos_adelante;
    }

    public void setCant_pos_adelante(int cant_pos_adelante) {
        this.cant_pos_adelante = cant_pos_adelante;
    }

    @Override
    public int compareTo(Object o) {
        Jugador otro  =(Jugador)  o ;

        if(this.cant_pos_adelante > otro.getCant_pos_adelante()){
            return 1;
        }
        else if(this.cant_pos_adelante< otro.getCant_pos_adelante()){
            return 0;
        }
        return 0;
    }
}
