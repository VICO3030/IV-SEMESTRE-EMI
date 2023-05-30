import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class ejer1Test {


    @Test
    public void numerosTest(){
        Assertions.assertEquals(4,ejer1.numeros(26));
      /*  Assertions.assertEquals(3,ejer1.numeros(56));
        Assertions.assertEquals(4,ejer1.numeros(16));
        Assertions.assertEquals(12,ejer1.numeros(36));*/
    }
}
