using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTAS_SIMPLES
{
    public partial class Frm_InsertarNodo : Form
    {
        public Frm_InsertarNodo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_prim_Cabeza_Load(object sender, EventArgs e)
        {

        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FRM_lista principio = new FRM_lista();
            this.Hide();//para cerrar o ocultar
            principio.Show();//para mostrar el principal
        }

        private void Btn_Cabeza_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscanom = TXT_insertarNOM.Text;
         //   string edadNueva = ;
            int edad = Int16.Parse(txt_InsertarEDAD.Text);
            Estatica.Lista.InsertarFinal(buscanom, edad);
            MessageBox.Show("Se anadio el Nuevo dato!!! ");
        }
    }
}
