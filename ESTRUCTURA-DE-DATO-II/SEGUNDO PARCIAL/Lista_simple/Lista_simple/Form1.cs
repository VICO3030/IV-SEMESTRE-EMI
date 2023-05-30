using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_simple
    
{
    
    public partial class Form1 : Form
    {
        Lista lista = new Lista();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BTN_REGISTRAR_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            int cod = int.Parse(txt_codigo.Text);
            lista.Agregar_lista(usuario, cod);
            MessageBox.Show("Se registro usuario !!!");

            txt_usuario.Clear();
            txt_codigo.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void mostrarlista()
        {
            Nodo punt = lista.Getcabeza();
            while(punt!= null)
            {
                LST_LISTAREGISTRO.Items.Add("usuario " + punt.GetUsuario());
                LST_LISTAREGISTRO.Items.Add("Codigo : " + punt.GetCodigo());
                LST_LISTAREGISTRO.Items.Add("--------------------------------");
                punt = punt.GetEnlace();
            }
        }
        private void BTN_MOSTRAR_Click(object sender, EventArgs e)
        {
            mostrarlista();
        }
    }
}
