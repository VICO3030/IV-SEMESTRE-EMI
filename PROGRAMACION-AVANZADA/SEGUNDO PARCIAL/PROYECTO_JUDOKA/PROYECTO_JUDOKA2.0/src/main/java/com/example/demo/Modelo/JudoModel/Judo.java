package com.example.demo.Modelo.JudoModel;

public class Judo extends  Persona{
    private String categoria;
    private String grado;

    public Judo(String nombre, String apellido, String fecha_nac, String sexo, double telef, double peso, String categoria, String grado) {
        super(nombre, apellido, fecha_nac, sexo, telef, peso);
        this.categoria = categoria;
        this.grado = grado;
    }

    public String getCategoria() {
        return categoria;
    }

    public void setCategoria(String categoria) {
        this.categoria = categoria;
    }

    public String getGrado() {
        return grado;
    }

    public void setGrado(String grado) {
        this.grado = grado;
    }

    @Override
    public String toString() {
        return "Judo{" +
                "categoria='" + categoria + '\'' +
                ", grado='" + grado + '\'' +
                '}';
    }
}
