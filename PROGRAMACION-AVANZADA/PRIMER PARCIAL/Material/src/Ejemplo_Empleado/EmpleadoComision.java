package Ejemplo_Empleado;

public class EmpleadoComision extends Empleado {
    private double salario_bruto;
    private double porcentaje_comision;

    public EmpleadoComision(String nombre, String apellido, String ci, double salario_bruto, double porcentaje_comision) {
        super(nombre, apellido, ci);
        this.salario_bruto = salario_bruto;
        this.porcentaje_comision = porcentaje_comision;
    }

    public double getSalario_bruto() {
        return salario_bruto;
    }

    public void setSalario_bruto(double salario_bruto) {
        this.salario_bruto = salario_bruto;
    }

    public double getPorcentaje_comision() {
        return porcentaje_comision;
    }

    public void setPorcentaje_comision(double porcentaje_comision) {
        this.porcentaje_comision = porcentaje_comision;
    }

    @Override
    public double get_pago() {
        return getPorcentaje_comision() * getSalario_bruto();
    }

    @Override
    public String toString() {
        return super.toString() + "EmpleadoComision{" +
                "salario_bruto=" + salario_bruto +
                ", porcentaje_comision=" + porcentaje_comision +
                '}';
    }


}
