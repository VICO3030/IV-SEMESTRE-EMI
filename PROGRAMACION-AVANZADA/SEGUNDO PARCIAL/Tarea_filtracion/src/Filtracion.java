public class Filtracion extends Grupos03{

    private int[][] grilla;


    public Filtracion(int n){
        super(n*n);
        grilla = new int[n][n];
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                grilla[i][j] = 0;
            }
        }
    }

    public void abrir(int fila,int columna){
        if(grilla[fila][columna] == 0){
            grilla[fila][columna] = 1;
        }

    }

    public boolean esta_abierto(int fila, int columna){
        return grilla[fila][columna] == 1;
    }

    public boolean esta_lleno(int fila,int columna){
        return grilla[fila][columna] == 1 && true;
    }


}
