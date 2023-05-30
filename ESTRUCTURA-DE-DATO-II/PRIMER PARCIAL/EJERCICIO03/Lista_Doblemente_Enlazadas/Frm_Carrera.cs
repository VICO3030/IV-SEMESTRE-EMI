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
    public partial class Frm_Carrera : Form
    {
        Nodo_Ciclista punt;
        public Frm_Carrera()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            Frm_principal mostrar = new Frm_principal();
            this.Hide();
            mostrar.Show();

        }

        private void txt_nBici_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                punt = Estatica.ciclista.existeBici(int.Parse(txt_nBici.Text));
                if (punt == null)
                {
                    MessageBox.Show("No existe Ciclista ");
                    txt_nBici.Clear();
                    txt_nBici.Focus();

                }
                else
                {   
                    lbl_nombre_Mostrar.Text = punt.get_NombreCicli();
                    lbl_cat_mostrar.Text = punt.get_Categoria();
                    txt_lugar.Enabled = true;
                    txt_fecha.Enabled = true;
                    txt_tiempo.Enabled = true;
                }
            }
        }

        private void Btn_registrar_carr_Click(object sender, EventArgs e)
        {
            int nrobici = int.Parse(txt_nBici.Text);
            string lugar = txt_lugar.Text;
            DateTime fecha = DateTime.Parse( txt_fecha.Text);
            float tiempo = float.Parse(txt_fecha.Text);
            Estatica.carrera.Agregar(nrobici, tiempo, lugar, fecha);
            MessageBox.Show("SE REGISTRO CARRERA");


        }

        private void txt_nroBiciCarre_Click(object sender, EventArgs e)
        {
        }

        private void txt_nroBiciCarre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Carrera_Load(object sender, EventArgs e)
        {

        }

        private void lbl_nombre_Mostrar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cat_mostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
