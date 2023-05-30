package com.example.demo.Controlador;

import com.example.demo.Modelo.JudoModel.Municipio;
import com.example.demo.PrograAvan.Lineal.Lista;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;

public class MunicipioView {
    public Button btn_registrar ;
    public Label lbl_nomMuni    ;
    public Label lbl_cantClubes ;
    public TextField txt_Muni   ;
    public TextField txt_cantClub   ;
    public TextField txt_afiliados  ;
            public TextField txt_ubicacion  ;
    public TextField txt_url    ;
    public TextField txt_contact    ;
    public TextField txt_direct ;
    public Label lbl_cantDirec  ;
    public TextField txt_NomMuni    ;
    Lista<Municipio> muni = new Lista<>();
    public void RegitrarMuni(MouseEvent mouseEvent) {
        //Municipio munip = new Municipio(Integer.parseInt(txt_afiliados.getText()) ,txt_NomMuni.getText() , txt_ubicacion.getText() , txt_direct.getText() , txt_afiliados.getText(),txt_contact.getText(),txt_url.getText());
    }
}
