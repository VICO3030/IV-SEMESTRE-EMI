using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Cola
{
    class Cola
    {
        Nodo_Cola Frente, Final, Nuevo;
        public Cola()
        {
            Frente = null;
            Final = null;
            Nuevo = null;

        }
        public  void Crear_nodo(int dato )
        {
            Nuevo = new Nodo_Cola();
            Nuevo.Set_dato(dato);
            Nuevo.Set_sig(null);

        }
        public Nodo_Cola Get_Final()
        {
            return Final;
        }
        public void Encolar(int dato)
        {
            Crear_nodo(dato);
            if (Frente == null)
            {
                Frente = Nuevo;
                Final = Nuevo;
            }
            else
            {
                Final.Set_sig(Nuevo);
                Final = Nuevo;
              
            }
        }
        public Nodo_Cola Desencolar()
        {
            Nodo_Cola aux = Frente;
            Frente = Frente.Get_sig();
            aux.Set_sig(null);
            if(Frente == Final)
            {
                Final = null;
            }
            return aux;
        }
        public Boolean Estavacio()
        {
            return Frente == null;
        }
        public Nodo_Cola Get_frente()
        {
            return Frente;
        }

        public string Eliminar(int dato)
        {
            Nodo_Cola punt = Frente;
            Nodo_Cola ant = null;

            while (punt != null)
            {
                if (dato == Frente.Get_dato())
                {
                    Frente = Frente.Get_sig();
                    punt.Set_sig(null);
                    return "SE  SELEMINO DATO!!";
                }
                else
                {
                    if (punt.Get_dato()==dato)
                    {
                        ant.Set_sig(punt.Get_sig());
                        punt.Set_sig(null);
                        return "SE ELEMINO DATO!!";
                    }
                }
                ant = punt;

                punt = punt.Get_sig();
            }
            return "EL DATO NO EXISTE!!";
        }       
    }
}
