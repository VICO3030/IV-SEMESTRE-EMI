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
    public partial class Frm_Buscar : Form
    {
        public Frm_Buscar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            FRM_lista principal = new FRM_lista();
            this.Hide();//para cerrar o ocultar
            principal.Show();//para mostrar el principal
        }

        private void Btn_Actualizar_edad_Click(object sender, EventArgs e)
        {
            GRP_EDAD.Visible = false;
            string buscanom = txtbuscar_nom.Text;
            string edadNueva = txt_nuevaedad.Text;
            int edad = Int16.Parse(edadNueva);
            Estatica.Lista.Modificar2(buscanom, edad);
            MessageBox.Show("CAMBIO DE EDAD ");
            txt_nuevaedad.Clear();



           // GRO_EDAD.visible = true;
           //muy cholo soy, me gusta la coca con bicarbinato :)



        }

        private void GRP_EDAD_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GRP_EDAD.Visible = true;
            Nodo punt;
            punt = Estatica.Lista.Modificar(txtbuscar_nom.Text);//la direccion donde le nombre se esta buscando puedo ingresar a todos sus atributos
            lbl_edad_actual.Text = "la edad actual es de  : " + punt.get_Edad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean existe;
            existe =  Estatica.Lista.Buscar(txtbuscar_nom.Text);  //llamamos
            if (existe)
                MessageBox.Show(txtbuscar_nom.Text + " --> EXISTE  :)  ");
            else
                MessageBox.Show(txtbuscar_nom.Text + " --> NO EXISTE  :( ");





        }

        private void lbl_edad_actual_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nuevaedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Buscar_Load(object sender, EventArgs e)
        {

        }
    }
}
