using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_enlazadas
{
    class DobleCarrera
    {
        NodoCarrera cabezaCarrera;
        NodoCarrera nuevoCarrera;
        public DobleCarrera()
        {
            cabezaCarrera = null;
            nuevoCarrera = null;
        }

        public void crearCarrera(int bici, int tiempo, int lugar, DateTime fecha)
        {
            nuevoCarrera = new NodoCarrera();
            nuevoCarrera.setBici(bici);
            nuevoCarrera.setLugar(lugar);
            nuevoCarrera.setTiempo(tiempo);
            nuevoCarrera.setFecha(fecha);
            nuevoCarrera.setAnt(null);
            nuevoCarrera.setSig(null);
        }
        public void crearLista(int bici, int tiempo, int lugar, DateTime fecha)
        {
           crearCarrera(bici, tiempo, lugar, fecha);
            if(cabezaCarrera == null)
            {
                cabezaCarrera = nuevoCarrera;
            }
            else
            {
                NodoCarrera punt = cabezaCarrera;
                while(punt.getSig() != null)
                {
                    punt = punt.getSig();
                }
                punt.setSig(nuevoCarrera);
                nuevoCarrera.setAnt(punt);
            }
        }
        
        public void insertar()
        {
            float tiempo;
            NodoCarrera i, j;
            j = cabezaCarrera.getSig();
            while(j != null)
            {
                tiempo = j.getTiempo();
                i = j.getAnt();
                while (i != null && i.getTiempo() > tiempo)
                {
                    i.getSig().setTiempo(i.getTiempo());
                    i = i.getAnt();
                }
                if(i == null)
                {
                    i = cabezaCarrera;
                }
                i.getSig().setTiempo(tiempo);

                //i.getAnt().setTiempo(tiempo);
                j = j.getSig();
            }
        }

        public NodoCarrera getCabezaCarrera()
        {
            return cabezaCarrera;
        }
    }
}
