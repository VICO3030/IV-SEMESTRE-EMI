public class Detectado implements  Comparable{
    private int distancia;
    private int camiseta;

    public Detectado(int distancia, int camiseta) {
        this.distancia = distancia;
        this.camiseta = camiseta;
    }

    public Detectado() {

    }

    public int getDistancia() {
        return distancia;
    }

    public void setDistancia(int distancia) {
        this.distancia = distancia;
    }

    public int getCamiseta() {
        return camiseta;
    }

    public void setCamiseta(int camiseta) {
        this.camiseta = camiseta;
    }


    //se genra automatico
    //esto es para oder usar el ordenar hay que volverlo comparable implementando comparable
    @Override
    public int compareTo(Object o) {
        Detectado otro =(Detectado) o;
        if(this.distancia>otro.getDistancia()){
            return 1;
        }
        else if(this.distancia< otro.getDistancia()){
            return -1;
        }
            return 0;
    }

}
