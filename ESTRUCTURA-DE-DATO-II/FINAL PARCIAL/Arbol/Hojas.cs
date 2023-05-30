using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class Hojas : Form
    {
        public Hojas()
        {
            InitializeComponent();
        }
        private void contar_hojas(nodo arbol,ref int c)
        {
            if (arbol != null)
            {
                if(arbol.Iz==null && arbol.Der==null)
                {
                    Lst_Hojas.Items.Add(arbol.Dato);
                    c++;
                }
                contar_hojas(arbol.Iz,ref c);
                contar_hojas(arbol.Der,ref c);
            }
        }
        private void Btn_Hojas_Click(object sender, EventArgs e)
        {
            nodo arbol = Estatica.A.get_Raiz();
            if(arbol!=null)
            {
                int c = 0;
                Lst_Hojas.Items.Clear();
                contar_hojas(arbol, ref c);
                Lbl_cant_Hojas.Text = "Son " + Convert.ToString(c) + " Hojas";
            }
            else
            {
                MessageBox.Show("No existe arbol creado");
            }
        }
    }
}
