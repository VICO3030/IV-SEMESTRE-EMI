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
    public partial class FrmCarrera : Form
    {
        NodoCiclista punt;
        public FrmCarrera()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            FrmPrincipal form1 = new FrmPrincipal();
            this.Close();
            form1.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            StaticClass.carrera.crearLista(int.Parse(txtNrobici.Text),int.Parse(txtTiempo.Text), int.Parse(txtLugar.Text), DateTime.Parse(txtfecha.Text));
            DgbCarrera.Rows.Add(punt.getNombre(), txtNrobici.Text, txtLugar.Text, txtTiempo.Text, txtfecha.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNrobici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                punt = StaticClass.ciclista.existNumber(int.Parse(txtNrobici.Text));
                if(punt == null)
                {
                    MessageBox.Show("NO existe");
                    txtNrobici.Clear();
                    txtNrobici.Focus();
                }
                else
                {
                    lblNombre.Text = punt.getNombre();
                    lblCategoria.Text = punt.getCategoria();
                    txtfecha.Enabled = true;
                    txtLugar.Enabled = true;
                    txtTiempo.Enabled = true;

                }
            }
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {

        }
    }
}
