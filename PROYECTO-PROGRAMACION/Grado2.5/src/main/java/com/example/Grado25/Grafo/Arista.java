package com.example.Grado25.Grafo;

public class Arista {
    private int origen;
    private int destino;
    private double peso;

    public Arista(int origen, int destino, double peso) {
        this.origen = origen;
        this.destino = destino;
        this.peso = peso;
    }

    public int getOrigen() {
        return origen;
    }

    public void setOrigen(int origen) {
        this.origen = origen;
    }

    public int getDestino() {
        return destino;
    }

    public void setDestino(int destino) {
        this.destino = destino;
    }

    public double getPeso() {
        return peso;
    }

    public void setPeso(double peso) {
        this.peso = peso;
    }

    @Override
    public String toString() {
        return "\nOIRGEN{" +
                "-->" + origen +
                "  " + destino +
                "\tdistancia : " + peso +
                '}';
    }
    //llamammos al menu
    public static void main(String[] args) {
        Arista a1 = new Arista(2,3,56);
        System.out.println(a1);
    }
}
