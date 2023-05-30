package com.example.demo.Modelo.JudoModel;

public class Club {

    private String nombre;
    private double personeria;
    private String direc;

    public Club(String nombre, double personeria, String direc) {
        this.nombre = nombre;
        this.personeria = personeria;
        this.direc = direc;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getPersoneria() {
        return personeria;
    }

    public void setPersoneria(double personeria) {
        this.personeria = personeria;
    }

    public String getDirec() {
        return direc;
    }

    public void setDirec(String direc) {
        this.direc = direc;
    }

   /* public void Inscribir(Judo j){
        Integer m;
        if(Judo.es_vacio()){
            m=1;
        }
        else{
            m = Judo.get_max()+1;
        }
        this.Judo.insertar(m,j);
    }*/
    @Override
    public String toString() {
        return "Club{" +
                "nombre='" + nombre + '\'' +
                ", personeria=" + personeria +
                ", direc='" + direc + '\'' +
                '}';
    }
}
