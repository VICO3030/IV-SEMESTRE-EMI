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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }
        private void inorden(nodo arbol)
        {
            if (arbol != null)
            {
                inorden(arbol.Iz);
                Lst_Antes.Items.Add(arbol.Dato);
                inorden(arbol.Der);
            }
        }
        private void inorden_desp(nodo arbol)
        {
            if (arbol != null)
            {
                inorden_desp(arbol.Iz);
                Lst_Despues.Items.Add(arbol.Dato);
                inorden_desp(arbol.Der);
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(Txt_num.Text!="")
            {
                Lst_Antes.Items.Clear();
                Lst_Despues.Items.Clear();
                int n = int.Parse(Txt_num.Text);
                inorden(Estatica.A.get_Raiz()) ;
                if(Estatica.A.eliminar(n))
                {
                    inorden_desp(Estatica.A.get_Raiz());
                    MessageBox.Show("Nodo eliminado");
                }
            }
        }
    }
}
