using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventarioLI
{
    public partial class Historial : Form
    {

        public Historial()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void bntVolver9_Click(object sender, EventArgs e)
        {
            AgregarProducto ap = new AgregarProducto();
            ap.Show();
            this.Hide();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = Conexion.getConexion();

            try
            {
                connection.Open();
                string query = "SELECT * FROM HistorialProductos";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataHistorial.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void boxFiltrarAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = boxFiltrarAME.SelectedItem.ToString();
            string consulta;

            if (filtro == "Todo")
            {
                consulta = "SELECT * FROM HistorialProductos";
            }
            else
            {
                consulta = "SELECT * FROM HistorialProductos WHERE Alteracion LIKE '%" + filtro + "%'";
            }

            MySqlConnection conexion = Conexion.getConexion();
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataHistorial.DataSource = tabla;
        }

        private void dataHistorial_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataHistorial.Columns[e.ColumnIndex].Name == "Alteracion")
            {
                string alteracion = e.Value.ToString();

                switch (alteracion)
                {
                    case "Agregado":
                        e.CellStyle.ForeColor = Color.Green;
                        break;

                    case "Modificado":
                        e.CellStyle.ForeColor = Color.Blue;
                        break;

                    case "Eliminado":
                        e.CellStyle.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea borrar el historial?", "Borrar historial", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Conecta a la base de datos
                    MySqlConnection conexion = Conexion.getConexion();

                    // Abre la conexión
                    conexion.Open();

                    // Define la consulta SQL que trunca la tabla Historial
                    string consulta = "TRUNCATE TABLE historialproductos;";

                    // Crea un comando para ejecutar la consulta
                    MySqlCommand comando = new MySqlCommand(consulta, conexion);

                    // Ejecuta el comando
                    comando.ExecuteNonQuery();

                    // Cierra la conexión
                    conexion.Close();

                    MessageBox.Show("Historial borrado exitosamente.", "Borrar historial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el historial: " + ex.Message, "Borrar historial", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FillDataGridView()
        {
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM historialproductos", conexion);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dataHistorial.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
