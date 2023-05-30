using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Proyecto_bd;

namespace TablaSanti
{
    public partial class frm_reg_pac : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_reg_pac()
        {
            InitializeComponent();
            
        }
        private void txt_cod_pac_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private bool vacio()
        {
            return txt_cod_pac.Text == "" || txt_nomPac.Text == "" || txt_apellidoPatPac.Text == ""
                || txt_apellidoMatPac.Text == "" || txt_direccPac.Text == "" || txt_correoPac.Text == ""
                || txt_telfPac.Text == "";
        }
        private void insertar()
        {
            conexion.InsertarPac(
                Convert.ToInt32(txt_cod_pac.Text),
                txt_nomPac.Text,
                txt_apellidoPatPac.Text,
                txt_apellidoMatPac.Text,
                txt_direccPac.Text,
                txt_correoPac.Text,
                Convert.ToInt32(txt_telfPac.Text)
                );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //registrar
            if (vacio()) MessageBox.Show("Todos los campos deben ser llenados");
            else insertar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiarPac_Click(object sender, EventArgs e)
        {
            txt_cod_pac.Clear();
            txt_nomPac.Clear();
            txt_apellidoPatPac.Clear();
            txt_apellidoMatPac.Clear();
            txt_direccPac.Clear();
            txt_correoPac.Clear();
            txt_telfPac.Clear();
        }

        private void txt_direccPac_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
