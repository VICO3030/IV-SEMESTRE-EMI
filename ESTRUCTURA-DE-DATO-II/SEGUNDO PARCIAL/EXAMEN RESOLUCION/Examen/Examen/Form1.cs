using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        Doblemente l1 = new Doblemente();
        public Form1()
        {
            InitializeComponent();
        }
        //metodo de ver si ya existe el numero o no
        public Boolean Verificar(int dato)
        {
            Boolean encontrado = false;
            Nodo punt = l1.get_cabeza();

           while(punt != null && encontrado != true)
            {
                if (dato == punt.getDato())
                {
                    encontrado = true;
                }
                punt = punt.get_sig();
            }
           
            return encontrado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Verificar(int.Parse(txt_num.Text)) != true )
            {
                l1.agregar(int.Parse(txt_num.Text));
                MessageBox.Show("SE REGISTRO NUMERO !!");
                txt_num.Clear();
            }
            else
            {

                    MessageBox.Show("EL NUMERO YA EXISTE !");
                    txt_num.Clear();
                

            }

            //VACIAMO el textbox
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void mostrarInicio()
        {
            Nodo punt = l1.get_cabeza();
            while (punt != null)
            {
                LST_PRINCIPAL.Items.Add(punt.getDato());
                punt = punt.get_sig();
            }
        }
        private void BTN_MOSTRAR_Click(object sender, EventArgs e)
        {
                mostrarInicio();
        }
        public int mostrarMenor()
        {
            int menor = 1000;
            Nodo punt = l1.get_cabeza();
            while (punt != null)
            {
                if (punt.getDato() < menor)
                {
                    menor = punt.getDato();
                }
                punt = punt.get_sig();
            }
            return menor;
        }
        public int mostrarMayor()
        {
            int mayor= 0;
            Nodo punt = l1.get_cabeza();
            while (punt != null)
            {
                if (punt.getDato()>mayor)
                {
                    mayor = punt.getDato();
                }
                punt = punt.get_sig();
            }
            return mayor;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El menor numero es  :" + mostrarMenor());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("El mayor numero es  :" + mostrarMayor());
        }
    }
}
