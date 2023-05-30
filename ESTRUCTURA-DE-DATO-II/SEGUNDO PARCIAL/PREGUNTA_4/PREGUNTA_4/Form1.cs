using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREGUNTA_4
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            frm_imprimir frm = new frm_imprimir();
            this.Hide();
            frm.Show();
        }

        private void btn_Cola_impresion_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text != "" && txt_Num_Hojas.Text != "" && cbx_calcol.Text != "")
            {
                Estatica.imp.encolar(txt_Nombre.Text, int.Parse(txt_Num_Hojas.Text), cbx_calcol.Text);
                txt_Nombre.Text = "";
                txt_Num_Hojas.Text = "";
                cbx_calcol.Text = "";
                MessageBox.Show("ARCHIVO AGRGADO A LA COLA DE IMPRESIÓN");
            }
            else MessageBox.Show("Ingrese todos los datos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cola_Impresion most = new Cola_Impresion();
            this.Hide();
            most.Show();
        }
    }
}
