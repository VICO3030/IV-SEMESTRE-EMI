package JudoModel;

public class Municipio {
    private String nombre;
    private double Personeria;

    public Municipio(String nombre, double personeria) {
        this.nombre = nombre;
        Personeria = personeria;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getPersoneria() {
        return Personeria;
    }

    public void setPersoneria(double personeria) {
        Personeria = personeria;
    }

    @Override
    public String toString() {
        return "Municipio{" +
                "nombre='" + nombre + '\'' +
                ", Personeria=" + Personeria +
                '}';
    }
}
