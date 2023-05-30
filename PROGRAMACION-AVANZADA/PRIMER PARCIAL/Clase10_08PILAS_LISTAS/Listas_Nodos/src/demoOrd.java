import Lineal_.Ordenamiento;

public class demoOrd {
    public static void main(String[] args) {
        Integer [] numeros = {6,3,9,1,8};


        Estudiante [] lista = new Estudiante[5];
        lista[0] = new Estudiante("vitor",20,96.3);
        lista[1]= new Estudiante("jhazmin" ,56,98.3);
        lista[2] = new Estudiante("pedro",30,96.3);
        lista[3]= new Estudiante("fulano" ,6,98.3);
        lista[4] = new Estudiante("manuel",15,96.3);

        Ordenamiento.merge_sort(lista);
        for(int i=0 ; i<lista.length ;i++) {            //compareTo trabaja con Objetos asi que  por eso declaramos com INTEGER
            System.out.println(lista[i]);
        }
    }
}
//:) :> :-) ;-_(  :[]  :-{()
