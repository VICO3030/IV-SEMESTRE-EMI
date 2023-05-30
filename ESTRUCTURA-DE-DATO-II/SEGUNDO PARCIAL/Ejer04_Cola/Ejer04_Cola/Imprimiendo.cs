using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer04_Cola
{
    public partial class frm_imprimiendo : Form
    {
        public frm_imprimiendo()
        {

            InitializeComponent();
            guardar();
            guardar2();
            reseteo();
        }
        public void guardar()
        {
            Nodo_Cola auxi = Estatica.Impresion.Get_frente();
            int f = 0;
            dgt_imprimirr.Rows.Clear();
            while (auxi != null)
            {
                dgt_imprimirr.Rows.Add();
                dgt_imprimirr[0, f].Value = auxi.Get_nomDoc();
                dgt_imprimirr[1, f].Value = auxi.Get_nroHoj();
                dgt_imprimirr[2, f].Value = auxi.Get_calidad();
                dgt_imprimirr[3, f].Value = auxi.Get_color();
                dgt_imprimirr[4, f].Value = auxi.Get_tiempo();
                // dgt_imprimirr[5, f].Value = auxi.Estado;
                auxi = auxi.Get_sig();
                f++;
            }


        }
        public void guardar2()
        {
            Nodo_Cola auxi = Estatica.Imprimido.Get_frente();
            int f = 0;
            dgt_imprimido.Rows.Clear();
            while (auxi != null)
            {
                dgt_imprimido.Rows.Add();
                dgt_imprimido[0, f].Value = auxi.Get_nomDoc(); 
                dgt_imprimido[1, f].Value = auxi.Get_nroHoj();
                dgt_imprimido[2, f].Value = auxi.Get_calidad();
                dgt_imprimido[3, f].Value = auxi.Get_color();
                dgt_imprimido[4, f].Value = auxi.Get_tiempo();
           //     dgt_imprimido[5, f].Value = auxi.Estado;
                auxi = auxi.Get_sig();
                f++;
            }

        }
        public void reseteo()
        {
            Nodo_Cola aux = Estatica.Impresion.Get_frente();
            Tiempo2.Enabled = false;
            Tiempo.Enabled = false;
            pgrBarra.Enabled = false;
            if (aux != null)
            {
                Tiempo2.Interval = (int)(aux.Get_tiempo() * 1000);
                pgrBarra.Value = 0;
                pgrBarra.Maximum = (int)(aux.Get_tiempo() * 100);
                Tiempo.Enabled = true;
                pgrBarra.Enabled = true;
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

        private void Imprimiendo_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        public void Mostrar()
        {
            Nodo_Cola aux = Estatica.Impresion.Get_frente();
            while (aux != null)
            {
                dgt_imprimirr.Rows.Add(aux.Get_nomDoc(), aux.Get_nroHoj(), aux.Get_calidad(), aux.Get_color() , aux.Get_tiempo());
                aux = aux.Get_sig();

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if(pgrBarra.Value < pgrBarra.Maximum)
            {
                pgrBarra.Value++;

            }
            else
            {
               /* if (Estattica.Impresion.Get_frente() != null)
                {
                    Nodo_Cola aux; = Estattica.Imprimido.Get_Final();
                    if (aux != null)
                    {

                    }
                }*/
            }
        }

        private void tmr_tiempo_Tick(object sender, EventArgs e)
        {
            if (pgrBarra.Value < pgrBarra.Maximum)
            {
                pgrBarra.Value++;
            }
            else
            {
                if (Estatica.Impresion.Get_frente() != null)
                {
                    Nodo_Cola x = Estatica.Impresion.Desencolar();
                  ///  x.Estado = "Terminado";
                    Nodo_Cola aux = Estatica.Imprimido.Get_Final();
                    if (aux != null)
                    {
                        x.Set_tiempo( x.Get_tiempo() + aux.Get_tiempo());
                    }
                    Estatica.Imprimido.Encolar(x.Get_nomDoc() , x.Get_nroHoj() , x.Get_calidad(),x.Get_tiempo(),x.Get_color());
                    if (Estatica.Impresion.Get_frente() != null)
                    {
                        x = Estatica.Impresion.Get_frente();
                      //  x.Estado = "Imprimiendo...";
                    }
                }
                guardar();
                guardar2();
                reseteo();
            }

        }
        private void BTN_IMPRIMIR_Click(object sender, EventArgs e)
        {

        }
        public void borrar_C()
        {
            Nodo_Cola x = Estatica.Impresion.Get_frente();

            while (x != null)
            {
                if (!Estatica.Impresion.Estavacio())
                {
                    x = Estatica.Impresion.Desencolar();
                }
                else
                {
                    x = null;
                }
            }


        }
        public void borrar_C2()
        {
            Nodo_Cola x = Estatica.Imprimido.Get_frente();
            while (x != null)
            {
                if (!Estatica.Imprimido.Estavacio())
                {
                    x = Estatica.Imprimido.Desencolar();
                }
                else
                {
                    x = null;
                }
            }
        }

        private void Btn_Reanudar_Click(object sender, EventArgs e)
        {
            Nodo_Cola x = Estatica.Impresion.Get_frente();
           // x.Estado = "Imprimiendo...";
            guardar();
            guardar2();
            Btn_Salir.Enabled = false;
            Btn_Detener.Enabled = true;
            Btn_Reanudar.Enabled = false;
            reseteo();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            borrar_C();
            borrar_C2();
            this.Hide();
            this.Close();
        }
    }
}
