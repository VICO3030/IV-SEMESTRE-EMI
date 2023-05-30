package com.example.demo.Controlador;

import com.example.demo.Modelo.JudoModel.Judo;
import com.example.demo.Modelo.JudoModel.Persona;
import com.example.demo.PrograAvan.Lineal.Lista;
import javafx.fxml.Initializable;
import javafx.scene.control.*;
import javafx.scene.input.MouseEvent;
import javafx.stage.Stage;

import java.net.URL;
import java.util.ResourceBundle;

public class JudokaControl implements Initializable {
    public Label lbl_nom    ;
    public RadioButton rbd_mas  ;
    public RadioButton rbd_feme ;
    public Button btn_registrar ;
    public TextField txt_nom    ;
    public Label lbl_apellid   ;
    public TextField txt_apellidos ;
    public Label lbll_Cat   ;
    public Label lbl_peso   ;
    public TextField txt_peso   ;
    public Button btn_volver    ;
    public Button btn_limpiar   ;
    public ComboBox cmb_category    ;
    public ComboBox cmb_grado;
    public DatePicker dtp_fechanac  ;
    public Lista<Judo>  j1  = new Lista<>();

    public Label txt_telf;
    public TextField txt_telefe;
    public TextField txt_fechanac   ;
    //para la vetanan
    private PanelControl controlpanel;
    private Stage stage;
    public void sslufsr(MouseEvent mouseEvent) {
        System.out.println("hola mundo!!! bienvenido a la banda de locos");
        lbl_nom.setText("Cambio!!!");

    }


    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        cmb_grado.getItems().removeAll(cmb_grado.getItems());
        cmb_grado.getItems().addAll("Amarillo", "Naranja", "Verde", "Azul", "Cafe", "Negro");
        cmb_grado.getSelectionModel().select("");
    }

    public void CambiarM(MouseEvent mouseEvent) {
        if (rbd_mas.isSelected() == rbd_feme.isSelected())
        cmb_category.getItems().removeAll(cmb_category.getItems());
            cmb_category.getItems().addAll("-60", "-66", "-73", "-81", "-90", "-100", "+100");
        cmb_category.getSelectionModel().select("");
    }

    public void CambiarF(MouseEvent mouseEvent) {
        if (rbd_mas.isSelected() == rbd_feme.isSelected())
            rbd_mas.setSelected(!rbd_mas.isSelected());
            cmb_category.getItems().removeAll(cmb_category.getItems());
            cmb_category.getItems().addAll("-48", "-52", "-57", "-63", "-70", "-78", "+78");

    }


    public void registrado(MouseEvent mouseEvent) {
        //Condicion para saber f o m
        String aux;
        if(rbd_mas ==null){
            aux=rbd_feme.getText().toString();
        }else{
            aux = rbd_mas.getText().toString();
        }

       Judo judoka = new Judo(txt_nom.getText() , txt_apellidos.getText() , txt_fechanac.getText() , aux ,Double.parseDouble(txt_telefe.getText()) , Double.parseDouble(txt_peso.getText()) , cmb_category.getSelectionModel().getSelectedItem().toString() , cmb_grado.getSelectionModel().getSelectedItem().toString() );
        System.out.println("SE REGISTRO EL JUDOKA "+txt_nom.getText() + "su genero es "+aux);
        System.out.println(judoka.toString() + "Se registro correctamente!!");

    }

    public void init(Stage stage, PanelControl panelControl) {//pasamos la vcentana
        this.controlpanel = panelControl;
        this.stage =stage;
    }

    public void RegisMuni(MouseEvent mouseEvent) {
    }

    public void setVentanain(Stage ventana) {
        this.stage = ventana;
    }
}
