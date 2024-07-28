using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InventarioLI
{
    class Control
    {
        public string ctrlRegistro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Contraseña) || string.IsNullOrEmpty(usuario.Nombre) ||
                string.IsNullOrEmpty(usuario.Rcontraseña1) || string.IsNullOrEmpty(usuario.Correo) || usuario.Id_tipo == 0)
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if(usuario.Contraseña == usuario.Rcontraseña1)
                {
                    if(modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Contraseña = generarSHA1(usuario.Contraseña);
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }

        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todo los campos";
            }
            else
            {
                datosUsuario = modelo.porUsuario(usuario);

                if(datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if(datosUsuario.Contraseña != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                    else
                    {
                        Session.id = datosUsuario.Id;
                        Session.usuario = usuario;
                        Session.nombre = datosUsuario.Nombre;
                        Session.correo = datosUsuario.Correo;
                        Session.id_tipo = datosUsuario.Id_tipo;
                    }
                }
            }
            return respuesta;
        }

        public string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if(result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }
    }
}
