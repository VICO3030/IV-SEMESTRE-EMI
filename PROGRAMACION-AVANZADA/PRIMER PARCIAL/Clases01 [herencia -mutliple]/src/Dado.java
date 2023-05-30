import java.util.Random;

public class Dado {
    private int numero;

    public Dado() {
    }

    public int getNumero() {
        return numero;
    }

    public void lanzar(){
        Random aleatorio = new Random();
        numero = aleatorio.nextInt(6)+1;
    }
}
