package com.example.judokas.Controlador;

import com.example.judokas.HelloApplication;
import com.example.judokas.Modelo.Club;
import com.example.judokas.Modelo.Estatica;
import com.example.judokas.Modelo.JUDOKA;
import com.example.judokas.Modelo.Municipio;
import javafx.application.Application;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.input.MouseEvent;
import javafx.stage.Modality;
import javafx.stage.Stage;
import javafx.stage.StageStyle;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class PANELCONTROL implements Initializable {
    public Button btnMunicipio;
    public Button btnClub;
    public Button btnJudoka;
    private HelloApplication Ventanaprincipal;
    public void abrirJudokas(MouseEvent mouseEvent) throws IOException {
        Ventanaprincipal.mostrarJudokas();
    }


    public void setVentanaprincipal(HelloApplication Ventanaprincipal)
    {
        this.Ventanaprincipal=Ventanaprincipal;
    }

    public void abrirMunicipio(MouseEvent mouseEvent) throws IOException {
        Ventanaprincipal.mostrarMunicipios();
    }

    public void abrirClubes(MouseEvent mouseEvent) throws IOException {
        Ventanaprincipal.mostrarClubes();
    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        JUDOKA xd=new JUDOKA("pablo","rodriguez",'M',"1988-09-29","-81",90);
        JUDOKA xd1=new JUDOKA("Andres","Guti",'F',"2000-09-29","+78",90);
        JUDOKA xV=new JUDOKA("Leo","Eguino",'M',"1988-09-29","-81",90);
        JUDOKA xV1=new JUDOKA("Pablito","Sanabria",'F',"2000-09-29","+78",90);
        JUDOKA xP=new JUDOKA("Andresito","andrade",'M',"1988-09-29","-81",90);
        JUDOKA xP1=new JUDOKA("Luisito","Perez",'F',"2000-09-29","+78",90);

        //CLUBES

        Club c1 = new Club("COBRA KAI", "C27234", "CALLE LA PAZ #1210");
        Club c2 = new Club("COCHABAMBITA", "C13214", "CALLE ORURO #2");
        Club c3 = new Club("PORTOBELLO", "C27578", "CALLE POTOSI # 23");
        Club c4 = new Club("BRUCE LEE XD", "C90876", "CALLE LA PAZ #2005");
        Club c5 = new Club("REAL MADRID", "C27", "CALLE SUCRE # 23");
        Club c6 = new Club("BAYER MUNICH", "C96", "CALLE LLALLAGUA #2005");

        //MUNICIPIOS

        Estatica.municipios.insertar(new Municipio("SAN JOSE","3213"));
        Estatica.municipios.insertar(new Municipio("SAN JULIAN","323"));
        Estatica.municipios.insertar(new Municipio("SAN JORGE","213"));

        Estatica.municipios.get(0).anadir_club(c1);
        Estatica.municipios.get(0).anadir_club(c2);
        Estatica.municipios.get(1).anadir_club(c3);
        Estatica.municipios.get(1).anadir_club(c4);
        Estatica.municipios.get(2).anadir_club(c5);
        Estatica.municipios.get(2).anadir_club(c6);

        Estatica.municipios.get(0).getClubes().get(0).anadir_Judoka(xd);
        Estatica.municipios.get(0).getClubes().get(1).anadir_Judoka(xd1);
        Estatica.municipios.get(1).getClubes().get(0).anadir_Judoka(xV);
        Estatica.municipios.get(1).getClubes().get(1).anadir_Judoka(xV1);
        Estatica.municipios.get(2).getClubes().get(0).anadir_Judoka(xP);
        Estatica.municipios.get(2).getClubes().get(1).anadir_Judoka(xP1);
    }
}
