package com.example.grafo01.Modelo;

public class Camion {
    private  int id;
    private String placa;
    private int carga;

    public Camion() {
    }

    public Camion(int id, String placa, int carga) {
        this.id = id;
        this.placa = placa;
        this.carga = carga;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getPlaca() {
        return placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public int getCarga() {
        return carga;
    }

    public void setCarga(int carga) {
        this.carga = carga;
    }
}
