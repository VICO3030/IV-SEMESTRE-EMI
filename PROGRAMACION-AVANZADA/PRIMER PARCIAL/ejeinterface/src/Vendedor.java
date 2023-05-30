import java.util.Objects;

public class Vendedor implements Empleado{
    private String ci ;
    private int reg;
    private double salario_base;
    private int numero_ventas;
    private double  comision;


    public Vendedor(String ci, int reg, double salario_base, int numero_ventas, double comision) {
        this.ci = ci;
        this.reg = reg;
        this.salario_base = salario_base;
        this.numero_ventas = numero_ventas;
        this.comision = comision;
    }

    @Override
    public void registrarse(int cod  , String ci) {
        this.reg =cod;
        this.ci = ci;

    }


    @Override
    public void mostrar() {
        System.out.println("Vendedor numeros  + "+reg+ " tiene "+numero_ventas+"ventas");
    }

    @Override
    public double get_salario() {
        return this.salario_base +this.numero_ventas*comision;
    }

    @Override
    public String toString() {
        return "Vendedor{" +
                "ci='" + ci + '\'' +
                ", reg=" + reg +
                ", salario_base=" + salario_base +
                ", numero_ventas=" + numero_ventas +
                ", comision=" + comision +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Vendedor vendedor = (Vendedor) o;
        return reg == vendedor.reg && Objects.equals(ci, vendedor.ci);
    }

    @Override
    public int hashCode() {
        return Objects.hash(ci, reg);
    }
}
