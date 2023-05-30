using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Colas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            guardar();
            guardar2();
            reseteo();
        }
        public void guardar()
        {
            nodo auxi = Estatica.C.get_frente();
            int f = 0;
            DGV_1.Rows.Clear();
            while (auxi != null)
            {
                DGV_1.Rows.Add();
                DGV_1[0, f].Value = auxi.Nombre;
                DGV_1[1, f].Value = auxi.Hojas;
                DGV_1[2, f].Value = auxi.Calidad;
                DGV_1[3, f].Value = auxi.Color;
                DGV_1[4, f].Value = auxi.Tiempo;
                DGV_1[5, f].Value = auxi.Estado;
                auxi =auxi.Enlace;
                f++;
            }
        }
        public void guardar2()
        {
            nodo auxi = Estatica.C2.get_frente();
            int f = 0;
            DGV_2.Rows.Clear();
            while (auxi != null)
            {
                DGV_2.Rows.Add();
                DGV_2[0, f].Value = auxi.Nombre;
                DGV_2[1, f].Value = auxi.Hojas;
                DGV_2[2, f].Value = auxi.Calidad;
                DGV_2[3, f].Value = auxi.Color;
                DGV_2[4, f].Value = auxi.Tiempo;
                DGV_2[5, f].Value = auxi.Estado;
                auxi = auxi.Enlace;
                f++;
            }

        }
        private void Btn_Detener_Click(object sender, EventArgs e)
        {
            nodo x = Estatica.C.get_frente();
            x.Estado = "Pausa";
            guardar();
            guardar2();
            Tiempo.Enabled = false;
            Tiempo2.Enabled = false;
            progressBar1.Enabled = false;
            MessageBox.Show("Impresion Pausada");
            Btn_Detener.Enabled = false;
            Btn_Reanudar.Enabled = true;
            Btn_Salir.Enabled = true;
        }
        public void reseteo()
        {
            nodo aux = Estatica.C.get_frente();
            Tiempo2.Enabled = false;
            Tiempo.Enabled = false;
            progressBar1.Enabled = false;
            if(aux!=null)
            { 
                Tiempo2.Interval = (int)(aux.Tiempo * 1000);
                progressBar1.Value = 0;
                progressBar1.Maximum = (int)(aux.Tiempo * 100);
                Tiempo.Enabled = true;
                progressBar1.Enabled = true;
                Tiempo2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Impresion terminada");
                borrar_C2();
                Btn_Detener.Enabled = false;
                Btn_Salir.Enabled = true;
            }
        }
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                if (Estatica.C.get_frente() != null)
                {
                    nodo x = Estatica.C.desencolar();
                    x.Estado = "Terminado";
                    nodo aux = Estatica.C2.get_ultimo();
                    if(aux!=null)
                    {
                        x.Tiempo = x.Tiempo + aux.Tiempo;
                    }
                    Estatica.C2.encolar(x.Nombre, x.Hojas, x.Color, x.Calidad, x.Estado, x.Tiempo);
                    if(Estatica.C.get_frente() != null)
                    {
                        x = Estatica.C.get_frente();
                        x.Estado = "Imprimiendo...";
                    }
                }
                guardar();
                guardar2();
                reseteo();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Tiempo2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
        }
        public void borrar_C()
        {
            nodo x = Estatica.C.get_frente();

            while (x != null)
            {
                if (!Estatica.C.esta_vacia())
                {
                    x = Estatica.C.desencolar();
                }
                else
                {
                    x = null;
                }
            }


        }
        public void borrar_C2()
        {
            nodo x = Estatica.C2.get_frente();
            while (x != null)
            {
                if (!Estatica.C2.esta_vacia())
                {
                    x = Estatica.C2.desencolar();
                }
                else
                {
                    x = null;
                }
            }
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            borrar_C();
            borrar_C2();
            this.Hide();
        }

        private void Btn_Reanudar_Click(object sender, EventArgs e)
        {
            nodo x = Estatica.C.get_frente();
            x.Estado = "Imprimiendo...";
            guardar();
            guardar2();
            Btn_Salir.Enabled = false;
            Btn_Detener.Enabled = true;
            Btn_Reanudar.Enabled = false;
            reseteo();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void DGV_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
