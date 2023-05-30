
import com.sun.jdi.PathSearchingVirtualMachine;

public class demo01 {
   // Nodo <string? pando  = new Nodo<>("item, |)PSVPPPS
   public static void main(String[] args) {

       //Creacion de los departamentos de los Nodos
       Nodo <String>  pando  = new Nodo<>("PANDO ");
       Nodo<String >  beni =new Nodo<>("BENI");
       Nodo<String >  chuq =new Nodo<>("CHUQUISACA");
       Nodo<String >  santa = new Nodo<>("SANTA CRUZ");
       Nodo<String > tarija =new Nodo<>("TARIJA");
       Nodo<String > Oruro =new Nodo<>("ORURO");
       Nodo<String> LaP= new Nodo<>("LA PAZ");
       Nodo<String>  pot= new  Nodo<>("POTOSI");
       Nodo<String>  cbba = new Nodo<>("COCHABAMBA");
      // System.out.println( cbba.toString());//se mostraria el nombew y el enlace

       //Asignacion Arista (origen , llegada  , mas el costo del viaje
       //conectamos todos contra todos
       pando.add_enlace(new Arista<>(pando , LaP ,200));
       pando.add_enlace(new Arista<>(pando , beni , 150));

       beni.add_enlace(new Arista<>(beni , LaP,130));
       beni.add_enlace(new Arista<>(beni,cbba,150));
       beni.add_enlace(new Arista<>(beni,santa,130));

       santa.add_enlace(new Arista<>(santa , cbba ,80) );
       santa.add_enlace(new Arista<>(santa , chuq ,80) );

       cbba.add_enlace(new Arista<>(cbba ,LaP  , 45));
       cbba.add_enlace(new Arista<>(cbba ,Oruro  , 115));
       cbba.add_enlace(new Arista<>(cbba ,chuq  , 45));
       cbba.add_enlace(new Arista<>(cbba ,pot, 78.3));


       //mostrado del grafo  le asignamos ante todo los departamentos que hemos llenado
       Grafo <String> g = new Grafo<>();

      g.addNodo(pando);

       g.addNodo(beni);

       g.addNodo(santa);

       g.addNodo(cbba);

       //mostramos el graf o
       System.out.println(g.toString());

   }
}
