package gruposTest;

import org.junit.Test;
import org.junit.Assert;


public class Grupo02Test
{
    @Test
    public void findTest(){
         
        Grupo02 g2   = new Grupo02();
        Assert.assertEquals(4,g2.find(4));

    }
}
