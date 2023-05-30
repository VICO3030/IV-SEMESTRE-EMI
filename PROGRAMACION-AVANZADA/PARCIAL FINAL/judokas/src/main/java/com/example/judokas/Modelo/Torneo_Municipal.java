package com.example.judokas.Modelo;

import com.example.judokas.Modelo.PrograAvan.NoLineal.ArbolRB;

import java.util.Random;

public class Torneo_Municipal {
    String nombre;
    String fecha;
    ArbolRB<Integer, JUDOKA> competidores;
    ArbolRB<Integer, JUDOKA> competencia;
    int num_registro;
    Random r = new Random();

    public Torneo_Municipal(String nombre, String fecha) {
        this.nombre = nombre;
        this.fecha = fecha;
        competidores = new ArbolRB<>();
        competencia = new ArbolRB<>();
        num_registro = 0;
    }

    public void actuaizar_datos(){
        num_registro++;
    }

    public void registro_competidores(JUDOKA j){
        actuaizar_datos();;
        competidores.insertar(num_registro, j);
    }

    public boolean Round_Robin(){
        if(competidores.get_tam() <= 5) return true;
        else return false;
    }

    public void generar_competencia_simple(){
        competencia.insertar(8,null);
        competencia.insertar(4,null);
        competencia.insertar(12,null);
        competencia.insertar(2,null);
        competencia.insertar(6,null);
        competencia.insertar(10,null);
        competencia.insertar(14,null);
        competencia.insertar(1,null);
        competencia.insertar(3,null);
        competencia.insertar(5,null);
        competencia.insertar(7,null);
        competencia.insertar(9,null);
        competencia.insertar(11,null);
        competencia.insertar(13,null);
        competencia.insertar(15,null);
    }

    public int asignar_lugares(){
        int n;
        do{
            n = r.nextInt(competencia.get_tam()-1+1) + 1;
            if(n%2==0){
                n=n+1;
            }
        }while(competencia.getValorByLlave(n) != null);
        return n;
    }

    public void asignar_posiciones(){
        for (int i = 1; i <= competidores.get_tam(); i++) {
            competencia.getNodoByLlave(asignar_lugares()).valor = competidores.getValorByLlave(i);
        }
    }
    public void competir() {
        if (Round_Robin() == true) {
            int n;
            int  RR [][] = new int [competidores.get_tam()][competidores.get_tam()+1];

            //LLENADO DE VICTORIAS Y DERROTAS DE TODOS CONTRA TODOS
            for(int i = 0; i<competidores.get_tam();i++){
                for(int j = 0; j<competidores.get_tam();j++){
                    n = r.nextInt(1 - 0 + 1) + 0;

                    //CONDICIONAMOS QUE UN COMPETIDOR NO PUEDE COMPETIR CON SI MISMO
                    if(i == j){
                        RR[i][j] = 0;
                    }
                    else{
                        RR[i][j] = n;
                    }
                }
            }

            //SUMA DE TODAS LAS COMPETENCIAS DE CADA COMPETIDOR EN UNA COLUMNA FINAL
            int col = competidores.get_tam();
            for(int i = 0; i<competidores.get_tam();i++){
                int sum = 0;
                for(int j = 0; j<competidores.get_tam();j++){
                    sum = sum + RR[i][j];
                }
                RR[i][col] = sum;
            }

            //ENCONTRADO DEL MAYOR GANADOR
            int may = 0, pos = 0;
            for(int i = 0; i<competidores.get_tam();i++){
                if(may < RR[i][col]){
                    may = RR[i][col];
                    pos = i+1;
                }
            }
            System.out.println("EL GANADOR ES: " + competidores.getValorByLlave(pos) + " con: "+may+" victorias.");


            for(int i = 0; i<competidores.get_tam();i++){
                for(int j = 0; j<competidores.get_tam()+1;j++){
                    System.out.print(RR[i][j]);
                }
                System.out.println();
            }

        }
        else {
            int comp1 = 1, comp2 = 3;

            generar_competencia_simple();
            asignar_posiciones();

            int con = 2;

            for (int j = 1; j <= 4; j++) {
                if (competencia.getValorByLlave(comp1) != null && competencia.getValorByLlave(comp2) != null) {
                    int n = r.nextInt(2 - 1 + 1) + 1;
                    if (n == 1) {
                        competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp1);
                    } else competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp2);
                } else {
                    if (competencia.getValorByLlave(comp1) == null) {
                        competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp2);
                    } else competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp1);
                }
                con += 4;
                comp1 += 4;
                comp2 += 4;
            }

            con = 4;
            comp1 = 2;
            comp2 = 6;

            for (int j = 1; j <= 2; j++) {
                if (competencia.getValorByLlave(comp1) != null && competencia.getValorByLlave(comp2) != null) {
                    int n = r.nextInt(2 - 1 + 1) + 1;
                    if (n == 1) {
                        competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp1);
                    }
                    else competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp2);
                }
                else {
                    if (competencia.getValorByLlave(comp1) == null) {
                        competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp2);
                    }
                    else competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp1);
                }
                con += 8;
                comp1 += 8;
                comp2 += 8;
            }

            con = 8;
            comp1 = 4;
            comp2 = 12;

            int n = r.nextInt(2 - 1 + 1) + 1;
            if (n == 1) {
                competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp1);
            }
            else competencia.getNodoByLlave(con).valor = competencia.getValorByLlave(comp2);

            competencia.amplitud();

            System.out.println();
            System.out.println("EL GANADOR ES: "+ competencia.getValorByLlave(8));
        }
    }
}

