using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Primerparcial
{
    public partial class Form1 : Form
    {
        ListaDoble l=new ListaDoble();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            l.registrarLista(char.Parse(txt_p.Text));
            MessageBox.Show("SE REGISTRO : "+txt_p.Text);
            txt_p.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            lst_lista.Items.Clear();
            NodoDoble punt =l.getCabezaCI();
            while (punt != null)
            {
                lst_lista.Items.Add(punt.getP());
                punt = punt.getSiguiente();
            }
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (l.palindromo() == true)
            {
                MessageBox.Show("ES PALINDROMOOO");
            }
            else
            {
                MessageBox.Show("NO ES PALINDROMOOO");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
