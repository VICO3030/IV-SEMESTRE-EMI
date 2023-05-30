using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDobleEnlazada
{

    public partial class Frm_Busqueda : Form
    {
        NodoCiclista punt;

        public Frm_Busqueda()
        {
            InitializeComponent();
        }

        private void btn_exisstencia_Click(object sender, EventArgs e)
        {
            punt = Estatica.ciclistas.existe_nom((txt_nombusqueda.Text));
            if (punt == null)
            {
                MessageBox.Show("No Existe Ciclista");

            }
            else
            {
                MessageBox.Show("si existe ciclista");
            }
        }

        private void txt_nuevotiempo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            NodoCiclista punt;
            string nomactual = txt_nombusqueda.Text;
            punt = Estatica.ciclistas.Modificar(txt_nombusqueda.Text);
            if (punt != null)
            {
                Grp_NRO.Visible = true;
                //la direccion donde le nombre se esta buscando puedo ingresar a todos sus atributos
                lbl_nro_actual.Text = "El nro actual es : " + punt.get_nBici();
            }
            else
            {
                MessageBox.Show("Ciclista no Existe");
            }
            

        }

        private void Btn_Actualizar_tiempo_Click(object sender, EventArgs e)
        {
            Grp_NRO.Visible = false;
            string buscanom = txt_nombusqueda.Text;

            int nro = Int16.Parse(txt_nuevo_nro.Text);
            Estatica.ciclistas.Modificar2(buscanom, nro);
            MessageBox.Show("CAMBIO DE EDAD ");
            txt_nuevo_nro.Clear();

        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            this.Hide();
            principal.Show();
        }

        private void Btn_eleminar_Click(object sender, EventArgs e)
        {

        }


        /*  private void txt_nuevotiempo_Load(object sender, EventArgs e)
          {

          }*/

    }
    
}
