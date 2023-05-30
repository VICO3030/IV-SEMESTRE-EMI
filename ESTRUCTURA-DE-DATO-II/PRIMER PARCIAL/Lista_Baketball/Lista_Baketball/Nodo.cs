using System;
namespace Lista_Baketball
{
    class Nodo
    {
        /*tipos de datos que voya guardar atributos por defecto estan en privador*/
        private string equipo_nom;
        private int cant_anillos;

        /*Si ponemos para poder conectar con otros nodos*/
        Nodo enlazar;

        //constructor incializamos
        public Nodo()
        {
            equipo_nom = "";
            cant_anillos = 0;
            enlazar = null;
        }


        //creamos primero los setters
        public void set_Equipo(string _equipo)
        {
            equipo_nom = _equipo;
        }
        public void set_Cant(int _cant)
        {
            cant_anillos = _cant;
        }
        public void set_Enlace(Nodo punt)
        {
            enlazar = punt;
        }


        //creamos los getters para los atributos

        public string get_Nombre()
        {
            return equipo_nom;
        }
        public int get_Cantidad()
        {
            return cant_anillos;
        }
        public Nodo get_enlace()
        {
            return enlazar;
        }
    }

   

}
