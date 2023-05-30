public class Arista<T> {//representa la union de los enlaces
    private Nodo<T>  origen ;


    private Nodo <T> destino ;
    private  double costo;

    public Arista(Nodo<T> origen, Nodo<T> destino, double costo) {
        this.origen = origen;
        this.destino = destino;
        this.costo = costo;
    }

    public Nodo<T> getOrigen() {
        return origen;
    }

    public void setOrigen(Nodo<T> origen) {
        this.origen = origen;
    }

    public Nodo<T> getDestino() {
        return destino;
    }

    public void setDestino(Nodo<T> destino) {
        this.destino = destino;
    }

    public double getCosto() {
        return costo;
    }

    public void setCosto(double costo) {
        this.costo = costo;
    }
    @Override
    public String toString() {
        return "Arista{" +
                "origen=" + origen.getItem() +
                ", destino=" + destino.getItem() +
                ", costo=" + costo +
                '}';
    }

}
