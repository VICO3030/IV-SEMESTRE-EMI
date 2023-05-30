import PrograAvan.Cola;
import PrograAvan.Cola;
import jdk.swing.interop.SwingInterOpUtils;

public class demo {
    public static void main(String[] args) {
        Gerente g1=new Gerente(1234  ,"12456" );
        g1.setSalario(9000);
        Vendedor v1 = new Vendedor("2365",567,5000,50,0.6);
        Vendedor v2 = new Vendedor("785",57,7000,80,0.6);
        Vendedor v3 = new Vendedor("365",67,8000,90,0.5);
        Vendedor v4 = new Vendedor("235",63,2000,20,0.3);
        Vendedor v5 = new Vendedor("235",85,3000,30,0.1);
        Externo e1 = new Externo("AROMA", "78799655",556565,5,56,565656);
        Externo e2 = new Externo("Ayacucho", "78799655",78796,1,56,565656);
        Externo e3 = new Externo("tiquipaya", "78799655",45482,10,56,565656);
        Externo e4 = new Externo("prado", "78799655",12364,15,56,565656);
        Empleado[] planilla = new Empleado[9];
        planilla[0]=g1;
        planilla[1]=v1;
        planilla[2]=v2;
        planilla[3]=v3;
        planilla[4]=v4;
        planilla[5]=e1;
        planilla[6]=e2;
        planilla[7]=e3;
        planilla[8]=e4;

        for(int i= 0  ;i<planilla.length ; i++){
            planilla[i].mostrar();
        }

        Cola <Empleado> atencion = new Cola<>();
        atencion.Encolar(g1);
        atencion.Encolar(v1);
        atencion.Encolar(v2);
        atencion.Encolar(v3);
        atencion.Encolar(v4);
        atencion.Encolar(e1);
        atencion.Encolar(e1);
        atencion.Encolar(e2);
        atencion.Encolar(e3);
        atencion.Encolar(e4);

        for(Empleado x : atencion){ //recorriendo  x va tener el valor de caada uno de atencion  , la atencion es una cola paa mostrar
            x.mostrar();
            System.out.println("sueldo : "+x.get_salario());
        }

//arbol binario investigar  java


    }
}
