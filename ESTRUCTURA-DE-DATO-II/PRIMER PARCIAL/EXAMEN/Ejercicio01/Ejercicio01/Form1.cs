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
        Lista lista = new Lista();
        Lista r = new Lista();
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
            lista.crear_lista(num);

            MessageBox.Show("Se registro correctamente ");

            txt_numingreso.Clear();
        }
        public void mostrar(ListBox lst)
        {
            Nodo punt;
            punt = lista.get_cabeza();
            while (punt != null)
            {
                lst.Items.Add(punt.Get_num());
    
                punt = punt.Get_enlace();//que recorra nodo en nodo hazta que llegue en nulll
            }
        }
        public void mostrar_repetidos()
        {
            
        }
        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            //  mostrar(lista_numeros);
            Nodo punt;
            Nodo punt2;
            punt = lista.get_cabeza();
            punt2 = punt;
            while (punt != null)
            {
                punt2 = punt.Get_enlace();
                    while(punt2!= null)
                {
                    if(punt.Get_num()==punt2.Get_num() && (r.Buscar(punt.Get_num()) != true)){
                        r.crear_lista(punt.Get_num());
                    }
                    punt2 = punt2.Get_enlace();

                }
                punt = punt.Get_enlace();
            }
            punt = lista.get_cabeza();
            lista_numeros.Items.Clear();
            while (punt != null){
                lista_numeros.Items.Add(punt.Get_num());
                punt = punt.Get_enlace();
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eleminar_Click(object sender, EventArgs e)
        {
            Nodo punt = r.get_cabeza();
            lst_repetidos.Items.Clear();
            while(punt != null)
            {
                lst_repetidos.Items.Add(punt.Get_num());
                punt = punt.Get_enlace();
            }
            punt = r.get_cabeza();
            while(punt != null)
            {
                if (r.Buscar(punt.Get_num()))
                {
                    lista.Eleminar(punt.Get_num());

                }
                punt = punt.Get_enlace();
            }
            

        }



        private void lst_repetidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
