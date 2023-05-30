package ejer1_POO;
import java.util.Random;

public class Dado {
    private int numero;
    private int numero2;



    public int getNumero() {
        return numero;
    }

    public int getNumero2() {
        return numero2;
    }

    public  void  lanzar(){
        Random aleatorio = new Random();
        numero = aleatorio.nextInt(6)+1;
       numero2 = aleatorio.nextInt(6)+1;
    }
    public int Sumaa(){
        return getNumero()+getNumero2();
    }
}


