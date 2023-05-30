using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Baketball
{
    
    public partial class LISTA_EQUIPOS : Form
    {
        Lista_basketball Lista;
        public LISTA_EQUIPOS()
        {
            InitializeComponent();
            Lista = new Lista_basketball();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombreequipo.Text; //convertimos la letra en una cadena a string
            int cant = int.Parse(txt_cantidadAni.Text);
            Lista.crear_lista(nombre, cant);//llamo ami objeto mas mi funcion de crear lista
            MessageBox.Show("EQUIPO REGISTRADO !!!");
        }

        public void mostrar()
        {
            Nodo punt;
            punt = Lista.get_cabeza();
            while(punt != null)
            {
                Lst_FORMULARIONBA.Items.Add("Equipo : " +punt.get_Nombre());
                Lst_FORMULARIONBA.Items.Add("Campeonatos  : " +punt.get_Cantidad());
                punt = punt.get_enlace();
                //recorrido del nodo
            }

        }
        private void Btn_mostrarlista_Click(object sender, EventArgs e)
        {
            mostrar();
                
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cantidadAni.Clear();//ELEMINAMOS LISTBOX
            txt_nombreequipo.Clear();
            Lst_FORMULARIONBA.Items.Clear();

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lst_FORMULARIONBA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
