public class Clave {
    public static void main(String[] args) {
        String Grupos ="CBA DDD";
        String resul[];

        resul  = Grupos.split(" ");
       // System.out.println(Suma(Grupos,resul));
        int total=0, n = 0;
        for(int i =  0 ; i<resul.length;i++){
            total = Suma(resul[i],n) + total;
            n++;
        }
        System.out.println("La cantidad  total es de : "+total);

    }
    public static int Suma( String m,int n  ){
        int k=0,a1,sum=0;
            for(int j=0 ;j<m.length() ; j++){
                a1 = m.charAt(j) -65;
                sum = sum + a1 + n+ j;
        }
        return sum;
    }
}
