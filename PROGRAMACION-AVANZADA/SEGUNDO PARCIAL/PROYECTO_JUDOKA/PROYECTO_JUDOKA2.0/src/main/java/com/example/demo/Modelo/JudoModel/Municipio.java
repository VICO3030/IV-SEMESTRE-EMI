package com.example.demo.Modelo.JudoModel;

import com.example.demo.PrograAvan.Lineal.Lista;

public class Municipio {
    private int id_municipal;
    private String nombre;
    private String Personeria;
    private String ubicacion;
    private Lista<Directivo> directivos;
    private Lista<Club> afiliadoos;
    private String contactos;
    private String url;

    public Municipio(int id_municipal, String nombre, String personeria, String ubicacion, Lista<Directivo> directivos, Lista<Club> afiliadoos, String contactos, String url) {
        this.id_municipal = id_municipal;
        this.nombre = nombre;
        Personeria = personeria;
        this.ubicacion = ubicacion;
        this.directivos = directivos;
        this.afiliadoos = afiliadoos;
        this.contactos = contactos;
        this.url = url;
    }

    public int getId_municipal() {
        return id_municipal;
    }

    public void setId_municipal(int id_municipal) {
        this.id_municipal = id_municipal;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getPersoneria() {
        return Personeria;
    }

    public void setPersoneria(String personeria) {
        Personeria = personeria;
    }

    public String getUbicacion() {
        return ubicacion;
    }

    public void setUbicacion(String ubicacion) {
        this.ubicacion = ubicacion;
    }

    public Lista<Directivo> getDirectivos() {
        return directivos;
    }

    public void setDirectivos(Lista<Directivo> directivos) {
        this.directivos = directivos;
    }

    public Lista<Club> getAfiliadoos() {
        return afiliadoos;
    }

    public void setAfiliadoos(Lista<Club> afiliadoos) {
        this.afiliadoos = afiliadoos;
    }

    public String getContactos() {
        return contactos;
    }

    public void setContactos(String contactos) {
        this.contactos = contactos;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    @Override
    public String toString() {
        return "Municipio{" +
                "id_municipal=" + id_municipal +
                ", nombre='" + nombre + '\'' +
                ", Personeria='" + Personeria + '\'' +
                ", ubicacion='" + ubicacion + '\'' +
                ", directivos=" + directivos +
                ", afiliadoos=" + afiliadoos +
                ", contactos='" + contactos + '\'' +
                ", url='" + url + '\'' +
                '}';

    }
    
}
