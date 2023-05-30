public class Principal {
    public static void main(String[] args) {
        // instanciar la clase Empleado
        Planilla l1 = new Planilla(4);
        Empleado e1 = new Empleado("Juan", 1998,3800);
        Empleado e2 = new Empleado_comision("Luis", 1994,3900, 456);
        Empleado e3 = new Empleado("Pedro", 2009,6800);
        Empleado e4 = new Empleado_comision("Maria", 1978,8800, 345);

        Empleado e5 = new Empleado("Maria", 1978,8800);

        if (e4.equals(e5)){
            System.out.println("Es el mismo empleado");
        }
        else{
            System.out.println("Diferente empleado");
        }

        if (e1.compareTo(e2) > 0){
            System.out.println(e1.getNombre() + " es mayor "+ " que " + e2.getNombre());
        }
        l1.insertar(0, e1);
        l1.insertar(1, e2);
        l1.insertar(2, e3);
        l1.insertar(3, e4);

        for (int i=0; i < 4; i++){
            System.out.println(l1.getEmpleados()[i]);
        }
        // ejemplo de nuestro objeto dado
        Dado d1 = new Dado();
        d1.lanzar();
        System.out.println(d1.getNumero());
    }
}
