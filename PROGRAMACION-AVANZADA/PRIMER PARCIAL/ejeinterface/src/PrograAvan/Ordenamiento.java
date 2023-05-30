package PrograAvan;

public class Ordenamiento {
    //metodo burbuja
    public static void burbuja(Comparable[] a ){
//creamos auxiliar tippo T , tipo de dato comparable

        for(int i = 0 ;i <a.length ; i++){
            for(int  j=i+1; j<a.length ; j++){
                if(a[i].compareTo(a[j])>0){
// + sinifica que es mayor a[i]  si es - significa que es menor a[i]  , si son iguales es =0
                        intercambiar(a, i ,j);
                    }
            }
        }
    }

    private static void intercambiar(Object[] a,int pos1 , int pos2) {
        Object aux = a[pos1];       //Object es el papa de todos  es generico de generico
        a[pos1]= a [pos2];
        a[pos2] =aux;
    }

    //odenamiento por el merge sort
    public static void merge_sort(Comparable []a){ //la caracteristica para que esos elementos puedan compararse

        Comparable [] aux = new Comparable[a.length];
        merge_sort(a,aux,0,a.length-1);
    }
    private static   void merge_sort(Comparable[] a , Comparable [] aux , int Xi , int Xs){
        if(Xs <= Xi)    return ;
        int mitad = Xi +(Xs-Xi)/2;
        merge_sort(a,aux , Xi , mitad);
        merge_sort(a,aux , mitad+1,Xs);
        merge(a,aux,Xi,mitad,Xs);

    }

    private static void  merge(Comparable[] a, Comparable[] aux, int xi , int mitad , int xs) {
        //mitad en mitad , hazta llegar al caso base
        for(int  k=xi ; k<=xs ; k++){
            aux[k]= a[k];
        }
          //union
        int i=xi;
        int j=mitad +1;
        for(int k= xi ; k<=xs ; k++){
            if( i>mitad){
                a[k]=aux[j++];

            }
            else if (j> xs){
                a[k]= aux[i++];

            }
            else if(aux[j].compareTo(aux[i])<0){
                a[k] = aux[j++];

            }
            else {
                a[k]=aux[i++];
            }
        }
    }

}
