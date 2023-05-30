using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_bd
{
    public partial class frm_reg_med : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_reg_med()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txt_cod.Clear();
            txt_nombre.Clear();
            txt_paterno.Clear();
            txt_materno.Clear();
            txt_direc.Clear();
            txt_correo.Clear();
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            insertar();
        }
        private void insertar()
        {
            if(
                txt_cod.Text == "" ||
                txt_nombre.Text == "" ||
                txt_paterno.Text == "" ||
                txt_materno.Text == "" ||
                txt_direc.Text == "" ||
                txt_correo.Text == ""
                )
            {
                MessageBox.Show("Todos los campos deben ser llenados!");
            }
            else
            {
                conexion.InsertarMed(
                    Convert.ToInt32(txt_cod.Text),
                    txt_nombre.Text,
                    txt_paterno.Text,
                    txt_materno.Text,
                    txt_direc.Text,
                    txt_correo.Text
                    );
            }
        }
    }
}
