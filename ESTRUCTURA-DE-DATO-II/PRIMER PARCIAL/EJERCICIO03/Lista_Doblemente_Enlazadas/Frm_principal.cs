using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Doblemente_Enlazadas
{
    public partial class Frm_principal : Form
    {
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ciclista mostrar = new Frm_ciclista();
            this.Hide();
            mostrar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Carrera mostrar = new Frm_Carrera();
            this.Hide();

            mostrar.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
