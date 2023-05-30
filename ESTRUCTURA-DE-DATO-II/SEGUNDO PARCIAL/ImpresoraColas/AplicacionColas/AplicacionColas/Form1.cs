using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionColas
{
    public partial class Form1 : Form
    {
        Nodo aux;
        public Form1()
        {
            InitializeComponent();
            aux = new Nodo();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string estado = "Imprimiendo";
            if (txtHojas.Text != "" && txtNombre.Text != "" && cboCalidad.Text != "")
            {
                if(cboCalidad.Text == "Borrador" && rdbColor.Checked == true)
                {
                    aux.setTiempo(0.15);
                    aux.setColor("Color");
                }
                if(cboCalidad.Text == "Borrador" && rdbBlancoYnegro.Checked == true)
                {
                    aux.setTiempo(0.5);
                    aux.setColor("Blanco y Negro");
                }
                if(cboCalidad.Text == "Estandar" && rdbColor.Checked == true)
                {
                    aux.setTiempo(0.20);
                    aux.setColor("Color");
                }
                if(cboCalidad.Text == "Estandar" && rdbBlancoYnegro.Checked == true)
                {
                    aux.setTiempo(0.18);
                    aux.setColor("Blanco y Negro");
                }
                if(cboCalidad.Text == "Alto" && rdbColor.Checked == true)
                {
                    aux.setTiempo(0.30);
                    aux.setColor("Color");
                }
                if(cboCalidad.Text == "Alto" && rdbBlancoYnegro.Checked == true)
                {
                    aux.setTiempo(0.25);
                    aux.setColor("Blanco y Negro");
                }
                Estatica.cola.encolar(txtNombre.Text,int.Parse(txtHojas.Text),aux.getColor(),cboCalidad.Text,aux.getTiempo() ,"Imprimiendo");
                MessageBox.Show("Impresion añadida a la cola");
                txtHojas.Clear();
                txtNombre.Clear();
                rdbBlancoYnegro.Checked = false;
                rdbColor.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimiendo imp = new Imprimiendo();
            this.Hide();
            imp.Show();
        }
    }
}
