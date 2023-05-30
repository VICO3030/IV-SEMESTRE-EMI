module com.example.demo {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.demo to javafx.fxml;
    exports com.example.demo;
    exports com.example.demo.Controlador;
    opens com.example.demo.Controlador to javafx.fxml;
   // opens com.example.demo.controller to  javafx.fxml;
    //opens HelloApplication to  javafx.fxml;
    //opens   main.resources.com.example.demo  to javafx.fxml;


}