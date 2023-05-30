public class Empleado_comision extends Empleado{
    private double ventas;

    public Empleado_comision(String nombre, int anio_nac, double salario_base, double ventas) {
        super(nombre, anio_nac, salario_base);
        this.ventas = ventas;
    }

    public double getVentas() {
        return ventas;
    }

    public void setVentas(double ventas) {
        this.ventas = ventas;
    }
    public double get_salario(){
        return this.salario_base + ventas;
    }
}
