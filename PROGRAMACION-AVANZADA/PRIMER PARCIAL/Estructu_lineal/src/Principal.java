public class Principal {
    public static void main(String[] args) {
        ArbolBinario<Integer ,String> Lista = new ArbolBinario<>();
        Lista.insertar(10 ,"Juan");
        Lista.insertar(18 ,"Pedro");
        Lista.insertar(15 ,"judas");
        Lista.insertar(8 ,"santiago");
        Lista.insertar(5 ,"Jesus");
        Lista.insertar(56 ,"leo");
        System.out.println(Lista.get_element_by__llave(8));
        System.out.println(Lista.get_element_by__llave(15));
    }
}
