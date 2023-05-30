using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        Cola Espera;
        Cola Atendidos;
        Cola Paux = new Cola();
        Random rd = new Random();
        public Form1()
        {
            Atendidos = new Cola();
            Espera = new Cola();
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void llenarCialeatorios(int nro)
        {
            
            for(int i = 1; i <=nro; i++)

            {
                int ci = rd.Next(1000, 9999);
                Espera.Encolar(0 ,ci);
            }
        }
        public void Mostrar()
        {
            Nodo aux = Espera.Get_frente();
            while (aux != null)
            {
                LST_ESPERA.Items.Add("Persona  " +aux.CI1);
                aux = aux.Sig;
            }

        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            llenarCialeatorios(int.Parse(txt_cantidad.Text));
            MessageBox.Show("SE REGISTRO !");
        }
       void llenarAtendidos(string dia)
        {
            int nrodia;
            Nodo aux = Espera.Get_frente();
            while (aux !=null)
            {    nrodia = aux.CI1 % 10;
                if(dia == "LUNES" &&  (nrodia == 0 ||nrodia == 1) )
                {
                    
                    Atendidos.Encolar(aux.Cant, aux.CI1);
                  //  LST_ATENDIDOS.Items.Add(aux.CI1);


                }
                if (dia == "MARTES" && (nrodia == 2 || nrodia == 3))
                {
                    Atendidos.Encolar(aux.Cant, aux.CI1);
                 //   LST_ATENDIDOS.Items.Add(aux.CI1);

                }
                if (dia == "MIERCOLES" &&( nrodia == 4 || nrodia == 5))
                {
                    Atendidos.Encolar(aux.Cant, aux.CI1);
                //    LST_ATENDIDOS.Items.Add(aux.CI1);

                }

                if (dia == "JUEVES" && (nrodia == 6 || nrodia == 7))
                {
                    Atendidos.Encolar(aux.Cant, aux.CI1);
              //      LST_ATENDIDOS.Items.Add(aux.CI1);

                }
                if (dia == "VIERNES" && (nrodia == 8 || nrodia == 9))
                {
                    Atendidos.Encolar(aux.Cant, aux.CI1);
                 //   LST_ATENDIDOS.Items.Add(aux.CI1);

                    //  LST_ATENDIDOS.Items.Add(aux.CI1);
                }
                
                
                aux = aux.Sig;
            }

        }
     /*   void mostrarAtencion(string dia)
        {
            int ultimo;
            Nodo aux = Espera.Get_frente();
            while (aux != null)
            {
                
                ultimo = aux.CI1 % 10 ;
                if(dia == "LUNES" &&( ultimo == 0 || ultimo== 1))
                {
                    Atendidos.Encolar(1, aux.CI1);
                }
                if (dia == "MARTES" && (ultimo == 2 || ultimo == 3))
                {
                    Atendidos.Encolar(1, aux.CI1);
                }
                if (dia == "MIERCOLES" && (ultimo == 4 || ultimo == 5))
                {
                    Atendidos.Encolar(1, aux.CI1);
                }
                if (dia == "JUEVES" && (ultimo == 6 || ultimo == 7))
                {
                    Atendidos.Encolar(1, aux.CI1);
                }
                if (dia == "VIERNES" && (ultimo == 8 || ultimo == 9))
                {
                    Atendidos.Encolar(1, aux.CI1);
                }
                aux = aux.Sig;
            }
        }*/
        String cantidad()
        {
            int con = 0;
            Nodo aux = Atendidos.Get_frente();
            while (aux != null)
            {
                con++;
                aux = aux.Sig;
                
            }
            return  "LA CANTIDAD ES DE : "+con;
        }
        void vaciarCola()
        {
            Nodo aux ;
            while (!Atendidos.Estavacio())
            {
                aux = Atendidos.Desencolar();

               
            }
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btn_atendidos_Click(object sender, EventArgs e)
        {
           //mostrarAtencion(CBO_DIAS.Text);
           llenarAtendidos(CBO_DIAS.Text);
            Mostrar02();
            MessageBox.Show(cantidad());


        }
        public void Mostrar02()
        {
            Nodo aux = Atendidos.Get_frente();
            while (aux != null)
            {
               LST_ATENDIDOS.Items.Add("Persona  " + aux.CI1);
                aux = aux.Sig;
            }

        }

        private void BNT_LIMPIAR_Click(object sender, EventArgs e)
        {
            LST_ATENDIDOS.Items.Clear();

            vaciarCola();
            
        }

        private void CBO_DIAS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
