using System;

namespace LISTAS_SIMPLES
{
    class Nodo
    {
        //atributos  por defecto y ya esta privado 
        string nombre;
        int edad;
        //vamos  crear con enlaze
        Nodo enlace;
        //es la direcccion del nodo con que se enlaza , sino ponems esto no podremso enlazar nodo con nodo
        //set es para cambiar dato , y el get saca los daTOS 
        //creamos el constructor 
        public Nodo()
        {
            nombre = "";
            edad = 0;
            enlace = null;
        }
        public void  set_Nombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void set_Edad(int _edad)
        {
            edad = _edad;
        }
        public void set_enlace(Nodo punt)
        {
            enlace = punt;
        } 
        //geters sacan los valores 
        public string get_nombre()
        {
            return nombre;
        }
        public int get_Edad()
        {
            return edad;
        }
        public Nodo get_enlace()
        {
            return enlace;
        }
    }  
}