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
    public partial class frm_editar_med : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        string queryTodo = "select * from medico";
        string queryBusca; 
        public frm_editar_med()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chb_nombre_CheckedChanged(object sender, EventArgs e)
        {
            txt_nom.Enabled = chb_nombre.Checked;
        }
        private void chb_apat_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_apat.Enabled = chb_apat.Checked;
        }

        private void chb_amat_CheckedChanged(object sender, EventArgs e)
        {
            txt_amat.Enabled = chb_amat.Checked;
        }

        private void chb_direc_CheckedChanged(object sender, EventArgs e)
        {
            txt_direc.Enabled = chb_direc.Checked;
        }

        private void chb_correo_CheckedChanged(object sender, EventArgs e)
        {
            txt_correo.Enabled = chb_correo.Checked;
        }

        private void chb_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            grp_eliminar.Enabled = chb_eliminar.Checked;
            grp_eliminar.Visible = chb_eliminar.Checked;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            /*
            queryBusca = "select * from medico where cod_med='" + txt_cod.Text + "'";
            dgv_mostrar.DataSource = conexion.Consultar(queryBusca);
            if(dgv_mostrar.Rows.Count == 0)
            {
                MessageBox.Show("Codigo inexistente!");
            }
            else
            {
                conexion.EliminarMed(txt_cod.Text);
            }
            */
            
        }

        

        private void frm_editar_med_Load(object sender, EventArgs e)
        {
            DataTable o = conexion.Consultar(queryTodo);
            dgv_mostrar.DataSource = conexion.Consultar(queryTodo);
            if(o == null)
            {
                MessageBox.Show("Base de datos vacia para la tabla medicos!");
            }
            else
            {
                grp_todo.Enabled = true;
            }
        }
        private string getMedQuery(string cod)
        {
            string query = "update medico set ";
            bool anterior = false;

            if (cod == "") return "1";
            if (!chb_nombre.Checked && !chb_apat.Checked && !chb_amat.Checked && !chb_direc.Checked && !chb_correo.Checked) return "2";

            if (chb_nombre.Checked)
            {
                if (txt_nom.Text == "") return "";
                if (!anterior)
                {
                    query += "nom_med='" + txt_nom.Text + "'";
                    anterior = true;
                }
                else query += ",nom_med='" + txt_nom.Text + "'";
            }

            if (chb_apat.Checked)
            {
                if (txt_apat.Text == "") return "";
                if (!anterior)
                {
                    query += "apat_med='" + txt_apat.Text + "'";
                    anterior = true;
                }
                else query += ",apat_med='" + txt_apat.Text + "'";
            }

            if (chb_amat.Checked)
            {
                if (txt_amat.Text == "") return "";
                if (!anterior)
                {
                    query += "amat_med='" + txt_amat.Text + "'";
                    anterior = true;
                }
                else query += ",amat_med='" + txt_amat.Text + "'";
            }

            if (chb_direc.Checked)
            {
                if (txt_direc.Text == "") return "";
                if (!anterior)
                {
                    query += "direc_med='" + txt_direc.Text + "'";
                    anterior = true;
                }
                else query += ",direc_med='" + txt_direc.Text + "'";
            }

            if (chb_correo.Checked)
            {
                if (txt_correo.Text == "") return "";
                if (!anterior)
                {
                    query += "correo_med='" + txt_correo.Text + "'";
                    anterior = true;
                }
                else query += ",correo_med='" + txt_correo.Text + "'";
            }
            return query += " where cod_med=" + cod + " ";
        }
        private void chb_eliminar_CheckedChanged_1(object sender, EventArgs e)
        {
            btn_eliminar.Enabled = chb_eliminar.Checked;
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (txt_cod.Text == "") MessageBox.Show("Codigo Invalido!");
            else
            {
                dgv_mostrar.DataSource = conexion.Consultar("select * from cita where medico=" + txt_cod.Text);
                if (dgv_mostrar.Rows[0].Cells[0].Value != null) MessageBox.Show("Codigo referido en la tabla cita! No se puede eliminar!");
                else conexion.Eliminar("delete from medico where cod_med=" + txt_cod.Text);
                dgv_mostrar.DataSource = conexion.Consultar("select * from medico");
            }
        }

        private void btn_aplicar_Click_1(object sender, EventArgs e)
        {
            if (getMedQuery(txt_cod.Text) == "1") MessageBox.Show("Codigo invalido!");
            else
            {
                if (getMedQuery(txt_cod.Text) == "2") MessageBox.Show("Ningun campo seleccionado!");
                else
                {
                    if (getMedQuery(txt_cod.Text) == "") MessageBox.Show("Campos seleccionados Vacios");
                    else
                    {
                        conexion.editar(getMedQuery(txt_cod.Text));
                        dgv_mostrar.DataSource = conexion.Consultar("select * from medico where cod_med=" + txt_cod.Text);
                    }
                }
            }
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {
            txt_correo.Enabled = chb_correo.Checked;
        }

        private void chb_nombre_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_nom.Enabled = chb_nombre.Checked;
        }

        private void chb_apat_CheckedChanged(object sender, EventArgs e)
        {
            txt_apat.Enabled = chb_apat.Checked;
        }

        private void chb_amat_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_amat.Enabled = chb_amat.Checked;
        }

        private void chb_direc_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_direc.Enabled = chb_direc.Checked;
        }

        private void chb_correo_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_correo.Enabled = chb_correo.Checked;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "")
            {
                MessageBox.Show("Codigo Invalido!");
                grp_editar.Enabled = false;
            }
            else
            {
                dgv_mostrar.DataSource = conexion.Consultar("select * from medico where cod_med=" + txt_cod.Text);
                if (dgv_mostrar.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo inexistente!");
                    dgv_mostrar.DataSource = conexion.Consultar("select * from medico");
                    grp_editar.Enabled = false;
                    chb_eliminar.Enabled = false;
                }
                else
                {
                    grp_editar.Enabled = true;
                    chb_eliminar.Enabled = true;
                }
            }
        }
    }
}
