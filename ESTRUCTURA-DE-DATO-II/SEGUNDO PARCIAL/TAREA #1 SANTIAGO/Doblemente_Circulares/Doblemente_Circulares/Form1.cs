using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doblemente_Circulares
{
    public partial class Frm_Principal : Form
    {
        LISTADOBLEMENTE l1 = new LISTADOBLEMENTE();
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((l1.Eleminar(int.Parse(txt_eleminar.Text))) == false)
            {
                MessageBox.Show("EL numero no existe");
            }
            else
            {
                if ((l1.Eleminar(int.Parse(txt_eleminar.Text))) == true)
                {

                    
                    
                    MessageBox.Show("El numero se elemino");
                }
            }
            txt_eleminar.Clear();
            LST_NUMEROS.Items.Clear();

        }
        public void Mostrar()
        {
            NodoCircular punt = l1.Get_cabeza();
            do
            {
                LST_NUMEROS.Items.Add("num  : " + punt.Get_num());
                LST_NUMEROS.Items.Add("====================== ");
                punt = punt.Get_sig();

            } while (punt != l1.Get_cabeza());
        }
        private void BTN_mostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            l1.Agregar_lista(int.Parse(txt_numero.Text));
            MessageBox.Show("SE REGISTRO NUMERO !!");
            //VACIAMO el textbox
            txt_numero.Clear();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
