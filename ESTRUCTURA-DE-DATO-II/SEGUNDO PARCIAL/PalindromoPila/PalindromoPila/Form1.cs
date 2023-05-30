using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalindromoPila
{
    public partial class FRM_MENU : Form
    {
        Pila lst = new Pila();
        Pila Paux = new Pila();
        Pila Pcopia = new Pila();
        public FRM_MENU()
        {
            InitializeComponent();
        }
        //metodo de mostrar registro
        void Mostrar()
        {
            Nodo aux;
            if (lst.estaVacio() == true)
            {
                MessageBox.Show("Esta vacio la Pila!!");
            }
            else
            {
                while (!lst.estaVacio())
                {
                    aux = lst.Desapilar();
                    LST_PALI.Items.Add(aux.Dat);
                    Paux.Apilar(aux.Dat);
                }
                while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    lst.Apilar(aux.Dat);
                }
            }
        }
        void CopiarPilar()
        {
            Nodo aux;
           
              while (!lst.estaVacio())
                {
                    aux = lst.Desapilar();
                    
                    Paux.Apilar(aux.Dat);
                Pcopia.Apilar(aux.Dat);
                    
                }
              while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    lst.Apilar(aux.Dat);
                }
            

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lst.Apilar(Char.Parse(txt_dat.Text)));
            //      Mostrar();
        }

        private void BTN_MOSTRAR_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string Palindromo()
        {
            Boolean pali= false;
            CopiarPilar();
            Nodo aux1, aux2;
            while(!lst.estaVacio() && !Pcopia.estaVacio() && pali !=true)
            {
                aux1 = lst.Desapilar();
                aux2 = Pcopia.Desapilar();
                if(aux1.Dat != aux2.Dat)
                {
                    pali = true;
                }
                Paux.Apilar(aux1.Dat);
            }
            if (pali == true) return "NO ES PALINDROMO!!";
            return "SI ES PALINDROMO";
        }
        private void btn_palindromo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Palindromo());
        }
    }
}
