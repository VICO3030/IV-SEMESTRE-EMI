import Librerias.PrograAvan.NoLineal.Grupos03;
public class Filtrado {
    private Celda[][] sitios;
    private Grupos03 conexiones ;
    private int tope ;
    private int base;
    private int dimension;
    private int abiertos ;

    class Celda{
        public Celda(){

        }
    }

    public Filtrado(int  n ){
        this.sitios = new Celda[n][n];//instaciada el tamano de la matris
        this.dimension  =  n ;
        this.conexiones = new Grupos03(n * n +2);//cuantos noso tiene  , n para que tome erl mismo valor
        this.tope = n * n ;
        this.base  =  n * n +1;
        this.abiertos  = 0 ;

    }
    public void abrir(int fila  ,  int columna){
        //metodo aplanar
        int id_aplanado  = aplanar(fila , columna);
        if(esta_abierto(fila,columna)){
            return;
        }
        sitios[fila-1][columna -1] =  new Celda();
        this.abiertos++;
        if(fila ==this.dimension ){
            conexiones.conectado(this.base , id_aplanado);
        }
        if(fila ==1){
            conexiones.conectado(this.tope ,id_aplanado );
        }
        if(es_valido(fila+1 , columna) && esta_abierto(fila+1 ,columna)){
            conexiones.conectado(id_aplanado , aplanar(fila+1 , columna)-1);
        }
        if(es_valido(fila-1 , columna) && esta_abierto(fila-1 , columna)){
            conexiones.conectado(id_aplanado , aplanar(fila-1 , columna)-1);
        }
        if(es_valido(fila , columna+1)&& esta_abierto(fila , columna+1)){
            conexiones.conectado(id_aplanado , aplanar(fila , columna+1)-1);
        }
        if(es_valido(fila,columna-1 ) && esta_abierto(fila  , columna-1)){
            conexiones.conectado(id_aplanado , aplanar(fila , columna-1)-1);
        }
    }

    private boolean es_valido(int fila, int columna) {
            fila = fila -1;
            columna = columna -1;
            return (fila <this.dimension && columna <this.dimension && fila >=0 && columna >=0);
    }

    private boolean esta_abierto(int fila, int columna) {
            if(es_valido(fila , columna)){
                return   sitios[fila-1 ][columna-1] !=null;
            }
            return false;
    }
    private boolean  esta_lleno(int fila , int columna ){
        return  conexiones.Conectados(aplanar(fila , columna)-1,this.tope);

    }

    public int getAbiertos() {
        return abiertos;
    }

    public boolean hay_filtrado(){
        return conexiones.Conectados(this.tope  , this.base);
    }

    private int aplanar(int fila, int columna){
        return this.dimension * (fila-1)+columna;
        //identificar la coordenada , lo que me est adevolviendo es un entero
    }
}
