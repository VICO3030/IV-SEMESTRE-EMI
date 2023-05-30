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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ciclistas form_cic = new frm_ciclistas();
            this.Hide();
            form_cic.Show();
        }

        private void btn_reg_ca_Click(object sender, EventArgs e)
        {
            frm_carreras form_ca = new frm_carreras();
            this.Hide();
            form_ca.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_mostrar_cic_Click(object sender, EventArgs e)
        {
            frm_mostrar_ciclista mostrar = new frm_mostrar_ciclista();
            this.Hide();
            mostrar.Show();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_ca_Click(object sender, EventArgs e)
        {
            Frm_mostrar_carrera mostrar = new Frm_mostrar_carrera();
            this.Hide();
            mostrar.Show();
        }

        private void btn_buscar_cic_Click(object sender, EventArgs e)
        {
            Frm_Busqueda mostrar = new Frm_Busqueda();
            this.Hide();
            mostrar.Show();
        }
    }
}
