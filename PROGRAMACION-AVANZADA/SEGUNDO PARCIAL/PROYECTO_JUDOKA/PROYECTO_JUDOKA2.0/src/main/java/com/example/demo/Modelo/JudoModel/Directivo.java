package com.example.demo.Modelo.JudoModel;

import java.util.Date;

public class Directivo {
    public enum Cartera { PRESIDENTE , VICEPRESIDENTE , SECRETARIA , HACIENDA};
    private Cartera puesto;
    private Date fecha_inic;
    private Date fecha_final;

    public Directivo(Cartera puesto, Date fecha_inic, Date fecha_fina) {
        this.puesto = puesto;
        this.fecha_inic = fecha_inic;
        this.fecha_final = fecha_fina;
    }

    public Cartera getPuesto() {
        return puesto;
    }

    public void setPuesto(Cartera puesto) {
        this.puesto = puesto;
    }

    public Date getFecha_inic() {
        return fecha_inic;
    }

    public void setFecha_inic(Date fecha_inic) {
        this.fecha_inic = fecha_inic;
    }

    public Date getFecha_fina() {
        return fecha_final;
    }

    public void setFecha_fina(Date fecha_fina) {
        this.fecha_final = fecha_fina;
    }
}
