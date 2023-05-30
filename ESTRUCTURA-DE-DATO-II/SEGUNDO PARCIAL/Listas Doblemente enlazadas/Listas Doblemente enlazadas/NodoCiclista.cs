using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_enlazadas
{

    class NodoCiclista
    {
        int bici;
        string nombre_ciclista;
        string categoria;
        NodoCiclista sig;
        NodoCiclista ant;

        public NodoCiclista()
        {
            bici = 0;
            nombre_ciclista = "";
            categoria = "";
            sig = null;
            ant = null;
        }
        public void setBici(int bici) { this.bici = bici; }
        public int getBici() { return this.bici; }
        public void setNombre(string nombre) { this.nombre_ciclista = nombre; }
        public string getNombre() { return this.nombre_ciclista; }
        public string getCategoria() { return this.categoria; }
        public void setCategoria(string type) { this.categoria = type; }
        public void setAnt(NodoCiclista punt) { ant = punt; }
        public void setSig(NodoCiclista sig) { this.sig = sig; }
        public NodoCiclista getSig() { return this.sig; }
        public NodoCiclista getAnt() { return this.ant; }
    }
}
