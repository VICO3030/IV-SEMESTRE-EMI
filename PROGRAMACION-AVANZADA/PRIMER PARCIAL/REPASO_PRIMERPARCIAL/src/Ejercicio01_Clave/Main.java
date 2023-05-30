package Ejercicio01_Clave;

public class Main {
    public static void main(String[] args) {
        String grupo="ES WU DD WC PP OM OU VW DT JL YN VM WI YI OA YE ZV HA RG BO WA YM NJ GJ WA RU";
        String vec[];
        vec=grupo.split(" ");
        int tam=0;
        Clave l1 = new Clave(grupo);
        l1.Mostrar(vec,tam);

    }



}
