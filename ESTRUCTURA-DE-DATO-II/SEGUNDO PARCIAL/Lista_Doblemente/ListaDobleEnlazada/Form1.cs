using System;

using System.Windows.Forms;

namespace ListaDobleEnlazada
{
    public partial class frm_ciclistas : Form
    {
        public frm_ciclistas()
        {
            InitializeComponent();
        }

        private void frm_ciclistas_Load(object sender, EventArgs e)
        {
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_nBici.Focus();
               
            }
        }

        private void txt_nBici_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nBici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmb_cat.Focus();
            }
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Estatica.ciclistas.agregar(int.Parse(txt_nBici.Text), txt_nom.Text, cmb_cat.Text);
            MessageBox.Show("Ciclista Registrado");
            //vaciamos una vez registrado 
            txt_nom.Clear();
            txt_nBici.Clear();
            cmb_cat.Text = "";
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            this.Hide();
            principal.Show();
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
