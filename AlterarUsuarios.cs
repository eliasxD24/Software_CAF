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
    public partial class AlterarUsuarios : Form
    {
        public AlterarUsuarios()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            CargarUsuarios();
        }

        private void btnVolver10_Click(object sender, EventArgs e)
        {
            ActivosFijos a = new ActivosFijos();
            a.Show();
            this.Hide();
        }

        private void EliminarUsuario(int idUsuario)
        {
            MySqlConnection conexion = Conexion.getConexion();
            MySqlCommand comando = new MySqlCommand("DELETE FROM usuarios WHERE id = @id", conexion);
            comando.Parameters.AddWithValue("@id", idUsuario);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("El usuario ha sido eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar el DataGridView con la lista de usuarios actualizada.
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void CargarUsuarios()
        {
            MySqlConnection conexion = Conexion.getConexion();
            MySqlCommand comando = new MySqlCommand("SELECT id, usuario, nombre, id_tipo FROM usuarios", conexion);
            DataTable tablaUsuarios = new DataTable();
            try
            {
                conexion.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(tablaUsuarios);

                // Eliminar la columna "Eliminar" de su posición actual
                if (dataUsers.Columns.Contains("Eliminar"))
                {
                    dataUsers.Columns.RemoveAt(dataUsers.Columns["Eliminar"].Index);
                }

                // Agregar la columna "Eliminar" al final de la tabla
                DataGridViewImageColumn columnaEliminar = new DataGridViewImageColumn();
                columnaEliminar.Name = "Eliminar";
                columnaEliminar.HeaderText = "Eliminar";
                columnaEliminar.Image = Properties.Resources.DeleteIco;
                columnaEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;

                dataUsers.DataSource = tablaUsuarios;
                dataUsers.Columns["id"].Visible = false; // Ocultar la columna "id"
                dataUsers.Columns["usuario"].HeaderText = "Usuario";
                dataUsers.Columns["nombre"].HeaderText = "Nombre";
                dataUsers.Columns["id_tipo"].HeaderText = "Tipo de usuario";
                dataUsers.Columns.Add(columnaEliminar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al intentar cargar la lista de usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void dataUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataUsers.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                string nombreUsuario = dataUsers.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                if (MessageBox.Show("¿Desea eliminar el usuario " + nombreUsuario + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idUsuario = (int)dataUsers.Rows[e.RowIndex].Cells["id"].Value;
                    EliminarUsuario(idUsuario);
                }
            }
        }

        private void AlterarUsuarios_Load(object sender, EventArgs e)
        {
            // Crea una instancia de ToolTip
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 30000; // Establece el tiempo de espera para 30 segundos
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;

            // Agrega el botón de ayuda y establece su texto y posición
            Button btnAyuda = new Button();
            btnAyuda.Text = "?";
            btnAyuda.AutoSize = true;
            btnAyuda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Controls.Add(btnAyuda);

            // Establece el texto que se mostrará en el cuadro emergente de ToolTip
            toolTip.SetToolTip(btnAyuda, "Tips:\n1.- Para borrar un Usuario presione el icono de la basura. " +
                "\n2.- Hay dos tipos de usuarios: Numero dos el Usuario \ny Numero uno el Administrador.");

            btnAyuda.Location = new Point(this.ClientSize.Width - btnAyuda.Width - 10,
                                  this.ClientSize.Height - btnAyuda.Height - 10);
        }
    }
}
