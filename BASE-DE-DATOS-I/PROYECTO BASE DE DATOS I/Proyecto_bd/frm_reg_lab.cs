using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_bd;

namespace Laboratorio
{
    public partial class frm_reg_lab : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_reg_lab()
        {
            InitializeComponent();
           
        }

        private void lbl_desc_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_labo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.Consultar("select * from receta");
            this.WindowState = FormWindowState.Normal;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                txt_ciudad.Text == "" || txt_cod.Text == "" ||
                txt_desc.Text == "" || txt_direc.Text == "" ||
                txt_est.Text == "" || txt_pais.Text == "" ||
                mtxt_fecha.Text == "00-00-0000"
                ) MessageBox.Show("Campos vacios!");
            else conexion.InsertarLab(Convert.ToInt32(txt_cod.Text),mtxt_fecha.Text,txt_desc.Text,txt_pais.Text,txt_ciudad.Text,txt_direc.Text,Convert.ToInt32(txt_est.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cod.Clear();
            txt_ciudad.Clear();
            txt_desc.Clear();
            txt_direc.Clear();
            txt_est.Clear();
            mtxt_fecha.Clear();
            txt_pais.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_est.Text == "") MessageBox.Show("Codigo Receta invalido!");
            else
            {
                dataGridView1.DataSource = conexion.Consultar("select * from receta where cod_rec=" + txt_est.Text);
                if (dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo Receta Inexistente!");
                    dataGridView1.DataSource = conexion.Consultar("select * from receta");
                }
                else btn_registrar.Enabled = true;
            }
        }
    }
}
