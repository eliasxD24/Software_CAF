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
using System.Net;
using System.Net.Mail;

namespace InventarioLI
{
    public partial class RecuperarContra : Form
    {
        public RecuperarContra()
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

        private void btnEnviarC_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRcorreo.Text))
            {
                MessageBox.Show("Por favor, introduzca un correo");
                return;                    
            }

            string correo = txtRcorreo.Text;

            MySqlConnection connection = Conexion.getConexion();
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM usuarios WHERE correo = @correo", connection);
            command.Parameters.AddWithValue("@correo", correo);
            connection.Open();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            if (count == 0)
            {
                // El correo no existe
                MessageBox.Show("El correo no existe");
            }
            else
            {
                // El correo existe, envía un correo electrónico al usuario
                // Para enviar correos electrónicos, puedes usar la biblioteca System.Net.Mail
                using (MailMessage message = new MailMessage("tu_correo@gmail.com", correo))
                {
                    message.Subject = "Recuperación de contraseña";
                    message.Body = "Por favor, complete el siguiente formulario para restablecer su contraseña: [aquí iría el formulario HTML]";

                    // Agrega un formulario HTML al cuerpo del correo electrónico
                    // Aquí podrías usar una plantilla HTML que muestre un formulario para restablecer la contraseña
                    // El formulario podría incluir campos para la nueva contraseña y la confirmación de la contraseña
                    // También podrías incluir un enlace que lleve al usuario a una página web donde pueda restablecer su contraseña

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("tu_correo@gmail.com", "tu_contrasena");
                    client.Send(message);
                }

                MessageBox.Show("Le hemos enviado un formulario para recuperar la contraseña a su correo");
            }
        }
    }
}
