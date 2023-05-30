using System;

namespace Lista_Doblemente_Enlazadas
{
    class Nodo_Carrera
    {
        //atributos
        int nBici;
        float tiempo;
        string lugar;
        DateTime fecha;
      
        Nodo_Carrera sig;
        Nodo_Carrera ant;
        public Nodo_Carrera()
        {
            nBici = 0;
            tiempo = 0;
            lugar = " ";
            
            sig = null;
            ant = null;
            


        }
        //creamos los setter de  los atributos 
        public void Set_nBici(int bis)
        {
            this.nBici = bis;
        }
        public void Set_tiempo(float tiempo)
        {
            this.tiempo = tiempo;
        }
        public void Set_lugar(string lugar)
        {
            this.lugar = lugar;
        }
        public void Set_fecha(DateTime fecha)
        {
            this.fecha = fecha;

        }
        public void Set_Ant(Nodo_Carrera anterior)
        {
            this.ant = anterior;
        }
        public void Set_Sig(Nodo_Carrera siguiente)
        {
            this.sig = siguiente;
        }
        //creammos los getters

        public DateTime Get_Fecha()
        {
            return fecha;
        }
        public int Get_nroBici()
        {
            return nBici;
        }
        public float Get_Tiempo()
        {
            return tiempo;
        }
        public string Get_Lugar()
        {
            return lugar;
        }
        public Nodo_Carrera get_Ant()
        {
            return ant;
        }
        public Nodo_Carrera get_Sig()
        {
            return sig;
        }
    }
}
