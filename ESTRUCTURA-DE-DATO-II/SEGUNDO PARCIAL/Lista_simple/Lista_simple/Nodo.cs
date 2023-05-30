using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_simple
{
    class Nodo
    {
        Nodo enlace;
        string usuario;
        int codigo;
        public Nodo()
        {
            enlace = null;
            usuario = "";
            codigo = 0;

        }
        public void SetEnlace(Nodo _enlace)
        {
            enlace = _enlace;
        }
        public void SetUsuario(string _usuario)
        {
            usuario = _usuario;
        }
        public void SetCodigo(int _codigo)
        {
            codigo = _codigo;
        }
        //getters
        public Nodo GetEnlace()
        {
            return enlace; 
        }
        public string GetUsuario()
        {
            return usuario;
        }
        public int GetCodigo()
        {
            return codigo;
        }

    }
}
