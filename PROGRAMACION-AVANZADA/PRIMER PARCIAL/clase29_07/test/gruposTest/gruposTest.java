package gruposTest;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class gruposTest{
    @Test//hacer la prueba el find me da el grupo
    public void findTest() {          //contenido del vector

        grupos mostrar = new grupos (10);
        Assertions.assertEquals(7, mostrar.find(7));
        Assertions.assertEquals(3, mostrar.find(3));
        mostrar.conectar(6,1);
        Assertions.assertEquals(2,mostrar.find(7));
    }
}
