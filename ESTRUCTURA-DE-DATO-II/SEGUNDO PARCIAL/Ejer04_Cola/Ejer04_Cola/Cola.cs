using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer04_Cola
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
        public void Crear_nodo(string NomDoc , int nro , string calid ,  double tiempo , string color )
        {
            Nuevo = new Nodo_Cola();
            Nuevo.Set_nombreDoc(NomDoc);
            Nuevo.Set_nroHojas(nro);
            Nuevo.Set_calidad(calid);
            Nuevo.Set_tiempo(tiempo);
            Nuevo.Set_Color(color);
            Nuevo.Set_sig(null);

        }
        public Nodo_Cola Get_Final()
        {
            return Final;
        }
        public void Encolar(string NomDoc, int nro, string calid , double tiempo, string color)
        {
            Crear_nodo( NomDoc,  nro, calid , tiempo , color);
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
            if (Frente == Final)
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
    }
}
