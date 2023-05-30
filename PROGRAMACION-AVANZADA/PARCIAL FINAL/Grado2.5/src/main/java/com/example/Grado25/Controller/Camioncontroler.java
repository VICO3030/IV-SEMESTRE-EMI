package com.example.Grado25.Controller;

import com.example.Grado25.Modelo.Camion;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.LinkedList;
import java.util.List;

@RestController
public class Camioncontroler {
    //para que se ejecute esto/
    @RequestMapping(value="prueba")
    public List<Camion> prueba() {
        List<Camion> lista=new LinkedList<>();
        lista.add(new Camion(1,"sde-895",45));
        lista.add(new Camion(2,"sde-895",45));
        lista.add(new Camion(3,"mkd-895",90));
        return (lista);
    }

    @RequestMapping(value="buscar/{peso}")
    public List<Camion> buscar(@PathVariable int peso){
        List<Camion> lista=new LinkedList<>();

        lista.add(new Camion(1,"874-dxd",84));
        lista.add(new Camion(1,"874-dxd",300));
        lista.add(new Camion(1,"874-dxd",582));
        lista.add(new Camion(1,"874-dxd",896));
        List<Camion> buscados=new LinkedList<>();
        for(Camion c:lista){
            if(c.getCarga()>peso){
                buscados.add(c);
            }
        }
        return (buscados);
    }
}