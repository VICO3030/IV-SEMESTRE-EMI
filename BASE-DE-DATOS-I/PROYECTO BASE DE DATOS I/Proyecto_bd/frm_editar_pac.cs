using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_bd;

namespace TablaSanti
{
    public partial class frm_editar_pac : Form
    {
        ConexionPgsql conexion = new ConexionPgsql();
        public frm_editar_pac()
        {
            InitializeComponent();
        }
        
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "") MessageBox.Show("Codigo Invalido!");
            else
            {
                dataGridView1.DataSource = conexion.Consultar("select * from historia where paciente=" + txt_cod.Text);
                if (dataGridView1.Rows[0].Cells[0].Value != null) MessageBox.Show("Codigo referido en la tabla historia! No se puede eliminar!");
                else conexion.Eliminar("delete from paciente where cod_pac=" + txt_cod.Text);
                dataGridView1.DataSource = conexion.Consultar("select * from paciente");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //ya no
           
        }
        private string getPacQuery(string cod)
        {
            string query = "update paciente set ";
            bool anterior = false;
            //codigo vacio
            if (cod == "") return "1";
            //ningun campo seleccionado
            if (!chb_nom.Checked && !chb_apat.Checked && !chb_amat.Checked && !chb_direc.Checked && !chb_correo.Checked && !chb_telf.Checked) return "2";

            if (chb_nom.Checked)
            {
                if (txt_nom_nuevo.Text == "") return "";
                if (!anterior)
                {
                    query += "nom_pac='" + txt_nom_nuevo.Text + "'";
                    anterior = true;
                }
                else query += ",nom_pac='" + txt_nom_nuevo.Text + "'";
            }

            if (chb_apat.Checked)
            {
                if (txt_apPat_nuevo.Text == "") return "";
                if (!anterior)
                {
                    query += "apat_pac='" + txt_apPat_nuevo.Text + "'";
                    anterior = true;
                }
                else query += ",apat_pac='" + txt_apPat_nuevo.Text + "'";
            }

            if (chb_amat.Checked)
            {
                if (txt_apMat_nuevo.Text == "") return "";
                if (!anterior)
                {
                    query += "amat_pac='" + txt_apMat_nuevo.Text + "'";
                    anterior = true;
                }
                else query += ",amat_pac='" + txt_apMat_nuevo.Text + "'";
            }

            if (chb_direc.Checked)
            {
                if (txt_direcc_nuevo.Text == "") return "";
                if (!anterior)
                {
                    query += "direcccion_pac='" + txt_direcc_nuevo.Text + "'";
                    anterior = true;
                }
                else query += ",direccion_med='" + txt_direcc_nuevo.Text + "'";
            }

            if (chb_correo.Checked)
            {
                if (txt_correo_nuevo.Text == "") return "";
                if (!anterior)
                {
                    query += "correo_pac='" + txt_correo_nuevo.Text + "'";
                    anterior = true;
                }
                else query += ",correo_pac='" + txt_correo_nuevo.Text + "'";
            }

            if (chb_telf.Checked)
            {
                if (txt_telf_nuevo.Text == "") return "";
                if (!anterior)
                {
                    query += "tel_pac='" + txt_telf_nuevo.Text + "'";
                    anterior = true;
                }
                else query += ",tel_pac='" + txt_telf_nuevo.Text + "'";
            }
            return query += " where cod_pac=" + cod + " ";
        }
        private void btn_actualizarDatos_Click(object sender, EventArgs e)
        {
            if (getPacQuery(txt_cod.Text) == "1") MessageBox.Show("Codigo invalido!");
            else
            {
                if (getPacQuery(txt_cod.Text) == "2") MessageBox.Show("Ningun campo seleccionado!");
                else
                {
                    if (getPacQuery(txt_cod.Text) == "") MessageBox.Show("Campos seleccionados Vacios");
                    else
                    {
                        conexion.editar(getPacQuery(txt_cod.Text));
                        dataGridView1.DataSource = conexion.Consultar("select * from paciente where cod_pac=" + txt_cod.Text);
                    }
                }
            }

        }

        private void btn_modificar_cliente_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text != "")
            {
                dataGridView1.DataSource = conexion.Consultar("select * from paciente where cod_pac=" + txt_cod.Text);
                if (dataGridView1.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Codigo Inexistente!");
                    grp_mod.Enabled = false;
                    chb_eliminar.Enabled = false;
                    dataGridView1.DataSource = conexion.Consultar("select * from paciente");
                }
                else
                {
                    //existe el codigo
                    grp_mod.Enabled = true;
                    chb_eliminar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Codigo invalido");
                dataGridView1.DataSource = conexion.Consultar("select * from paciente");
            }
            
        }
        public void mostrarPacientes()
        {
            
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chb_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            btn_eliminar.Enabled = chb_eliminar.Checked;
        }

        private void frm_editar_pac_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conexion.Consultar("select * from paciente");
        }

        private void chb_nom_CheckedChanged(object sender, EventArgs e)
        {
            txt_nom_nuevo.Enabled = chb_nom.Checked;
        }

        private void chb_apat_CheckedChanged(object sender, EventArgs e)
        {
            txt_apPat_nuevo.Enabled = chb_apat.Checked;
        }

        private void chb_amat_CheckedChanged(object sender, EventArgs e)
        {
            txt_apMat_nuevo.Enabled = chb_amat.Checked;
        }

        private void chb_direc_CheckedChanged(object sender, EventArgs e)
        {
            txt_direcc_nuevo.Enabled = chb_direc.Checked;
        }

        private void chb_correo_CheckedChanged(object sender, EventArgs e)
        {
            txt_correo_nuevo.Enabled = chb_correo.Checked;
        }

        private void chb_telf_CheckedChanged(object sender, EventArgs e)
        {
            txt_telf_nuevo.Enabled = chb_telf.Checked;
        }


        /*
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

* */
    }
}
