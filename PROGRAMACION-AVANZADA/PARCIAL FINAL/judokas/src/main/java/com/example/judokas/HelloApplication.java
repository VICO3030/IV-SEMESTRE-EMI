package com.example.judokas;

import com.example.judokas.Controlador.PANELCONTROL;
import com.example.judokas.Controlador.REGISTRARCLUBES;
import com.example.judokas.Controlador.REGISTRARJUDOKA;
import com.example.judokas.Controlador.REGISTRARMUNICIPIOS;
import com.example.judokas.Modelo.Estatica;
import com.example.judokas.Modelo.Municipio;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

import java.io.IOException;

public class HelloApplication extends Application {
    Stage stagePrincipal;
    AnchorPane rootPane;
    public void mostrarPanel() throws IOException {
        FXMLLoader loader = new FXMLLoader(HelloApplication.class.getResource("PANEL_CONTROL.fxml"));
        rootPane=(AnchorPane) loader.load();
        Scene scene = new Scene(rootPane, 600, 480);
        stagePrincipal.setTitle("   PANEL DE CONTROL BY  NOSOTROS");
        stagePrincipal.setScene(scene);
        PANELCONTROL controller = loader.getController();
        controller.setVentanaprincipal(this);
        stagePrincipal.show();

    }
    public void mostrarJudokas() throws IOException {
        FXMLLoader loader = new FXMLLoader(HelloApplication.class.getResource("REGISTRAR_JUDOKA.fxml"));
        AnchorPane rjudokas=(AnchorPane) loader.load();
        Stage ventana=new Stage();
        ventana.setTitle("KRATOS");
        ventana.initOwner(stagePrincipal);
        Scene scene = new Scene(rjudokas, 600, 480);
        ventana.setScene(scene);
        REGISTRARJUDOKA controller = loader.getController();
        controller.setVentanaprincipal(ventana);

        ventana.show();
    }
    public void mostrarMunicipios() throws IOException {
        FXMLLoader loader = new FXMLLoader(HelloApplication.class.getResource("REGISTRAR_MUNICIPIOS.fxml"));
        AnchorPane rmunicipios=(AnchorPane) loader.load();
        Stage ventana=new Stage();
        ventana.setTitle("MUNICIPIOS");
        ventana.initOwner(stagePrincipal);
        Scene scene = new Scene(rmunicipios, 600, 480);
        ventana.setScene(scene);
        REGISTRARMUNICIPIOS controller = loader.getController();
        controller.setVentanaprincipal(ventana);

        ventana.show();
    }
    public void mostrarClubes() throws IOException {
        FXMLLoader loader = new FXMLLoader(HelloApplication.class.getResource("REGISTRAR_CLUBES.fxml"));
        AnchorPane rclubes=(AnchorPane) loader.load();
        Stage ventana=new Stage();
        ventana.setTitle("KIKO XD");
        ventana.initOwner(stagePrincipal);
        Scene scene = new Scene(rclubes, 600, 480);
        ventana.setScene(scene);
        REGISTRARCLUBES controller = loader.getController();
        controller.setVentanaprincipal(ventana);

        ventana.show();
    }
    @Override
    public void start(Stage stage) throws IOException {
        this.stagePrincipal=stage;
        mostrarPanel();


    }

    public static void main(String[] args) {
        launch();
    }
}