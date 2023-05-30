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

namespace TablaSanti
{
    public partial class frm_rep_pac : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_rep_pac()
        {
            InitializeComponent();
        }
       
        private void btn_mostrarPac_Click(object sender, EventArgs e)
        {
            string query = "select * from paciente";
            dtgv_pacientes.DataSource = conexion.Consultar(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "") MessageBox.Show("Codigo invalido");
            else
            {
                dtgv_pacientes.DataSource = conexion.Consultar("select * from paciente where cod_pac=" + txt_cod.Text);
                if(dtgv_pacientes.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo Inexistente");
                    dtgv_pacientes.DataSource = conexion.Consultar("select * from paciente");
                }
            }
        }
    }
}
