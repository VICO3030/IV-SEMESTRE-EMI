package com.example.judokas.Controlador;

import com.example.judokas.Modelo.Club;
import com.example.judokas.Modelo.Estatica;
import com.example.judokas.Modelo.Municipio;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.stage.Stage;

import java.net.URL;
import java.util.ResourceBundle;

public class REGISTRARCLUBES implements Initializable {
    public Label lblIngrese;
    public Label lblNombre;
    public ComboBox cmbMunicipio;
    public TextField txtNombre;
    public TextField txtPersoneria;
    public TextField txtDireccion;
    public Button btnRegistrar;
    private Stage stage;
    public void setVentanaprincipal(Stage stage)
    {
        this.stage=stage;
    }

    public void ClickRegitrarClub(MouseEvent mouseEvent) {

        int id=cmbMunicipio.getSelectionModel().getSelectedIndex();
        Estatica.municipios.get(id).anadir_club(new Club(txtNombre.getText(),txtPersoneria.getText(),txtDireccion.getText()));
    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        cmbMunicipio.getItems().removeAll(cmbMunicipio.getItems());
        for(Municipio n: Estatica.municipios){
            cmbMunicipio.getItems().add(n.getNombre());
        }
    }
}
