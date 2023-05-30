package com.example.judokas.Controlador;

import com.example.judokas.Modelo.Estatica;
import com.example.judokas.Modelo.Municipio;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.stage.Stage;

import java.net.URL;
import java.util.ResourceBundle;

public class REGISTRARMUNICIPIOS implements Initializable {
    public Label lbl_RegistroMunicipios;
    public Label lblNombre;
    public Label idPersoneria;
    public TextField txtNomM;
    public TextField txtPersoneriaM;
    public Button btnRegistrar;
    public ListView lstMunicipios;
    private Stage stage;
    public void setVentanaprincipal(Stage stage)
    {
        this.stage=stage;
    }

    public void clickRegistrar(MouseEvent mouseEvent) {

        Estatica.municipios.insertar(new Municipio(txtNomM.getText(),txtPersoneriaM.getText()));
        lstMunicipios.getItems().removeAll(lstMunicipios.getItems());
        for (Municipio n:Estatica.municipios)
        {
            lstMunicipios.getItems().add(n.getNombre());
        }
    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        lstMunicipios.getItems().removeAll(lstMunicipios.getItems());
        for (Municipio n:Estatica.municipios)
        {
            lstMunicipios.getItems().add(n.getNombre());
        }

    }
}
