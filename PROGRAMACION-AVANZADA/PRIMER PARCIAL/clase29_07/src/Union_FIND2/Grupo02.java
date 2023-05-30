package Union_FIND2;

import static java.nio.file.Files.find;
import java.util.Scanner;

public class Grupo02 {
    Scanner pedir = new Scanner(System.in);
    private int tam;
    private int[] padres;
    private int num_grupos;

    Grupo02(int tam) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    public int getNum_grupos() {
        return num_grupos;
    }


    public Grupo02(int tam, int[] padres, int num_grupos) {
        this.tam = tam;
        this.padres = new int[this.tam];
        this.num_grupos = num_grupos;
        for(int i=0 ; i<this.tam ;i ++){
            padres[i]= i; ///  i= 0 , padre[0]=0
        }
    }

    
    public int find(int i){
        while(i!=padres[i]){
            i=padres[i];
        }
        return i;
    }
    //buscamos el papa de la raiz de  papa 
    public boolean conectados(int p , int  q){
            return find(p) == find(q);//saber dos nodos si estan conectados
    }
    public void conectar(int p , int q ){
        int i =find(p);
        int j= find(q);
        if (!conectados(p,q)){
         padres[i]=j;
         num_grupos--;
          
        }

    }
}
