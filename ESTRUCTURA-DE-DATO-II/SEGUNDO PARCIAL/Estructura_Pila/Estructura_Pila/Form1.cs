using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_Pila
{
    public partial class Frm_principal : Form
    {
        Pila p1 = new Pila();
        Pila Paux = new Pila();
        public Frm_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p1.Apilar(int.Parse(txt_DATO.Text)));
            txt_DATO.Clear();

            //ocultar las oopciones mientrar el usuario no lo llene 
            txt_eleminar.Visible = true;
            btn_buscar.Visible = true;
            txt_buscar.Visible = true;
            btn_eleminar.Visible  = true;

            

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MostrarPila()
        {
            Nodo aux;
            if (p1.estaVacio() == true)
            {
                MessageBox.Show("ESTA VACIO LA PILA !!");
            }
            else
            {
                while (!p1.estaVacio())
                {
                    aux = p1.Desapilar();
                    Paux.Apilar(aux.get_dato());
                    LST_PILA.Items.Add("Dato :    "+aux.get_dato());
                   
                }
                while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    p1.Apilar(aux.get_dato());
                }
            }
        }
        public void  BuscarDato(int dato)
        {
            Nodo aux = p1.Get_tope();
            Boolean encontrado = false;
            while (!p1.estaVacio() && encontrado != true)
            {  
                aux = p1.Desapilar();
                if (aux.get_dato() == dato)
                {
                    encontrado = true;
                }
                Paux.Apilar(aux.get_dato());
            }
            while (!Paux.estaVacio())
            {
                aux = Paux.Desapilar();
                p1.Apilar(aux.get_dato());
            }
            if (encontrado == true)
            {
                MessageBox.Show("Se encuentra el dato [ "+ dato +" ] en la pila ");
            }
            else
            {
                MessageBox.Show("No se encuentra el dato [" + dato + " ]  en la pila");
            }

        }
        //Metodo de eleminar un dato
        public void EleminarDato(int dato)
        {
            Nodo aux = p1.Get_tope();
            Boolean encontrado = false;
            while (!p1.estaVacio())
            {
                aux = p1.Desapilar();
                if (aux.get_dato() != dato)
                {
                    encontrado = true;
                    Paux.Apilar(aux.get_dato());
                }
                
            }
            while (!Paux.estaVacio())
            {
                aux = Paux.Desapilar();
                p1.Apilar(aux.get_dato());
            }
            if (encontrado == true)
            {
                MessageBox.Show("Se elemino  :  [ " + dato + " ] en la pila ");
            }
            else
            {
                MessageBox.Show("No se encuentra el dato [" + dato + " ]  en la pila");
            }

        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
                MostrarPila();
        }

        private void btn_desapilar_Click(object sender, EventArgs e)
        {
            if (p1.estaVacio() == true)
            {
                MessageBox.Show("ESTA VACIO L PILA!!");
            }
            else
            {
                Nodo aux = p1.Desapilar();
                LST_PILA.Items.RemoveAt(0);
               
                MessageBox.Show("SE DESAPILO el " + aux.get_dato());


            }
        }


        private void btn_eleminar_Click(object sender, EventArgs e)
        {
            EleminarDato(int.Parse(txt_eleminar.Text));
            txt_eleminar.Clear();
            LST_PILA.Items.Clear();
            MostrarPila();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarDato(int.Parse(txt_buscar.Text));
            txt_buscar.Clear();
            LST_PILA.Items.Clear();
            MostrarPila();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
