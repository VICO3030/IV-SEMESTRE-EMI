using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arbol_Binario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Graphics g; //Definición del objeto gráfico
                    //Evento del formulario que permitirá dibujar el Árbol Binario





        private void btn_inorden_Click(object sender, EventArgs e)
        {

        }
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_principal f2 = new Frm_principal();
            this.Hide();
            f2.Show();
        }

        private void GRafica_Click(object sender, EventArgs e)
        {
             
            
        }

        private void GraficaArbol_Load(object sender, EventArgs e)
        {

        }

        private void GRafica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            Estatica.A.DibujarArbol(g, this.Font, Brushes.Pink, Brushes.Blue, Pens.Red, Brushes.Black);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (Estatica.A.existe(int.Parse(txt_buscar.Text))==false)
            {
                MessageBox.Show("No existe el numero !!");
            }
            else
            {
                if (txt_buscar.Text != "")
                {

                    int num = int.Parse(txt_buscar.Text);
                    int c = 0;
                     Alturalbl.Text = "La altura es: " + Estatica.A.altura(num);
                    //mostramosel nivel del arbol
                    Nodo_Arbol aux = Estatica.A.devolver_raiz();

                    if (Estatica.A.buscar(num, aux, ref c))
                    {
                        lst_reco.Items.Clear();
                        noodo x = Estatica.C.desencolar();
                        while (x != null)
                        {
                            lst_reco.Items.Add(x.Dato.Dato);
                            x = Estatica.C.desencolar();
                        }


                        nivellbl.Text = "El " + num + " esta en el nivel " + c;
                    }
                }
            }
        }
    }

}
