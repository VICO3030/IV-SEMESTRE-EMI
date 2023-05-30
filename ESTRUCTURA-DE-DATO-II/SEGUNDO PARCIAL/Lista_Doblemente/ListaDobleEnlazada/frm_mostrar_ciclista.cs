using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleEnlazada
{
    public partial class frm_mostrar_ciclista : Form
    {
        public frm_mostrar_ciclista()
        {
            InitializeComponent();
        }
        public void mostrarInicio()
        {
            NodoCiclista punt = Estatica.ciclistas.get_cabeza();
            while(punt != null)
            {
                dgv_ciclista.Rows.Add(punt.get_nomCic(), punt.get_nBici(), punt.get_cat());
                punt = punt.get_sig();
            }
        }
        public void mostrarFinal()
        {
            NodoCiclista punt = Estatica.ciclistas.get_cabeza();
            while(punt.get_sig() != null)
            {
                punt = punt.get_sig();
            }
            while(punt.get_ant() != null)
            {
                dgv_ciclista.Rows.Add(punt.get_nomCic(), punt.get_nBici(), punt.get_cat());
                punt = punt.get_ant();
            }
        }
        private void frm_mostrar_ciclista_Load(object sender, EventArgs e)
        {

        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            if(Estatica.ciclistas.get_cabeza() == null)
            {
                MessageBox.Show("No Existen Ciclistas Inscritos");
            }
            else
            {
                mostrarInicio();
            }
        }

        private void btn_final_Click(object sender, EventArgs e)
        {
            if (Estatica.ciclistas.get_cabeza() == null)
            {
                MessageBox.Show("No Existen Ciclistas Inscritos");
            }
            else
            {
                mostrarFinal();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            this.Hide();
            principal.Show();
        }
    }
}
