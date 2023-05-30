public class Jugador implements Comparable{
    String nombre;
    int goles_anulados;
    //int camiseta; (Se usa para el inciso c, me falto completar)

    public Jugador(String nombre, int goles_anulados) {
        this.nombre = nombre;
        this.goles_anulados = goles_anulados;
    }

    public int getGoles_anulados() {
        return goles_anulados;
    }


    @Override
    public int compareTo(Object o) {
        Jugador otro = (Jugador) o;
        if(goles_anulados > otro.getGoles_anulados()){
            return 1;
        }
        else{
            if(goles_anulados < otro.getGoles_anulados()){
                return -1;
            }
        }
        return 0;
    }

    @Override
    public String toString() {
        return "Jugador{" +
                "nombre='" + nombre + '\'' +
                ", goles_anulados=" + goles_anulados +
                '}';
    }
}

