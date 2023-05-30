using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(Txt_num.Text!="")
            {
                int n = int.Parse(Txt_num.Text);
                nodo x = Estatica.A.get_Raiz();
                Estatica.A.agregar(n, x);
                Txt_num.Clear();
                Txt_num.Focus();
                MessageBox.Show("Numero ingresado");
            }
            else
            {
                MessageBox.Show("Ingresar un numero");
            }
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            RECORRIDO Formulario = new RECORRIDO();
            Formulario.Show();
        }

        private void Btn_hojas_Click(object sender, EventArgs e)
        {
            Hojas Formulario = new Hojas();
            Formulario.Show();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if(Estatica.A.get_Raiz()!=null)
            {
                Busqueda formulario = new Busqueda();
                formulario.Show();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Estatica.A.get_Raiz() != null)
            {
                Eliminar formulario = new Eliminar();
                formulario.Show();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
