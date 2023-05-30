package Librerias.PrograAvan.NoLineal;

import Librerias.PrograAvan.Lineal.Cola;
import Librerias.PrograAvan.Lineal.Nodo;
import Librerias.PrograAvan.Lineal.Pila;

public class Arbol_RN <Llave extends Comparable <Llave>,valor >{
    //constantes para el rojo el negro podemos tener el boolean
    private static final boolean  ROJO = true;
    private  static  final boolean NEGRO =false;
    public Pila <Nodo > p;
    public Cola<Nodo> c;
   private  Nodo raiz ;
   class Nodo {
       private Llave llave ;
       private valor valor ;
       private Nodo izq ;
       private  Nodo der ;


       private boolean  color  ;
       private int tam;
       public Nodo(Llave  l , valor v , boolean color   , int t ){
           this.llave  =   l;
           this.valor  = v;
           this.color = color;
           this.tam =  t;
           p=new Pila<>();
           c=  new Cola<>();


       }

   }
   //constructor
    public Arbol_RN() {
    }
    //copia de arbol binario
    public boolean esta_vacio(){
        return get_tam() == 0;
    }

    public int get_tam(){
        return get_tam(raiz);
    }
    public int get_tam(Nodo x){
        if (x == null){
            return 0;
        }
        else{
            return x.tam;
        }
    }

    public valor get_element_by_llave(Llave l){
        return get_element_by_llave(raiz, l);
    }
    private valor get_element_by_llave(Nodo x, Llave l){
        if (x == null){
            return null;
        }
        int cmp = l.compareTo(x.llave);
        if (cmp < 0){
            return get_element_by_llave(x.izq, l);
        }
        else if (cmp > 0){
            return get_element_by_llave(x.der, l);
        }
        else{
            return x.valor;
        }
    }//final de copia de arbol binario
    //funcion que verifica si es rojo o negro
    private boolean es_rojo(Nodo x ){
       if(x==null){//precisar vaya recorriendo quiere decir que es null es negro si es rojo
           return  NEGRO;
       }
       return x.color ==ROJO ;//detectaamos si es rojo o e otro color
    }
    //get valor no cambia porque todo va estar balanceado

    public void insertar(Llave llave  , valor  val ) {
       raiz  = insertar(raiz ,llave , val);
    }
    public Nodo insertar(Nodo x  , Llave l , valor  v ){
       if( x==null){
           return new Nodo( l , v , ROJO , 1);
       }
       //hazta aqui lo mismo que el binario
       int cmp =  l.compareTo(x.llave);
       if(cmp <0){
           //hacemos a llamada recursiva
           x.izq = insertar(x.izq  , l , v);
       }
       else {
          x.der =  insertar(x.der  , l , v);
       }
       //verificar el balanceado con los colores
        //caso03
        if(es_rojo(x.der)&& !es_rojo(x.izq)){
            x = rotar_izq(x);
        }
        //caso02
        if(es_rojo(x.izq) && es_rojo(x.izq.izq)){
            x =  rotar_der(x);
        }
        //caso 03
        if(es_rojo(x.izq) &&  es_rojo(x.der)){
            cambiar_color(x);
        }
        x.tam  = get_tam(x.izq ) + get_tam(x.der)+1;
        return x;
    }

    private void cambiar_color(Nodo x) {
        x.color   = !x.color;
        x.der.color =  !x.der.color;
        x.izq.color  =  !x.izq.color;
        //el de arriba normalente va ser negro
    }
    /***************************ROTACIONES ************************************ */
    private Nodo rotar_der(Nodo x) {
       //vamos a necesitar u auxiliar
        Nodo aux  = x.izq;
        x.izq = aux.der;
        aux.der  = x ;
        aux.color=aux.der.color;
        aux.der.color =ROJO;
        aux.tam= x.tam;
        x.tam  = get_tam(x.izq)+get_tam(x.der) +1;

        return aux;
    }
    ///verificmos que tenemos fxml
    private Nodo rotar_izq(Nodo x) {
        Nodo aux = x.der;
        x.der = aux.izq;
        aux.izq = x;
        aux.color = aux.izq.color;
        aux.izq.color=ROJO;
        aux.tam = x.tam;
        x.tam=get_tam(x.izq)+get_tam(x.der)+1;

            return  x;
    }
    //DOS TIPOS PARA MOSTRAR  ---> AMPLITUD  , PROFUNDIDAD
    //metodos de mostrar como metodo normal para que despues sea iterable
    public void Profuncidad(Llave x){
        Nodo aux;
        while (!p.esta_vacia()){
            aux= p.desempilar();
            System.out.println(aux.llave);
            if(aux.izq!=null)
                p.empilar(aux.izq);
            if(aux.der !=  null)
                p.empilar(aux.der);
        }
    }
    public void Balanceado(){
        Nodo aux;
        c.encolar(raiz);
        while (!c.esta_vacio()){
            aux = p.desempilar();
            System.out.println(aux.llave);
            if(aux.izq!=null) c.encolar(aux.izq);
            if(aux.der!= null) c.encolar(aux.der);
        }

    }


}
