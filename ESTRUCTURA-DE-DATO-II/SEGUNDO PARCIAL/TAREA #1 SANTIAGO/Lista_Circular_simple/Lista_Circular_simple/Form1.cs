using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Circular_simple
{
    public partial class FRM_PRINCIPAL : Form
    {
         Lista_Circular l1 = new Lista_Circular();
        public FRM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            l1.Agregarlista(int.Parse(txt_numero.Text));
            MessageBox.Show("Se REGISTRO NUMERO !!!");
            //vaciamos 
            txt_numero.Clear();
        }
        //msotramos la lista{
        public void Mostrarlista()
        {
            NodoCircular punt = l1.Get_cabeza();
            do
            {
                lst_lista.Items.Add("num  : " + punt.Get_num());
                lst_lista.Items.Add("====================== " );
                punt = punt.Get_enlace();

            } while (punt != l1.Get_cabeza());
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            Mostrarlista();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_ELEMINARNUM_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(txt_eleminarnum.Text);
            
            if(l1.eleminar(num)==false)
                MessageBox.Show("No se encontro numero !!");
            else
                MessageBox.Show("Se eleminimo numero!!");
            txt_eleminarnum.Clear();
            lst_lista.Items.Clear();

        }
    }
}
