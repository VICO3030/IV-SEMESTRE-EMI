using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_Doblemente_enlazadas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public void mostrarCarrera(ListBox lst)
        {
            NodoCarrera punt = StaticClass.carrera.getCabezaCarrera();
            while(punt != null)
            {
                lst.Items.Add("Nro Bici: " + punt.getBici());
                lst.Items.Add("Tiempo de carrera"+ punt.getTiempo());
                lst.Items.Add("Lugar: " + punt.getLugar());
                lst.Items.Add("fecha: " + punt.getFecha());
                punt = punt.getSig();
                //punt = punt.getAnt();
            }

        }

        public void mostrarCiclista(ListBox lst)
        {
            NodoCiclista punt = StaticClass.ciclista.getCabezaCiclista();
            while(punt != null)
            {
                lst.Items.Add("Nro Bici: " + punt.getBici());
                lst.Items.Add("Nombre: " + punt.getNombre());
                lst.Items.Add("Categoria: " + punt.getCategoria());
                lst.Items.Add("=====================================");
                punt = punt.getSig();
               // punt = punt.getAnt();
            }
        }

        private void Btn_registerCarrera_Click(object sender, EventArgs e)
        {
            FrmCarrera frmCarrera = new FrmCarrera();
            this.Hide();
            frmCarrera.Show();
        }

        private void Btn_registerCiclista_Click(object sender, EventArgs e)
        {
            FrmCiclistsa frmCiclista = new FrmCiclistsa();
            this.Hide();
            frmCiclista.Show();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            FrmMostrarCiclista frmciclistaShow = new FrmMostrarCiclista();
            this.Hide();
            frmciclistaShow.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            FrmBuscatyEliminar frmbuansh = new FrmBuscatyEliminar();
            this.Hide();
            frmbuansh.Show();
        }

        private void btn_MostrarCarrera_Click(object sender, EventArgs e)
        {
            frmMostrarCarrera frmCarrera = new frmMostrarCarrera();
            this.Hide();
            frmCarrera.Show();
        }
    }
}
