public class Planilla {
    private Empleado[] empleados;
    private int tam;

    public Planilla(int n) {
        empleados = new Empleado[n];
        tam = n;
    }

    public void insertar(int pos, Empleado e){
        if (pos < tam){
            empleados[pos] = e;
        }
        else{
            new IllegalAccessException("Error");
        }
    }

    public Empleado[] getEmpleados() {
        return empleados;
    }

    public void setEmpleados(Empleado[] empleados) {
        this.empleados = empleados;
    }

    public int getTam() {
        return tam;
    }

    public void setTam(int tam) {
        this.tam = tam;
    }
}
