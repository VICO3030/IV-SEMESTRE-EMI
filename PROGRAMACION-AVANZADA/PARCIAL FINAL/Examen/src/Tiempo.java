
public class Tiempo {
    private int h,m,s;

    public Tiempo(int h, int m, int s) {
        this.h = h;
        this.m = m;
        this.s = s;
    }

    public static void comparar(int h1, int m1, int s1, String f1, int h2, int m2, int s2, String f2){
        if(f1==f2){
                if(h1==h2){
                    if(m1==m2){
                        if(s1==s2){
                            System.out.println("SON LA MISMA HORA");
                            return;
                        }
                    }
                }
            }
            System.out.println("NO SOON LA MISMA HORA");
        }
        public void Mostrar(){
            String f="AM";
            while (s>=60){
                s=s-60;
                m=m+1;
            }
            while (m>=60){
                m=m-60;
                h=h+1;
            }
            while (h>=24){
                h=h-24;
            }
            if(h>12){
                h=h-12;
                f="PM";
            }
            System.out.println("LA HORA ES: ");
            System.out.println(h+":"+m+":"+s+"  "+f);
            comparar(1,12,11,"AM",1,12,11,"AM");
        }
}

