package com.example.judokas.Modelo;

import com.example.judokas.Modelo.PrograAvan.Lineal.Lista;
import com.example.judokas.Modelo.PrograAvan.Lineal.Ordenamiento;

public class Municipio {
    String nombre;
    String personeria;
    Lista<Club> clubes;
    Lista<JUDOKA> cat81;

    public Municipio(String nombre, String personeria) {
        this.nombre = nombre;
        this.personeria = personeria;
        this.clubes = new Lista<Club>();
        this.cat81 = new Lista<JUDOKA>();
    }

    public Lista<JUDOKA> getCat81() {
        return cat81;
    }

    public void setCat81(Lista<JUDOKA> cat81) {
        this.cat81 = cat81;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getPersoneria() {
        return personeria;
    }

    public void setPersoneria(String personeria) {
        this.personeria = personeria;
    }

    public Lista<Club> getClubes() {
        return clubes;
    }

    public void anadir_club(Club club) {

        this.clubes.insertar(club);
    }
    public void mostrarClubes()
    {
        for (Club c: clubes)
        {
            System.out.println("______________________________________________________________________________________________");
            System.out.println(c);
            System.out.println("______________________________________________________________________________________________");
            c.mostrarJudokas();
        }
    }
    public void mostrarJu()
    {
        for (Club c: clubes)
        {
            c.mostrarJudokas();
        }
    }


    //METODO QUE DEVUELVE UN VECTOR CON LOS CLUBES ORDENADOS
    public Club [] ordenar_clubes(){
        Club [] Cordenados = new Club[clubes.getTam()];
        for(int i =0; i<clubes.getTam();i++){
            Cordenados[i] = clubes.get(i);
        }
        Ordenamiento.merge_sort(Cordenados);
        return Cordenados;
    }

    public JUDOKA [] get_judokas_mismo_id(int llav){
        JUDOKA [] misma_llave = new JUDOKA[clubes.getTam()];
        int con = 0;
        for(Club c: clubes){
            misma_llave[con] = c.getJudokas().getValorByLlave(llav);
            con++;
        }
        return misma_llave;
    }


    //METODO TRASPASO
    public void traspaso(Lista<Municipio> M, String c, String nombre){
        JUDOKA encontrado;
        for(Municipio muni: M){
            int cclub = 0;
            for(Club cu: muni.clubes){
                int cjud = 1;
                for(int i = 0; i<muni.clubes.get(cclub).getJudokas().get_tam();i++){
                    if(muni.clubes.get(cclub).getJudokas().getValorByLlave(cjud).nombre == nombre){
                        encontrado = muni.clubes.get(cclub).getJudokas().getValorByLlave(cjud);
                        muni.clubes.get(cclub).getJudokas().eliminar_nodo_by_llave(cjud);
                    }
                    cjud++;
                }
                cclub++;
            }
        }
    }

    public void obtener_cat81(){
        for(Club c: clubes){
            int i = c.getJudokas().get_tam();
            for(int j = 1; j<= i; j++){
                JUDOKA x = c.getJudokas().getValorByLlave(j);
                if(x.getCategoria() == "-81"){
                    cat81.insertar(x);
                }
            }
        }
    }
    /*public void mostrarCat(String ca){
        for(Club c : clubes){
            c.mostrarPorCategorias(ca);
        }
    }*/
    @Override
    public String toString() {
        return "Municipio{" +
                "nombre='" + nombre + '\'' +
                ", personeria='" + personeria + '\'' +
                '}';
    }
}
