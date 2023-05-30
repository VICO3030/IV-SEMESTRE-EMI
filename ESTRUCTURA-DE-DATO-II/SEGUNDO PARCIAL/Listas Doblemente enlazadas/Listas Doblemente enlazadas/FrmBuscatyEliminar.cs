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
    public partial class FrmBuscatyEliminar : Form
    {
        public FrmBuscatyEliminar()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            NodoCiclista p = StaticClass.ciclista.existNumber(int.Parse(txtbuscar.Text));
            if(p != null)
            {
                StaticClass.ciclista.eliminarNodo(p);
                grpbLista.Visible = true;
                lblxd.Text = p.getNombre();
                lbld2.Text = p.getCategoria();
                MessageBox.Show("Se borro todo");
            }
            else
            {
                MessageBox.Show("No existe");
            }
            
        }
    }
}
