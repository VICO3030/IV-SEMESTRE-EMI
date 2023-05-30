package com.example.grafo01.Controller;

import com.example.grafo01.Grafo.Arista;
import com.example.grafo01.Grafo.Grafo;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;

@RestController
public class GrafoController {
//nombre para ejecutar el puertoe
    @RequestMapping(value="grafo")
    public List<Grafo> grafo(){
        Queue<Integer> cp  = new PriorityQueue<>();
        Scanner lector  = null;
        try {
            lector = new Scanner(new File("grafo01.txt"));
        } catch (FileNotFoundException e) {
            throw new RuntimeException(e);
        }
        Grafo  g  = new Grafo(8);
        while(lector.hasNext()){
            g.addArista(new Arista(lector.nextInt() , lector.nextInt(), lector.nextDouble()));
        }
       List<Grafo> list=new ArrayList<>();
        list.add(g);
        return (list);
    }

}
