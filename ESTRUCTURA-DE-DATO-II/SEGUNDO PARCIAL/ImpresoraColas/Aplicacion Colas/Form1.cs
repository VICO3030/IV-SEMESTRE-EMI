using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Colas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            if(Txt_nombre.Text!="" && Txt_hojas.Text!="" && ComBox_Calidad.Text!="Elegir Opcion" && ((RaBu_Color.Checked==false && RaBu_ByN.Checked==true) ||((RaBu_Color.Checked == true && RaBu_ByN.Checked == false)))) 
            {
                string n = Txt_nombre.Text;
                int h = int.Parse(Txt_hojas.Text);
                string c = ComBox_Calidad.Text;
                string col;
                float tiempo=0;
                string es = "En espera";
                if(RaBu_ByN.Checked)
                {
                    col = "Color";
                }
                else 
                {
                    col = "Blanco y Negro";
                }
                if(c=="Estandar" && RaBu_Color.Checked==true)
                {
                    tiempo = (float)0.45*h;
                }
                else if(c=="Estandar" && RaBu_ByN.Checked==true)
                {
                    tiempo =(float) 0.35*h;
                }
                else if(c=="Borrador" && RaBu_Color.Checked==true)
                {
                    tiempo = (float)0.30*h;
                }
                else if (c == "Borrador" && RaBu_ByN.Checked == true)
                {
                    tiempo = (float)0.25*h;
                }
                else if(c=="Alta" && RaBu_Color.Checked==true)
                {
                    tiempo = (float)0.60*h;
                }
                else if (c == "Alta" && RaBu_ByN.Checked == true)
                {
                    tiempo = (float)0.55*h;
                }
                Estatica.C.encolar(n, h, col, c, es, tiempo);
                Txt_nombre.Clear();
                Txt_hojas.Clear();
                ComBox_Calidad.Text = "Elegir Opcion";
                RaBu_ByN.Checked = false;
                RaBu_Color.Checked = false;
                Txt_nombre.Focus();
            }
            else
            {
                if(Txt_nombre.Text=="")
                {
                    MessageBox.Show("Ingresar un nombre");
                }
                else if(Txt_hojas.Text=="")
                {
                    MessageBox.Show("Ingresar una cantidad de hojas");
                }
                else if(ComBox_Calidad.Text=="Elegir Opcion")
                {
                    MessageBox.Show("Elegir una calidad");
                }
                else
                {
                    MessageBox.Show("Seleccione una opcion de color");
                }
            }
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            if(!Estatica.C.esta_vacia())
            {
                nodo aux = Estatica.C.get_frente();
                aux.Estado = "Imprimiendo...";
                Form2 formulario = new Form2();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Debe agregar impresiones a la cola");
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
