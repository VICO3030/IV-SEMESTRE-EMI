import Lineal_.Cola;

public class demoCola {
    public static void main(String[] args) {
        Cola<Estudiante> espera = new Cola<>();


       espera.Encolar(new Estudiante("victor",18,95));
        espera.Encolar(new Estudiante("FUlano1",18,95));
        espera.Encolar(new Estudiante("fulano2",17,95));
        espera.Encolar(new Estudiante("fulano 3 ",28,95));


        Estudiante e = espera.Desencolar();
        System.out.println(e);

        e= espera.Desencolar();
        System.out.println(e);
        e= espera.Desencolar();
        System.out.println(e);
        e= espera.Desencolar();
        System.out.println(e);
        //e= espera.Desencolar();
     //  System.out.println(e);

    }
}
