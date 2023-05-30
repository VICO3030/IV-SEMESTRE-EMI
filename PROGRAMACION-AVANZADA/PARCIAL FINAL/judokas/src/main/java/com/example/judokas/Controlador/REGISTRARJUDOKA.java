package com.example.judokas.Controlador;

import com.example.judokas.HelloApplication;
import com.example.judokas.Modelo.Club;
import com.example.judokas.Modelo.Estatica;
import com.example.judokas.Modelo.JUDOKA;
import com.example.judokas.Modelo.Municipio;
import com.example.judokas.Modelo.PrograAvan.Lineal.Lista;
import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class REGISTRARJUDOKA implements Initializable  {
    public Label lbl_fech;
    public TextField txtFecha;
    public Label lblPeso;
    public TextField txtPeso;
    public RadioButton rdbM;
    public RadioButton rdbF;
    public ComboBox cmbCat;
    public ComboBox cmbClubes;
    public ComboBox cmbMunicipio;

    public AnchorPane frmMain;
    public Label lblNombre;
    public TextField txtNombrej;
    public Label lblApellido;
    public TextField txtApellidoj;
    public Label lblCategoria;
    public TextField txtCategoria;
    public Label lblGenero;
    public TextField txtGenero;
    public Button btnRegistrar;
    private Stage stage;
    public void setVentanaprincipal(Stage stage)
    {
        this.stage=stage;
    }
    public void ejmplito(MouseEvent mouseEvent) {
    }

    public void clickRegistrar(MouseEvent mouseEvent) {
        char genero;
        if (rdbF.isSelected()) genero='F';
        else genero='M';
        JUDOKA j;
        j =new JUDOKA(txtNombrej.getText(),txtApellidoj.getText(),genero,txtFecha.getText(),cmbCat.getSelectionModel().getSelectedItem().toString(),Float.parseFloat(txtPeso.getText()));
        int idMunis=cmbMunicipio.getSelectionModel().getSelectedIndex();
        int idClub=cmbClubes.getSelectionModel().getSelectedIndex();
        Estatica.municipios.get(idMunis).getClubes().get(idClub).anadir_Judoka(j);

        System.out.println(j);
        for(Municipio n: Estatica.municipios){
            System.out.println(n);
            n.mostrarClubes();
        }
    }

    public void cambiarF(MouseEvent mouseEvent) throws IOException {
        if(rdbF.isSelected()==rdbM.isSelected()){
            rdbF.setSelected(false);
        }
        System.out.println(cmbCat.getSelectionModel().getSelectedItem());

        cmbCat.getItems().removeAll(cmbCat.getItems());
        cmbCat.getItems().addAll("-60", "-66", "-73", "-81", "-90", "-100", "+100");
    }

    public void cambiarM(MouseEvent mouseEvent) {
        if(rdbF.isSelected()==rdbM.isSelected()){
            rdbM.setSelected(false);
        }
        cmbCat.getItems().removeAll(cmbCat.getItems());
        cmbCat.getItems().addAll("-48", "-52", "-57", "-63", "-70", "-78", "+78");

    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {



        cmbCat.getItems().removeAll(cmbCat.getItems());
        cmbMunicipio.getItems().removeAll(cmbMunicipio.getItems());
        for (Municipio m:Estatica.municipios){
            cmbMunicipio.getItems().add(m.getNombre());
        }
        cmbCat.getItems().addAll("SELECCIONE UN GENERO");
        cmbCat.getSelectionModel().select("");
    }

    public void cambiarMunicipio(ActionEvent actionEvent) {
        int idMunis=cmbMunicipio.getSelectionModel().getSelectedIndex();
        System.out.println(idMunis);
        cmbClubes.getItems().removeAll(cmbClubes.getItems());
        Lista <Club>c=Estatica.municipios.get(idMunis).getClubes();
        for(Club n:c){
            System.out.println(n);
            cmbClubes.getItems().add(n.getNombre());
        }
    }

    public void cambiarMunicipio2(MouseEvent mouseEvent) {

    }

    public void cambiarClub(MouseEvent mouseEvent) {

    }
}
