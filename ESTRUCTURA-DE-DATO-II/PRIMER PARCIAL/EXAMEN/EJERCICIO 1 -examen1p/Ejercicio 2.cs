using System;
using System.Collections;
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
    public partial class frm_ejercicio2 : Form
    {
        Listas_Simples a, b, result;
        public frm_ejercicio2()
        {
            a=new Listas_Simples();
            b = new Listas_Simples();
            InitializeComponent();
        }
        public void mostrar_a()
        {
            Nodo pun;
            pun = a.get_cabeza();
            while (pun != null)
            {
                lst_lista1.Items.Add(pun.get_numero());
                pun = pun.get_enlace();
            }
        }
        public void mostrar_b()
        {
            Nodo pun;
            pun = b.get_cabeza();
            while (pun != null)
            {
                lst_lista2.Items.Add(pun.get_numero());
                pun = pun.get_enlace();
            }
        }
        public void unir()
        {
            Nodo pun = a.get_cabeza();
            Nodo pun1 = b.get_cabeza();

            while (pun != null && pun1 != null)
            {
                result.crear_lista(pun.get_numero());
                result.crear_lista(pun1.get_numero());
                pun = pun.get_enlace();
                pun1 = pun1.get_enlace();

            }
        }
        public void mostrar_result()
        {
            result = new Listas_Simples();
            unir();

            Nodo punt = result.get_cabeza();
            while (punt != null)
            {
                lst_listaResult.Items.Add(punt.get_numero());
                punt = punt.get_enlace();
            }
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (b.get_cabeza() == null || a.get_cabeza() == null)
            {
                MessageBox.Show(" Las Listas Estan vacias ");
            }
            else
            {
                mostrar_a();
                mostrar_b();
                mostrar_result();
                

            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lst_lista1.Items.Clear();
            lst_lista2.Items.Clear();
            lst_listaResult.Items.Clear();
        }

        private void btn_registrarList1_Click(object sender, EventArgs e)
        {
            if (txt_Numero1.Text != null)
            {

                int numero = int.Parse(txt_Numero1.Text);
                staticLista.lista.crear_lista(numero);
                txt_Numero1.Clear();
            }
            else
            {
                MessageBox.Show("Porfavor introducir datos correctos");
            }
        }

        private void btn_registrarList2_Click(object sender, EventArgs e)
        {
            if (txt_Numero2.Text != null)
            {

                int numero = int.Parse(txt_Numero2.Text);
                staticLista.lista.crear_lista(numero);
                txt_Numero2.Clear();
            }
            else
            {
                MessageBox.Show("Porfavor introducir datos correctos");
            }
        }

    }
}
