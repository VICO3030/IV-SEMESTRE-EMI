public class Viaje {
    //atributos
    private String  nombre ;
    private double distancia;
    //creamos el constructor
    public Viaje(String nombre, double distancia) {
        this.nombre = nombre;
        this.distancia = distancia;
    }
    //creamos los setters y los getters


    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getDistancia() {
        return distancia;
    }

    public void setDistancia(double distancia) {
        this.distancia = distancia;
    }
}
