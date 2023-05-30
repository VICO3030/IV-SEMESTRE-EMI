using System;
namespace ListaDobleEnlazada
{
    class NodoCarrera
    {
        int nBici;
        float tiempo;
        string lugar;
        DateTime fecha;

        NodoCarrera ant;
        NodoCarrera sig;

        //Costructor
        public NodoCarrera()
        {
            nBici = 0;
            tiempo = 0;
            lugar = "";
            fecha = DateTime.Now;
        }

        /*=====SETTERS====*/
        public void set_nBici(int nBici)
        {
            this.nBici = nBici;
        }
        public void set_tiempo(float tiempo)
        {
            this.tiempo = tiempo;
        }
        public void set_lugar(string lugar)
        {
            this.lugar = lugar;
        }
        public void set_fecha(DateTime fecha)
        {
            this.fecha = fecha;
        }
        public void set_ant(NodoCarrera ant)
        {
            this.ant = ant;
        }
        public void set_sig(NodoCarrera sig)
        {
            this.sig = sig;
        }
        /*=====SETTERS====*/
        /*=====GETTERS====*/
        public int get_nBici()
        {
            return nBici;
        }
        public float get_tiempo()
        {
            return tiempo;
        }
        public string get_lugar()
        {
            return lugar;
        }
        public DateTime get_fecha()
        {
            return fecha;
        }
        public NodoCarrera get_ant()
        {
            return ant;
        }
        public NodoCarrera get_sig()
        {
            return sig;
        }
        /*=====GETTERS====*/
    }
}
