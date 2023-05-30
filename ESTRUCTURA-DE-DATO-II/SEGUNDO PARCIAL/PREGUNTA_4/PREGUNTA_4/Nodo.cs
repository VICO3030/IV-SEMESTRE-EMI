using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREGUNTA_4
{
    class Nodo
    {
        string nombre;
        int hojas;
        string calidad_color;
        Nodo siguiente;

        public Nodo()
        {
            this.nombre = "";
            this.hojas = 0;
            this.calidad_color = "";
            siguiente = null;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setHojas(int hojas)
        {
            this.hojas = hojas;
        }

        public void SetCalidadColor(string calidad_color)
        {
            this.calidad_color = calidad_color;
        }

        public void setSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getHojas()
        {
            return this.hojas;
        }

        public string getCalidadColor()
        {
            return this.calidad_color;
        }

        public Nodo getSiguiente()
        {
            return this.siguiente;
        }

        public int getTiempohoja()
        {
            if (getCalidadColor() == "Borrador y color")
            {
                return 15;
            }
            else
            {
                if (getCalidadColor() == "Borrador y negro_gris")
                {
                    return 50;
                }

                else
                {
                    if (getCalidadColor() == "Estandar y color")
                    {
                        return 20;
                    }
                    else
                    {
                        if (getCalidadColor() == "Estandar y negro_gris")
                        {
                            return 18;
                        }
                        else
                        {
                            if (getCalidadColor() == "Alto y color")
                            {
                                return 30;
                            }
                            else
                            {
                                if (getCalidadColor() == "Alto y negro_gris")
                                {
                                    return 25;
                                }
                                else return 0;
                            }
                        }
                    }
                }
            }
        }
    }
}
