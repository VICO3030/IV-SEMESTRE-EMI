package com.example.demo.Controlador;

import com.example.demo.Controlador.JudokaControl;
import com.example.demo.HelloApplication;
import javafx.event.ActionEvent;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.input.MouseEvent;
import javafx.stage.Stage;

import java.io.IOException;

public class PanelControl {
    public Button btn_judoka    ;
    public Button btn_registrarClub ;
    private Stage  _stage;
    private HelloApplication ventanaIncial;


    public void cargarJudo(MouseEvent mouseEvent) throws IOException {
            ventanaIncial.MostrarJudokas();
    }

    public void setStage(Stage stage) {
        stage =_stage;
    }

    public void Cargamuni(MouseEvent mouseEvent) {

    }

    public void cargaClub(MouseEvent mouseEvent) {

    }

    public void setVentanaPrincipal(HelloApplication helloApplication) {
        this.ventanaIncial=helloApplication;
    }
}
