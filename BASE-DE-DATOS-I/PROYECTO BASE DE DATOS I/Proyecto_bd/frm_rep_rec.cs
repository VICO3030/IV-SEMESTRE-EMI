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

namespace Tabla_receta
{
    public partial class frm_rep_rec : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_rep_rec()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.Consultar("select * from receta");
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "") MessageBox.Show("Codigo invalido!");
            else
            {
                dataGridView1.DataSource = conexion.Consultar("select * from receta where cod_rec=" + txt_cod.Text);
                if (dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo inexistente!");
                    dataGridView1.DataSource = conexion.Consultar("select * from receta");
                }

            }
        }
    }
}
