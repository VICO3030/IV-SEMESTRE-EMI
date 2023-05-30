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
    public partial class Frm_mostrar_carrera : Form
    {
        public Frm_mostrar_carrera()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }
        public void mostrarInicio()
        {
            NodoCarrera punt = Estatica.carreras.get_Cabeza();
            while (punt != null)
            {
                Estatica.carreras.llenarlugar();
                Estatica.carreras.Descalificados();
               
                grp_car.Rows.Add(punt.get_tiempo(),punt.get_lugar(),punt.get_fecha());
                punt = punt.get_sig();
            }
        }
        public void mostrarFinal()
        {
            NodoCarrera punt = Estatica.carreras.get_Cabeza();
            while (punt.get_sig() != null)
            {
                punt = punt.get_sig();
            }
            while (punt.get_ant() != null)
            {
                //tiempo lugar fecha
                grp_car.Rows.Add(punt.get_tiempo(), punt.get_lugar(), punt.get_fecha());
                punt = punt.get_ant();
            }
        }

        private void Btn_volver_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            this.Hide();
            principal.Show();
        }

        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            if (Estatica.ciclistas.get_cabeza() == null)
            {
                MessageBox.Show("No Existen Ciclistas Inscritos");
            }
            else
            {
                mostrarInicio();
            }
        }

        private void Btn_MostrarFinal_Click(object sender, EventArgs e)
        {
            if (Estatica.ciclistas.get_cabeza() == null)
            {
                MessageBox.Show("No Existen Ciclistas Inscritos");
            }
            else
            {
                mostrarFinal();
            }
        }

        private void Frm_mostrar_carrera_Load(object sender, EventArgs e)
        {

        }

        private void grp_car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_ordenar_Click(object sender, EventArgs e)
        {
            grp_car.Rows.Clear();
            Estatica.carreras.Ordenamiento();
            mostrarInicio();

        }
    }
}
