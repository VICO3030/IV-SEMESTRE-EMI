package union_find;

import java.lang.management.ManagementFactory;
import java.lang.management.ThreadMXBean;

public class Cronometro {
    private static final double NANO2SEG = 1000000000;
    private long incio;
    private final ThreadMXBean hilo;

    public Cronometro() {
        hilo = ManagementFactory.getThreadMXBean(); //incializamos nuestro hilo al microprocesaddor
        incio= hilo.getCurrentThreadCpuTime();      //automaticamente incio va tener el momento que se esta inciando el algoritmo


    }
    public double get_tiempo(){
        long ahora =hilo.getCurrentThreadCpuTime();
        return (ahora - incio)/NANO2SEG;        //paramos el tik tak

    }
}
