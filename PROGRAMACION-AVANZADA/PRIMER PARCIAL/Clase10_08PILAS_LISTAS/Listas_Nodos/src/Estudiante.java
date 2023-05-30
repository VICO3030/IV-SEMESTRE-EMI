public class Estudiante implements  Comparable{//hacemos que estudiante pertenezca a la familia por eso implements
    private String nombre;
    private int edad;
    private double calif;

    public Estudiante(String nombre, int edad, double calif) {
        this.nombre = nombre;
        this.edad = edad;
        this.calif = calif;
    }

    @Override
    public String toString() {
        return "Estudiante{" +
                "nombre='" + nombre + '\'' +
                ", edad=" + edad +
                ", calif=" + calif +
                '}';
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }

    public double getCalif() {
        return calif;
    }

    public void setCalif(double calif) {
        this.calif = calif;
    }
//impplementamos el compareTo
    @Override
    public int compareTo(Object o) {
        Estudiante otro = (Estudiante) o;
        if(this.edad  >otro.edad){
            return 1;
        }
        else if(this.edad <otro.edad){
            return -1;
        }
        return 0;
    }
}
