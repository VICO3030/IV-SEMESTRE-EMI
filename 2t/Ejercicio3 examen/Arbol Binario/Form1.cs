using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_Binario
{
    public partial class principal : Form
    {
      
        public principal()
        {
            InitializeComponent();
        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            StaticClass.a.crear_arbol(int.Parse(txtDAto.Text));
            txtDAto.Clear();
        }
        private void preOrder(NodoArbol punt,int acc)
        {
            if(punt != null)
            {
                acc += punt.Dato;
                lstpreOrden.Items.Add(punt.Dato);
                preOrder(punt.Izq, acc);
                preOrder(punt.Der, acc);
               
            }
        }

        private void inOrder(NodoArbol punt)
        {
            if(punt != null)
            {
                
                inOrder(punt.Izq);
                lstInOrdne.Items.Add(punt.Dato);
                
                inOrder(punt.Der);
            }
        }
        private void postOrder(NodoArbol punt)
        {
            if(punt != null)
            {
                postOrder(punt.Izq);
                postOrder(punt.Der);
                lstPosrOrden.Items.Add(punt.Dato);
            }
        }

        private void BtnPreordne_Click(object sender, EventArgs e)
        {

            NodoArbol punt = new NodoArbol();
            punt = StaticClass.a.get_raiz();
            if(punt != null)
            {
                preOrder(punt, 0);
            }
            else
            {
                MessageBox.Show("The tree is empty");
            }
        }

        private void BtnInordern_Click(object sender, EventArgs e)
        {
            int acc = 0;
            NodoArbol punt = new NodoArbol();
            punt = StaticClass.a.get_raiz();
            if (punt == null)
            {
                MessageBox.Show("Arbol vacio");
            }
            else
            {
                inOrder(punt);
            }
        }

        private void BtnPostOrden_Click(object sender, EventArgs e)
        {
            NodoArbol punt = StaticClass.a.get_raiz();
            if (punt == null) {
                MessageBox.Show("Arbon vacio");
            }
            else
            {
                postOrder(punt);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            lstInOrdne.Items.Clear();
            lstPosrOrden.Items.Clear();
            lstpreOrden.Items.Clear();
        }



        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (StaticClass.a.buscar(int.Parse(txtDAto.Text), StaticClass.a.get_raiz()))
            {
                MessageBox.Show("El Numero se encuentra registrado");
            }
            else
            {
                MessageBox.Show("No se encuentra registrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("La suma de los datos del arbol es: " + StaticClass.a.suma);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("los numeros pares son : " + StaticClass.a.pares + "\n" + "los numeros impares son: " + StaticClass.a.impares);
        }
    }
}
