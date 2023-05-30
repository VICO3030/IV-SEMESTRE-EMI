using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer04_Cola
{
    public partial class Form1 : Form
    {
        double tiempo;
        string color;
        public Form1()
        {
            color = "";
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            


        private void btn_Agregar_Click(object sender, EventArgs e)
           
        {


            if (rbd_color.Checked == true && txt_calidad.Text == "Borrador")
            {
                tiempo = 0.15;
                color = "Color";

            }
            if (rbd_color.Checked == true && txt_calidad.Text == "Estandar")
            {
                tiempo = 0.20;
                color = "Color";
            }
            if (rbd_color.Checked == true && txt_calidad.Text == "Alto")
            {
                tiempo = 0.30;
                color = "Color";
            }
            if (rbd_negro.Checked == true && txt_calidad.Text == "Borrador")
            {
                tiempo = 0.5;
                color = "Blanco y negro";
            }
            if (rbd_negro.Checked == true && txt_calidad.Text == "Estandar")
            {
                tiempo = 0.18;
                color = "Blanco y negro";
            }
            if (rbd_negro.Checked == true && txt_calidad.Text == "Alto")
            {
                tiempo = 0.25;
                color = "Blanco y negro";
            }
            Estatica.Impresion.Encolar(txt_nom.Text, int.Parse(txt_nro.Text), txt_calidad.Text ,tiempo ,color);
            MessageBox.Show("SE AÑADIO!!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbd_color_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            frm_imprimiendo im1 = new frm_imprimiendo();
            this.Hide();
            im1.Show();
        }
    }
}
