public class Nodo {
    //lel nodo tiene un vertice y un costo
    private String vertice;
    private int costo;

    public Nodo(String vertice, int costo) {
        this.vertice = vertice;
        this.costo = costo;
    }

    public String getVertice() {
        return vertice;
    }

    public void setVertice(String vertice) {
        this.vertice = vertice;
    }

    public int getCosto() {
        return costo;
    }

    public void setCosto(int costo) {
        this.costo = costo;
    }


    @Override
    public String toString() {
        return "Nodo=" +
                "vertice :'" + vertice + '\'' +
                ", costo :" + costo +
                '}';
    }
}
