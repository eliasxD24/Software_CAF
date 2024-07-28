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
    public partial class Registro : Form
    {
        private Form origen;
        public Registro(Form origen)
        {
            InitializeComponent();
            this.origen = origen;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Usuario = frmUsuario.Text;
            usuario.Contraseña = frmContraseña.Text;
            usuario.Rcontraseña1 = frmContraseñaR.Text;
            usuario.Nombre = frmNombre.Text;
            usuario.Correo = frmCorreo.Text;

            if (boxTipo.SelectedIndex != -1)
    {
        if (boxTipo.Text == "Administrador")
        {
            usuario.Id_tipo = 1;
        }
        else
        {
            usuario.Id_tipo = 2;
        }
    }
    else
    {
        MessageBox.Show("Debe seleccionar un tipo de usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }

            try
            {

                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario Registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver1_Click(object sender, EventArgs e)
        {
            if (origen is ActivosFijos)
            {
                ActivosFijos activosFijos = (ActivosFijos)origen;
                activosFijos.Show();
                this.Close();
            }
            else if (origen is Login)
            {
                Login login = (Login)origen;
                login.Show();
                this.Close();
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
