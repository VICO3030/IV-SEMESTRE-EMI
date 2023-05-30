using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Proyecto_bd
{
    class ConexionPgsql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id=postgres; Password=1234567890; Database=clinica_02;");
        
        public void Conectar()
        {
            conn.Open();
            System.Windows.Forms.MessageBox.Show("Conexion establecida");
        }

        public void Desconectar()
        {
            conn.Close();
            System.Windows.Forms.MessageBox.Show("Conexion terminada");
        }

        public DataTable Consultar(string query)
        {
            //string query = "select * from \"medico\"";
            NpgsqlCommand connector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(connector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
            
        }


        public void InsertarMed(int cod_med,string nom_med,string apat_med,string amat_med,string direc_med,string correo_med)
        {
            
            string query = "insert into medico values(" 
                + cod_med + ",'" + nom_med + "','" + apat_med + "','"
                + amat_med + "','" + direc_med + "','" + correo_med
                + "')";
            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("Registro Efectuado Con Exito!");
            conn.Close();
        }
        public void InsertarRec(int cod_rec,string prescripcion,int cita)
        {

            string query = "insert into receta values("
                + cod_rec + ",'" + prescripcion + "'," + cita + ")";
            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("Registro Efectuado Con Exito!");
            conn.Close();
        }
        public void InsertarPac(int cod_pac,string nom_pac,string apat_pac,string amat_pac,string direc_pac,string correo_pac,int telf_pac)
        {
            string query = "insert into paciente values(" + cod_pac + ",'" + nom_pac + "','" 
                + apat_pac + "','" + amat_pac + "','" + direc_pac + "','" + correo_pac + "'," 
                + telf_pac +")";
            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Registro Efectuado con Exito!");
            
        }
        public void InsertarLab(int cod_lab,string fecha_est,string desc_est,string pais_lab,string ciud_lab,string dir_lab,int estudios)
        {
            string query = "insert into laboratorio values(" + cod_lab + ",'" + fecha_est + "','"
                + desc_est + "','" + pais_lab + "','" + ciud_lab + "','" + dir_lab+ "',"
                + estudios + ")";
            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Registro Efectuado con Exito!");

        }
        public void InsertarCita(int cod_cita,string mot_cita,string fecha_cita,string hora_cita,int medico,int historia)
        {
            string query = "insert into cita values(" + cod_cita + ",'" + mot_cita + "','"
                + fecha_cita + "','" + hora_cita + "'," + medico + "," + historia + ")";

            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Registro Efectuado con Exito!");
        }
        public void InsertarHistoria(int cod_hist,int paciente,string desc_hist)
        {
            string query = "insert into historia values(" + cod_hist + "," + paciente + ",'" + desc_hist + "')";

            conn.Open();
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            ejecutor.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Registro Efectuado con Exito!");
        }
        public void Eliminar(string query)
        {
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Eliminado con exito");
            
        }
        public void editar(string query)
        {
            NpgsqlCommand ejecutor = new NpgsqlCommand(query,conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cambios aplicados con exito");

        }

    }
}
