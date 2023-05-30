using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleEnlazada
{
    public partial class frm_carreras : Form
    {
        NodoCiclista punt;
        public frm_carreras()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nBici_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nBici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                punt = Estatica.ciclistas.existe_nBici(int.Parse(txt_nBici.Text));
                if(punt == null)
                {
                    MessageBox.Show("No Existe Ciclista");
                    txt_nBici.Clear();
                    txt_nBici.Focus();
                }
                else
                {
                    lbl_ciclista.Text = punt.get_nomCic();
                    lbl_cat.Text = punt.get_cat();
                   // txt_lugar.Enabled = true;
                    txt_fecha.Enabled = true;
                    txt_tiempo.Enabled = true;
                    btn_reg.Enabled = true;
                }
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            this.Hide();
            principal.Show();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Estatica.carreras.agregar(int.Parse(txt_nBici.Text), float.Parse(txt_tiempo.Text), DateTime.Parse(txt_fecha.Text));
            dgv_carreras.Rows.Add(punt.get_nomCic(),txt_nBici.Text,txt_tiempo.Text,txt_fecha.Text);
            MessageBox.Show("Se registro!!");
            txt_nBici.Clear();
            //txt_lugar.Clear();
            txt_tiempo.Clear();
            txt_fecha.Clear();
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_carreras_Load(object sender, EventArgs e)
        {

        }

        private void lbl_ciclista_Click(object sender, EventArgs e)
        {

        }

        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_carreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}