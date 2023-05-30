using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    
    public partial class Frm_principal : Form
    {
        Lista l1 = new Lista();
        Lista l2 = new Lista();
        Lista l3 = new Lista();
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void Btn_registrar_num_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_numingreso.Text);
            l1.crear_lista(num);

            MessageBox.Show("Se registro correctamente ");

            txt_numingreso.Clear();
        }
        public void mostrar(ListBox lst)
        {
            Nodo punt;
            punt = l1.get_cabeza();
            while (punt != null)
            {
                lst.Items.Add(punt.Get_num());
    
                punt = punt.Get_enlace();//que recorra nodo en nodo hazta que llegue en nulll
            }
        }
        public void mostrar02(ListBox lst)
        {
            Nodo punt;
            punt = l2.get_cabeza();
            while (punt != null)
            {
                lst_numeros2.Items.Add(punt.Get_num());

                punt = punt.Get_enlace();//que recorra nodo en nodo hazta que llegue en nulll
            }
        }
        public void mostrar03(ListBox lst)
        {
            Nodo punt;
            punt = l3.get_cabeza();
            while (punt != null)
            {
                lstintercalado.Items.Add(punt.Get_num());

                punt = punt.Get_enlace();//que recorra nodo en nodo hazta que llegue en nulll
            }
        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            mostrar(lista_numeros);
            mostrar02(lst_numeros2);
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eleminar_Click(object sender, EventArgs e)
        {
            lstintercalado.Items.Clear();
            Nodo punt;
            Nodo punt2;
            punt = l1.get_cabeza();
            punt2 = l2.get_cabeza();
            while(punt != null || punt2 != null)
            {
                if(punt != null)
                {
                    l3.crear_lista(punt.Get_num());
                    punt = punt.Get_enlace();
                }
                if (punt2 != null)
                {
                    l3.crear_lista(punt2.Get_num());
                    punt2 = punt2.Get_enlace();
                }

            }
            lstintercalado.Items.Clear();
            Nodo punt3;
            punt3 = l3.get_cabeza();
            while (punt3 != null)
            {
                lstintercalado.Items.Add(punt3.Get_num());
                punt3 = punt3.Get_enlace();
            }
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt_numingreso.Text);
            l2.crear_lista(num);

            MessageBox.Show("Se registro correctamente ");

            txt_numingreso.Clear();
        }

        private void lstintercalado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_limpiar_Click(object sender, EventArgs e)
        {
            lst_numeros2.Items.Clear();
            lista_numeros.Items.Clear();
        }
    }
}
