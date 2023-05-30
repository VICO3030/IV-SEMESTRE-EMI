import java.util.Scanner;
// la clase principal, debe tener el mismo nombre que el archivo Ejercicio01.java
public class ejer1{
    // debe tener un metodo publico, estático con un arreglo de String como parametro
    public static void main(String[] args) {
        // la clase scanner se instancia en el objeto lector
        // el cosntructor de esta clase tiene como parametro el origen de la entrada
        // System.in hace referencia al teclado
        Scanner lector = new Scanner(System.in);

        int may, men;
        int nums;
        // leemos del teclado como entero
        men = lector.nextInt();
        may = lector.nextInt();
        nums = lector.nextInt();
        // instanciamos un vector de enteros de nums posiciones
        int[] cant = new int[nums];
        // leemos cada elemento del vector
        for (int i= 0; i<nums; i++){
            cant[i] = lector.nextInt();
        }
        // llamamos a la función donde se implementa nuestro algoritmo solución
        System.out.println(ejercicio01(men, may, cant));
    }

    public static int ejercicio01(int menor, int mayor,  int[] peces) {
        int result=0;
        for (int i = menor; i <= mayor; i++)
            for (int p=0; p<peces.length; p++) {
                if ((i <= (0.5 * peces[p]) && i >= (0.1 * peces[p])) || (peces[p] <= (0.5 * i) && peces[p] >= (0.1 * i)))
                    break;
                if (p == peces.length-1)
                    result++;
            }
        return result;
    }
}

