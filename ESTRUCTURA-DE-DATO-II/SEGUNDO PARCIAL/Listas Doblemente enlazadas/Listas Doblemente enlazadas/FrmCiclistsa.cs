using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Doblemente_enlazadas
{
    public partial class FrmCiclistsa : Form
    {
        public FrmCiclistsa()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int nroBici = int.Parse(txtNroBici.Text);
            object b = Cmb_Ciclista.SelectedItem;
            string category = Convert.ToString(b);
            StaticClass.ciclista.crearLista(nroBici, nombre, category);
            txtNombre.Clear();
            txtNroBici.Clear();
        }

        private void txtNroBici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter)) txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Cmb_Ciclista.Focus();
                Cmb_Ciclista.DroppedDown = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
