import Lineal_.Cola;

public class demoCola2 {
    public static void main(String[] args) {
        Cola<Victor> anadir = new Cola<>();
        //anadimos al Encolar xd
        anadir.Encolar(new Victor("juan" ,30));
        anadir.Encolar(new Victor("jhazmin" ,10));
        anadir.Encolar(new Victor("leandro" ,15));
        anadir.Encolar(new Victor("victoria" ,55));

        //Desencolamos las 4  variables que anadimos
        while (!anadir.Esta_vacio()){
            Victor  m = anadir.Desencolar();
            System.out.println(m);
        }




    }
}
