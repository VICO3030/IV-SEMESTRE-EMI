using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer02_Pila
{
    public partial class FRM_MENU : Form
    {
        public FRM_MENU()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            FRM_EMPRESA form = new FRM_EMPRESA();
            this.Hide();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MENU_Load(object sender, EventArgs e)
        {

        }
    }
}
