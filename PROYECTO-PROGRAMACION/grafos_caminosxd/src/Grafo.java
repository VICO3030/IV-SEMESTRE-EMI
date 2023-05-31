import java.util.*;

public class Grafo {
                    //puede ser lo que quireras
    private HashMap<String, ArrayList<Nodo>> grafo;
    private boolean dirigido;

    public Grafo(boolean dirigido) {
        grafo=new HashMap<>();
        this.dirigido = dirigido;
    }
    //aqui agrga costo
    public void agregarArista(String orig,String dest,int costo){
        crearArista(orig,dest,costo);
        if(!dirigido){
            crearArista(dest,orig,costo);
        }
    }
                                                  //crear a qui apla costo una nueva variable
    private void crearArista(String ori, String dest,int costo) {
        if(!grafo.containsKey(ori)){
            grafo.put(ori,new ArrayList<>());
        }
            grafo.get(ori).add(new Nodo(dest,costo));

    }
    public void eliminarArista(String ori,String dest){
        elimArista(ori,dest);
        if(!dirigido){
            elimArista(dest,ori);
        }
    }
    public void elimArista(String ori,String dest){
        ArrayList<Nodo> lista=grafo.get(ori);
        if(lista!=null){
            for(int i=0;i< lista.size();i++){
                Nodo ac=lista.get(i);
                if(ac.getVertice().equals(dest)){
                    lista.remove(i);
                }
            }
        }

    }

    public void eliminarVertice(String v){
        ArrayList<Nodo> lista=grafo.get(v);
        ArrayList<String> destinos=new ArrayList<>();
        for(Nodo n:lista){
            destinos.add(n.getVertice());
        }
        grafo.remove(v);
        for(String s:destinos){
            eliminarArista(s,v);
        }
    }

    public void agregarVertice(String v){
        grafo.put(v,new ArrayList<>());

    }

    public ArrayList<ArrayList<String>> caminos(String vo,String vd){
        ArrayList<ArrayList<String>> res=new ArrayList<>();
        ArrayList<String > camino=new ArrayList<>();
        camino.add(vo);
        ArrayList<Nodo> vecinos=grafo.get(vo);
        for(Nodo n:vecinos){
            String act=n.getVertice();
            ArrayList<String> copia=(ArrayList<String>)camino.clone();
            copia.add(act);
            caminos(act,vd,copia,res);

        }
        return res;
    }
    private void caminos(String vo,String vd,ArrayList<String> camino,ArrayList<ArrayList<String>>res){
        if(vo.equals(vd)){
            res.add(camino);
        }else{
            ArrayList<Nodo> vecinos=grafo.get(vo);
            if(vecinos!=null){
                for(Nodo n:vecinos){
                    String act=n.getVertice();
                    ArrayList<String> copia=(ArrayList<String>)camino.clone();
                    if(!copia.contains(act)){
                        copia.add(act);
                        caminos(act,vd,copia,res);
                    }


                }
            }

        }

    }

    public HashMap<String,Integer> dijkstra(String vo){
        HashMap<String, Integer> dist=new HashMap<>();
        PriorityQueue<String> cola=new PriorityQueue<>();
        for(String k:grafo.keySet()){
            dist.put(k,Integer.MAX_VALUE/2);

        }
        dist.put(vo,0);
        cola.add(vo);
        while(!cola.isEmpty()){
            String ac=cola.poll();
            ArrayList<Nodo> vecinos=grafo.get(ac);
            if(vecinos!=null){
                for(Nodo n:vecinos){
                    String verticesig=n.getVertice();
                    int costo=n.getCosto();
                    if(dist.get(ac)+costo<dist.get(verticesig)){
                        dist.put(verticesig,dist.get(ac)+costo);
                        cola.offer(verticesig);
                    }
                }
            }
        }
        return dist;
    }

    public List<String> gerar(String origem, String destino){
        List<String> resultado = new ArrayList<>();
        String no = destino;
        while(no != origem && this.grafo.containsKey(no)) {
            resultado.add(no);
            no = this.grafo.get(no).toString();
        }
        resultado.add(no);
        Collections.reverse(resultado);
        return resultado;
    }



    @Override
    public String toString() {
        return "Grafo{" +
                "grafo=" + grafo +
                ", dirigido=" + dirigido +
                '}';
    }
}
