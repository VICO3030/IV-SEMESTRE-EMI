using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_1__examen1p
{
    public partial class Frm_lista : Form
    {
        public Frm_lista()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if ( txt_nuevoNumero.Text != null)
            {
                
                int numero = int.Parse(txt_nuevoNumero.Text);
                staticLista.lista.crear_lista(numero);
                txt_nuevoNumero.Clear();
            }
            else
            {
                MessageBox.Show("Porfavor introducir datos correctos");
            }
        }
        public void mostrar(ListBox lst)
        {
            Nodo punte;
            punte = staticLista.lista.get_cabeza(); //empieza en la cabeza de la lista
            while (punte != null)
            {
                lst.Items.Add("numero : " + punte.get_numero());
                lst.Items.Add("=======================");
                punte = punte.get_enlace();
            }
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            mostrar(lst_listaL);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nuevoNumero.Clear();
            lst_listaL.Items.Clear();
            lst_listaR.Items.Clear();

        }

        private void rbt_mosLista_L_CheckedChanged(object sender, EventArgs e)
        {
            /*lst_listaR.Items.Clear();
            staticLista.lista.lista_L();//------------------
            mostrar(lst_listaR);*/
        }

        private void rbt_mosLista_R_CheckedChanged(object sender, EventArgs e)
        {
           /* lst_listaR.Items.Clear();
            staticLista.lista.lista_R();//-----------------
            mostrar(lst_listaR);*/
        }

        private void btn_formulario2_Click(object sender, EventArgs e)
        {
            frm_ejercicio2 frm_ejercicio2 = new frm_ejercicio2();
            this.Hide();
            frm_ejercicio2.Show ();
        }

        private void lst_listaL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frm_lista_Load(object sender, EventArgs e)
        {

        }
    }
}
