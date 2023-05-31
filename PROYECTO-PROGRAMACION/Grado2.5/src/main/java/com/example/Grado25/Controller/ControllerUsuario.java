package com.example.Grado25.Controller;

import com.example.Grado25.Modelo.Usuario;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.LinkedList;
import java.util.List;

@RestController
public class ControllerUsuario {
    @RequestMapping(value="pruebatabla")
    public List<Usuario> prueba21(){
        List<Usuario> lista  = new LinkedList<>();
        lista.add(new Usuario("1","Juan " , "Perez" ,  "algo@der.com" , "7899641"));
        lista.add(new Usuario("2","Luis" , "Tapia" , "luis@gmail.com","899631"));
        lista.add(new Usuario("3","Uriona " , "Camba ","uriona12@gmail", "45586936"));
        lista.add(new Usuario("4","mateo" , "espinoza", "mteo45@gmail.com","76955600"));
        return lista;

    }


}
