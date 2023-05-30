using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_Cola
{
    public partial class Form1 : Form
    {
        Cola C1;
       

        public Form1()
        {
            C1 = new Cola();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_encolar_Click(object sender, EventArgs e)
        {
            C1.Encolar(int.Parse(txt_dato.Text));
            MessageBox.Show("SE ENCOLO!!");
            txt_dato.Clear();
        }

        private void btn_desencolar_Click(object sender, EventArgs e)
        {
            

            if (C1 != null)
            {
                Nodo_Cola aux = C1.Desencolar();
                MessageBox.Show("Dato desencolado");
                LST_COLAS.Items.Clear();

            }else
            {
                MessageBox.Show("LISTA VACIA!!");
            }



        }
        public void Mostrar()
        {
            Nodo_Cola aux = C1.Get_frente();
            while (aux != null)
            {
                LST_COLAS.Items.Add("dato : " + aux.Get_dato());
                aux = aux.Get_sig();
            } 

        }
        public void buscar(int dato)
        {
            Nodo_Cola aux = C1.Get_frente();
            Boolean encontrado = false;
            while (aux != null && encontrado != true)
            {
                if (dato==aux.Get_dato())
                {
                    encontrado = true;
                }
                aux = aux.Get_sig();
            }
            if (encontrado == true)
            {
                MessageBox.Show("EL DATO EXISTE !!");
            }
            else
            {
                MessageBox.Show("EL DATO NO EXISTE !!");
            }
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {
            buscar(int.Parse(txt_dato.Text));

        }

        private void BTN_ELEMINAR_Click(object sender, EventArgs e)
        {

            MessageBox.Show(C1.Eliminar(int.Parse(txt_dato.Text)));

            txt_dato.Clear();
            LST_COLAS.Items.Clear();
            Mostrar();
        }
    }
}
