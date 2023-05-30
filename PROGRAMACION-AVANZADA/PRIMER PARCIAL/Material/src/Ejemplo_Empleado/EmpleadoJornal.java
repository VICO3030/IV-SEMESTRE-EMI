package Ejemplo_Empleado;

public class EmpleadoJornal extends Empleado {
    private double pago;
    private double horas;

    public EmpleadoJornal(String nombre, String apellido, String ci, double pago, double horas) {
        super(nombre, apellido, ci);
        this.pago = pago;
        this.horas = horas;
    }

    public double getPago() {
        return pago;
    }

    public void setPago(double pago) {
        this.pago = pago;
    }

    public double getHoras() {
        return horas;
    }

    public void setHoras(double horas) {
        this.horas = horas;
    }

    @Override
    public double get_pago() {
        if (getHoras() <= 40){
            return getPago() * getHoras();
        }
        else{
            return 40 * getPago() + (getHoras() - 40) * get_pago() * 1.5;
        }
    }

    @Override
    public String toString() {
        return super.toString() + "EmpleadoJornal{" +
                "pago=" + pago +
                ", horas=" + horas +
                '}';
    }
}
