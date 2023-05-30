import Librerias.PrograAvan.Lineal.Ordenamiento;

public class Dectectado implements Comparable  {
    private  int distancia;
    private int camiseta;

    public Dectectado(int distancia, int camiseta) {
        this.distancia = distancia;
        this.camiseta = camiseta;
    }
    public Dectectado(){

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

    @Override
    public int compareTo(Object o) {
        Dectectado otro  =(Dectectado) o;
        if(this.distancia > otro.getDistancia()){
            return 1;
        }
        else if(this.distancia < otro.getDistancia())
            return -1;
        return 0;
    }




}
