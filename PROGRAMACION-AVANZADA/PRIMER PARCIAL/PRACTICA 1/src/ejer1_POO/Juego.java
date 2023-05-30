
package ejer1_POO;

public class Juego {
        //atributos 
            
    public void jugar(){
        boolean control =false;
        
         Dado d1 = new Dado();
        do{
        
        d1.lanzar();
        System.out.println("SU primer dado es : "+d1.getNumero());
        System.out.println("Su segundo dado es de :"+d1.getNumero2());
            System.out.println("La suma de sus dados es de : "+(d1.getNumero()+d1.getNumero2()));
        if(d1.Sumaa()==7 ||d1.Sumaa()==11){
            System.out.println("Felicidades gano el JUEGO !!!!!");
            control=false;
        }
        else{
            if(d1.Sumaa()==3 || d1.Sumaa()==12){
                System.out.println("Perdio el Juego :( ");
                control=true;
            }
            else{
                
                if(d1.Sumaa()!=7 ||d1.Sumaa()!=11 || d1.Sumaa()!=3 || d1.Sumaa()!=12){
                    System.out.println("=============SEGUUNDA RONDA==================");
                    System.out.println("Se volvio a lanzar el dado ");
                    d1.lanzar();
                    System.out.println("SU primer dado es : "+d1.getNumero());
                    System.out.println("Su segundo dado es de :"+d1.getNumero2());
                    System.out.println("La suma de sus dados es de : "+(d1.getNumero()+d1.getNumero2()));
                    if(d1.Sumaa()==4 || d1.Sumaa()==5 || d1.Sumaa()==6 || d1.Sumaa()==8 || d1.Sumaa()==9){
                        System.out.println("FELICIDADES GANO EL JUEGO ");
                    }
                    else{
                        if(d1.Sumaa()==7){
                            System.out.println("Perdio el Juego ");
                        }
                    }
                }
            }
        }
        
        }while(control ==true && control==false);
        
    } 
}
