using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class FRM_PRINCIPAL : Form
    {
        Pila Fabrica = new Pila();
        Pila Paux = new Pila();
        Pila Vendido = new Pila();
        int i = 1;
        public FRM_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //metodo de mostrar

        void MostrarFabrica()
        {
            Nodo aux;
            if (Fabrica.estaVacio() == true)
            {
                MessageBox.Show("ESTA VACIO LA PILA !!");
            }
            else
            {
                while (!Fabrica.estaVacio())
                {
                    aux = Fabrica.Desapilar();
                    DTG_FABRICA.Rows.Add(aux.Autonum1 ,aux.NomProduc , aux.NroLotes);
                    Paux.Apilar(aux.Autonum1, aux.NomProduc, aux.NroLotes);
                }
                while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    Fabrica.Apilar(aux.Autonum1, aux.NomProduc, aux.NroLotes);
                }
            }
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(Fabrica.Apilar(i, txt_nom.Text, int.Parse(txt_nrolotes.Text)));
            i = i + 1;
            txt_nom.Clear();
            txt_nrolotes.Clear();
        }

        private void FRM_PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void btn_mostrarFabrica_Click(object sender, EventArgs e)
        {
            DTG_FABRICA.Rows.Clear();
            MostrarFabrica();
                 
        }
       Boolean BuscarDato(string dato , int nro)
        {
            Nodo aux = Fabrica.Get_tope();
            Boolean encontrado = false;
            Boolean cantidad = false;
            
            while (!Fabrica.estaVacio() && encontrado != true )
            {
                aux = Fabrica.Desapilar();
                if (aux.NomProduc == dato)
                {
                    encontrado = true;
                    if (aux.NroLotes >= nro)
                    {
                        cantidad = true;
                    }
                }
                Paux.Apilar(i,aux.NomProduc,aux.NroLotes);
            }
            while (!Paux.estaVacio())
            {
                aux = Paux.Desapilar();
                Fabrica.Apilar(i, aux.NomProduc, aux.NroLotes);
            }
            if(encontrado== true && cantidad == true){
                //  MessageBox.Show("Se hara la siguiente Compra!");
                cantidad = true;
            }
            else
            {
                if(encontrado==true && cantidad == false)
                {
                    //MessageBox.Show("No existe esa cantidad de Lotes!");
                    cantidad = false;
                }

            }

            return cantidad;
        }
        
        private void txt_nomcompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BuscarDato(txt_nomcompra.Text, int.Parse(txt_canticompra.Text)) == false)
            {
                MessageBox.Show("ERROR  NOMBRE O CANTIDAD");
            }
            else
            {
                MessageBox.Show("SE HARA COMPRA !");
            }


            

        }
    }
}
