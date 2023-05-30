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
    public partial class FRM_lista : Form
    {
       // LISTA_SIMPLE Lista; vamos a usar para varios 
       //vamos a volver statico
        public FRM_lista()
        {
            InitializeComponent();
            //Estatica.Lista = new LISTA_SIMPLE();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_lista_Load(object sender, EventArgs e)
        {

        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            string nombre =txt_nom.Text;
            int edad = int.Parse(txt_edad.Text);
            Estatica.Lista.crear_lista(nombre, edad);//llamando a mi objeto lista 

            MessageBox.Show("ALUMNO REGISTRADO  !!!!");

        }
        public void mostrar(ListBox lst)
        {
            Nodo punt;
            punt = Estatica.Lista.get_cabeza();
            while (punt != null)
            {
                lst.Items.Add("Nombre : "+ punt.get_nombre());
                lst.Items.Add("Edad : " + punt.get_Edad());
                lst.Items.Add("===============================");
                punt = punt.get_enlace();//que recorra nodo en nodo hazta que llegue en nulll
            }
        }
        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            mostrar(Lst_lista);

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_edad.Clear();
            txt_nom.Clear();
            Lst_lista.Items.Clear();
            txt_mayor.Clear();
            txt_menor.Clear();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lst_lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        private void Btn_promedio_Click(object sender, EventArgs e)
        {
            int prom;
            prom = Estatica.Lista.Edad_prom();

            Lbl_prom.Text ="La edad promedio es : "+ prom.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total_menor;
            total_menor = Estatica.Lista.Menor();
            txt_menor.Text = total_menor.ToString();

            MessageBox.Show("EL nombre es : " + Estatica.Lista.MenorNOMBRE());


        }

        private void Lbl_Menor_Click(object sender, EventArgs e)
        {

        }

        private void txt_menor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mayor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_mayor_Click(object sender, EventArgs e)
        {
            int total_mayor;
            total_mayor = Estatica.Lista.Mayor();
            txt_mayor.Text = total_mayor.ToString();
            MessageBox.Show("EL nombre es : " + Estatica.Lista.MayorNOMBRE());

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Lst_lista.Items.Clear();
            Estatica.Lista.Ordenamiento_Cad();
            mostrar(Lst_lista);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            Lst_lista.Items.Clear();
            Estatica.Lista.Ordenamiento();
            mostrar(Lst_lista);
            
        }

        private void txt_edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            Frm_Buscar Buscar = new Frm_Buscar();
            this.Hide();
            Buscar.Show();//vamos a mostrar el otro formulario con eso interactua el otro formulario con el otro
        }

        private void Btn_Eleminar_Click(object sender, EventArgs e)
        {
            string busca = txt_nom_eleminar.Text;
            Estatica.Lista.Eliminar( busca);
            MessageBox.Show("esta eleminado");
        }

        private void txt_nom_eleminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_edad_eleminar_Click(object sender, EventArgs e)
        {
            int ed;
            ed= int.Parse(txt_eleminar_edad.Text) ;
            Estatica.Lista.EleminarEdad(ed);
            MessageBox.Show("Se elemino");


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_InsertarNodo Insertar = new Frm_InsertarNodo();
            this.Hide();
            Insertar.Show(); 
        }
    }
    
}
