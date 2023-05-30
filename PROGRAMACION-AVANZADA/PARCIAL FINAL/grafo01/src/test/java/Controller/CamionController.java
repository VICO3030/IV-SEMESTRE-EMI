package Controller;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController//para que venga unna solicitud del url   , para que ejecute alguna funcion como controlador
public class CamionController {
    //nuestro metodo
    //omo hacemos para enlzar ese mensaje para que le llegue
    @RequestMapping(value="prueba2.0")
    public String prueba(){
        return ("Este es una prueba ");
    }




}
