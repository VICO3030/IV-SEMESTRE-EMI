package com.example.original;

import javafx.fxml.Initializable;
import javafx.scene.control.*;
import javafx.scene.input.KeyEvent;
import javafx.scene.input.MouseEvent;

import java.net.URL;
import java.util.ResourceBundle;

public class JudokaController implements Initializable {
    public TextField input_nom;
    public TextField input_apellido;
    public TextField input_ci;
    public RadioButton rb_masc;
    public RadioButton rb_fem;
    public TextField input_telf;
    public TextField input_email;
    public TextField input_direc;
    public TextField input_grado;
    public DatePicker pick_nac;
    public Button btn_registrar;
    public DatePicker pick_ky;
    public ComboBox cmb_category;
    public ComboBox cmb_grade;
    public Label label_saludo;


    public void registrar_judoka(MouseEvent mouseEvent) {
        System.out.println("hola " + rb_masc.isSelected());
    }

    public void cambiar_fem(MouseEvent mouseEvent) {
        if (rb_masc.isSelected() == rb_fem.isSelected())

        cmb_category.getItems().removeAll(cmb_category.getItems());
            cmb_category.getItems().addAll("-60", "-66", "-73", "-81", "-90", "-100", "+100");
        cmb_category.getSelectionModel().select("");
    }

    public void cambiar_mas(MouseEvent mouseEvent) {
        if (rb_masc.isSelected() == rb_fem.isSelected())
            rb_masc.setSelected(!rb_masc.isSelected());
            cmb_category.getItems().removeAll(cmb_category.getItems());
            cmb_category.getItems().addAll("-48", "-52", "-57", "-63", "-70", "-78", "+78");

        // cmb_category.getSelectionModel().select("Option B");
    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        cmb_grade.getItems().removeAll(cmb_grade.getItems());
        cmb_grade.getItems().addAll("Amarillo", "Naranja", "Verde", "Azul", "Cafe", "Negro");
        cmb_grade.getSelectionModel().select("");

    }

    public void saludar(MouseEvent mouseEvent) {
        System.out.println("haz encontrado el link secreto");
        label_saludo.setText("Cambio");
    }
}
