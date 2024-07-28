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

    public partial class ActivosFijos : Form
    {

        int tipoUsuario;
        public ActivosFijos()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            lNombre.Text = ("Bienvenido " + Session.nombre + "!");

            tipoUsuario = Session.id_tipo;

            if(tipoUsuario == 1)
            {
                this.menuUsuarios.Visible = false;

            }
            else if (tipoUsuario == 2)
            {
                this.menuUsuarios.Visible = false;
                btnAsignar.Enabled = false;
                this.menuUsuariosA.Visible = false;
            }
            else
            {
                this.menuUsuarios.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            i.Show();
            this.Hide();
        }

        private void subMenuRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(this);
            registro.Show();
            this.Hide();

        }

        private void menuCerrarSesion_Click(object sender, EventArgs e)
        {
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
            this.Close();

            Login login = new Login();
            login.Visible = true;

            Session session = new Session();
        }

        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            AgregarProducto a = new AgregarProducto();
            a.Visible = true;
            this.Close();
        }

        private void subMenuUsuariosA_Click(object sender, EventArgs e)
        {
            UsuariosActivos u = new UsuariosActivos();
            u.Visible = true;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
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
            this.Close();
        }

        private void menuUsuariosA_Click(object sender, EventArgs e)
        {
            UsuariosActivos ua = new UsuariosActivos();
            ua.Show();
            this.Hide();
        }

        private void subMenuEliminarU_Click(object sender, EventArgs e)
        {
            AlterarUsuarios au = new AlterarUsuarios();
            au.Show();
            this.Hide();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void acercaDeEliAssetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDeEliAssets ae = new AcercaDeEliAssets();
            ae.ShowDialog();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soporte s = new Soporte();
            s.ShowDialog();
        }
    }
}
