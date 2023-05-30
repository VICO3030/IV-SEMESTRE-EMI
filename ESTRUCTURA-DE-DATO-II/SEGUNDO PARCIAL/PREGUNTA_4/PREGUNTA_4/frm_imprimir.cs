using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREGUNTA_4
{
    public partial class frm_imprimir : Form
    {
        Nodo aux;
        float tmp_cola;
        public frm_imprimir()
        {
            InitializeComponent();
            aux = new Nodo();
            tmp_cola = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            lbl_Finalizado.Visible = false;
            pgb_Impresion.Value = 0;
            lbl_Segundos.Text = "0 segudos"; 
            while (Estatica.imp.getFrente() != null)
            {
                aux = Estatica.imp.desencolar();
                Timer();
               
            }
            
        }

        private void frm_imprimir_Load(object sender, EventArgs e)
        {

        }

        public void Timer()
        {
            pgb_Impresion.Value = 0;
            pgb_Impresion.Maximum = aux.getHojas() * aux.getTiempohoja();
            lbl_calidad.Text = aux.getCalidadColor();
            lbl_Hojas.Text = aux.getHojas().ToString();
            lbl_Nombre.Text = aux.getNombre();
            tmr_Doc.Enabled = true;
        }

        private void tmr_Doc_Tick(object sender, EventArgs e)
        {
            gpb_Impresion.Visible = true;
            pgb_Impresion.Value += aux.getTiempohoja();
            lbl_Segundos.Text = ((float)pgb_Impresion.Value / 100).ToString() + " segundos";
         
            if (pgb_Impresion.Value == aux.getHojas() * aux.getTiempohoja())
            {
                lbl_Finalizado.Visible = true;
                dgv_IMPRESOS.Rows.Add(aux.getNombre(), (float)aux.getTiempohoja() * aux.getHojas() / 100, tmp_cola);
                tmp_cola = tmp_cola + (float)aux.getTiempohoja() * aux.getHojas() / 100;
                MessageBox.Show("Se imprimio el archivo " + aux.getNombre());
                tmr_Doc.Stop();
            } 
        }

        private void tmr_Cola_Tick(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Frm f1 = new Frm();
            this.Close();
            f1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pgb_Impresion_Click(object sender, EventArgs e)
        {

        }
    }
}
