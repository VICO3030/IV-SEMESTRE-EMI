package union_find;

public class grupos {
    private int [] id;
    private int num_grupos;
    
    public grupos(int n){
        this.num_grupos=n;
        //inicalizamo el vector resevando memoria
        id = new int [n];
        for(int i=0; i<n ;i++){
            id[i]=i;
        }
    }
    
    public int get_num_grupos(){
        return num_grupos;
    }
    //saber a  que grupo pertenece 
    public int find(int p){
        return id[p];
    }
    public boolean conectados(int p ,int q){
        return id[p]== id[q];
    }
    //acemos la conexion
    public void conectar(int p , int q){
        if(conectados(p,q)){
           return;
        }
        int idp=id[p];//idp agarra el contenido
        for(int i=0; i<id.length;i++){
            id[i]=id[q];
        }
        num_grupos--;
        
    }
 
    
}
