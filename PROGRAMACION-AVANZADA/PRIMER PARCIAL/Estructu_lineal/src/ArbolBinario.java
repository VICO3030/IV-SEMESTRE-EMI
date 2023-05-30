public class ArbolBinario <Llave extends  Comparable <Llave>,Valor>{
    private Nodo raiz;
    private class  Nodo {
     private Llave llave;
     private Valor valor ;
     private Nodo izquierdo;
     private Nodo derecho;
     private int tam;

        public Nodo(Llave llave, Valor valor, int tam) {
            this.llave = llave;
            this.valor = valor;
            this.tam = tam;
        }
    }
    public ArbolBinario(){
    }
    public boolean esta_vacia(){
        return raiz == null;
    }
    public int get_Tam(){
        return get_Tam(raiz);

    }
    public int  get_Tam(Nodo x){
        if(x==null){
            return 0 ;//caso base
        }
        else{
            return x.tam;
        }
    }
    public Valor  get_element_by__llave(Llave l){
        return get_element_by__llave(raiz , l);

    }
    public Valor get_element_by__llave(Nodo x ,Llave l){
        if(x==null){
            return null;
        }
        int cmp=l.compareTo(x.llave);
        if(cmp< 0){
            return get_element_by__llave(x.izquierdo ,l);
        }
        else if(cmp>0){
            return get_element_by__llave(x.derecho ,l);
        }
        else{
            return x.valor;
        }
    }
    public void insertar(Llave  l , Valor v ){
        raiz = insertar(raiz ,  l , v);
    }
    private Nodo insertar (Nodo x  , Llave l , Valor v)  {
        if (x == null) {
            return new Nodo(l, v, 1);
        }
        int cmp = l.compareTo(x.llave);
        if (cmp < 0) {
            x.izquierdo = insertar(x.izquierdo, l, v);
        } else if (cmp > 0) {
            x.derecho = insertar(x.derecho, l, v);

        } else {
            throw new IllegalArgumentException();
        }

        x.tam = 1 + get_Tam(x.izquierdo) + get_Tam(x.derecho);
        return x;
    }

    public Llave Minimo(){
        while()
    }






}
