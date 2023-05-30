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

namespace registro_de_las_citas
{
    public partial class frm_rep_cita : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_rep_cita()
        {
            InitializeComponent();
        }

        private void btn_volver_reporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.Consultar("select * from cita");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Codigo invalido");
            else
            {
                dataGridView1.DataSource = conexion.Consultar("select * from cita where cod_cita=" + textBox1.Text);
                if(dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo Inexistente");
                    dataGridView1.DataSource = conexion.Consultar("select * from cita");
                }
            }
        }
    }
}
