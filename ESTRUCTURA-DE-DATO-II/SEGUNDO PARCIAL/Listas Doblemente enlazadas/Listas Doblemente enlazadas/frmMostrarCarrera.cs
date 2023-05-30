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
    public partial class frmMostrarCarrera : Form
    {
        NodoCarrera punt;
        public frmMostrarCarrera()
        {
            InitializeComponent();
        }
        public void mostrarInicio()
        {
            punt = StaticClass.carrera.getCabezaCarrera();
            while (punt != null)
            {
                DgvCarrera.Rows.Add(punt.getBici(), punt.getTiempo(), punt.getLugar(), punt.getFecha());
                punt = punt.getSig();

            }
        }

        public void mostrarFinal()
        {
            punt = StaticClass.carrera.getCabezaCarrera();
            while (punt.getSig() != null)
            {
                punt = punt.getSig();
            }
            while (punt != null)
            {
                DgvCarrera.Rows.Add(punt.getBici(), punt.getTiempo(), punt.getLugar(), punt.getFecha());
                punt = punt.getAnt();
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        private void Btn_mostrarInicio_Click(object sender, EventArgs e)
        {
            if (StaticClass.ciclista.getCabezaCiclista() == null)
            {
                MessageBox.Show("NO tienes Carreras pinche puto");
            }
            else
            {
                mostrarInicio();
            }
        }

        private void Btn_MostrarFinal_Click(object sender, EventArgs e)
        {
            if (StaticClass.ciclista.getCabezaCiclista() == null)
            {
                MessageBox.Show("NO tienes carreras pinche puto");
            }
            else
            {
                mostrarFinal();
            }
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            StaticClass.carrera.insertar();
        }
    }
}
