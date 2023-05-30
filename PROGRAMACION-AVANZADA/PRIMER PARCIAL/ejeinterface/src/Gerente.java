import java.io.Serializable;
import java.util.Objects;

public class Gerente implements Empleado , Serializable {
    //atributos
    private int codigo;//codigo
    private String ci;//carnet de identidad
    private double salario;
    public double getSalario() {
        return salario;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }

    public Gerente(int codigo, String ci) {
        this.codigo = codigo;
        this.ci = ci;
    }
    public int getCodigo() {
        return codigo;
    }
    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }
    public String getCi() {
        return ci;
    }
    public void setCi(String ci) {
        this.ci = ci;
    }


    //va implementar
    @Override
    public void registrarse(int cod, String ci) {
        this.codigo = cod;
        this.ci = ci;

    }
    @Override
    public void mostrar() {
        System.out.println("Gerente  con codigo  : "+this.codigo + " y cedula de identidad  : "+this.ci);
    }
    @Override
    public double get_salario() {
        return 0;
    }

    @Override
    public String toString() {
        return "Gerente{" +
                "codigo=" + codigo +
                ", ci='" + ci + '\'' +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Gerente gerente = (Gerente) o;
        return codigo == gerente.codigo && Objects.equals(ci, gerente.ci);
    }

    @Override
    public int hashCode() {
        return Objects.hash(codigo, ci);
    }
}
