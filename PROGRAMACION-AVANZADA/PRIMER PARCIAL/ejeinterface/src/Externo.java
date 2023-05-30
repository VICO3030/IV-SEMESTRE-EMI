import java.util.Objects;

public class Externo implements Empleado{
    private  int codigo;
    private String direccion;
    private String whatsaap;
    private double jornaal;
    private int dias;
    private int penalidades;

    public Externo(String direccion, String whatsaap, double jornaal, int dias, int penalidades, int codigo) {
        this.direccion = direccion;
        this.whatsaap = whatsaap;
        this.jornaal = jornaal;
        this.dias = dias;
        this.penalidades = penalidades;
        this.codigo = codigo;
    }

    @Override
    public void registrarse(int cod, String ci) {
        this.codigo = cod;
        this.direccion = direccion;

    }

    @Override
    public void mostrar() {
        System.out.println("Trabajador externo "+"conclusiones"+dias+"Buscar en "+direccion+"o llamar"+whatsaap+"Codigo : "+codigo);
    }

    @Override
    public double get_salario() {
        return dias*jornaal -penalidades;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Externo externo = (Externo) o;
        return codigo == externo.codigo && Objects.equals(whatsaap, externo.whatsaap);
    }

    @Override
    public int hashCode() {
        return Objects.hash(codigo, whatsaap);
    }
}
