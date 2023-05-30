package com.example.judokas.Controlador;

import com.example.judokas.Modelo.*;
import com.example.judokas.Modelo.PrograAvan.Lineal.Lista;

public class main_prueba {
    public static void main(String[] args) {

        JUDOKA xd=new JUDOKA("pablo","rodriguez",'M',"1988-09-29","-81",90);
        JUDOKA xdextra = new JUDOKA("pablo","sanabria",'M',"1988-09-29","-1",90);

        JUDOKA xd1=new JUDOKA("Andres","Guti",'M',"2000-09-29","-81",90);
        JUDOKA xV=new JUDOKA("Leo","Eguino",'M',"1988-09-29","-81",90);
        JUDOKA xV1=new JUDOKA("Pablito","Sanabria",'F',"2000-09-29","+78",90);

        JUDOKA xP=new JUDOKA("Andresito","andrade",'M',"1988-09-29","-81",90);
        JUDOKA xP1=new JUDOKA("Luisito","Perez",'F',"2000-09-29","+78",90);

        //CLUBES

        Club c1 = new Club("COBRA KAI", "C27234", "CALLE LA PAZ #1210");
        Club c2 = new Club("COCHABAMBITA", "C13214", "CALLE ORURO #2");
        Club c3 = new Club("PORTOBELLO", "C27578", "CALLE POTOSI # 23");
        Club c4 = new Club("BRUCE LEE XD", "C90876", "CALLE LA PAZ #2005");
        Club c5 = new Club("REAL MADRID", "C27", "CALLE SUCRE # 23");
        Club c6 = new Club("BAYER MUNICH", "C96", "CALLE LLALLAGUA #2005");

        //MUNICIPIOS

        Estatica.municipios.insertar(new Municipio("SAN JOSE","3213"));
        Estatica.municipios.insertar(new Municipio("SAN JULIAN","323"));
        Estatica.municipios.insertar(new Municipio("SAN JORGE","213"));

        Estatica.municipios.get(0).anadir_club(c1);
        Estatica.municipios.get(0).anadir_club(c2);
        Estatica.municipios.get(1).anadir_club(c3);
        Estatica.municipios.get(1).anadir_club(c4);
        Estatica.municipios.get(2).anadir_club(c5);
        Estatica.municipios.get(2).anadir_club(c6);

        Estatica.municipios.get(0).getClubes().get(0).anadir_Judoka(xd);
        Estatica.municipios.get(0).getClubes().get(0).anadir_Judoka(xdextra);
        Estatica.municipios.get(0).getClubes().get(1).anadir_Judoka(xd1);
        Estatica.municipios.get(1).getClubes().get(0).anadir_Judoka(xV);
        Estatica.municipios.get(1).getClubes().get(1).anadir_Judoka(xV1);
        Estatica.municipios.get(2).getClubes().get(0).anadir_Judoka(xP);
        Estatica.municipios.get(2).getClubes().get(1).anadir_Judoka(xP1);

        //PREGUNTA 1
        System.out.println("PREGUNTA 1");
        Lista<JUDOKA> misma_cat = Estatica.municipios.get(0).getClubes().get(0).obtener_cates("-81"); //SE LE ASIGNA CUALQUIER CATEGORIA, LA CAEGORIA ES STRING
        for(JUDOKA j : misma_cat){
            System.out.println(j);
        }

        System.out.println();
        System.out.println("PREGUNTA 2");

        //PREGUNTA 2
        Club c []= Estatica.municipios.get(0).ordenar_clubes(); //SE RESCATA A LOS CLUBES ORDENADOS DE UN MUNICIPIO SEGUN SUS INTEGRANTES
        ///METODO IMPLEMENTADO EN MUNICIPIO, DEVUELVE UN VECTOR
        for(int i=0;i<c.length;i++){
            System.out.println(c[i]); // MUESTRA A LOS CLUBES ORDENADOS
        }


        System.out.println();
        System.out.println("PREGUNTA 3");
        //PREGUNTA 3
        JUDOKA judo []= Estatica.municipios.get(0).get_judokas_mismo_id(1); //SE RESCATA A LOS JUDOKAS DE UN MUNICIPIO SEGUN EL ID
        ///METODO IMPLEMENTADO EN MUNICIPIO, DEVUELVE UN VECTOR
        for(int i=0;i<c.length;i++) {
            System.out.println(judo[i]); // MUESTRA A LOS JUDOKAS CON UN MISMO ID
        }

        //PREGUNTA 4
        //IMPLEMENTE EL METODO TRASPASO EN MUNICIPIO
        //UTILIZA EL METODO ELIMINAR IMPLEMENTADO EN ARBOL RB
    }
}
