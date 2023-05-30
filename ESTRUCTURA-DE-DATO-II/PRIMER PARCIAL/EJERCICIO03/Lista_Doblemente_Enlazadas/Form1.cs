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
    public partial class Frm_ciclista : Form
    {
        public Frm_ciclista()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txt_nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_nro_Ciclista.Focus();
            }
        }


        private void txt_nBici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_categoria.Focus();
            }
        }
        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Frm_principal MOSTRAR = new Frm_principal();
            this.Hide();
            MOSTRAR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre =  txt_nom_ciclista.Text;
            int num = int.Parse(txt_nro_Ciclista.Text);
            string cat = txt_categoria.Text;
            Estatica.ciclista.Crear_ciclista(num, nombre, cat);
          
            MessageBox.Show("CICLISTA REGISTRADO");

        }
    }
}
