using Proyecto_bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HISTORIA_CLINICA
{
    public partial class frm_reg_hist : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_reg_hist()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_pacientes.DataSource = conexion.Consultar("select * from paciente");
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "" || txt_paciente.Text == "") MessageBox.Show("Campos vacios!");
            else
                conexion.InsertarHistoria(Convert.ToInt32(txt_codigo.Text), Convert.ToInt32(txt_paciente.Text), txt_descripcion.Text);
        }
        private void limpiar()
        {
            txt_codigo.Clear();
            txt_paciente.Clear();
            txt_descripcion.Clear();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_paciente.Text != "")
            {
                dgv_pacientes.DataSource = conexion.Consultar("select * from paciente where cod_pac=" + txt_paciente.Text);
                if (dgv_pacientes.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo Inexistente!");
                    btn_registrar.Enabled = false;
                    dgv_pacientes.DataSource = conexion.Consultar("select * from paciente");
                }
                else
                {
                    btn_registrar.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Codigo paciente vacio!");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
