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
    public partial class UsuariosActivos : Form
    {

        public UsuariosActivos()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

        }

        private void UsuariosActivos_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Conexion.getConexion())
            {
                connection.Open();

                // Obtener los usuarios y su estado
                string query = "SELECT usuario, estado FROM usuarios";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Mostrar los usuarios y su estado en el datagridview
                    dataUsuariosAc.DataSource = dataTable;
                    foreach (DataGridViewRow row in dataUsuariosAc.Rows)
                    {
                        string estado = row.Cells["estado"].Value.ToString();
                        if (estado == "Activo")
                        {
                            row.Cells["estado"].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            row.Cells["estado"].Style.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void UsuariosActivos_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Actualizar el estado del usuario a "Inactivo"
            string usuario = Properties.Settings.Default.UltimoUsuario;
            if (!string.IsNullOrEmpty(usuario))
            {
                using (MySqlConnection connection = Conexion.getConexion())
                {
                    connection.Open();

                    string query = "UPDATE usuarios SET estado = 'Inactivo' WHERE usuario = @usuario";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnVolver8_Click(object sender, EventArgs e)
        {
            ActivosFijos a = new ActivosFijos();
            a.Show();
            this.Hide();
        }
    }
}

