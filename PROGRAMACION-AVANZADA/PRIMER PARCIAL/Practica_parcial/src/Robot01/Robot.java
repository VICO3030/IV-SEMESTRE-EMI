package Robot01;

import jdk.swing.interop.SwingInterOpUtils;

import java.util.Scanner;

public class Robot {
    Scanner pedir = new Scanner (System.in);
    public String tipo;
    public int Insertar ;
    public String getTipo() {
        return tipo;
    }

    public Robot(String tipo) {
        this.tipo = tipo;
    }
     public void Movimiento(){
        int x=360, m;
        if(getTipo()=="LEFTH"){
            x-=90;
        }
        else if(getTipo()=="RIGHT"){
            x+=90;
        }
        else if(getTipo()=="TURN AROUND"){
            x+=180;
        }
        else if(getTipo()=="LEFTH X"){
            System.out.print("Inserte  m " );
            m=pedir.nextInt();
            x-=m;

        }
        else if(getTipo()=="RIGHT X"){
            System.out.print("Inserte  m " );
            m=pedir.nextInt();
            x+=m;

        }

         System.out.println(x);


    }
}
