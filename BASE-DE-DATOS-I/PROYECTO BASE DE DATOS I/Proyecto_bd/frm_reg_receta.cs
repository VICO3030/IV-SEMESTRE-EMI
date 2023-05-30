using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Proyecto_bd;

namespace Tabla_receta
{
    public partial class frm_reg_rec : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_reg_rec()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_mostrar.DataSource = conexion.Consultar("select * from cita");
        }

        private void cmb_Cita_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            txt_cita.Clear();
            txt_codReceta.Clear();
            txt_prescripcion.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_cita.Text == "") MessageBox.Show("Codigo cita invalido!");
            else
            {
                dgv_mostrar.DataSource = conexion.Consultar("select * from cita where cod_cita=" + txt_cita.Text);
                if (dgv_mostrar.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo cita Inexistente!");
                    dgv_mostrar.DataSource = conexion.Consultar("select * from cita");
                }
                else btn_Registrar.Enabled = true;
            }
            
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (txt_codReceta.Text == "" || txt_cita.Text == "" || txt_prescripcion.Text == "") MessageBox.Show("Campos vacios!");
            else conexion.InsertarRec(Convert.ToInt32(txt_codReceta.Text), txt_prescripcion.Text, Convert.ToInt32(txt_cita.Text));
        }
    }
}
