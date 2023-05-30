using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace ConexionSQL.clases
{
    class Conexion
    {
        NpgsqlConnection conex = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd= "examen";
        static String usuario= "postgres";
        static String password="root";
        static String puerto="5432";

        String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";"+"user id="+usuario+";"+"password=" +password+ ";" + "database=" + bd + ";";
        
        public NpgsqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto correctamente a la Base de datos");

            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se pudo Conextar a la base de datos  de PostegredSQL"+e.ToString());

                
            }
            return conex;
        }

    }
}
