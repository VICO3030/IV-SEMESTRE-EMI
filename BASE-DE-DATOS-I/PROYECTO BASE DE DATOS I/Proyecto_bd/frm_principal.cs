using HISTORIA_CLINICA;
using Laboratorio;
using registro_de_las_citas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tabla_receta;
using TablaSanti;

namespace Proyecto_bd
{
    public partial class frm_principal : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            conexion.Desconectar();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reg_med regMed = new frm_reg_med();
            regMed.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reg_pac regPac = new frm_reg_pac();
            regPac.Show();
        }

        private void mostrarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void medicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_rep_med repMed = new frm_rep_med();
            repMed.Show();
        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_rep_pac repPac = new frm_rep_pac();
            repPac.Show();
        }

        private void medicoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_editar_med edMed = new frm_editar_med();
            edMed.Show();
        }

        private void pacienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_editar_pac edPac = new frm_editar_pac();
            edPac.Show();
        }

        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_reg_hist regHist = new frm_reg_hist();
            regHist.Show();
        }

        private void historiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_rep_hist repHist = new frm_rep_hist();
            repHist.Show();
        }

        private void citaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_reg_cita regCita = new frm_reg_cita();
            regCita.Show();
        }

        private void citaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rep_cita repCita = new frm_rep_cita();
            repCita.Show();
        }

        private void recetaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_reg_rec regRec = new frm_reg_rec();
            regRec.Show();
        }

        private void recetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rep_rec repRec = new frm_rep_rec();
            repRec.Show();
        }

        private void laboratorioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_reg_lab regLab = new frm_reg_lab();
            regLab.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rep_lab repLab = new frm_rep_lab();
            repLab.Show();
        }
    }
}
