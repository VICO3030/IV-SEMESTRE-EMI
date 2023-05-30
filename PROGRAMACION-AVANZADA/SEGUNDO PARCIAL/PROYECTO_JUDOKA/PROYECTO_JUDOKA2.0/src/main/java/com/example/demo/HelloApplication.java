package com.example.demo;

import com.example.demo.Controlador.ClubCONTROLER;
import com.example.demo.Controlador.JudokaControl;
import com.example.demo.Controlador.PanelControl;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.Pane;
import javafx.stage.Stage;

import java.io.IOException;

public class HelloApplication extends Application {
    Stage stagepnel;
    AnchorPane rootPane;
    @Override
    public void start(Stage stage) throws IOException {
        this.stagepnel=  stage;
        MostrarPanel();

    }
    //mostrar planes
    public void MostrarPanel() throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(HelloApplication.class.getResource("PanelControl.fxml"));
        rootPane = (AnchorPane) fxmlLoader.load();
        Scene scene = new Scene(rootPane);
        stagepnel.setTitle("MENU PRINCIPAl");
        stagepnel.setScene(scene);

        //controlador
        PanelControl controller =  fxmlLoader.getController();
        controller.setVentanaPrincipal(this);

        stagepnel.show();
    }
    public void MostrarJudokas() throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(HelloApplication.class.getResource("JUDOKA_VIEW.fxml"));
        AnchorPane rjudokas = (AnchorPane) fxmlLoader.load();
        Stage ventana = new Stage();
        ventana.setTitle("CHOLO KRATOS");
        ventana.initOwner(stagepnel);
        Scene scene = new Scene(rjudokas);
        ventana.setScene(scene);
        JudokaControl controllerr = fxmlLoader.getController();
        controllerr.setVentanain(ventana);
        ventana.show();
    }

    public void MostrarClub() throws IOException {
        FXMLLoader loader  = new FXMLLoader(HelloApplication.class.getResource("Club_view.fxml"));
        AnchorPane rclubes =(AnchorPane) loader.load();
        Stage ventana2 = new Stage();
        ventana2.initOwner(stagepnel);
        //mostramos la nueva ventanan
        Scene scene  = new Scene(rclubes);
        ventana2.setScene(scene);
        //llamamos al controladore
        ClubCONTROLER controller2 = loader.getController();
        controller2.setVenata(ventana2);
        ventana2.show();

    }

    @Override
    public void init() throws Exception {
        super.init();
    }

    public static void main(String[] args) {
        launch();
    }
}