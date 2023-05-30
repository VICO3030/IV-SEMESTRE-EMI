import java.util.Scanner;
public class Grupo {
    static int[] padre=new int[1000000];
    public static void main(String[] args) {
        Scanner gg=new Scanner(System.in);
        int n=gg.nextInt(); 	//numero de conjunto al inicio
        iniciar(n);
        union(1,2);         	//unimos el conjunto 1 y 2
        union(2,3);         	//unimos el conjunto 2 y 3
        union(2,4);         	//unimos el conjunto 2 y 4
        union(6,5);         	//unimos el conjunto 6 y 5
        union(4,2);         	//unimos el conjunto 4 y 2 que como ya no estan unidos no cambiara nada
        System.out.println(mismoConjunto(1, 2));//con esto comprobamos si estan en el mismo conjunto
        System.out.println(mismoConjunto(1, 5));
        for (int i = 1; i <= n; i++) {
            System.out.print(padre[i]+" ");
        }
        //si cambiamos el union(a,b) por el union2(a,b) este es mas eficiente
        //pero olvida los niveles de nuestro arbol para lo cual habria que ver
        //algunas alternativas
    }
    public static void iniciar(int n){
        for (int i = 1; i <=n; i++) {
            padre[i]=i;
        }
    }
    public static int Find(int x){
        if(x==padre[x])
            return x;
        return Find(padre[x]);
    }
    public static void union(int x, int y){
        int u=Find(x),v=Find(y);
        if(u!=v){
            padre[y]=x;
        }
        //padre[v]=u;
    }
    public static boolean mismoConjunto(int x,int y){
        int u=Find(x),v=Find(y);
        return v==u;
    }
    public static int Find2(int x){
        if(x==padre[x])
            return x;
        return padre[x]=Find2(padre[x]);
    }
    public static void union2(int x, int y){
        int u=Find2(x),v=Find2(y);
        padre[v]=u;
    }

}
