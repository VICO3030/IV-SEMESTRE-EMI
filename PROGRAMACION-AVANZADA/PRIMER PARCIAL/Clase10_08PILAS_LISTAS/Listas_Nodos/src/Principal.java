import Lineal_.Lista;

public class Principal {
    public static void main(String[] args) {

        //creamos las distimtas listas de diferentes tipos
        Lista<String> miLista_ente = new Lista<>();
        Lista<Integer> otra_Lista = new Lista<>();
        Lista<Estudiante> lista_estudiante = new Lista<>();
        //mostramos de  la lista  1
        miLista_ente.Insertar("juan");
        miLista_ente.Insertar("pedrito");
        miLista_ente.Insertar("caceres");
        //insertamos de la lista  2 de la lista 2
        otra_Lista.Insertar(4);
        otra_Lista.Insertar(14);
        otra_Lista.Insertar(24);
        otra_Lista.Insertar(44);
        otra_Lista.Insertar(48);
        otra_Lista.Insertar(94);
        //insertamos datos de la lista 3
        lista_estudiante.Insertar(new Estudiante("palotes",18,4));
        lista_estudiante.Insertar(new Estudiante("Fulano",18,8));
        lista_estudiante.Insertar(new Estudiante("juancarlos",28,5.1));

        //nuevo metodo para mostrar
       /* for(String cad : miLista_ente){
            System.out.println(cad);
        }*/
        for(Integer cad :otra_Lista){
            if(cad%2 ==0)
                System.out.println(cad);
        }

      /*  for(Estudiante e: lista_estudiante){
            System.out.println(e);
        }*/
        for(Estudiante e: lista_estudiante){
            if(e.getCalif()>5.1){
                System.out.println(e);
            }
        }

    }
}
