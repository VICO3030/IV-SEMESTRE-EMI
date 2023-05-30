package ejercicio2_poo;

import javax.swing.JOptionPane;

public class Fraccion {
    //atributos
     private int num;
     private int den;

    public Fraccion(int num, int den) {
        this.num = num;
        this.den = den;
    }

    public int getNum() {
        return num;
    }

    public void setNum(int num) {
        this.num = num;
    }

    public int getDen() {
        return den;
    }

    public void setDen(int den) {
        this.den = den;
    }
     //metodo sumar
    public int Sumar(int x,int y){
        int total;
        total=x+y;
        return total;
    }
     
    //metodo Multiplicar
    public int  Multiplicar(){
        int total;
        total=getNum()*getDen();
        return total;
    }
    
    //metodo dividir
    public float Dividir(){
        float total;
        total =getNum()/getDen();
        return total;
    }
    public int Comparar(){
        if(getNum()>getDen()){
            return getNum();
        }else{
            return getDen();
        }
    }
    public void Simplificar(int numerador , int denominador){
                int div=0;
        if((numerador % denominador)==0)
        {
            div=numerador/denominador;
            System.out.println("la simplificacion es de :"+div);
        }
        else if((denominador % numerador)==0)
        {
            div=denominador/numerador;
            System.out.println("1/"+div);
        }
        else{
            System.out.println(""+numerador+"/"+denominador);
        }    
    }    
    

}
        
    
