using System;
using System.Windows.Forms;

namespace Arbol
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            noodo aux = Estatica.C.desencolar();
            while(aux!=null)
            {
                aux = Estatica.C.desencolar();
            }
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if(Txt_num.Text!="")
            {
                
                int num = int.Parse(Txt_num.Text);
                int c = 0;
                lbl_nivelmax.Text = "La altura es: " + Estatica.A.altura(num);
                nodo aux = Estatica.A.get_Raiz();
                if(Estatica.A.buscar(num, aux, ref c))
                {
                    Lst_Niveles.Items.Clear();
                    noodo x = Estatica.C.desencolar();
                    while (x != null)
                    {
                        Lst_Niveles.Items.Add(x.Dato.Dato);
                        x = Estatica.C.desencolar();
                    }
                   

                    Lbl_niveles.Text = "El " + num + " esta en el nivel " + c;
                }
                else
                {
                    limpiar();
                    Lst_Niveles.Items.Clear();
                    Lbl_niveles.Text = "El " + num + " no existe";
                }
            }
            else
            {
                MessageBox.Show("Ingresar un numero en la casilla");
            }
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {

        }

        private void Lst_Niveles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
