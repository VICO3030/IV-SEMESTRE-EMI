using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Proyecto_bd;

namespace registro_de_las_citas
{
    public partial class frm_reg_cita : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_reg_cita()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertar()
        {
            if(txt_codigo.Text == "" ||
               txt_motivo.Text == "" ||
               mtxt_fecha.Text == "" ||
               mtxt_hora.Text == "" ||
               txt_medico.Text == "" ||
               txt_historial.Text == ""

                )
            {
                MessageBox.Show("Campos vacios en el registro");
            }
            else
            {
                conexion.InsertarCita(
                    Convert.ToInt32(txt_codigo.Text),
                    txt_motivo.Text,
                    mtxt_fecha.Text,
                    mtxt_hora.Text,
                    Convert.ToInt32(txt_medico.Text),
                    Convert.ToInt32(txt_historial.Text)
                    );
            }
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(mtxt_fecha.Text);
            //insertar();
            if (txt_medico.Text != "" && txt_historial.Text != "")
            {
                dataGridView1.DataSource = conexion.Consultar("select * from historia where cod_hist=" + txt_historial.Text);
                dataGridView2.DataSource = conexion.Consultar("select * from medico where cod_med=" + txt_medico.Text);
                if (dataGridView1.Rows[0].Cells[0].Value == null || dataGridView2.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Medico inexistente o Historia inexistente!");

                    dataGridView1.DataSource = conexion.Consultar("select * from historia");
                    dataGridView2.DataSource = conexion.Consultar("select * from medico");
                }
                else insertar();
            }
            else MessageBox.Show("Codigo invalido para: Medico, Historia");
        }
        private void limpiar()
        {
            txt_codigo.Clear();
            txt_motivo.Clear();
            mtxt_fecha.Clear();
            mtxt_hora.Clear();
            txt_medico.Clear();
            txt_historial.Clear();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frm_reg_cita_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.Consultar("select * from historia");
            dataGridView2.DataSource = conexion.Consultar("select * from medico");
        }
    }
}
