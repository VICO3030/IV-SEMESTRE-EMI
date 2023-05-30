using System;

namespace Lista_Doblemente_Enlazadas
{
    class Nodo_Ciclista
    { //por defecto ya estan en privado 
        int N_bici;
        string nombre_ciclista;
        string categoria;
        Nodo_Ciclista ant;
        Nodo_Ciclista sig;

        public Nodo_Ciclista()
        {
            N_bici = 0;
            nombre_ciclista = "";
            categoria = "";
            ant = null;
            sig = null;
        }
        /*Los  Setters de todos  los atributos */
        public void Set_NBici(int Bici)
        {
            this.N_bici = Bici;

        }
        public void Set_nombre(string nombre)
        {
            this.nombre_ciclista = nombre;
        }
        public void Set_Categoria(string cat)
        {
            this.categoria = cat;
        }
        public void Set_Ant(Nodo_Ciclista anterior)
        {
            this.ant = anterior;
        }
        public void Set_Sig(Nodo_Ciclista siguiente)
        {
            this.sig = siguiente;
        }


        /**Formulamos los getters */
        public int get_Nbici()
        {
            return N_bici;
        }
        public string get_NombreCicli()
        {
            return nombre_ciclista;
        }
        public string get_Categoria()
        {
            return categoria;
        }
        public Nodo_Ciclista get_Ant()
        {
            return ant;
        }
        public Nodo_Ciclista get_Sig()
        {
            return sig;
        }
    }
}
