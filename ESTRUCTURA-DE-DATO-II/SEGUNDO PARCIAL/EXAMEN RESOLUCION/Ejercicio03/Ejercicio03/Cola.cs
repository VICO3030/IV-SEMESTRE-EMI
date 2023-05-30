    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Ejercicio03
    {
        class Cola
        {
                Nodo Frente, Final, Nuevo;
                public Cola()
                {
                    Frente = null;
                    Final = null;
                    Nuevo = null;

                }
                public void Crear_nodo(int nro , int ci)
                {
                Nuevo = new Nodo();
                Nuevo.Cant = nro;
                Nuevo.CI1 = ci;
                Nuevo.Sig = null;


                }
                public Nodo Get_Final()
                {
                    return Final;
                }
                public void Encolar( int nro , int ci)
                {
                    Crear_nodo(nro,ci);
                    if (Frente == null)
                    {
                        Frente = Nuevo;
                        Final = Nuevo;
                    }
                    else
                    {
                    Final.Sig = Nuevo;
                        Final = Nuevo;

                    }
                }
                public Nodo Desencolar()
                {
                    Nodo aux = Frente;
                Frente = Frente.Sig;
                aux.Sig = null;
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
                public Nodo Get_frente()
                {
                    return Frente;
                }
            }
    
    }
