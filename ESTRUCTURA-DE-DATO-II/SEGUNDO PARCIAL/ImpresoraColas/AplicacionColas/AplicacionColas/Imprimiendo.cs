using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionColas
{
    public partial class Imprimiendo : Form
    {
        public Imprimiendo()
        {
            InitializeComponent();
            float timer = Estatica.cola.getFrente().getHojas() * Estatica.cola.getFrente().getHojas() * 1000;
            tmr_Reloj.Interval = (int)timer;
            tmr_Reloj1.Interval = (int)timer / 10;
            tmr_Reloj.Start();
            tmr_Reloj1.Start();
            Mostrar();
        }

        private void Imprimiendo_Load(object sender, EventArgs e)
        {
            
        }
        public void Mostrar()
        {

            Nodo aux = Estatica.cola.getFrente();
            dgvImprimiendo.Rows.Clear();
            while (aux != null)
            {
            
                dgvImprimiendo.Rows.Add(aux.getNombre(), aux.getHojas(), aux.getColor(), aux.getCalidad(), aux.getTiempo(), aux.getEstado());
                aux = aux.getSiguiente();
            } 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void tmr_Reloj_Tick(object sender, EventArgs e)
        {
            Nodo punt;
            if(Estatica.cola.Estavacio() == false)
            {
                punt = Estatica.cola.desencolar();
                tmr_Reloj.Stop();
                Mostrar();
                dgvImpresos.Rows.Add(punt.getNombre(), punt.getHojas(), punt.getColor(), punt.getCalidad(),punt.getTiempo(),"Impreso");
                if (Estatica.cola.getFrente() != null)
                {
                    float timer = Estatica.cola.getFrente().getHojas() * Estatica.cola.getFrente().getHojas() * 1000;
                    tmr_Reloj.Interval = (int)timer;
                    tmr_Reloj1.Interval = (int)timer / 10;
                    pgbCargar.Value = 0;
                    tmr_Reloj.Start();
                    tmr_Reloj1.Start();
                }
            }
            else
            {
                tmr_Reloj.Stop();
                tmr_Reloj1.Stop();
            }
        }

        private void tmr_Reloj1_Tick(object sender, EventArgs e)
        {
            if(pgbCargar.Value <= 100)
            {
                pgbCargar.Increment(10);
            }
            else
            {
                pgbCargar.Value = 0;
                tmr_Reloj1.Stop();
            }
        }
    }
}
