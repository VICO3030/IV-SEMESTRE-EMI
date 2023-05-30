using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Doblemente_enlazadas
{
    public partial class FrmMostrarCiclista : Form
    {
        NodoCiclista punt;
        public FrmMostrarCiclista()
        {
            InitializeComponent();
        }
        public void mostrarInicio()
        {
            punt = StaticClass.ciclista.getCabezaCiclista();
            while(punt != null)
            {
                DgvCiclisa.Rows.Add(punt.getNombre(), punt.getBici(), punt.getCategoria());
                punt = punt.getSig();

            }
        }

        public void mostrarFinal()
        {
            punt = StaticClass.ciclista.getCabezaCiclista();
            while (punt.getSig() != null) {
                punt = punt.getSig();
            }
            while (punt != null)
            {
                DgvCiclisa.Rows.Add(punt.getNombre(), punt.getBici(), punt.getCategoria());
                punt = punt.getAnt();
            }
        }
        private void FrmMostrarCiclista_Load(object sender, EventArgs e)
        {

        }

        private void Btn_MostrarFinal_Click(object sender, EventArgs e)
        {
            if(StaticClass.ciclista.getCabezaCiclista() == null)
            {
                MessageBox.Show("NO tienes ciclistas pinche puto");
            }
            else
            {
                mostrarInicio();
            }
        }

        private void Btn_mostrarInicio_Click(object sender, EventArgs e)
        {
            if (StaticClass.ciclista.getCabezaCiclista() == null)
            {
                MessageBox.Show("NO tienes ciclistas pinche puto");
            }
            else
            {
                mostrarFinal();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }
    }
}
