using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS_SIMPLES
{
    /// <summary>
    ///     Clase Nodo para la creacion de una lista 
    ///     requiere un nombre y una promedio para poder funcionar correctamente
    /// </summary>
    public class Nodo
    {
        string nombre;
        int promedio;
        Nodo enlace; // direccion del nodo
    public Nodo()
        {
            nombre = "";
            promedio = 0;
            enlace = null;
        }
        public void set_nombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void set_edad(int ed)
        {
            promedio = ed;
        }
        public void set_enlace(Nodo punt)
        {
            enlace = punt;
        }
        public string get_nombre()
        {
            return nombre;
        }
        public int get_edad()
        {
            return promedio;
        }
        public Nodo get_enlace()
        {
            return enlace;
        }

    }
}
