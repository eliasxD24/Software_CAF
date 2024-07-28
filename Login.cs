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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            btnOlvido.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro r = new Registro(this);
            r.Show();
            this.Hide();
      
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtContraseña.Text;
            bool recordarUsuario = boxRecordar.Checked;

            try
            {
                Control ctrl = new Control();
                string respuesta = ctrl.ctrlLogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Guardar el último usuario y contraseña si el checkbox está marcado
                    if (recordarUsuario)
                    {
                        Properties.Settings.Default.UltimoUsuario = usuario;
                        Properties.Settings.Default.UltimaContra = password;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        // Borrar las propiedades de usuario y contraseña guardadas
                        Properties.Settings.Default.UltimoUsuario = "";
                        Properties.Settings.Default.UltimaContra = "";
                        Properties.Settings.Default.Save();
                    }
                    
                    using (MySqlConnection connection = Conexion.getConexion())
                    {
                        connection.Open();

                        // Actualizar el estado del usuario
                        string query = "UPDATE usuarios SET estado = 'Activo' WHERE usuario = @usuario";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                            command.ExecuteNonQuery();
                        }
                    }

                    ActivosFijos frm = new ActivosFijos();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ckMostrar_CheckedChanged(object sender, EventArgs e)
        {

            if (ckMostrar.Checked )
            {
                txtContraseña.UseSystemPasswordChar = false;
           
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
              
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Establecer el usuario y contraseña guardados si existen
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UltimoUsuario))
            {
                txtUsuario.Text = Properties.Settings.Default.UltimoUsuario;
                txtContraseña.Text = Properties.Settings.Default.UltimaContra;
                boxRecordar.Checked = true;
            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOlvido_Click(object sender, EventArgs e)
        {
            RecuperarContra rc = new RecuperarContra();
            rc.Show();
            this.Hide();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            CrearConexion cc = new CrearConexion();
            cc.Show();
            this.Hide();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}