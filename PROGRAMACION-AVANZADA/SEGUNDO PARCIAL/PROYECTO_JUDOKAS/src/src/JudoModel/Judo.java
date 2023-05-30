package JudoModel;

public class Judo {
    private  String nombre;
    private  String apellido;
    private  double fecha_nac;
    private String genero;
    private String categoria;
    private double peso_Actu;

    public Judo(String nombre, String apellido, double fecha_nac, String genero, String categoria, double peso_Actu) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fecha_nac = fecha_nac;
        this.genero = genero;
        this.categoria = categoria;
        this.peso_Actu = peso_Actu;
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

    public double getFecha_nac() {
        return fecha_nac;
    }

    public void setFecha_nac(double fecha_nac) {
        this.fecha_nac = fecha_nac;
    }

    public String getGenero() {
        return genero;
    }

    public void setGenero(String genero) {
        this.genero = genero;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    public double getPeso_Actu() {
        return peso_Actu;
    }

    public void setPeso_Actu(double peso_Actu) {
        this.peso_Actu = peso_Actu;
    }

    @Override
    public String toString() {
        return "Judo{" +
                "nombre='" + nombre + '\'' +
                ", apellido='" + apellido + '\'' +
                ", fecha_nac=" + fecha_nac +
                ", genero='" + genero + '\'' +
                ", categoria='" + categoria + '\'' +
                ", peso_Actu=" + peso_Actu +
                '}';
    }
}
