import java.util.Random;

public class Experimento {
    private int num_pruebas;
    private double[] result_pruebas;
    double acu =0;
    public Experimento(int n  , int pruebas){
        Random aleatorio  = new Random();

        int dimension  =n;
        num_pruebas = pruebas;
        result_pruebas =  new double[num_pruebas];
        for(int prueba = 0 ; prueba<num_pruebas ;prueba++){
            Filtrado f= new Filtrado(dimension);
            while (!f.hay_filtrado()){
                aleatorio.nextInt(1,n);
                int fila  = aleatorio.nextInt(1,dimension+1);
                int columna  = aleatorio.nextInt(1 ,dimension+1);
            }
            int abierto  = f.getAbiertos();
            double result=  (double) abierto /  (dimension *  dimension);
            result_pruebas[prueba]  = result;
            acu = acu+result;
        }
    }
    public double media(){
        //aqui tu codigo
     double total ;
     total  = this.acu/num_pruebas;
     return  total;
    }


}
