using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_enlazadas
{
    class DobleCiclista
    {
        NodoCiclista cabezaCiclista, nuevoCiclista;
        public DobleCiclista()
        {
            cabezaCiclista = null;
            nuevoCiclista = null;
        }

        public void crearCiclista(int bici, string nombre, string categoria)
        {
            nuevoCiclista = new NodoCiclista();
            nuevoCiclista.setBici(bici);
            nuevoCiclista.setCategoria(categoria);  
            nuevoCiclista.setNombre(nombre);
            nuevoCiclista.setAnt(null);
            nuevoCiclista.setSig(null);
        }

        public void crearLista(int bici, string nombre, string categortia) {
            crearCiclista(bici, nombre, categortia);
            if (cabezaCiclista == null)
            {
                cabezaCiclista = nuevoCiclista;
            }
            else
            {
                NodoCiclista punt = cabezaCiclista;
                while (punt.getSig() != null)
                {
                    punt = punt.getSig();
                }
                punt.setSig(nuevoCiclista);
                nuevoCiclista.setAnt(punt);
            }
        }
        public NodoCiclista existNumber(int number)
        {
            NodoCiclista punt = StaticClass.ciclista.getCabezaCiclista();
            while (punt.getSig() != null)
            {
                if (punt.getBici() == number) return punt;
                punt = punt.getSig(); 
            }
            return null;
        }
        public NodoCiclista getCabezaCiclista()
        {
            return cabezaCiclista;
        }

        public void eliminarNodo(NodoCiclista punt)
        {
            NodoCiclista ant = punt.getAnt();
            NodoCiclista sig = punt.getSig();
            if(cabezaCiclista.getBici() == punt.getBici())
            {
                cabezaCiclista = cabezaCiclista.getSig();
                punt.setSig(null);
                cabezaCiclista.setAnt(null);
            }
            else
            {
                ant.setSig(punt.getSig());
                sig.setAnt(punt.getAnt());
                punt.setSig(null);
                punt.setAnt(null);
               
            }
        }
        
    }
}
        