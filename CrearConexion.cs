using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioLI
{
    public partial class CrearConexion : Form
    {
        public CrearConexion()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string servidor = txtServidor.Text;
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string bd = txtBD.Text;
            string puerto = txtPuerto.Text;
            bool recordarConexion = ckRecordar.Checked;

            if (recordarConexion)
            {
                Properties.Settings.Default.UltimoUser = usuario;
                Properties.Settings.Default.UltimoPass = password;
                Properties.Settings.Default.UltimoServer = servidor;
                Properties.Settings.Default.UltimoBD = bd;
                Properties.Settings.Default.UltimoPort = puerto;
                Properties.Settings.Default.Save();
            }
            else
            {
                // Borrar las propiedades de usuario y contraseña guardadas
                Properties.Settings.Default.UltimoUser = "";
                Properties.Settings.Default.UltimoPass = "";
                Properties.Settings.Default.UltimoServer = "";
                Properties.Settings.Default.UltimoBD = "";
                Properties.Settings.Default.UltimoPort = "";
                Properties.Settings.Default.Save();
            }

            Conexion.SetConexion(servidor, usuario, password, bd, puerto);
            MessageBox.Show("La conexión a la base de datos fue exitosa.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            // Abrir el formulario Login
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void CrearConexion_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UltimoServer))
            {
                txtServidor.Text = Properties.Settings.Default.UltimoServer;
                txtUsuario.Text = Properties.Settings.Default.UltimoUser;
                txtPassword.Text = Properties.Settings.Default.UltimoPass;
                txtBD.Text = Properties.Settings.Default.UltimoBD;
                txtPuerto.Text = Properties.Settings.Default.UltimoPort;
                ckRecordar.Checked = true;
            }
        }

        private void ckMostrar_CheckedChanged(object sender, EventArgs e)
        {

            if (ckMostrar.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
