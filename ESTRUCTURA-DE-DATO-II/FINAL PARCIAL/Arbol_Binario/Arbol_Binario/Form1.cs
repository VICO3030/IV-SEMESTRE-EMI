using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario
{
    public partial class Frm_principal : Form
    {
       
        public Frm_principal()
        {
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            //  Nodo_Arbol nuevo,= new Nodo_Arbol();
            Estatica.A.insertar_Arbol(int.Parse(txt_numero.Text));
            MessageBox.Show("Se registro correctamente!!!");
            txt_numero.Clear();
        }
        //metodo de mostras Preorden
          void Preorden(Nodo_Arbol punt)
        {
            if (punt != null)
            {
                lst_preorden.Items.Add(punt.Dato);
                Preorden(punt.Punt_izq);
                Preorden(punt.Punt_dere);
            } 
        }
        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (Estatica.A.existe(int.Parse(txt_numero.Text)) == true)
            {
                MessageBox.Show("SI EXISTE EL DATO EN EL ARBOL");
            }
            else
            {
                MessageBox.Show("EL DATO NO EXISTE!!");
            }

               
        }

        private void btn_preorden_Click(object sender, EventArgs e)
        {
            Nodo_Arbol punt;
            
            punt = Estatica.A.devolver_raiz();
            if (punt == null)
            {
                MessageBox.Show("ARBOL VACIO !!");
            }
            else
            {
                Preorden(punt);
            }
        }
        void PostOrden(Nodo_Arbol punt)
        {
            if(punt != null)
            {
                PostOrden(punt.Punt_izq);
                PostOrden(punt.Punt_dere);
                lst_postOrden.Items.Add(punt.Dato);
            }
        }
        private void btn_postorden_Click(object sender, EventArgs e)
        {
            Nodo_Arbol punt;
            punt = new Nodo_Arbol();
            punt = Estatica.A.devolver_raiz();
            if (punt == null)
            {
                MessageBox.Show("ARBOL VACIO ");

            }
            else
            {
                PostOrden(punt);
            }
        }
        void Inorden(Nodo_Arbol punt)
        {
            if (punt != null)
            {
                Inorden(punt.Punt_izq);
                lst_inorden.Items.Add(punt.Dato);
                
                Inorden(punt.Punt_dere);

            }
        }
        private void btn_inorden_Click(object sender, EventArgs e)
        {
            Nodo_Arbol punt;
            punt = new Nodo_Arbol();
            punt = Estatica.A.devolver_raiz();
            if (punt == null)
            {
                MessageBox.Show("ARBOL VACIO ");

            }
            else
            {
                Inorden(punt);
            }
        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Estatica.A.Eleminar(int.Parse(txt_numero.Text)) == false)
            {
                MessageBox.Show("EL ELEMENTO NO SE ENCONTRO EN EL ARBOL!");
            }
            else
            {
                MessageBox.Show("EL ELEMENTO SE ELEMINO DEL ARBOL!!");
            }

        }

        private void btn_MostrarGrafica_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void lst_inorden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_hojas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cantidad de hojas que hay es :"+Estatica.A.ContarHoja());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_postOrden.Items.Clear();
            lst_preorden.Items.Clear();
            lst_inorden.Items.Clear();
        }
    } 
 }

