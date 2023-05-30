using System;

namespace ListaDobleEnlazada
{
    class NodoCiclista
    {
        int nBici;
        string nomCic;
        string cat;

        NodoCiclista ant;
        NodoCiclista sig;

        //=====METODOS=====

        public NodoCiclista()//constructor
        {
            nBici = 0;
            nomCic = "";
            cat = "";
            ant = null;
            sig = null;
        }
        /*=====SETTERS=====*/
        public void set_nBici(int nBici)
        {
            this.nBici = nBici;
        }
        public void set_nomCic(string nomCic)
        {
            this.nomCic = nomCic;
        }
        public void set_cat(string cat)
        {
            this.cat = cat;
        }
        public void set_ant(NodoCiclista ant)
        {
            this.ant = ant;
        }
        public void set_sig(NodoCiclista sig)
        {
            this.sig = sig;
        }
        /*=====SETTERS=====*/

        /*=====GETTERS=====*/
        public int get_nBici()
        {
            return nBici;
        }
        public string get_nomCic()
        {
            return nomCic;
        }
        public string get_cat()
        {
            return cat;
        }
        public NodoCiclista get_ant()
        {
            return ant;
        }
        public NodoCiclista get_sig()
        {
            return sig;
        }
        /*=====GETTERS=====*/
    }
}
