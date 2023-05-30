using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1._1
{
    public partial class Form1 : Form
    {
        Lista_Circular l1 = new Lista_Circular();
        Lista_Circular Sumatoria = new Lista_Circular();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Mostrarlista()
        {
            NodoCircular punt = l1.Get_cabeza();
            do
            {
                LST_NUMEROS.Items.Add("num  : " + punt.Get_num());
                LST_NUMEROS.Items.Add("====================== ");
                punt = punt.Get_enlace();

            } while (punt != l1.Get_cabeza());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Agregarlista(int.Parse(txt_num.Text));
            MessageBox.Show("Se REGISTRO NUMERO !!!");
            //vaciamos 
            txt_num.Clear();
        }

        private void BTN_mostrar_Click(object sender, EventArgs e)
        {
            Mostrarlista();
        }

        private void btn_posicion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SumatoriaNum(int.Parse(TXT_posicion.Text)));
        }
        string SumatoriaNum(int nro)
        {
            
            int j = 0;
            int recorrido = nro;
            NodoCircular punt1 = l1.Get_cabeza();
            while(nro != 0 )
            {
                j = recorrido;
                
                while(recorrido != 0)
                {
                    LST_SUMAR.Items.Add(punt1.Get_num());
                    Sumatoria.Agregarlista(punt1.Get_num());

                    punt1 = punt1.Get_enlace();
                    recorrido--;
                }
                

            }

            return "SE ANADIO DE LA POSICION " + nro;
        }
        
    }
}
