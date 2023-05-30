package com.example.demo.Modelo.JudoModel;

import java.util.Date;

public class Persona {
    private  String nombre;
    private  String apellido;
    private String fecha_nac;
    private  String sexo;
    private   double telef;
    private  double peso;

    public Persona(String nombre, String apellido, String fecha_nac, String sexo, double telef, double peso) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fecha_nac = fecha_nac;
        this.sexo = sexo;
        this.telef = telef;
        this.peso = peso;
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

    public String getFecha_nac() {
        return fecha_nac;
    }

    public void setFecha_nac(String fecha_nac) {
        this.fecha_nac = fecha_nac;
    }

    public String getSexo() {
        return sexo;
    }

    public void setSexo(String sexo) {
        this.sexo = sexo;
    }

    public double getTelef() {
        return telef;
    }

    public void setTelef(double telef) {
        this.telef = telef;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }
}
