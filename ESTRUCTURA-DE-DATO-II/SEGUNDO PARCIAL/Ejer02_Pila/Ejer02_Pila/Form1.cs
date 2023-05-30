using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer02_Pila
{
    public partial class FRM_EMPRESA : Form
    {
        Pila Tienda = new Pila();
        Pila Paux = new Pila();
        Pila Almacen = new Pila();
        public FRM_EMPRESA()
        {
            InitializeComponent();
        }

        private void FRM_EMPRESA_Load(object sender, EventArgs e)
        {

        }
        public void MostrarRegistro()
        {
            Nodo aux;
            if (Tienda.estaVacio() == true)
            {
                MessageBox.Show("ESTA VACIO LA PILA !!");
            }
            else
            {
                while (!Tienda.estaVacio())
                {
                    aux = Tienda.Desapilar();
                    GRP_REGISTRO.Rows.Add(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
                    Paux.Apilar(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
                }
                while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    Tienda.Apilar(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
                }
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            GRP_REGISTRO.Rows.Clear();
            int cod = int.Parse(txt_cod.Text);
            int stock = int.Parse(txt_stock.Text);
            float pre = float.Parse(txt_precio.Text);

            MessageBox.Show(Tienda.Apilar(cod, stock, pre, txt_descrip.Text));
            MostrarRegistro();
            /*txt_cod.Clear();
            txt_descrip.Clear();
            txt_precio.Clear();
            txt_stock.Clear();*/

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            FRM_MENU p1 = new FRM_MENU();
            this.Hide();
            p1.Show();
        }
        public void MostrarCompra()
        {
            Nodo aux;
            if (Almacen.estaVacio() == true)
            {
                MessageBox.Show("ESTA VACIO LA PILA !!");
            }
            else
            {
                while (!Almacen.estaVacio())
                {
                    aux = Almacen.Desapilar();
                    GRP_COMPRAS.Rows.Add(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
                    Paux.Apilar(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
                }
                while (!Paux.estaVacio())
                {
                    aux = Paux.Desapilar();
                    Almacen.Apilar(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
                }
            }
        }
        public Boolean BuscarDato(int dato)
        {

            Nodo aux = Tienda.Get_tope();
            Boolean encontrado = false;
            while (!Tienda.estaVacio() && encontrado != true)
            {
                aux = Tienda.Desapilar();
                if (aux.Get_Codigo() == dato)
                {
                    encontrado = true;
                }
                Paux.Apilar(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
            }
            while (!Paux.estaVacio())
            {
                aux = Paux.Desapilar();
                Tienda.Apilar(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
            }
            return encontrado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GRP_COMPRAS.Rows.Clear();
            int cod = int.Parse(txt_cod.Text);
            int stock = int.Parse(txt_stock.Text);
            float pre = float.Parse(txt_precio.Text);

            MessageBox.Show(Almacen.Apilar(cod, stock, pre, txt_descrip.Text));
            MostrarCompra();

        }
        /* public void Anadircompras()
         {
             Nodo aux = Compra.Get_tope();
             Nodo auxregis = registro.Get_tope();
             Nodo guardastock = new Nodo();

             while (!Compra.estaVacio() && !registro.estaVacio())
             {
                 aux = Compra.Desapilar();
                 auxregis = registro.Desapilar();
                 if (aux.Get_Codigo() == auxregis.Get_Codigo())
                 {
                     guardastock.Set_stok(auxregis.Get_Stock());//AUXX
                     auxregis.Set_stok(aux.Get_Stock() + guardastock.Get_Stock());
                 }
                 else
                 {
                     Paux.Apilar(aux.Get_Codigo(), aux.Get_Stock(), aux.Get_precio(), aux.Get_descripcion());
                 }

                 Paux.Apilar(auxregis.Get_Codigo(), auxregis.Get_Stock(), auxregis.Get_precio(), auxregis.Get_descripcion());

             }
             while (!Paux.estaVacio())
             {
                 auxregis = Paux.Desapilar();
                 registro.Apilar(auxregis.Get_Codigo(), auxregis.Get_Stock(), auxregis.Get_precio(), auxregis.Get_descripcion());
             }


         }*/
        public void anadirTienda()
        {
            int aux;
            Nodo auxTienda = Tienda.Get_tope();
            Nodo auxAlmacen = Almacen.Get_tope();
            Nodo anadirTienda = Almacen.Get_tope();
           // Boolean encontrado = false;

            while (!Tienda.estaVacio() && !Almacen.estaVacio())
            {
                auxTienda = Tienda.Desapilar();

                if (auxTienda.Get_Codigo() == auxAlmacen.Get_Codigo())
                {
                   // encontrado = true;
                    aux = auxTienda.Get_Stock();
                    auxTienda.Set_stok(aux + auxAlmacen.Get_Stock());
                    //auxAlmacen = auxAlmacen.Get_sig();
                    anadirTienda = Almacen.Desapilar();

                }
                else {
                     anadirTienda = Almacen.Desapilar();
                     Paux.Apilar(anadirTienda.Get_Codigo(), anadirTienda.Get_Stock(), anadirTienda.Get_precio(), anadirTienda.Get_descripcion());
                   // auxTienda = Almacen.Desapilar();
                }


                Paux.Apilar(auxTienda.Get_Codigo(), auxTienda.Get_Stock(), auxTienda.Get_precio(), auxTienda.Get_descripcion());
                // auxAlmacen = auxAlmacen.Get_sig();
                auxTienda = auxTienda.Get_sig();

            }
            /*  //condcion para avanzar
              if (encontrado != true)
              {

                  //anadirTienda = Almacen.Desapilar();
                  Paux.Apilar(anadirTienda.Get_Codigo(), anadirTienda.Get_Stock(), anadirTienda.Get_precio(), anadirTienda.Get_descripcion());
                  //auxAlmacen = auxAlmacen.Get_sig();
              }*/
            while (!Paux.estaVacio())
            {
                auxTienda = Paux.Desapilar();
                Tienda.Apilar(auxTienda.Get_Codigo(), auxTienda.Get_Stock(), auxTienda.Get_precio(), auxTienda.Get_descripcion());
            }

        }

    


        

        private void button2_Click(object sender, EventArgs e)
        {
            GRP_COMPRAS.Rows.Clear();
            GRP_REGISTRO.Rows.Clear();
            anadirTienda();
            MostrarRegistro();
        }

        private void GRP_REGISTRO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grp_venta_Enter(object sender, EventArgs e)
        {

        }
    }
}
