using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class RECORRIDO : Form
    {
        public RECORRIDO()
        {
            InitializeComponent();
        }

        private void preorden(nodo arbol)
        {
            if (arbol != null)
            {
                Lst_Preorden.Items.Add(arbol.Dato);
                preorden(arbol.Iz);
                preorden(arbol.Der);
            }
        }
        private void inorden(nodo arbol)
        {
            if (arbol != null)
            {
                inorden(arbol.Iz);
                Lst_Inorden.Items.Add(arbol.Dato);
                inorden(arbol.Der);
            }
        }
        private void postorden(nodo arbol)
        {
            if (arbol != null)
            {
                postorden(arbol.Iz);
                postorden(arbol.Der);
                Lst_Postorden.Items.Add(arbol.Dato);
            }
        }
        
        private void Btn_Preorden_Click_1(object sender, EventArgs e)
        {
            nodo arbol = Estatica.A.get_Raiz();
            if (arbol != null)
            {
                Lst_Preorden.Items.Clear();
                preorden(arbol);
            }
            else
            {
                MessageBox.Show("No existe arbol creado");
            }
        }

        private void Btn_Posorden_Click_1(object sender, EventArgs e)
        {
            nodo arbol = Estatica.A.get_Raiz();
            if (arbol != null)
            {
                Lst_Postorden.Items.Clear();
                postorden(arbol);
            }
            else
            {
                MessageBox.Show("No existe arbol creado");
            }
        }

        private void Btn_Inorden_Click(object sender, EventArgs e)
        {
            nodo arbol = Estatica.A.get_Raiz();
            if (arbol != null)
            {
                Lst_Inorden.Items.Clear();
                inorden(arbol);
            }
            else
            {
                MessageBox.Show("No existe arbol creado");
            }
        }

        private void graficaDelArbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //metodo para diseñar la interfaz del arbol
            Graphics nodo;
            nodo = CreateGraphics();
            nodo.FillEllipse(Brushes.White, 320, 30, 35, 35);
            nodo.DrawString("50", Font, Brushes.Purple, 330, 40);
            Pen myNodoRaiz = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodoRaiz, 320, 30, 35, 35);

            //primer nodo del izquierdo
  
            nodo.FillEllipse(Brushes.White, 200, 80, 35, 35);
            nodo.DrawString("40", Font, Brushes.Purple, 210, 90);
            Pen myNodo1 = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodoRaiz, 200, 80, 35, 35);

            //linea para conectar el primer nodo izquierdo
            Pen myLinea1 = new Pen(Color.Aqua,2);
            nodo.DrawLine(myLinea1, 235, 90, 320, 55);

            //primer nodo del derecho

            nodo.FillEllipse(Brushes.White, 440, 80, 35, 35);
            nodo.DrawString("80", Font, Brushes.Purple, 450, 90);
            Pen myNodo2 = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodo2, 440, 80, 35, 35);

            //linea para conectar el primer nodo derecho
            Pen myLinea2 = new Pen(Color.Aqua, 2);
            nodo.DrawLine(myLinea2, 355, 55, 440, 90);


            //Lineas para conectar los nodos

            //linea de 80 a 90
            Pen myLinea3 = new Pen(Color.Aqua, 2);
            nodo.DrawLine(myLinea3, 471, 110, 512, 141);

            //linea de 40 a 45
            Pen myLinea4 = new Pen(Color.Aqua, 2);
            nodo.DrawLine(myLinea4, 232, 108, 281, 132);

            //liena de 40 a 30
            Pen myLinea5 = new Pen(Color.Aqua, 2);
            nodo.DrawLine(myLinea5,203, 108, 160, 129);

            //linea de 80 a 70
            Pen myLinea6 = new Pen(Color.Aqua, 2);
            nodo.DrawLine(myLinea6, 444, 110, 403, 139);

            //linea de 30 a 10
            Pen myLinea7 = new Pen(Color.Aqua, 2);
            nodo.DrawLine(myLinea7, 145, 162, 129, 186);

            //redonditos 

            nodo.FillEllipse(Brushes.White, 140, 131, 35, 35);
            nodo.DrawString("30", Font, Brushes.Purple, 150, 141);
            Pen myNodo3 = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodo3, 140, 131, 35, 35);

            nodo.FillEllipse(Brushes.White, 265, 133, 35, 35);
            nodo.DrawString("45", Font, Brushes.Purple, 275,143);
            Pen myNodo4 = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodo4, 265, 133, 35, 35);

            nodo.FillEllipse(Brushes.White, 106, 187, 35, 35);
            nodo.DrawString("10", Font, Brushes.Purple, 116, 197);
            Pen myNodo5 = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodo5, 106, 187, 35, 35);

            nodo.FillEllipse(Brushes.White, 379, 139, 35, 35);
            nodo.DrawString("70", Font, Brushes.Purple, 389, 149);
            Pen myNodo6 = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodo6, 379, 139, 35, 35);

            nodo.FillEllipse(Brushes.White, 506, 139, 35, 35);
            nodo.DrawString("90", Font, Brushes.Purple, 516, 149);
            Pen myNodo7 = new Pen(Color.Aqua, 3);
            nodo.DrawEllipse(myNodo7, 506, 139, 35, 35);

        }

        private void RECORRIDO_Load(object sender, EventArgs e)
        {

        }
    }
}
