package Ejemplo_Empleado;

import java.io.Serializable;

public abstract class Empleado implements Pagable, Comparable, Serializable {
    private String nombre;
    private String apellido;
    private String ci;


    public Empleado(String nombre, String apellido, String ci) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.ci = ci;
    }

    // implementamos compareTo para indicar como comparamos empleados
    // Un empleado sera mayor que otro si su pago en mayor (getPago())
    @Override
    public int compareTo(Object o) {
        Empleado otro = (Empleado) o;
        if (get_pago() > otro.get_pago()){
            return 1;
        }
        else if(get_pago() < otro.get_pago()){
            return -1;
        }
        return 0;
    }
    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public String getCi() {
        return ci;
    }

    public void setCi(String ci) {
        this.ci = ci;
    }

    @Override
    public String toString() {
        return "Empleado{" +
                "nombre='" + nombre + '\'' +
                ", apellido='" + apellido + '\'' +
                ", ci='" + ci + '\'' +
                '}';
    }

}
