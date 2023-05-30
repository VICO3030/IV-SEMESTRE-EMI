using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Doblemente_enlazadas
{
    class NodoCarrera
    {
        int bici;
        float tiempo;
        int lugar;
        DateTime fecha;
        NodoCarrera sig;
        NodoCarrera ant;
        public NodoCarrera()
        {
            bici = 0;  
            tiempo = 0;
            lugar = 0;
            sig = null;
            ant = null;
            fecha = DateTime.Now;
        }

        public void setBici(int bici) { this.bici = bici; }
        public int getBici() { return this.bici; }
        public void setTiempo(float tiempo) { this.tiempo = tiempo; }
        public float getTiempo() { return this.tiempo; }
        public NodoCarrera getSig() { return this.sig; }
        public void setSig(NodoCarrera sig) { this.sig = sig; }
        public NodoCarrera getAnt() { return this.ant; }
        public void setAnt(NodoCarrera ant) { this.ant = ant; }
        public int getLugar() { return this.lugar; }
        public void setLugar(int lugar) { this.lugar = lugar; }
        public void setFecha(DateTime fecha) { this.fecha = fecha; }
        public DateTime getFecha() { return this.fecha; }

    }
}
