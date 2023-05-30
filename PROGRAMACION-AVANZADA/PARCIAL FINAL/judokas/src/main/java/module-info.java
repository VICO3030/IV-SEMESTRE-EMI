module com.example.judokas {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.judokas to javafx.fxml;
    exports com.example.judokas;
    exports com.example.judokas.Controlador;
    opens com.example.judokas.Controlador to javafx.fxml;
}