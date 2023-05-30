using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTAS_SIMPLES
{
    public partial class Frm_lista : Form
    {
       // lista_simple lista;
        public Frm_lista()
        {
            InitializeComponent();
           // lista = new lista_simple();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_edad.Clear();
            txt_nombre.Clear();
            lst_lista.Items.Clear();
            lstreprobados.Items.Clear();

        }

        private void lst_lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != null && txt_edad.Text != null)
            {
                string nom = txt_nombre.Text;
                int ed = int.Parse(txt_edad.Text);
                StaticClass.lista.crear_lista(nom, ed);
                //MessageBox.Show("alumno registrado");
                txt_edad.Clear();
                txt_nombre.Clear();
            }
            else
            {
                MessageBox.Show("Porfavor no se inutil introducir datos correctos");
            }
            

        }
        void aprobed(Nodo punt )
        {
            if(punt.get_edad() < 51)
            {
                StaticClass.list2.crear_lista(punt.get_nombre(), punt.get_edad());
            }
            else
            {
                StaticClass.list3.crear_lista(punt.get_nombre(), punt.get_edad());  
            }
        }

        public void mostrar(ListBox lst, lista_simple lista)
        {
            Nodo punt;
            punt = lista.get_cabeza();
            while(punt != null)
            {
                lst.Items.Add("NOMBRE : "+ punt.get_nombre());
                lst.Items.Add("EDAD : " + punt.get_edad());
                lst.Items.Add("--------------------------------");
                punt = punt.get_enlace();

            }
        }
    
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            Nodo punt = StaticClass.lista.get_cabeza();
            while (punt != null)
            {
                aprobed(punt);
                punt = punt.get_enlace();
            }
            mostrar(lst_lista, StaticClass.list3);
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_lista_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nodo punt = StaticClass.lista.get_cabeza();
            while(punt != null)
            {
                aprobed(punt);
                punt = punt.get_enlace();
            }
            mostrar(lstreprobados, StaticClass.list2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar(lstEstudiantes, StaticClass.lista);
            Nodo punt = StaticClass.lista.get_cabeza();
            while (punt != null)
            {
                aprobed(punt);
                punt = punt.get_enlace();
            }
        }
    }
}
