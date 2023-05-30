package Ejemplo_Empleado;

public class EmpleadoSalario extends Empleado{
    private double salario_semanal;

    public EmpleadoSalario(String nombre, String apellido, String ci, double salario_semanal) {
        super(nombre, apellido, ci);
        this.salario_semanal = salario_semanal;
    }

    public double getSalario_semanal() {
        return salario_semanal;
    }

    public void setSalario_semanal(double salario_semanal) {
        this.salario_semanal = salario_semanal;
    }

    @Override
    public double get_pago() {
        return salario_semanal;
    }

    @Override
    public String toString() {
        return super.toString() + "EmpleadoSalario{" +
                "salario_semanal=" + salario_semanal +
                '}';
    }
}
