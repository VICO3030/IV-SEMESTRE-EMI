import java.util.Objects;

public class Empleado implements Comparable {
    //atributos
    public String nombre;
    public int anio_nac;
    public double salario_base;

    //cosntructor

    public Empleado(String nombre, int anio_nac, double salario_base) {
        this.nombre = nombre;
        this.anio_nac = anio_nac;
        this.salario_base = salario_base;
    }

    //geteres y setters

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getAnio_nac() {
        return anio_nac;
    }

    public void setAnio_nac(int anio_nac) {
        this.anio_nac = anio_nac;
    }

    public double getSalario_base() {
        return salario_base;
    }

    public void setSalario_base(double salario_base) {
        this.salario_base = salario_base;
    }

    @Override
    public String toString(){
        return "El Empleado es " +
                nombre + ' ' +
                "nacido el " + anio_nac +
                ", su salario_base es " + salario_base;
    }
    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Empleado empleado = (Empleado) o;
        return anio_nac == empleado.anio_nac && Double.compare(empleado.salario_base, salario_base) == 0 && nombre.equals(empleado.nombre);
    }

    @Override

    public int hashCode() {return Objects.hash(nombre, anio_nac, salario_base);}

    @Override
    public int compareTo(Object o) {
        Empleado otro_empleado = (Empleado) o;
        if (this.anio_nac < otro_empleado.anio_nac){
            return 1;
        }
        else if (this.anio_nac > otro_empleado.anio_nac){
            return -1;
        }
        else
            return 0;
    }

    public double get_salario(){
        return this.salario_base;
    }
}


