using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioLI
{
    class Usuarios
    {
        int id, id_tipo;
        string usuario, contraseña, Rcontraseña, nombre, correo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Rcontraseña1 { get => Rcontraseña; set => Rcontraseña = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id { get => id; set => id = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
