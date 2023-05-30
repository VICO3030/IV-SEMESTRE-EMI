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

namespace Proyecto_bd
{
    public partial class frm_rep_med : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_rep_med()
        {
            InitializeComponent();
        }
        
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string query = "select * from \"medico\"";
            dgv_mostrar.DataSource = conexion.Consultar(query);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_nom_busq.Text != "")
            {
                dgv_mostrar.DataSource = conexion.Consultar("select * from medico where cod_med=" + txt_nom_busq.Text);
                if (dgv_mostrar.Rows[0].Cells[0].Value == null) MessageBox.Show("Codigo Inexistente!");
            }
            else MessageBox.Show("Codigo invalido!");
        }

        private void frm_rep_med_Load(object sender, EventArgs e)
        {

        }

        private void dgv_mostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
