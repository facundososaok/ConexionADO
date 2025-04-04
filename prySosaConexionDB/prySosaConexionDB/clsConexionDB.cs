using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prySosaConexionDB
{

    public class clsConexionDB
    {
        string connectionString = "Server=localhost;Database=Comercio;Trusted_Connection=True;";
        private SqlConnection cnn;
        public clsConexionDB()
        {
            cnn = new SqlConnection(connectionString);
        }
        public void abrirConexion()
        {
            try
            {
                if (cnn.State != System.Data.ConnectionState.Open)
                {
                    cnn.Open();
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }
        }
        public void mostrarNombreProductos()
        {
            try
            {
                string query = "Select * from Productos";
                SqlCommand cmd = new SqlCommand(query, cnn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(reader["Nombre"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los nombres de los productos: " + ex.Message);
            }
        }
    }
}

