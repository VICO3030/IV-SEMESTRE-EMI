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
    public partial class Cola_Impresion : Form
    {
        public Cola_Impresion()
        {
            InitializeComponent();
        }

        public void mostar()
        {
            Nodo cab = Estatica.imp.getFrente();
            while (cab != null)
            {
                dgv_Mostrado.Rows.Add(cab.getNombre(), cab.getHojas(), cab.getCalidadColor());
                cab = cab.getSiguiente();
            }
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Frm f1 = new Frm();
            this.Close();
            f1.Show();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            dgv_Mostrado.Rows.Clear();
            if (Estatica.imp.getFrente() != null)
            {
                mostar();
            }
            else MessageBox.Show("Sin Cola de Impresión");
        }
    }
}
