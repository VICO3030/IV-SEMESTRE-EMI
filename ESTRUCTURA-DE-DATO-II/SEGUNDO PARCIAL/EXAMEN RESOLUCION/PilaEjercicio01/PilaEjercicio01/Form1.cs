using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaEjercicio01
{
    public partial class EJERCICIO01 : Form
    {
        Pila p1 = new Pila();
        Pila Paux = new Pila();
        Pila Primo = new Pila();
        public EJERCICIO01()
        {
            InitializeComponent();
        }
        void Mostrar()
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
                    lst_original.Items.Add("Num : "+aux.Num);
                    Paux.Apilar(aux.Num);
                }
                while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    p1.Apilar(aux.Num);
                }
            }
        }
        private void EJERCICIO01_Load(object sender, EventArgs e)
        {

        }

        private void BTN_REGISTRAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p1.Apilar(int.Parse(txt_num.Text)));
            txt_num.Clear();

        }

        private void btn_list1_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean Esprimo(int n)
        {
            int cont = 0;
            for (int i=1; i<=n; i++)
            {
                
                if (n % i == 0)
                {
                    cont++;
                }

            }
            if (cont > 2)
            {
                return false;
            }
            return true;
        }
        void MostrarPrimo()
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
                    Paux.Apilar(aux.Num);
                    if (Esprimo(aux.Num) == true)
                    {
                        Primo.Apilar(aux.Num);
                        lst_primos.Items.Add("Num : " + aux.Num);
                    }
                }
                while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    if (Esprimo(aux.Num) != true)
                    {                        
                        p1.Apilar(aux.Num);
                    }
                }
            }
        }
        int cantiddadPrimo()
        {
            int c = 0;
            Nodo aux = Primo.Get_tope();
            while(aux != null)
            {
                aux = aux.Sig;
                c++;
            }
            return c;
        }
        private void btn_msotrarPrimos_Click(object sender, EventArgs e)
        {
            lst_original.Items.Clear();
            MostrarPrimo();
            MessageBox.Show("LA CANTIDAD QUE HAY ES : " + cantiddadPrimo());
        }
    }
}
