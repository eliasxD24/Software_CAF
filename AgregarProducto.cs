using MySql.Data.MySqlClient;
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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            li4.Visible = false;
            boxInternado4.Visible = false;
            li3.Visible = false;
            boxInternado3.Visible = false;
            boxInternado2.Visible = false;
            li2.Visible = false;
            li.Visible = false;
            boxInternado.Visible = false;
            lO3.Visible = false;
            lA3.Visible = false;
            btnEliminarAyO.Visible = false;
            btnBuscarAyO2.Visible = false;
            boxAyO3.Visible = false;
            boxLujoAyO3.Visible = false;
            boxAulas3.Visible = false;
            boxOficinas3.Visible = false;
            ckSalas2.Visible = false;
            ckAyO3.Visible = false;
            btnBuscarAyO.Visible = false;
            btnModificarAyO.Visible = false;
            btnAgregarAyO.Visible = false;
            boxAulas2.Visible = false;
            boxOficinas2.Visible = false;
            lA2.Visible = false;
            lO2.Visible = false;
            boxLujoAyO2.Visible = false;
            boxAyO2.Visible = false;
            ckAyO2.Visible = false;
            ckSalas.Visible = false;
            lOV.Visible = false;
            lAV.Visible = false;
            boxOficinasV.Visible = false;
            boxAulasV.Visible = false;
            boxOficinas.Visible = false;
            boxAulas.Visible = false;
            lO.Visible = false;
            lA.Visible = false;
            t25.Visible = false;
            t26.Visible = false;
            t27.Visible = false;
            t28.Visible = false;
            txtRetirador.Visible = false;
            txtIngreso.Visible = false;
            boxTipo.Visible = false;
            txtDevolucion.Visible = false;

            t29.Visible = false;
            t30.Visible = false;
            t31.Visible = false;
            t32.Visible = false;
            txtRetirador2.Visible = false;
            txtIngreso2.Visible = false;
            boxTipo2.Visible = false;
            txtDevolucion2.Visible = false;

            t33.Visible = false;
            t34.Visible = false;
            t35.Visible = false;
            t36.Visible = false;
            txtRetirador3.Visible = false;
            txtIngreso3.Visible = false;
            boxTipo3.Visible = false;
            txtDevolucion3.Visible = false;

            t44.Visible = false;
            boxLugarSalas.Visible = false;
            t45.Visible = false;

            t50.Visible = false;
            t51.Visible = false;
            t52.Visible = false;
            t53.Visible = false;
            t54.Visible = false;
            t55.Visible = false;

            txtProductoSala.Visible = false;
            boxRubroSala.Visible = false;
            txtSerieSala.Visible = false;
            txtCantidadSala.Visible = false;
            boxEstadoSala.Visible = false;
            txtObservacionesSala.Visible = false;
            boxSalasLujo.Visible = false;

            boxSalasCM.Visible = false;
            boxSalasE.Visible = false;
            boxSalasMA.Visible = false;
            boxSalasMI.Visible = false;
            boxSalasTC.Visible = false;

            LlenarComboBoxSalas();
            LlenarComboBoxSalas2();
            LlenarComboBoxSalas3();
            LlenarComboBoxSalas4();

            btnAgregar2.Visible = false;

            boxLugarSala2.Visible = false;

            t60.Visible = false;
            t61.Visible = false;
            t62.Visible = false;
            t63.Visible = false;
            t64.Visible = false;
            t65.Visible = false;
            t73.Visible = false;
            t67.Visible = false;
            t66.Visible = false;

            txtProductoSala2.Visible = false;
            boxRubroSala2.Visible = false;
            txtSerieSala2.Visible = false;
            txtCantidadSala2.Visible = false;
            boxEstadoSala2.Visible = false;
            txtObservacionesSala2.Visible = false;
            boxSalasLujo2.Visible = false;
            txtSerieSalaB.Visible = false;

            boxSalasCM2.Visible = false;
            boxSalasE2.Visible = false;
            boxSalasMA2.Visible = false;
            boxSalasMI2.Visible = false;
            boxSalasTC2.Visible = false;

            btnEliminar2.Visible = false;
            btnBuscarSalas.Visible = false;

            btnModificar2.Visible = false;

            boxLugarSala3.Visible = false;

            t80.Visible = false;
            t81.Visible = false;
            t82.Visible = false;
            t83.Visible = false;
            t84.Visible = false;
            t85.Visible = false;
            t93.Visible = false;
            t87.Visible = false;
            t86.Visible = false;

            txtProductoSala3.Visible = false;
            boxRubroSala3.Visible = false;
            txtSerieSala3.Visible = false;
            txtCantidadSala3.Visible = false;
            boxEstadoSala3.Visible = false;
            txtObservacionesSala3.Visible = false;
            boxSalasLujo3.Visible = false;
            txtSerieSalaB2.Visible = false;

            boxSalasCM3.Visible = false;
            boxSalasE3.Visible = false;
            boxSalasMA3.Visible = false;
            boxSalasMI3.Visible = false;
            boxSalasTC3.Visible = false;

            btnBuscarSalas2.Visible = false;

            ckSalas4.Visible = false;
            boxTallerSalas.Visible = false;
            boxLujo.Visible = false;
            tSalas.Visible = false;

            boxSalasCM5.Visible = false;
            boxSalasE5.Visible = false;
            boxSalasMA5.Visible = false;
            boxSalasMI5.Visible = false;
            boxSalasTC5.Visible = false;

            txtInterno1.Visible = false;
            t101.Visible = false;
            txtInterno2.Visible = false;
            t102.Visible = false;
            txtInterno3.Visible = false;
            t103.Visible = false;

            boxRubroBS1.Visible = false;
            boxRubroBS2.Visible = false;

            ckSalas3.Visible = false;
            ckAyO.Visible = false;

            boxAyO.Visible = false;
            boxLujoAyO.Visible = false;
        }

        private void btnVolver3_Click(object sender, EventArgs e)
        {
            pnlAgregar.Visible = false;
            btnVolver6.Visible = true;
        }

        private void boxSectores2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarBoxDepartamentos();
        }

        private void btnVer2_Click(object sender, EventArgs e)
        {
            if (boxSectores2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Sector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ckSalas4.Checked)
            {
                if (boxTallerSalas.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione el lugar de donde quiere ver las salas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz")
                {
                    if (boxSalasMA5.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameMA = boxSalasMA5.SelectedItem.ToString();
                    DataTable tableMA = GetTable(tableNameMA);
                    dataInventario2.DataSource = tableMA;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas")
                {
                    if (boxSalasCM5.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameCM = boxSalasCM5.SelectedItem.ToString();
                    DataTable tableCM = GetTable(tableNameCM);
                    dataInventario2.DataSource = tableCM;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Electricidad")
                {
                    if (boxSalasE5.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameE = boxSalasE5.SelectedItem.ToString();
                    DataTable tableE = GetTable(tableNameE);
                    dataInventario2.DataSource = tableE;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial")
                {
                    if (boxSalasMI5.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameMI = boxSalasMI5.SelectedItem.ToString();
                    DataTable tableMI = GetTable(tableNameMI);
                    dataInventario2.DataSource = tableMI;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion")
                {
                    if (boxSalasTC5.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameTC = boxSalasTC5.SelectedItem.ToString();
                    DataTable tableTC = GetTable(tableNameTC);
                    dataInventario2.DataSource = tableTC;
                }
            }
            else
            {
                if (boxDepartamentos2.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedDepartamento = boxDepartamentos2.SelectedItem.ToString();

                if (selectedDepartamento == "Aulas")
                {
                    if (boxAulasV.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un aula");
                        return;
                    }

                    string tableNameA = boxAulasV.SelectedItem.ToString();
                    DataTable tableA = GetTable(tableNameA);
                    dataInventario2.DataSource = tableA;
                }
                else if (selectedDepartamento == "Oficinas")
                {
                    if (boxOficinasV.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una oficina");
                        return;
                    }

                    string tableNameO = boxOficinasV.SelectedItem.ToString();
                    DataTable tableO = GetTable(tableNameO);
                    dataInventario2.DataSource = tableO;
                }
                else if (selectedDepartamento == "Internado")
                {
                    if (boxInternado.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una ubicacion");
                        return;
                    }

                    string tableNameI = boxInternado.SelectedItem.ToString();
                    DataTable tableI = GetTable(tableNameI);
                    dataInventario2.DataSource = tableI;
                }
                else
                {
                    string tableName = selectedDepartamento;
                    DataTable table = GetTable(tableName);
                    dataInventario2.DataSource = table;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener la opción seleccionada en el combobox boxSectores
            string sector = boxSectores4.SelectedItem?.ToString();

            if (sector == "Inventario General" && (string.IsNullOrEmpty(txtActual.Text) || string.IsNullOrEmpty(txtTipo.Text)
                || string.IsNullOrEmpty(txtEspecie.Text) || boxRubro.SelectedIndex == -1 || boxEstado.SelectedIndex == -1
                || string.IsNullOrEmpty(txtResponsable.Text) || string.IsNullOrEmpty(txtTalleres.Text)
                || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtValor.Text)
                || string.IsNullOrEmpty(txtFecha.Text) || string.IsNullOrEmpty(txtOrigen.Text) || string.IsNullOrEmpty(txtRut2.Text) 
                || string.IsNullOrEmpty(txtEstablecimiento2.Text)))
            {
                MessageBox.Show("Por favor, llene todos los campos antes de agregar datos.");
                return;
            }

            if ((sector == "Materiales de Escritorio") && (string.IsNullOrEmpty(txtActual.Text) || string.IsNullOrEmpty(txtEspecie.Text)
                || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtRetirador2.Text)
                || string.IsNullOrEmpty(txtIngreso2.Text) || boxTipo2.SelectedIndex == -1
                || boxRubro.SelectedIndex == -1 || string.IsNullOrEmpty(txtRut2.Text)
                || string.IsNullOrEmpty(txtEstablecimiento2.Text)))
            {
                MessageBox.Show("Por favor, llene todos los campos antes de agregar datos.");
                return;
            }

            if ((sector == "Materiales de Aseo") && (string.IsNullOrEmpty(txtActual.Text) || string.IsNullOrEmpty(txtEspecie.Text)
                || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtRetirador2.Text)
                || string.IsNullOrEmpty(txtIngreso2.Text) || boxTipo2.SelectedIndex == -1 || string.IsNullOrEmpty(txtRut2.Text)
                || string.IsNullOrEmpty(txtEstablecimiento2.Text)))
            {
                MessageBox.Show("Por favor, llene todos los campos antes de agregar datos.");
                return;
            }

                MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string tableName = boxLugar2.SelectedItem?.ToString();
            if(string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Por favor, seleccione una opción en el lugar.");
                return;
            }

            if(boxSectores4.SelectedItem.ToString() == "Materiales de Aseo")
            {
                string verificaSql = $"SELECT COUNT(*) FROM {tableName} WHERE NºActual = @NºActual";
                MySqlCommand verificaCommand = new MySqlCommand(verificaSql, conexion);
                verificaCommand.Parameters.Add(new MySqlParameter("@NºActual", txtActual.Text));

                int count = Convert.ToInt32(verificaCommand.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Ya existe un producto con el mismo NºActual, por favor modifíquelo para agregar el producto.");
                    conexion.Close();
                    return;
                }
            }
            else
            {
                string verificaSql = $"SELECT COUNT(*) FROM {tableName} WHERE NºActual = @NºActual AND Rubro = @Rubro";
                MySqlCommand verificaCommand = new MySqlCommand(verificaSql, conexion);
                verificaCommand.Parameters.Add(new MySqlParameter("@NºActual", txtActual.Text));
                verificaCommand.Parameters.Add(new MySqlParameter("@Rubro", boxRubro.Text));

                int count = Convert.ToInt32(verificaCommand.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Ya existe un producto con el mismo NºActual en el mismo Rubro, por favor modifíquelo para agregar el producto.");
                    conexion.Close();
                    return;
                }
            }

            string sql = ""; // Variable para almacenar la consulta SQL

            // Construir la consulta SQL dependiendo de la opción seleccionada en el combobox boxSectores
            switch (sector)
            {
                case "Inventario General":
                    sql = $"INSERT INTO {tableName} (NºAnterior, NºActual, Tipo_Especie, Descripcion_Especie, Rubro, Estado, Responsable, RUT, Nombre_de_Establecimiento, Talleres_Aulas," +
                        "Ubicacion_Fisica, Valor_Adquicision, Fecha_Adquicision, Origen, Clase) VALUES(@NºAnterior, @NºActual, @Tipo_Especie, @Descripcion_Especie, @Rubro, @Estado, @Responsable," +
                        "@RUT, @Establecimiento, @Talleres_Aulas, @Ubicacion_Fisica, @Valor_Adquicision, @Fecha_Adquicision, @Origen, @Clase)";
                    break;
                case "Materiales de Escritorio":
                    sql = $"INSERT INTO {tableName} (NºActual, Descripcion_Especie, Ubicacion_Fisica, Rubro, Retirador, RUT, Nombre_de_Establecimiento, Fecha_Ingreso, Tipo, Fecha_Devolucion, Clase) " +
                        "VALUES(@NºActual, @Descripcion_Especie, @Ubicacion_Fisica, @Rubro, @Retirador, @RUT, @Establecimiento, @Fecha_Ingreso, @Tipo, @Fecha_Devolucion, @Clase)";
                    break;
                case "Materiales de Aseo":
                    sql = $"INSERT INTO {tableName} (NºActual, Descripcion_Especie, Ubicacion_Fisica, Retirador, RUT, Nombre_de_Establecimiento, Fecha_Ingreso, Tipo, Fecha_Devolucion) " +
                        "VALUES(@NºActual, @Descripcion_Especie, @Ubicacion_Fisica, @Retirador, @RUT, @Establecimiento, @Fecha_Ingreso, @Tipo, @Fecha_Devolucion)";
                    break;
                default:
                    MessageBox.Show("Opción de sector no válida.");
                    return;
            }

            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.Add(new MySqlParameter("@NºAnterior", txtAnterior.Text));
            command.Parameters.Add(new MySqlParameter("@NºActual", txtActual.Text));
            command.Parameters.Add(new MySqlParameter("@Tipo_Especie", txtTipo.Text));
            command.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie.Text));
            command.Parameters.Add(new MySqlParameter("@Rubro", boxRubro.Text));
            command.Parameters.Add(new MySqlParameter("@Estado", boxEstado.Text));
            command.Parameters.Add(new MySqlParameter("@Responsable", txtResponsable.Text));
            command.Parameters.Add(new MySqlParameter("@Talleres_Aulas", txtTalleres.Text));
            command.Parameters.Add(new MySqlParameter("@Ubicacion_Fisica", txtUbicacion.Text));
            command.Parameters.Add(new MySqlParameter("@Valor_Adquicision", txtValor.Text));
            command.Parameters.Add(new MySqlParameter("@Fecha_Adquicision", txtFecha.Text));
            command.Parameters.Add(new MySqlParameter("@Origen", txtOrigen.Text));
            command.Parameters.Add(new MySqlParameter("@Retirador", txtRetirador2.Text));
            command.Parameters.Add(new MySqlParameter("@Fecha_Ingreso", txtIngreso2.Text));
            command.Parameters.Add(new MySqlParameter("@Tipo", boxTipo2.Text));
            command.Parameters.Add(new MySqlParameter("@Fecha_Devolucion", txtDevolucion2.Text));
            command.Parameters.Add(new MySqlParameter("@Clase", boxClase2.Text));
            command.Parameters.Add(new MySqlParameter("@RUT", txtRut2.Text));
            command.Parameters.Add(new MySqlParameter("@Establecimiento", txtEstablecimiento2.Text));

            string query = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

            using (MySqlConnection conn = Conexion.getConexion())
            using (MySqlCommand comando = new MySqlCommand(query, conn))
            {
                comando.Parameters.Add(new MySqlParameter("@NºActual", txtActual.Text));
                comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie.Text));
                comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                comando.Parameters.Add(new MySqlParameter("@Alteracion", "Agregado"));
                comando.Parameters.Add(new MySqlParameter("@Tabla", boxLugar2.Text));
                comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                conn.Open();
                comando.ExecuteNonQuery();
            }
            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Datos Insertados Correctamente");
                    
                }
                else
                {
                    MessageBox.Show("No se pudo insertar los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.Message);
            }

            conexion.Close();
        }
    

        private void btnirAgregar_Click(object sender, EventArgs e)
        {
            pnlAgregar.Visible = !pnlAgregar.Visible;
            btnVolver6.Visible = false;
        }

        private void btnirEliminar_Click(object sender, EventArgs e)
        {
            pnlEliminar.Visible = !pnlEliminar.Visible;
            btnVolver6.Visible = false;
        }

        private void btnirModificar_Click(object sender, EventArgs e)
        {
            pnlModificar.Visible = !pnlModificar.Visible;
            btnVolver6.Visible = false;
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            pnlAgregar.Visible = false;
            pnlModificar.Visible = false;
            pnlEliminar.Visible = false;
        }

        private void btnVolver4_Click(object sender, EventArgs e)
        {
            pnlEliminar.Visible = false;
            btnVolver6.Visible = true;
        }

        private void btnVolver6_Click(object sender, EventArgs e)
        {
            ActivosFijos a = new ActivosFijos();
            a.Show();
            this.Hide();
        }

        private void boxSectores3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ActualizarBoxLugar(boxLugar, boxSectores3);

        }

        private void boxSectores4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBoxLugar(boxLugar2, boxSectores4);
        }

        private void btnBuscar2_Click_1(object sender, EventArgs e)
        {
            if(boxSectores3.SelectedItem.ToString() == "Materiales de Aseo")
            {
                if (string.IsNullOrEmpty(boxLugar.Text) || string.IsNullOrEmpty(txtActual2.Text))
                {
                    MessageBox.Show("Por favor, inserte un NºActual");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(boxLugar.Text) || string.IsNullOrEmpty(txtActual2.Text) || boxRubroB1.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, inserte un NºActual y el Rubro.");
                    return;
                }
            }

            string rubro = boxRubroB1.Text;
            string codigo = txtActual2.Text;
            string sector = boxSectores3.Text;
            string tabla = boxLugar.Text;
            MySqlDataReader reader = null;

            string sql = "";
            if (sector == "Inventario General")
            {
                sql = "SELECT NºActual, NºAnterior, Tipo_Especie, Descripcion_Especie, Rubro, Estado, Responsable, RUT, Nombre_de_Establecimiento, Talleres_Aulas, Ubicacion_Fisica, " +
                "Valor_Adquicision, Fecha_Adquicision, Origen, Clase FROM " + tabla + " WHERE NºActual LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1";
            }
            else if (sector == "Materiales de Escritorio")
            {
                sql = "SELECT NºActual, Descripcion_Especie, Ubicacion_Fisica, Rubro, Retirador, RUT, Nombre_de_Establecimiento, Fecha_Ingreso, Tipo, Fecha_Devolucion, Clase FROM " + tabla + " WHERE NºActual LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1";
            }
            else if (sector == "Materiales de Aseo")
            {
                sql = "SELECT NºActual, Descripcion_Especie, Ubicacion_Fisica, Retirador, RUT, Nombre_de_Establecimiento, Fecha_Ingreso, Tipo, Fecha_Devolucion FROM " + tabla + " WHERE NºActual LIKE '" + codigo + "' LIMIT 1";
            }
            else
            {
                MessageBox.Show("Seleccione un sector válido.");
                return;
            }

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexion);
                reader = command.ExecuteReader();
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string sectores = boxSectores3.Text;
                        if (sectores == "Inventario General")
                        {
                            txtActual3.Text = reader.GetString(0);
                            txtAnterior2.Text = reader.GetString(1);
                            txtTipo2.Text = reader.GetString(2);
                            txtEspecie2.Text = reader.GetString(3);
                            boxRubro2.Text = reader.GetString(4);
                            boxEstado2.Text = reader.GetString(5);
                            txtResponsable2.Text = reader.GetString(6);
                            txtRut3.Text = reader.GetString(7);
                            txtEstablecimiento3.Text = reader.GetString(8);
                            txtTalleres2.Text = reader.GetString(9);
                            txtUbicacion2.Text = reader.GetString(10);
                            txtValor2.Text = reader.GetString(11);
                            txtFecha2.Text = reader.GetString(12);
                            txtOrigen2.Text = reader.GetString(13);
                            boxClase1.Text = reader.GetString(14);
                        }
                        else if (sectores == "Materiales de Escritorio")
                        {
                            txtActual3.Text = reader.GetString(0);
                            txtEspecie2.Text = reader.GetString(1);
                            txtUbicacion2.Text = reader.GetString(2);
                            boxRubro2.Text = reader.GetString(3);
                            txtRetirador.Text = reader.GetString(4);
                            txtRut3.Text = reader.GetString(5);
                            txtEstablecimiento3.Text = reader.GetString(6);
                            txtIngreso.Text = reader.GetString(7);
                            boxTipo.Text = reader.GetString(8);
                            txtDevolucion.Text = reader.GetString(9);
                            boxClase1.Text = reader.GetString(10);
                        }
                        else if (sectores == "Materiales de Aseo")
                        {
                            txtActual3.Text = reader.GetString(0);
                            txtEspecie2.Text = reader.GetString(1);
                            txtUbicacion2.Text = reader.GetString(2);
                            txtRetirador.Text = reader.GetString(3);
                            txtRut3.Text = reader.GetString(4);
                            txtEstablecimiento3.Text = reader.GetString(5);
                            txtIngreso.Text = reader.GetString(6);
                            boxTipo.Text = reader.GetString(7);
                            txtDevolucion.Text = reader.GetString(8);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            string sector = boxSectores3.SelectedItem?.ToString();
            
            if(boxSectores3.SelectedItem.ToString() == "Materiales de Aseo")
            {
                if (string.IsNullOrEmpty(txtActual2.Text))
                {
                    MessageBox.Show("Por favor, ingrese un valor para el NºActual.");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtActual2.Text) || boxRubroB1.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, ingrese un valor para el NºActual y el Rubro.");
                    return;
                }
            }

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string tableName = boxLugar.SelectedItem.ToString();
            string sql = ""; // Variable para almacenar la consulta SQL

            // Construir la consulta SQL dependiendo de la opción seleccionada en el combobox boxSectores
            switch (sector)
            {
                case "Inventario General":
                    sql = $"UPDATE {tableName} SET NºActual=@NºActual, NºAnterior=@NºAnterior, Tipo_Especie=@Tipo_Especie, Descripcion_Especie=@Descripcion_Especie, Rubro=@Rubro, Estado=@Estado, Responsable=@Responsable, RUT=@RUT, Nombre_de_Establecimiento=@Establecimiento, Talleres_Aulas=@Talleres_Aulas," +
                        $" Ubicacion_Fisica=@Ubicacion_Fisica, Valor_Adquicision=@Valor_Adquicision, Fecha_Adquicision=@Fecha_Adquicision, Origen=@Origen, Clase=@Clase WHERE NºActual=@NºActual2 AND Rubro=@Rubro2";
                    break;
                case "Materiales de Escritorio":
                    sql = $"UPDATE {tableName} SET NºActual=@NºActual, Descripcion_Especie=@Descripcion_Especie, Ubicacion_Fisica=@Ubicacion_Fisica, Rubro=@Rubro, Retirador=@Retirador, RUT=@RUT, Nombre_de_Establecimiento=@Establecimiento, Fecha_Ingreso=@Fecha_Ingreso, Tipo=@Tipo, Fecha_Devolucion=@Fecha_Devolucion, Clase=@Clase WHERE NºActual=@NºActual2 AND Rubro=@Rubro2";
                    break;
                case "Materiales de Aseo":
                    sql = $"UPDATE {tableName} SET NºActual=@NºActual, Descripcion_Especie=@Descripcion_Especie, Ubicacion_Fisica=@Ubicacion_Fisica, Retirador=@Retirador, RUT=@RUT, Nombre_de_Establecimiento=@Establecimiento, Fecha_Ingreso=@Fecha_Ingreso, Tipo=@Tipo, Fecha_Devolucion=@Fecha_Devolucion WHERE NºActual=@NºActual2";
                    break;
                default:
                    MessageBox.Show("Opción de sector no válida.");
                    return;
            }

            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.Add(new MySqlParameter("@Rubro2", boxRubroB1.Text));
            command.Parameters.Add(new MySqlParameter("@NºAnterior", txtAnterior2.Text));
            command.Parameters.Add(new MySqlParameter("@NºActual", txtActual3.Text));
            command.Parameters.Add(new MySqlParameter("@NºActual2", txtActual2.Text));
            command.Parameters.Add(new MySqlParameter("@Tipo_Especie", txtTipo2.Text));
            command.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie2.Text));
            command.Parameters.Add(new MySqlParameter("@Rubro", boxRubro2.Text));
            command.Parameters.Add(new MySqlParameter("@Estado", boxEstado2.Text));
            command.Parameters.Add(new MySqlParameter("@Responsable", txtResponsable2.Text));
            command.Parameters.Add(new MySqlParameter("@RUT", txtRut3.Text));
            command.Parameters.Add(new MySqlParameter("@Establecimiento", txtEstablecimiento3.Text));
            command.Parameters.Add(new MySqlParameter("@Talleres_Aulas", txtTalleres2.Text));
            command.Parameters.Add(new MySqlParameter("@Ubicacion_Fisica", txtUbicacion2.Text));
            command.Parameters.Add(new MySqlParameter("@Valor_Adquicision", txtValor2.Text));
            command.Parameters.Add(new MySqlParameter("@Fecha_Adquicision", txtFecha2.Text));
            command.Parameters.Add(new MySqlParameter("@Origen", txtOrigen2.Text));
            command.Parameters.Add(new MySqlParameter("@Retirador", txtRetirador.Text));
            command.Parameters.Add(new MySqlParameter("@Fecha_Ingreso", txtIngreso.Text));
            command.Parameters.Add(new MySqlParameter("@Tipo", boxTipo.Text));
            command.Parameters.Add(new MySqlParameter("@Fecha_Devolucion", txtDevolucion.Text));
            command.Parameters.Add(new MySqlParameter("@Clase", boxClase1.Text));



            string query = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

            using (MySqlConnection conn = Conexion.getConexion())
            using (MySqlCommand comando = new MySqlCommand(query, conn))
            {
                comando.Parameters.Add(new MySqlParameter("@NºActual", txtActual3.Text));
                comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie2.Text));
                comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                comando.Parameters.Add(new MySqlParameter("@Alteracion", "Modificado"));
                comando.Parameters.Add(new MySqlParameter("@Tabla", boxLugar.Text));
                comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                conn.Open();
                comando.ExecuteNonQuery();
            }

            try
            {
                MySqlCommand commando = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Modificado");
                txtAnterior2.Clear();
                txtActual3.Clear();
                txtTipo2.Clear();
                txtEspecie2.Clear();
                boxRubro2.SelectedIndex = -1;
                boxEstado2.SelectedIndex = -1;
                txtResponsable2.Clear();
                txtRut3.Clear();
                txtEstablecimiento3.Clear();
                txtTalleres2.Clear();
                txtUbicacion2.Clear();
                txtValor2.Clear();
                txtFecha2.Clear();
                txtOrigen2.Clear();
                txtActual2.Clear();
                boxClase1.SelectedIndex = -1;
                txtRetirador.Clear();
                txtIngreso.Clear();
                boxTipo.SelectedIndex = -1;
                txtDevolucion.Clear();
                boxRubroB1.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnVolver5_Click_1(object sender, EventArgs e)
        {
            pnlModificar.Visible = false;
            btnVolver6.Visible = true;

            txtActual3.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener la opción seleccionada en el combobox boxSectores
            string sector = boxSectores6.SelectedItem.ToString();

            if(boxSectores6.SelectedItem.ToString() == "Materiales de Aseo")
            {
                if (string.IsNullOrEmpty(txtActual4.Text))
                {
                    MessageBox.Show("Por favor, ingrese un valor para el NºActual.");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtActual4.Text) || boxRubroB2.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, ingrese un valor para el NºActual y el Rubro.");
                    return;
                }
            }

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string tableName = boxLugar3.SelectedItem.ToString();
            string sql = ""; // Variable para almacenar la consulta SQL

            // Construir la consulta SQL dependiendo de la opción seleccionada en el combobox boxSectores
            switch (sector)
            {
                case "Inventario General":
                    sql = $"DELETE FROM {tableName} WHERE NºActual = @NºActual AND Rubro = @Rubro";
                    break;
                case "Materiales de Escritorio":
                    sql = $"DELETE FROM {tableName} WHERE NºActual = @NºActual AND Rubro = @Rubro";
                    break;
                case "Materiales de Aseo":
                    sql = $"DELETE FROM {tableName} WHERE NºActual = @NºActual";
                    break;
                default:
                    MessageBox.Show("Opción de sector no válida.");
                    return;
            }

            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.Add(new MySqlParameter("@NºActual", txtActual4.Text));
            command.Parameters.Add(new MySqlParameter("@Rubro", boxRubroB2.Text));

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el NºActual proporcionado.");
            }

            string query = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

            using (MySqlConnection conn = Conexion.getConexion())
            using (MySqlCommand comando = new MySqlCommand(query, conn))
            {
                comando.Parameters.Add(new MySqlParameter("@NºActual", txtActual4.Text));
                comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie3.Text));
                comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                comando.Parameters.Add(new MySqlParameter("@Alteracion", "Eliminado"));
                comando.Parameters.Add(new MySqlParameter("@Tabla", boxLugar3.Text));
                comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                conn.Open();
                comando.ExecuteNonQuery();
            }

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                txtAnterior3.Clear();
                txtActual4.Clear();
                txtTipo3.Clear();
                txtEspecie3.Clear();
                boxRubro3.SelectedIndex = -1;
                boxEstado3.SelectedIndex = -1;
                txtResponsable3.Clear();
                txtTalleres3.Clear();
                txtUbicacion3.Clear();
                txtValor3.Clear();
                txtFecha3.Clear();
                txtOrigen3.Clear();
                txtActual5.Clear();
                txtRetirador3.Clear();
                txtIngreso3.Clear();
                boxTipo3.SelectedIndex = -1;
                txtDevolucion3.Clear();
                boxClase3.SelectedIndex = -1;
                txtRut1.Clear();
                txtEstablecimiento1.Clear();
                boxRubroB2.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            if(boxSectores6.SelectedItem.ToString() == "Materiales de Aseo")
            {
                if (string.IsNullOrEmpty(boxLugar3.Text) || string.IsNullOrEmpty(txtActual4.Text))
                {
                    MessageBox.Show("Por favor, coloque el NºActual para buscar el producto");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(boxLugar3.Text) || string.IsNullOrEmpty(txtActual4.Text) || boxRubroB2.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, coloque un NºActual y el Rubro para buscar el producto.");
                    return;
                }
            }

            string rubro = boxRubroB2.Text;
            string codigo = txtActual4.Text;
            string sector = boxSectores6.Text;
            string tabla = boxLugar3.Text;
            MySqlDataReader reader = null;

            string sql = "";
            if (sector == "Inventario General")
            {
                sql = "SELECT NºActual, NºAnterior, Tipo_Especie, Descripcion_Especie, Rubro, Estado, Responsable, RUT, Nombre_de_Establecimiento, Talleres_Aulas, Ubicacion_Fisica, " +
                "Valor_Adquicision, Fecha_Adquicision, Origen, Clase FROM " + tabla + " WHERE NºActual LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1";
            }
            else if (sector == "Materiales de Escritorio")
            {
                sql = "SELECT NºActual, Descripcion_Especie, Ubicacion_Fisica, Rubro, Retirador, RUT, Nombre_de_Establecimiento, Fecha_Ingreso, Tipo, Fecha_Devolucion, Clase FROM " + tabla + " WHERE NºActual LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1";
            }
            else if (sector == "Materiales de Aseo")
            {
                sql = "SELECT NºActual, Descripcion_Especie, Ubicacion_Fisica, Retirador, RUT, Nombre_de_Establecimiento, Fecha_Ingreso, Tipo, Fecha_Devolucion FROM " + tabla + " WHERE NºActual LIKE '" + codigo + "' LIMIT 1";
            }
            else
            {
                MessageBox.Show("Seleccione un sector válido.");
                return;
            }

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexion);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string sectores = boxSectores6.Text;
                        if (sectores == "Inventario General")
                        {
                            txtActual5.Text = reader.GetString(0);
                            txtAnterior3.Text = reader.GetString(1);
                            txtTipo3.Text = reader.GetString(2);
                            txtEspecie3.Text = reader.GetString(3);
                            boxRubro3.Text = reader.GetString(4);
                            boxEstado3.Text = reader.GetString(5);
                            txtResponsable3.Text = reader.GetString(6);
                            txtRut1.Text = reader.GetString(7);
                            txtEstablecimiento1.Text = reader.GetString(8);
                            txtTalleres3.Text = reader.GetString(9);
                            txtUbicacion3.Text = reader.GetString(10);
                            txtValor3.Text = reader.GetString(11);
                            txtFecha3.Text = reader.GetString(12);
                            txtOrigen3.Text = reader.GetString(13);
                            boxClase3.Text = reader.GetString(14);
                        }
                        else if (sectores == "Materiales de Escritorio")
                        {
                            txtActual5.Text = reader.GetString(0);
                            txtEspecie3.Text = reader.GetString(1);
                            txtUbicacion3.Text = reader.GetString(2);
                            boxRubro3.Text = reader.GetString(3);
                            txtRetirador3.Text = reader.GetString(4);
                            txtRut1.Text = reader.GetString(5);
                            txtEstablecimiento1.Text = reader.GetString(6);
                            txtIngreso3.Text = reader.GetString(7);
                            boxTipo3.Text = reader.GetString(8);
                            txtDevolucion3.Text = reader.GetString(9);
                            boxClase3.Text = reader.GetString(10);
                        }
                        else if (sectores == "Materiales de Aseo")
                        {
                            txtActual5.Text = reader.GetString(0);
                            txtEspecie3.Text = reader.GetString(1);
                            txtUbicacion3.Text = reader.GetString(2);
                            txtRetirador3.Text = reader.GetString(3);
                            txtRut1.Text = reader.GetString(4);
                            txtEstablecimiento1.Text = reader.GetString(5);
                            txtIngreso3.Text = reader.GetString(6);
                            boxTipo3.Text = reader.GetString(7);
                            txtDevolucion3.Text = reader.GetString(8);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void boxSectores6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBoxLugar(boxLugar3, boxSectores6);
        }

        private void txtAnterior3_TextChanged(object sender, EventArgs e)
        {
            txtAnterior3.ReadOnly = true;
        }

        private void txtTipo3_TextChanged(object sender, EventArgs e)
        {
            txtTipo3.ReadOnly = true;
        }

        private void txtActual5_TextChanged(object sender, EventArgs e)
        {
            txtActual5.ReadOnly = true;
        }

        private void txtEspecie3_TextChanged(object sender, EventArgs e)
        {
            txtEspecie3.ReadOnly = true;
        }

        private void boxRubro3_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxRubro3.Enabled = false;
        }

        private void boxEstado3_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxEstado3.Enabled = false;
        }

        private void txtResponsable3_TextChanged(object sender, EventArgs e)
        {
            txtResponsable3.ReadOnly = true;
        }

        private void txtTalleres3_TextChanged(object sender, EventArgs e)
        {
            txtTalleres3.ReadOnly = true;
        }

        private void txtUbicacion3_TextChanged(object sender, EventArgs e)
        {
            txtUbicacion3.ReadOnly = true;
        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {
            txtValor3.ReadOnly = true;
        }

        private void txtFecha3_TextChanged(object sender, EventArgs e)
        {
            txtFecha3.ReadOnly = true;
        }

        private void txtOrigen3_TextChanged(object sender, EventArgs e)
        {
            txtOrigen3.ReadOnly = true;
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial h = new Historial();
            h.Show();
            this.Hide();
        }

        private void ActualizarBoxLugar(ComboBox boxLugar, ComboBox boxSector)
        {    
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            boxLugar.Items.Clear();
            if (boxSector.SelectedItem.ToString() == "Inventario General")
            {
                boxLugar.Items.Add("Taller_de_Mecanica_Automotriz");
                boxLugar.Items.Add("Taller_de_Mecanica_Industrial");
                boxLugar.Items.Add("Taller_de_Construcciones_Metalicas");
                boxLugar.Items.Add("Taller_de_Terminaciones_de_la_Construccion");
                boxLugar.Items.Add("Taller_de_Electricidad");

                txtAnterior2.Enabled = true;                
                txtTipo2.Enabled = true;                    
                boxEstado2.Visible = true;                  t3.Visible = true;
                txtResponsable2.Enabled = true;             t4.Visible = true;
                txtTalleres2.Visible = true;                
                txtValor2.Enabled = true;                   t6.Visible = true;
                txtFecha2.Visible = true;                   t7.Visible = true;
                txtOrigen2.Visible = true;                  
                boxRubro2.Enabled = true;

                txtAnterior.Enabled = true;                 
                txtTipo.Enabled = true;                     
                boxEstado.Visible = true;                   t11.Visible = true;
                txtResponsable.Enabled = true;              
                txtTalleres.Visible = true;                 t13.Visible = true;
                txtValor.Enabled = true;                    
                txtFecha.Visible = true;                    t15.Visible = true;
                txtOrigen.Visible = true;                   t16.Visible = true;
                boxRubro.Enabled = true;

                txtAnterior3.Enabled = true;                
                txtTipo3.Enabled = true;                    
                boxEstado3.Visible = true;                  t19.Visible = true;
                txtResponsable3.Enabled = true;             
                txtTalleres3.Visible = true;                t21.Visible = true;
                txtValor3.Enabled = true;                   
                txtFecha3.Visible = true;                   t23.Visible = true;
                txtOrigen3.Visible = true;                  t24.Visible = true;
                boxRubro3.Enabled = true;

                t25.Visible = false;
                t26.Visible = false;
                t27.Visible = false;
                t28.Visible = false;
                txtRetirador.Visible = false;
                txtIngreso.Visible = false;
                boxTipo.Visible = false;
                txtDevolucion.Visible = false;

                t29.Visible = false;
                t30.Visible = false;
                t31.Visible = false;
                t32.Visible = false;
                txtRetirador2.Visible = false;
                txtIngreso2.Visible = false;
                boxTipo2.Visible = false;
                txtDevolucion2.Visible = false;

                t33.Visible = false;
                t34.Visible = false;
                t35.Visible = false;
                t36.Visible = false;
                txtRetirador3.Visible = false;
                txtIngreso3.Visible = false;
                boxTipo3.Visible = false;
                txtDevolucion3.Visible = false;
                boxClase1.Enabled = true;
                boxClase2.Enabled = true;
                boxClase3.Enabled = true;

                boxRubroB2.Enabled = true;
                boxRubroB1.Enabled = true;

                ckSalas3.Visible = true;
                ckAyO.Visible = true;
                ckAyO2.Visible = true;
                ckSalas.Visible = true;
                ckSalas2.Visible = true;
                ckAyO3.Visible = true;
            }
            else if (boxSector.SelectedItem.ToString() == "Materiales de Escritorio")
            {
                boxLugar.Items.Add("DeptoUTP");
                boxLugar.Items.Add("DeptoAdministracion");
                boxLugar.Items.Add("DeptoInspectoriaGeneral");
                boxLugar.Items.Add("DeptoPsicosocial");
                boxLugar.Items.Add("DeptoDireccion");
                boxLugar.Items.Add("DeptoBiblioteca");
                boxLugar.Items.Add("DeptoInternado");
                // Resto del código específico para el evento
                txtAnterior2.Enabled = false;                    
                txtTipo2.Enabled = false;                        
                boxEstado2.Visible = false;                      t3.Visible = false;
                txtResponsable2.Enabled = false;                 t4.Visible = false;
                txtTalleres2.Visible = false;                    
                txtValor2.Enabled = false;                       t6.Visible = false;
                txtFecha2.Visible = false;                       t7.Visible = false;
                txtOrigen2.Visible = false;                      
                boxRubro.Enabled = true;

                txtAnterior.Enabled = false;                    
                txtTipo.Enabled = false;                        
                boxEstado.Visible = false;                      t11.Visible = false;
                txtResponsable.Enabled = false;                 
                txtTalleres.Visible = false;                    t13.Visible = false;
                txtValor.Enabled = false;                       
                txtFecha.Visible = false;                       t15.Visible = false;
                txtOrigen.Visible = false;                      t16.Visible = false;
                boxRubro.Enabled = true;

                txtAnterior3.Enabled = false;                   
                txtTipo3.Enabled = false;                       
                boxEstado3.Visible = false;                     t19.Visible = false;
                txtResponsable3.Enabled = false;                
                txtTalleres3.Visible = false;                   t21.Visible = false;
                txtValor3.Enabled = false;                      
                txtFecha3.Visible = false;                      t23.Visible = false;
                txtOrigen3.Visible = false;                     t24.Visible = false;
                boxRubro3.Enabled = true;

                t25.Visible = true;
                t26.Visible = true;
                t27.Visible = true;
                t28.Visible = true;
                txtRetirador.Visible = true;
                txtIngreso.Visible = true;
                boxTipo.Visible = true;
                txtDevolucion.Visible = true;

                t29.Visible = true;
                t30.Visible = true;
                t31.Visible = true;
                t32.Visible = true;
                txtRetirador2.Visible = true;
                txtIngreso2.Visible = true;
                boxTipo2.Visible = true;
                txtDevolucion2.Visible = true;

                t33.Visible = true;
                t34.Visible = true;
                t35.Visible = true;
                t36.Visible = true;
                txtRetirador3.Visible = true;
                txtIngreso3.Visible = true;
                boxTipo3.Visible = true;
                txtDevolucion3.Visible = true;
                boxClase1.Enabled = true;
                boxClase2.Enabled = true;
                boxClase3.Enabled = true;

                boxRubroB2.Enabled = true;
                boxRubroB1.Enabled = true;

                ckSalas3.Visible = false;
                ckAyO.Visible = false;
                ckAyO2.Visible = false;
                ckSalas.Visible = false;

                ckSalas2.Visible = false;
                ckAyO3.Visible = false;
            }
            else if (boxSector.SelectedItem.ToString() == "Materiales de Aseo")
            {
                boxLugar.Items.Add("Liceo");
                boxLugar.Items.Add("Internado");
                // Resto del código específico para el evento
                txtAnterior2.Enabled = false;                  
                txtTipo2.Enabled = false;                       
                boxEstado2.Visible = false;                     t3.Visible = false;
                txtResponsable2.Enabled = false;                t4.Visible = false;        
                txtTalleres2.Visible = false;                   
                txtValor2.Enabled = false;                      t6.Visible = false;
                txtFecha2.Visible = false;                      t7.Visible = false;
                txtOrigen2.Visible = false;                     
                boxRubro2.Enabled = false;

                txtAnterior.Enabled = false;                    
                txtTipo.Enabled = false;                        
                boxEstado.Visible = false;                      t11.Visible = false;
                txtResponsable.Enabled = false;                 
                txtTalleres.Visible = false;                    t13.Visible = false;
                txtValor.Enabled = false;                       
                txtFecha.Visible = false;                       t15.Visible = false;
                txtOrigen.Visible = false;                      t16.Visible = false;
                boxRubro.Enabled = false;

                txtAnterior3.Enabled = false;                   
                txtTipo3.Enabled = false;                       
                boxEstado3.Visible = false;                     t19.Visible = false;
                txtResponsable3.Enabled = false;                
                txtTalleres3.Visible = false;                   t21.Visible = false;
                txtValor3.Enabled = false;                      
                txtFecha3.Visible = false;                      t23.Visible = false;
                txtOrigen3.Visible = false;                     t24.Visible = false;
                boxRubro3.Enabled = false;

                t25.Visible = true;
                t26.Visible = true;
                t27.Visible = true;
                t28.Visible = true;
                txtRetirador.Visible = true;
                txtIngreso.Visible = true;
                boxTipo.Visible = true;
                txtDevolucion.Visible = true;

                t29.Visible = true;
                t30.Visible = true;
                t31.Visible = true;
                t32.Visible = true;
                txtRetirador2.Visible = true;
                txtIngreso2.Visible = true;
                boxTipo2.Visible = true;
                txtDevolucion2.Visible = true;

                t33.Visible = true;
                t34.Visible = true;
                t35.Visible = true;
                t36.Visible = true;
                txtRetirador3.Visible = true;
                txtIngreso3.Visible = true;
                boxTipo3.Visible = true;
                txtDevolucion3.Visible = true;
                boxClase1.Enabled = false;
                boxClase2.Enabled = false;
                boxClase3.Enabled = false;

                boxRubroB2.Enabled = false;
                boxRubroB1.Enabled = false;

                ckSalas3.Visible = false;
                ckAyO.Visible = false;
                ckAyO2.Visible = false;
                ckSalas.Visible = false;

                ckSalas2.Visible = false;
                ckAyO3.Visible = false;
            }
        }

        private void ckSalas_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSectores4.SelectedItem == null && ckSalas.Checked)
            {
                    t43.Visible = false;
                    boxSectores4.Visible = false;
                    t44.Visible = true;
                    boxLugarSalas.Visible = true;
                    t45.Visible = true;
                    t46.Visible = false;
                    boxLugar2.Visible = false;

                    txtAnterior.Visible = false;
                    txtTipo.Visible = false;
                    txtActual.Visible = false;
                    txtEspecie.Visible = false;
                    boxRubro.Visible = false;
                    boxEstado.Visible = false;
                    txtResponsable.Visible = false;
                    txtTalleres.Visible = false;
                    txtUbicacion.Visible = false;
                    txtValor.Visible = false;
                    txtFecha.Visible = false;
                    txtOrigen.Visible = false;
                    boxClase2.Visible = false;

                    t9.Visible = false;
                    t10.Visible = false;
                    t47.Visible = false;
                    t48.Visible = false;
                    t38.Visible = false;
                    t11.Visible = false;
                    t12.Visible = false;
                    t13.Visible = false;
                    t14.Visible = false;
                    t49.Visible = false;
                    t15.Visible = false;
                    t16.Visible = false;
                    t41.Visible = false;

                    t50.Visible = true;
                    t51.Visible = true;
                    t52.Visible = true;
                    t53.Visible = true;
                    t54.Visible = true;
                    t55.Visible = true;

                    txtProductoSala.Visible = true;
                    boxRubroSala.Visible = true;
                    txtSerieSala.Visible = true;
                    txtCantidadSala.Visible = true;
                    boxEstadoSala.Visible = true;
                    txtObservacionesSala.Visible = true;

                boxSalasLujo.Visible = true;
                btnAgregar.Visible = false;
                btnAgregar2.Visible = true;

                t97.Visible = false;
                t98.Visible = false;
                txtRut2.Visible = false;
                txtEstablecimiento2.Visible = false;

                txtInterno1.Visible = true;
                t101.Visible = true;

                ckAyO2.Enabled = false;
            }
            else if(boxSectores4.SelectedItem == null || boxSectores4.SelectedItem.ToString() == "Inventario General" && ckSalas.Checked)
            {
                    t43.Visible = false;
                    boxSectores4.Visible = false;
                    t44.Visible = true;
                    boxLugarSalas.Visible = true;
                    t45.Visible = true;
                    t46.Visible = false;
                    boxLugar2.Visible = false;

                    txtAnterior.Visible = false;
                    txtTipo.Visible = false;
                    txtActual.Visible = false;
                    txtEspecie.Visible = false;
                    boxRubro.Visible = false;
                    boxEstado.Visible = false;
                    txtResponsable.Visible = false;
                    txtTalleres.Visible = false;
                    txtUbicacion.Visible = false;
                    txtValor.Visible = false;
                    txtFecha.Visible = false;
                    txtOrigen.Visible = false;
                    boxClase2.Visible = false;

                    t9.Visible = false;
                    t10.Visible = false;
                    t47.Visible = false;
                    t48.Visible = false;
                    t38.Visible = false;
                    t11.Visible = false;
                    t12.Visible = false;
                    t13.Visible = false;
                    t14.Visible = false;
                    t49.Visible = false;
                    t15.Visible = false;
                    t16.Visible = false;
                    t41.Visible = false;

                t50.Visible = true;
                t51.Visible = true;
                t52.Visible = true;
                t53.Visible = true;
                t54.Visible = true;
                t55.Visible = true;

                txtProductoSala.Visible = true;
                boxRubroSala.Visible = true;
                txtSerieSala.Visible = true;
                txtCantidadSala.Visible = true;
                boxEstadoSala.Visible = true;
                txtObservacionesSala.Visible = true;
                boxSalasLujo.Visible = true;
                btnAgregar.Visible = false;
                btnAgregar2.Visible = true;

                t97.Visible = false;
                t98.Visible = false;
                txtRut2.Visible = false;
                txtEstablecimiento2.Visible = false;

                txtInterno1.Visible = true;
                t101.Visible = true;

                ckAyO2.Enabled = false;
            }

            else if (boxSectores4.SelectedItem.ToString() == "Materiales de Escritorio" && ckSalas.Checked)
            {
                    t43.Visible = false;
                    boxSectores4.Visible = false;
                    t44.Visible = true;
                    boxLugarSalas.Visible = true;
                    t45.Visible = true;
                    t46.Visible = false;
                    boxLugar2.Visible = false;

                    txtActual.Visible = false;
                    txtEspecie.Visible = false;
                    txtUbicacion.Visible = false;
                    boxRubro.Visible = false;
                    txtRetirador2.Visible = false;
                    txtIngreso2.Visible = false;
                    boxTipo2.Visible = false;
                    txtDevolucion2.Visible = false;
                    txtAnterior.Visible = false;
                    txtTipo.Visible = false;
                    txtResponsable.Visible = false;
                    txtValor.Visible = false;


                    t29.Visible = false;
                    t30.Visible = false;
                    t31.Visible = false;
                    t32.Visible = false;
                    t47.Visible = false;
                    t48.Visible = false;
                    t38.Visible = false;
                    t9.Visible = false;
                    t10.Visible = false;
                    t12.Visible = false;
                    t14.Visible = false;
                    t49.Visible = false;

                t50.Visible = true;
                t51.Visible = true;
                t52.Visible = true;
                t53.Visible = true;
                t54.Visible = true;
                t55.Visible = true;

                txtProductoSala.Visible = true;
                boxRubroSala.Visible = true;
                txtSerieSala.Visible = true;
                txtCantidadSala.Visible = true;
                boxEstadoSala.Visible = true;
                txtObservacionesSala.Visible = true;
                boxSalasLujo.Visible = true;
                btnAgregar.Visible = false;
                btnAgregar2.Visible = true;

                t97.Visible = false;
                t98.Visible = false;
                txtRut2.Visible = false;
                txtEstablecimiento2.Visible = false;

                txtInterno1.Visible = true;
                t101.Visible = true;
            }

            else if (boxSectores4.SelectedItem.ToString() == "Materiales de Aseo" && ckSalas.Checked)
            {
                    t43.Visible = false;
                    boxSectores4.Visible = false;
                    t44.Visible = true;
                    boxLugarSalas.Visible = true;
                    t45.Visible = true;
                    t46.Visible = false;
                    boxLugar2.Visible = false;

                    txtActual.Visible = false;
                    txtEspecie.Visible = false;
                    txtUbicacion.Visible = false;
                    txtRetirador2.Visible = false;
                    txtIngreso2.Visible = false;
                    boxTipo2.Visible = false;
                    txtDevolucion2.Visible = false;
                    txtAnterior.Visible = false;
                    txtTipo.Visible = false;
                    boxRubro.Visible = false;
                    txtResponsable.Visible = false;
                    txtValor.Visible = false;


                    t29.Visible = false;
                    t30.Visible = false;
                    t31.Visible = false;
                    t32.Visible = false;
                    t47.Visible = false;
                    t48.Visible = false;
                    t9.Visible = false;
                    t10.Visible = false;
                    t38.Visible = false;
                    t12.Visible = false;
                    t14.Visible = false;
                    t49.Visible = false;

                t50.Visible = true;
                t51.Visible = true;
                t52.Visible = true;
                t53.Visible = true;
                t54.Visible = true;
                t55.Visible = true;

                txtProductoSala.Visible = true;
                boxRubroSala.Visible = true;
                txtSerieSala.Visible = true;
                txtCantidadSala.Visible = true;
                boxEstadoSala.Visible = true;
                txtObservacionesSala.Visible = true;
                boxSalasLujo.Visible = true;
                btnAgregar.Visible = false;
                btnAgregar2.Visible = true;

                t97.Visible = false;
                t98.Visible = false;
                txtRut2.Visible = false;
                txtEstablecimiento2.Visible = false;

                txtInterno1.Visible = true;
                t101.Visible = true;
            }

            if(boxSectores4.SelectedItem == null && !ckSalas.Checked)
            {
                t43.Visible = true;
                boxSectores4.Visible = true;
                t44.Visible = false;
                boxLugarSalas.Visible = false;
                t45.Visible = false;
                t46.Visible = true;
                boxLugar2.Visible = true;

                txtAnterior.Visible = true;
                txtTipo.Visible = true;
                txtActual.Visible = true;
                txtEspecie.Visible = true;
                boxRubro.Visible = true;
                boxEstado.Visible = true;
                txtResponsable.Visible = true;
                txtTalleres.Visible = true;
                txtUbicacion.Visible = true;
                txtValor.Visible = true;
                txtFecha.Visible = true;
                txtOrigen.Visible = true;
                boxClase2.Visible = true;

                t9.Visible = true;
                t10.Visible = true;
                t47.Visible = true;
                t48.Visible = true;
                t38.Visible = true;
                t11.Visible = true;
                t12.Visible = true;
                t13.Visible = true;
                t14.Visible = true;
                t49.Visible = true;
                t15.Visible = true;
                t16.Visible = true;
                t41.Visible = true;

                t50.Visible = false;
                t51.Visible = false;
                t52.Visible = false;
                t53.Visible = false;
                t54.Visible = false;
                t55.Visible = false;

                txtProductoSala.Visible = false;
                boxRubroSala.Visible = false;
                txtSerieSala.Visible = false;
                txtCantidadSala.Visible = false;
                boxEstadoSala.Visible = false;
                txtObservacionesSala.Visible = false;
                boxSalasLujo.Visible = false;
                btnAgregar.Visible = true;
                btnAgregar2.Visible = false;

                t97.Visible = true;
                t98.Visible = true;
                txtRut2.Visible = true;
                txtEstablecimiento2.Visible = true;

                txtInterno1.Visible = false;
                t101.Visible = false;

                ckAyO2.Enabled = true;

                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;

                boxLugarSalas.SelectedIndex = -1;

                txtProductoSala.Clear();
                boxRubroSala.SelectedIndex = -1;
                txtSerieSala.Clear();
                txtCantidadSala.Clear();
                boxEstadoSala.SelectedIndex = -1;
                txtObservacionesSala.Clear();
                txtInterno1.Clear();
            }              
            
            else if (boxSectores4.SelectedItem !=null && boxSectores4.SelectedItem.ToString() == "Inventario General" && !ckSalas.Checked)
            {
                    t43.Visible = true;
                    boxSectores4.Visible = true;
                    t44.Visible = false;
                    boxLugarSalas.Visible = false;
                    t45.Visible = false;
                    t46.Visible = true;
                    boxLugar2.Visible = true;

                    txtAnterior.Visible = true;
                    txtTipo.Visible = true;
                    txtActual.Visible = true;
                    txtEspecie.Visible = true;
                    boxRubro.Visible = true;
                    boxEstado.Visible = true;
                    txtResponsable.Visible = true;
                    txtTalleres.Visible = true;
                    txtUbicacion.Visible = true;
                    txtValor.Visible = true;
                    txtFecha.Visible = true;
                    txtOrigen.Visible = true;
                    boxClase2.Visible = true;

                    t9.Visible = true;
                    t10.Visible = true;
                    t47.Visible = true;
                    t48.Visible = true;
                    t38.Visible = true;
                    t11.Visible = true;
                    t12.Visible = true;
                    t13.Visible = true;
                    t14.Visible = true;
                    t49.Visible = true;
                    t15.Visible = true;
                    t16.Visible = true;
                    t41.Visible = true;

                t50.Visible = false;
                t51.Visible = false;
                t52.Visible = false;
                t53.Visible = false;
                t54.Visible = false;
                t55.Visible = false;

                txtProductoSala.Visible = false;
                boxRubroSala.Visible = false;
                txtSerieSala.Visible = false;
                txtCantidadSala.Visible = false;
                boxEstadoSala.Visible = false;
                txtObservacionesSala.Visible = false;
                boxSalasLujo.Visible = false;
                btnAgregar.Visible = true;
                btnAgregar2.Visible = false;

                t97.Visible = true;
                t98.Visible = true;
                txtRut2.Visible = true;
                txtEstablecimiento2.Visible = true;

                txtInterno1.Visible = false;
                t101.Visible = false;

                ckAyO2.Enabled = true;

                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;

                boxLugarSalas.SelectedIndex = -1;

                txtProductoSala.Clear();
                boxRubroSala.SelectedIndex = -1;
                txtSerieSala.Clear();
                txtCantidadSala.Clear();
                boxEstadoSala.SelectedIndex = -1;
                txtObservacionesSala.Clear();
                txtInterno1.Clear();
            }               
            else if (boxSectores4.SelectedItem != null && boxSectores4.SelectedItem.ToString() == "Materiales de Escritorio" && !ckSalas.Checked)
            {
                    t43.Visible = true;
                    boxSectores4.Visible = true;
                    t44.Visible = false;
                    boxLugarSalas.Visible = false;
                    t45.Visible = false;
                    t46.Visible = true;
                    boxLugar2.Visible = true;

                    txtActual.Visible = true;
                    txtEspecie.Visible = true;
                    txtUbicacion.Visible = true;
                    boxRubro.Visible = true;
                    txtRetirador2.Visible = true;
                    txtIngreso2.Visible = true;
                    boxTipo2.Visible = true;
                    txtDevolucion2.Visible = true;
                    txtAnterior.Visible = true;
                    txtTipo.Visible = true;
                    txtResponsable.Visible = true;
                    txtValor.Visible = true;


                    t29.Visible = true;
                    t30.Visible = true;
                    t31.Visible = true;
                    t32.Visible = true;
                    t47.Visible = true;
                    t48.Visible = true;
                    t38.Visible = true;
                    t9.Visible = true;
                    t10.Visible = true;
                    t12.Visible = true;
                    t14.Visible = true;
                    t49.Visible = true;

                t50.Visible = false;
                t51.Visible = false;
                t52.Visible = false;
                t53.Visible = false;
                t54.Visible = false;
                t55.Visible = false;

                txtProductoSala.Visible = false;
                boxRubroSala.Visible = false;
                txtSerieSala.Visible = false;
                txtCantidadSala.Visible = false;
                boxEstadoSala.Visible = false;
                txtObservacionesSala.Visible = false;
                boxSalasLujo.Visible = false;
                btnAgregar.Visible = true;
                btnAgregar2.Visible = false;

                t97.Visible = true;
                t98.Visible = true;
                txtRut2.Visible = true;
                txtEstablecimiento2.Visible = true;

                txtInterno1.Visible = false;
                t101.Visible = false;
            }         
            else if (boxSectores4.SelectedItem != null && boxSectores4.SelectedItem.ToString() == "Materiales de Aseo" && !ckSalas.Checked)
            {
                    t43.Visible = true;
                    boxSectores4.Visible = true;
                    t44.Visible = false;
                    boxLugarSalas.Visible = false;
                    t45.Visible = false;
                    t46.Visible = true;
                    boxLugar2.Visible = true;

                    txtActual.Visible = true;
                    txtEspecie.Visible = true;
                    txtUbicacion.Visible = true;
                    txtRetirador2.Visible = true;
                    txtIngreso2.Visible = true;
                    boxTipo2.Visible = true;
                    txtDevolucion2.Visible = true;
                    txtAnterior.Visible = true;
                    txtTipo.Visible = true;
                    boxRubro.Visible = true;
                    txtResponsable.Visible = true;
                    txtValor.Visible = true;


                    t29.Visible = true;
                    t30.Visible = true;
                    t31.Visible = true;
                    t32.Visible = true;
                    t47.Visible = true;
                    t48.Visible = true;
                    t9.Visible = true;
                    t10.Visible = true;
                    t38.Visible = true;
                    t12.Visible = true;
                    t14.Visible = true;
                    t49.Visible = true;

                t50.Visible = false;
                t51.Visible = false;
                t52.Visible = false;
                t53.Visible = false;
                t54.Visible = false;
                t55.Visible = false;

                txtProductoSala.Visible = false;
                boxRubroSala.Visible = false;
                txtSerieSala.Visible = false;
                txtCantidadSala.Visible = false;
                boxEstadoSala.Visible = false;
                txtObservacionesSala.Visible = false;
                boxSalasLujo.Visible = false;
                btnAgregar.Visible = true;
                btnAgregar2.Visible = false;

                t97.Visible = true;
                t98.Visible = true;
                txtRut2.Visible = true;
                txtEstablecimiento2.Visible = true;

                txtInterno1.Visible = false;
                t101.Visible = false;
            }
        }

        private void LlenarComboBoxSalas()
        {
            MySqlConnection connMA = Conexion.getConexion();
            MySqlCommand cmdMA = new MySqlCommand("SELECT nombre FROM masalas", connMA);
            connMA.Open();
            MySqlDataReader readerMA = cmdMA.ExecuteReader();
            while (readerMA.Read())
            {
                string nombreSalaMA = readerMA.GetString("nombre");
                boxSalasMA.Items.Add(nombreSalaMA);
            }
            readerMA.Close();
            cmdMA.Dispose();
            connMA.Close();

            // ComboBox boxSalasCM
            MySqlConnection connCM = Conexion.getConexion();
            MySqlCommand cmdCM = new MySqlCommand("SELECT nombre FROM cmsalas", connCM);
            connCM.Open();
            MySqlDataReader readerCM = cmdCM.ExecuteReader();
            while (readerCM.Read())
            {
                string nombreSalaCM = readerCM.GetString("nombre");
                boxSalasCM.Items.Add(nombreSalaCM);
            }
            readerCM.Close();
            cmdCM.Dispose();
            connCM.Close();

            // ComboBox boxSalasE
            MySqlConnection connE = Conexion.getConexion();
            MySqlCommand cmdE = new MySqlCommand("SELECT nombre FROM esalas", connE);
            connE.Open();
            MySqlDataReader readerE = cmdE.ExecuteReader();
            while (readerE.Read())
            {
                string nombreSalaE = readerE.GetString("nombre");
                boxSalasE.Items.Add(nombreSalaE);
            }
            readerE.Close();
            cmdE.Dispose();
            connE.Close();

            // ComboBox boxSalasMI
            MySqlConnection connMI = Conexion.getConexion();
            MySqlCommand cmdMI = new MySqlCommand("SELECT nombre FROM misalas", connMI);
            connMI.Open();
            MySqlDataReader readerMI = cmdMI.ExecuteReader();
            while (readerMI.Read())
            {
                string nombreSalaMI = readerMI.GetString("nombre");
                boxSalasMI.Items.Add(nombreSalaMI);
            }
            readerMI.Close();
            cmdMI.Dispose();
            connMI.Close();

            // ComboBox boxSalasTC
            MySqlConnection connTC = Conexion.getConexion();
            MySqlCommand cmdTC = new MySqlCommand("SELECT nombre FROM tcsalas", connTC);
            connTC.Open();
            MySqlDataReader readerTC = cmdTC.ExecuteReader();
            while (readerTC.Read())
            {
                string nombreSalaTC = readerTC.GetString("nombre");
                boxSalasTC.Items.Add(nombreSalaTC);
            }
            readerTC.Close();
            cmdTC.Dispose();
            connTC.Close();

            MySqlConnection connA2 = Conexion.getConexion();
            MySqlCommand cmdA2 = new MySqlCommand("SELECT nombre FROM Aulas", connA2);
            connA2.Open();
            MySqlDataReader readerA2 = cmdA2.ExecuteReader();
            while (readerA2.Read())
            {
                string nombreSalaA2 = readerA2.GetString("nombre");
                boxAulas2.Items.Add(nombreSalaA2);
            }
            readerA2.Close();
            cmdA2.Dispose();
            connA2.Close();

            MySqlConnection connO2 = Conexion.getConexion();
            MySqlCommand cmdO2 = new MySqlCommand("SELECT nombre FROM Oficinas", connO2);
            connO2.Open();
            MySqlDataReader readerO2 = cmdO2.ExecuteReader();
            while (readerO2.Read())
            {
                string nombreSalaO2 = readerO2.GetString("nombre");
                boxOficinas2.Items.Add(nombreSalaO2);
            }
            readerO2.Close();
            cmdO2.Dispose();
            connO2.Close();

            MySqlConnection connI = Conexion.getConexion();
            MySqlCommand cmdI = new MySqlCommand("SELECT nombre FROM Internado_IG", connI);
            connI.Open();
            MySqlDataReader readerI = cmdI.ExecuteReader();
            while (readerI.Read())
            {
                string nombreSalaI = readerI.GetString("nombre");
                boxInternado2.Items.Add(nombreSalaI);
            }
            readerI.Close();
            cmdI.Dispose();
            connI.Close();
        }

        private void boxLugarSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxLugarSalas.SelectedItem != null && boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && ckSalas.Checked)
            {
                boxSalasMA.Visible = true;


                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasE.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem != null && boxLugarSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && ckSalas.Checked)
            {
                boxSalasCM.Visible = true;


                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasE.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem != null && boxLugarSalas.SelectedItem.ToString() == "Taller_de_Electricidad" && ckSalas.Checked)
            {
                boxSalasE.Visible = true;

                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem != null && boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && ckSalas.Checked)
            {
                boxSalasMI.Visible = true;

                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem != null && boxLugarSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && ckSalas.Checked)
            {
                boxSalasTC.Visible = true;

                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasLujo.Visible = false;
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            if (boxLugarSalas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxLugarSalas.Text == "Taller_de_Mecanica_Automotriz")
            {
                sala = boxSalasMA.Text;
            }
            else if (boxLugarSalas.Text == "Taller_de_Electricidad")
            {
                sala = boxSalasE.Text;
            }
            else if (boxLugarSalas.Text == "Taller_de_Mecanica_Industrial")
            {
                sala = boxSalasMI.Text;
            }
            else if (boxLugarSalas.Text == "Taller_de_Construcciones_Metalicas")
            {
                sala = boxSalasCM.Text;
            }
            else if (boxLugarSalas.Text == "Taller_de_Terminaciones_de_la_Construccion")
            {
                sala = boxSalasTC.Text;
            }

            // Verificar que se hayan llenado todos los campos necesarios
            if (string.IsNullOrEmpty(txtProductoSala.Text) || string.IsNullOrEmpty(boxRubroSala.Text) ||
                string.IsNullOrEmpty(txtSerieSala.Text) || string.IsNullOrEmpty(txtCantidadSala.Text) ||
                string.IsNullOrEmpty(boxEstadoSala.Text) || string.IsNullOrEmpty(txtObservacionesSala.Text) || 
                string.IsNullOrEmpty(txtInterno1.Text))
            {
                MessageBox.Show("Debe llenar todos los campos para agregar un producto a la sala seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((boxLugarSalas.Text == "Taller_de_Mecanica_Automotriz" && boxSalasMA.SelectedItem == null) ||
                (boxLugarSalas.Text == "Taller_de_Electricidad" && boxSalasE.SelectedItem == null) ||
                (boxLugarSalas.Text == "Taller_de_Mecanica_Industrial" && boxSalasMI.SelectedItem == null) ||
                (boxLugarSalas.Text == "Taller_de_Construcciones_Metalicas" && boxSalasCM.SelectedItem == null) ||
                (boxLugarSalas.Text == "Taller_de_Terminaciones_de_la_Construccion" && boxSalasTC.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione una sala de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string verificaSql = $"SELECT COUNT(*) FROM {sala} WHERE NºInterno = @NºInterno AND Rubro = @Rubro";
            MySqlCommand verificaCommand = new MySqlCommand(verificaSql, conexion);
            verificaCommand.Parameters.Add(new MySqlParameter("@NºInterno", txtInterno1.Text));
            verificaCommand.Parameters.Add(new MySqlParameter("@Rubro", boxRubroSala.Text));

            int count = Convert.ToInt32(verificaCommand.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Ya existe un producto con el mismo NºActual en el mismo Rubro, por favor modifíquelo para agregar el producto.");
                conexion.Close();
                return;
            }


            // Realizar la consulta SQL para agregar el producto a la tabla de la sala seleccionada
            string query = "INSERT INTO " + sala + " (NºInterno, Descripcion_Especie, Rubro, NºSerie, Cantidad, Estado, Observaciones) " +
                           "VALUES (@NºInterno, @Descripcion_Especie, @Rubro, @NºSerie, @Cantidad, @Estado, @Observaciones)";

            using (MySqlConnection conn = Conexion.getConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // Agregar los parámetros a la consulta
                cmd.Parameters.Add("@NºInterno", MySqlDbType.VarChar).Value = txtInterno1.Text;
                cmd.Parameters.Add("@Descripcion_Especie", MySqlDbType.VarChar).Value = txtProductoSala.Text;
                cmd.Parameters.Add("@Rubro", MySqlDbType.VarChar).Value = boxRubroSala.Text;
                cmd.Parameters.Add("@NºSerie", MySqlDbType.VarChar).Value = txtSerieSala.Text;
                cmd.Parameters.Add("@Cantidad", MySqlDbType.VarChar).Value = txtCantidadSala.Text;
                cmd.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = boxEstadoSala.Text;
                cmd.Parameters.Add("@Observaciones", MySqlDbType.VarChar).Value = txtObservacionesSala.Text;

                // Abrir la conexión a la base de datos y ejecutar la consulta
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                string query1 = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

                using (MySqlConnection con = Conexion.getConexion())
                using (MySqlCommand comando = new MySqlCommand(query1, con))
                {
                    comando.Parameters.Add(new MySqlParameter("@NºActual", txtInterno1.Text));
                    comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtProductoSala.Text));
                    comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                    comando.Parameters.Add(new MySqlParameter("@Alteracion", "Agregado"));
                    comando.Parameters.Add(new MySqlParameter("@Tabla", sala));
                    comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                    con.Open();
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("El producto se ha agregado a la sala seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ckSalas2_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSectores6.SelectedItem == null && ckSalas2.Checked)
            {
                t68.Visible = false;
                boxSectores6.Visible = false;
                t67.Visible = true;
                boxLugarSala2.Visible = true;
                t66.Visible = true;
                t69.Visible = false;
                boxLugar3.Visible = false;

                txtAnterior3.Visible = false;
                txtTipo3.Visible = false;
                txtActual5.Visible = false;
                txtEspecie3.Visible = false;
                boxRubro3.Visible = false;
                boxEstado3.Visible = false;
                txtResponsable3.Visible = false;
                txtTalleres3.Visible = false;
                txtUbicacion3.Visible = false;
                txtValor3.Visible = false;
                txtFecha3.Visible = false;
                txtOrigen3.Visible = false;
                boxClase3.Visible = false;
                txtActual4.Visible = false;

                t17.Visible = false;
                t18.Visible = false;
                t70.Visible = false;
                t71.Visible = false;
                t39.Visible = false;
                t19.Visible = false;
                t20.Visible = false;
                t21.Visible = false;
                t22.Visible = false;
                t72.Visible = false;
                t23.Visible = false;
                t24.Visible = false;               
                t42.Visible = false;

                t60.Visible = true;
                t61.Visible = true;
                t62.Visible = true;
                t63.Visible = true;
                t64.Visible = true;
                t65.Visible = true;
                t73.Visible = true;

                txtProductoSala2.Visible = true;
                boxRubroSala2.Visible = true;
                txtSerieSala2.Visible = true;
                txtCantidadSala2.Visible = true;
                boxEstadoSala2.Visible = true;
                txtObservacionesSala2.Visible = true;
                txtSerieSalaB.Visible = true;

                boxSalasLujo2.Visible = true;
                btnEliminar.Visible = false;
                btnEliminar2.Visible = true;
                btnBuscarSalas.Visible = true;

                txtRut1.Visible = false;
                txtEstablecimiento1.Visible = false;
                t95.Visible = false;
                t96.Visible = false;

                txtInterno2.Visible = true;
                t102.Visible = true;

                boxRubroB2.Visible = false;
                boxRubroBS2.Visible = true;

                ckAyO3.Enabled = false;
            }
            else if (boxSectores6.SelectedItem == null || boxSectores6.SelectedItem.ToString() == "Inventario General" && ckSalas2.Checked)
            {
                t68.Visible = false;
                boxSectores6.Visible = false;
                t67.Visible = true;
                boxLugarSala2.Visible = true;
                t66.Visible = true;
                t69.Visible = false;
                boxLugar3.Visible = false;

                txtAnterior3.Visible = false;
                txtTipo3.Visible = false;
                txtActual5.Visible = false;
                txtEspecie3.Visible = false;
                boxRubro3.Visible = false;
                boxEstado3.Visible = false;
                txtResponsable3.Visible = false;
                txtTalleres3.Visible = false;
                txtUbicacion3.Visible = false;
                txtValor3.Visible = false;
                txtFecha3.Visible = false;
                txtOrigen3.Visible = false;
                boxClase3.Visible = false;
                txtActual4.Visible = false;

                t17.Visible = false;
                t18.Visible = false;
                t70.Visible = false;
                t71.Visible = false;
                t39.Visible = false;
                t19.Visible = false;
                t20.Visible = false;
                t21.Visible = false;
                t22.Visible = false;
                t72.Visible = false;
                t23.Visible = false;
                t24.Visible = false;
                t42.Visible = false;

                t60.Visible = true;
                t61.Visible = true;
                t62.Visible = true;
                t63.Visible = true;
                t64.Visible = true;
                t65.Visible = true;
                t73.Visible = true;

                txtProductoSala2.Visible = true;
                boxRubroSala2.Visible = true;
                txtSerieSala2.Visible = true;
                txtCantidadSala2.Visible = true;
                boxEstadoSala2.Visible = true;
                txtObservacionesSala2.Visible = true;
                txtSerieSalaB.Visible = true;

                boxSalasLujo2.Visible = true;
                btnEliminar.Visible = false;
                btnEliminar2.Visible = true;
                btnBuscarSalas.Visible = true;

                txtRut1.Visible = false;
                txtEstablecimiento1.Visible = false;
                t95.Visible = false;
                t96.Visible = false;

                txtInterno2.Visible = true;
                t102.Visible = true;

                boxRubroB2.Visible = false;
                boxRubroBS2.Visible = true;

                ckAyO3.Enabled = false;
            }

            else if (boxSectores6.SelectedItem.ToString() == "Materiales de Escritorio" && ckSalas2.Checked)
            {
                t68.Visible = false;
                boxSectores6.Visible = false;
                t67.Visible = true;
                boxLugarSala2.Visible = true;
                t66.Visible = true;
                t69.Visible = false;
                boxLugar3.Visible = false;

                txtActual5.Visible = false;
                txtEspecie3.Visible = false;
                txtUbicacion3.Visible = false;
                boxRubro3.Visible = false;
                txtRetirador3.Visible = false;
                txtIngreso3.Visible = false;
                boxTipo3.Visible = false;
                txtDevolucion3.Visible = false;
                txtAnterior3.Visible = false;
                txtTipo3.Visible = false;
                txtResponsable3.Visible = false;
                txtValor3.Visible = false;
                txtActual4.Visible = false;


                t33.Visible = false;
                t34.Visible = false;
                t35.Visible = false;
                t36.Visible = false;
                t70.Visible = false;
                t71.Visible = false;
                t39.Visible = false;
                t17.Visible = false;
                t18.Visible = false;
                t20.Visible = false;
                t22.Visible = false;
                t72.Visible = false;

                t60.Visible = true;
                t61.Visible = true;
                t62.Visible = true;
                t63.Visible = true;
                t64.Visible = true;
                t65.Visible = true;
                t73.Visible = true;

                txtProductoSala2.Visible = true;
                boxRubroSala2.Visible = true;
                txtSerieSala2.Visible = true;
                txtCantidadSala2.Visible = true;
                boxEstadoSala2.Visible = true;
                txtObservacionesSala2.Visible = true;
                txtSerieSalaB.Visible = true;

                boxSalasLujo2.Visible = true;
                btnEliminar.Visible = false;
                btnEliminar2.Visible = true;
                btnBuscarSalas.Visible = true;
                txtRut1.Visible = false;
                txtEstablecimiento1.Visible = false;
                t95.Visible = false;
                t96.Visible = false;

                txtInterno2.Visible = true;
                t102.Visible = true;

                boxRubroB2.Visible = false;
                boxRubroBS2.Visible = true;

            }

            else if (boxSectores6.SelectedItem.ToString() == "Materiales de Aseo" && ckSalas2.Checked)
            {
                t68.Visible = false;
                boxSectores6.Visible = false;
                t67.Visible = true;
                boxLugarSala2.Visible = true;
                t66.Visible = true;
                t69.Visible = false;
                boxLugar3.Visible = false;

                txtActual5.Visible = false;
                txtEspecie3.Visible = false;
                txtUbicacion3.Visible = false;
                txtRetirador3.Visible = false;
                txtIngreso3.Visible = false;
                boxTipo3.Visible = false;
                txtDevolucion3.Visible = false;
                txtAnterior3.Visible = false;
                txtTipo3.Visible = false;
                boxRubro3.Visible = false;
                txtResponsable3.Visible = false;
                txtValor3.Visible = false;
                txtActual4.Visible = false;


                t33.Visible = false;
                t34.Visible = false;
                t35.Visible = false;
                t36.Visible = false;
                t70.Visible = false;
                t71.Visible = false;
                t17.Visible = false;
                t18.Visible = false;
                t39.Visible = false;
                t20.Visible = false;
                t72.Visible = false;
                t22.Visible = false;

                t60.Visible = true;
                t61.Visible = true;
                t62.Visible = true;
                t63.Visible = true;
                t64.Visible = true;
                t65.Visible = true;
                t73.Visible = true;

                txtProductoSala2.Visible = true;
                boxRubroSala2.Visible = true;
                txtSerieSala2.Visible = true;
                txtCantidadSala2.Visible = true;
                boxEstadoSala2.Visible = true;
                txtObservacionesSala2.Visible = true;
                txtSerieSalaB.Visible = true;

                boxSalasLujo2.Visible = true;
                btnEliminar.Visible = false;
                btnEliminar2.Visible = true;
                btnBuscarSalas.Visible = true;
                txtRut1.Visible = false;
                txtEstablecimiento1.Visible = false;
                t95.Visible = false;
                t96.Visible = false;

                txtInterno2.Visible = true;
                t102.Visible = true;

                boxRubroB2.Visible = false;
                boxRubroBS2.Visible = true;

            }

            if (boxSectores6.SelectedItem == null && !ckSalas2.Checked)
            {
                t68.Visible = true;
                boxSectores6.Visible = true;
                t67.Visible = false;
                boxLugarSala2.Visible = false;
                t66.Visible = false;
                t69.Visible = true;
                boxLugar3.Visible = true;

                txtAnterior3.Visible = true;
                txtTipo3.Visible = true;
                txtActual5.Visible = true;
                txtEspecie3.Visible = true;
                boxRubro3.Visible = true;
                boxEstado3.Visible = true;
                txtResponsable3.Visible = true;
                txtTalleres3.Visible = true;
                txtUbicacion3.Visible = true;
                txtValor3.Visible = true;
                txtFecha3.Visible = true;
                txtOrigen3.Visible = true;
                boxClase3.Visible = true;
                txtActual4.Visible = true;

                t17.Visible = true;
                t18.Visible = true;
                t70.Visible = true;
                t71.Visible = true;
                t39.Visible = true;
                t19.Visible = true;
                t20.Visible = true;
                t21.Visible = true;
                t22.Visible = true;
                t72.Visible = true;
                t23.Visible = true;
                t24.Visible = true;
                t42.Visible = true;

                t60.Visible = false;
                t61.Visible = false;
                t62.Visible = false;
                t63.Visible = false;
                t64.Visible = false;
                t65.Visible = false;
                t73.Visible = false;

                txtProductoSala2.Visible = false;
                boxRubroSala2.Visible = false;
                txtSerieSala2.Visible = false;
                txtCantidadSala2.Visible = false;
                boxEstadoSala2.Visible = false;
                txtObservacionesSala2.Visible = false;
                boxSalasLujo2.Visible = false;
                btnEliminar.Visible = true;
                btnEliminar2.Visible = false;
                btnBuscarSalas.Visible = false;
                txtSerieSalaB.Visible = false;

                txtRut1.Visible = true;
                txtEstablecimiento1.Visible = true;
                t95.Visible = true;
                t96.Visible = true;

                txtInterno2.Visible = false;
                t102.Visible = false;

                boxRubroB2.Visible = true;
                boxRubroBS2.Visible = false;

                ckAyO3.Enabled = true;

                boxSalasCM2.Visible = false;
                boxSalasE2.Visible = false;
                boxSalasTC2.Visible = false;
                boxSalasMA2.Visible = false;
                boxSalasMI2.Visible = false;

                boxLugarSala2.SelectedIndex = -1;

                txtProductoSala2.Clear();
                boxRubroSala2.SelectedIndex = -1;
                txtSerieSala2.Clear();
                txtCantidadSala2.Clear();
                boxEstadoSala2.SelectedIndex = -1;
                txtObservacionesSala2.Clear();
                txtInterno2.Clear();
                boxRubroBS2.SelectedIndex = -1;
                txtSerieSalaB.Clear();

            }

            else if (boxSectores6.SelectedItem != null && boxSectores6.SelectedItem.ToString() == "Inventario General" && !ckSalas2.Checked)
            {
                t68.Visible = true;
                boxSectores6.Visible = true;
                t67.Visible = false;
                boxLugarSala2.Visible = false;
                t66.Visible = false;
                t69.Visible = true;
                boxLugar3.Visible = true;

                txtAnterior3.Visible = true;
                txtTipo3.Visible = true;
                txtActual5.Visible = true;
                txtEspecie3.Visible = true;
                boxRubro3.Visible = true;
                boxEstado3.Visible = true;
                txtResponsable3.Visible = true;
                txtTalleres3.Visible = true;
                txtUbicacion3.Visible = true;
                txtValor3.Visible = true;
                txtFecha3.Visible = true;
                txtOrigen3.Visible = true;
                boxClase3.Visible = true;
                txtActual4.Visible = true;

                t17.Visible = true;
                t18.Visible = true;
                t70.Visible = true;
                t71.Visible = true;
                t39.Visible = true;
                t19.Visible = true;
                t20.Visible = true;
                t21.Visible = true;
                t22.Visible = true;
                t72.Visible = true;
                t23.Visible = true;
                t24.Visible = true;
                t42.Visible = true;

                t60.Visible = false;
                t61.Visible = false;
                t62.Visible = false;
                t63.Visible = false;
                t64.Visible = false;
                t65.Visible = false;
                t73.Visible = false;

                txtProductoSala2.Visible = false;
                boxRubroSala2.Visible = false;
                txtSerieSala2.Visible = false;
                txtCantidadSala2.Visible = false;
                boxEstadoSala2.Visible = false;
                txtObservacionesSala2.Visible = false;
                boxSalasLujo2.Visible = false;
                btnEliminar.Visible = true;
                btnEliminar2.Visible = false;
                btnBuscarSalas.Visible = false;
                txtSerieSalaB.Visible = false;

                txtRut1.Visible = true;
                txtEstablecimiento1.Visible = true;
                t95.Visible = true;
                t96.Visible = true;

                txtInterno2.Visible = false;
                t102.Visible = false;

                boxRubroB2.Visible = true;
                boxRubroBS2.Visible = false;

                ckAyO3.Enabled = true;

                boxSalasCM2.Visible = false;
                boxSalasE2.Visible = false;
                boxSalasTC2.Visible = false;
                boxSalasMA2.Visible = false;
                boxSalasMI2.Visible = false;

                boxLugarSala2.SelectedIndex = -1;

                txtProductoSala2.Clear();
                boxRubroSala2.SelectedIndex = -1;
                txtSerieSala2.Clear();
                txtCantidadSala2.Clear();
                boxEstadoSala2.SelectedIndex = -1;
                txtObservacionesSala2.Clear();
                txtInterno2.Clear();
                boxRubroBS2.SelectedIndex = -1;
                txtSerieSalaB.Clear();
            }
            else if (boxSectores6.SelectedItem != null && boxSectores6.SelectedItem.ToString() == "Materiales de Escritorio" && !ckSalas2.Checked)
            {
                t68.Visible = true;
                boxSectores6.Visible = true;
                t67.Visible = false;
                boxLugarSala2.Visible = false;
                t66.Visible = false;
                t69.Visible = true;
                boxLugar3.Visible = true;

                txtActual5.Visible = true;
                txtEspecie3.Visible = true;
                txtUbicacion3.Visible = true;
                boxRubro3.Visible = true;
                txtRetirador3.Visible = true;
                txtIngreso3.Visible = true;
                boxTipo3.Visible = true;
                txtDevolucion3.Visible = true;
                txtAnterior3.Visible = true;
                txtTipo3.Visible = true;
                txtResponsable3.Visible = true;
                txtValor3.Visible = true;
                txtActual4.Visible = true;


                t33.Visible = true;
                t34.Visible = true;
                t35.Visible = true;
                t36.Visible = true;
                t70.Visible = true;
                t71.Visible = true;
                t39.Visible = true;
                t17.Visible = true;
                t18.Visible = true;
                t20.Visible = true;
                t22.Visible = true;
                t72.Visible = true;

                t60.Visible = false;
                t61.Visible = false;
                t62.Visible = false;
                t63.Visible = false;
                t64.Visible = false;
                t65.Visible = false;
                t73.Visible = false;

                txtProductoSala2.Visible = false;
                boxRubroSala2.Visible = false;
                txtSerieSala2.Visible = false;
                txtCantidadSala2.Visible = false;
                boxEstadoSala2.Visible = false;
                txtObservacionesSala2.Visible = false;
                boxSalasLujo2.Visible = false;
                btnEliminar.Visible = true;
                btnEliminar2.Visible = false;
                btnBuscarSalas.Visible = false;
                txtSerieSalaB.Visible = false;

                txtRut1.Visible = true;
                txtEstablecimiento1.Visible = true;
                t95.Visible = true;
                t96.Visible = true;

                txtInterno2.Visible = false;
                t102.Visible = false;

                boxRubroB2.Visible = true;
                boxRubroBS2.Visible = false;
            }
            else if (boxSectores6.SelectedItem != null && boxSectores6.SelectedItem.ToString() == "Materiales de Aseo" && !ckSalas2.Checked)
            {
                t68.Visible = true;
                boxSectores6.Visible = true;
                t67.Visible = false;
                boxLugarSala2.Visible = false;
                t66.Visible = false;
                t69.Visible = true;
                boxLugar3.Visible = true;

                txtActual5.Visible = true;
                txtEspecie3.Visible = true;
                txtUbicacion3.Visible = true;
                txtRetirador3.Visible = true;
                txtIngreso3.Visible = true;
                boxTipo3.Visible = true;
                txtDevolucion3.Visible = true;
                txtAnterior3.Visible = true;
                txtTipo3.Visible = true;
                boxRubro3.Visible = true;
                txtResponsable3.Visible = true;
                txtValor3.Visible = true;
                txtActual4.Visible = true;


                t33.Visible = true;
                t34.Visible = true;
                t35.Visible = true;
                t36.Visible = true;
                t70.Visible = true;
                t71.Visible = true;
                t17.Visible = true;
                t18.Visible = true;
                t39.Visible = true;
                t20.Visible = true;
                t72.Visible = true;
                t22.Visible = true;

                t60.Visible = false;
                t61.Visible = false;
                t62.Visible = false;
                t63.Visible = false;
                t64.Visible = false;
                t65.Visible = false;
                t73.Visible = false;

                txtProductoSala2.Visible = false;
                boxRubroSala2.Visible = false;
                txtSerieSala2.Visible = false;
                txtCantidadSala2.Visible = false;
                boxEstadoSala2.Visible = false;
                txtObservacionesSala2.Visible = false;
                boxSalasLujo2.Visible = false;
                btnEliminar.Visible = true;
                btnEliminar2.Visible = false;
                btnBuscarSalas.Visible = false;
                txtSerieSalaB.Visible = false;

                txtRut1.Visible = true;
                txtEstablecimiento1.Visible = true;
                t95.Visible = true;
                t96.Visible = true;

                txtInterno2.Visible = false;
                t102.Visible = false;

                boxRubroB2.Visible = true;
                boxRubroBS2.Visible = false;
            }
        }

        private void boxLugarSala2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxLugarSala2.SelectedItem != null && boxLugarSala2.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && ckSalas2.Checked)
            {
                boxSalasMA2.Visible = true;


                boxSalasTC2.Visible = false;
                boxSalasMI2.Visible = false;
                boxSalasE2.Visible = false;
                boxSalasCM2.Visible = false;
                boxSalasLujo2.Visible = false;
            }
            else if (boxLugarSala2.SelectedItem != null && boxLugarSala2.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && ckSalas2.Checked)
            {
                boxSalasCM2.Visible = true;


                boxSalasMA2.Visible = false;
                boxSalasTC2.Visible = false;
                boxSalasMI2.Visible = false;
                boxSalasE2.Visible = false;
                boxSalasLujo2.Visible = false;
            }
            else if (boxLugarSala2.SelectedItem != null && boxLugarSala2.SelectedItem.ToString() == "Taller_de_Electricidad" && ckSalas2.Checked)
            {
                boxSalasE2.Visible = true;

                boxSalasMA2.Visible = false;
                boxSalasTC2.Visible = false;
                boxSalasMI2.Visible = false;
                boxSalasCM2.Visible = false;
                boxSalasLujo2.Visible = false;
            }
            else if (boxLugarSala2.SelectedItem != null && boxLugarSala2.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && ckSalas2.Checked)
            {
                boxSalasMI2.Visible = true;

                boxSalasMA2.Visible = false;
                boxSalasTC2.Visible = false;
                boxSalasCM2.Visible = false;
                boxSalasE2.Visible = false;
                boxSalasLujo2.Visible = false;
            }
            else if (boxLugarSala2.SelectedItem != null && boxLugarSala2.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && ckSalas2.Checked)
            {
                boxSalasTC2.Visible = true;

                boxSalasCM2.Visible = false;
                boxSalasE2.Visible = false;
                boxSalasMA2.Visible = false;
                boxSalasMI2.Visible = false;
                boxSalasLujo2.Visible = false;
            }
        }

        private void LlenarComboBoxSalas2()
        {
            MySqlConnection connMA = Conexion.getConexion();
            MySqlCommand cmdMA = new MySqlCommand("SELECT nombre FROM masalas", connMA);
            connMA.Open();
            MySqlDataReader readerMA = cmdMA.ExecuteReader();
            while (readerMA.Read())
            {
                string nombreSalaMA = readerMA.GetString("nombre");
                boxSalasMA2.Items.Add(nombreSalaMA);
            }
            readerMA.Close();
            cmdMA.Dispose();
            connMA.Close();

            // ComboBox boxSalasCM
            MySqlConnection connCM = Conexion.getConexion();
            MySqlCommand cmdCM = new MySqlCommand("SELECT nombre FROM cmsalas", connCM);
            connCM.Open();
            MySqlDataReader readerCM = cmdCM.ExecuteReader();
            while (readerCM.Read())
            {
                string nombreSalaCM = readerCM.GetString("nombre");
                boxSalasCM2.Items.Add(nombreSalaCM);
            }
            readerCM.Close();
            cmdCM.Dispose();
            connCM.Close();

            // ComboBox boxSalasE
            MySqlConnection connE = Conexion.getConexion();
            MySqlCommand cmdE = new MySqlCommand("SELECT nombre FROM esalas", connE);
            connE.Open();
            MySqlDataReader readerE = cmdE.ExecuteReader();
            while (readerE.Read())
            {
                string nombreSalaE = readerE.GetString("nombre");
                boxSalasE2.Items.Add(nombreSalaE);
            }
            readerE.Close();
            cmdE.Dispose();
            connE.Close();

            // ComboBox boxSalasMI
            MySqlConnection connMI = Conexion.getConexion();
            MySqlCommand cmdMI = new MySqlCommand("SELECT nombre FROM misalas", connMI);
            connMI.Open();
            MySqlDataReader readerMI = cmdMI.ExecuteReader();
            while (readerMI.Read())
            {
                string nombreSalaMI = readerMI.GetString("nombre");
                boxSalasMI2.Items.Add(nombreSalaMI);
            }
            readerMI.Close();
            cmdMI.Dispose();
            connMI.Close();

            // ComboBox boxSalasTC
            MySqlConnection connTC = Conexion.getConexion();
            MySqlCommand cmdTC = new MySqlCommand("SELECT nombre FROM tcsalas", connTC);
            connTC.Open();
            MySqlDataReader readerTC = cmdTC.ExecuteReader();
            while (readerTC.Read())
            {
                string nombreSalaTC = readerTC.GetString("nombre");
                boxSalasTC2.Items.Add(nombreSalaTC);
            }
            readerTC.Close();
            cmdTC.Dispose();
            connTC.Close();
        }

        private void btnBuscarSalas_Click(object sender, EventArgs e)
        {
            if (boxLugarSala2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxLugarSala2.Text == "Taller_de_Mecanica_Automotriz")
            {
                sala = boxSalasMA2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Electricidad")
            {
                sala = boxSalasE2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Mecanica_Industrial")
            {
                sala = boxSalasMI2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Construcciones_Metalicas")
            {
                sala = boxSalasCM2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Terminaciones_de_la_Construccion")
            {
                sala = boxSalasTC2.Text;
            }

            if ((boxLugarSala2.Text == "Taller_de_Mecanica_Automotriz" && boxSalasMA2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Electricidad" && boxSalasE2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Mecanica_Industrial" && boxSalasMI2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Construcciones_Metalicas" && boxSalasCM2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Terminaciones_de_la_Construccion" && boxSalasTC2.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione una sala de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtSerieSalaB.Text) || boxRubroBS2.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, inserte un NºInterno y el Rubro");
                return;
            }

            string codigo = txtSerieSalaB.Text;
            string rubro = boxRubroBS2.Text;

            string consulta = "SELECT NºInterno, Descripcion_Especie, Rubro, NºSerie, Cantidad, Estado, Observaciones FROM " + sala + " WHERE NºInterno LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1"; ;
            MySqlConnection conexion = Conexion.getConexion();
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            try
            {
                // Ejecutar la consulta SQL y obtener los resultados
                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    // Si se encontraron resultados, mostrarlos en los controles correspondientes
                    reader.Read();
                    txtInterno2.Text = reader.GetString("NºInterno");
                    txtProductoSala2.Text = reader.GetString("Descripcion_Especie");
                    boxRubroSala2.Text = reader.GetString("Rubro");
                    txtSerieSala2.Text = reader.GetString("NºSerie");
                    txtCantidadSala2.Text = reader.GetString("Cantidad");
                    boxEstadoSala2.Text = reader.GetString("Estado");
                    txtObservacionesSala2.Text = reader.GetString("Observaciones");
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para el número de serie especificado");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void boxClase3_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxClase3.Enabled = false;
        }

        private void txtProductoSala2_TextChanged(object sender, EventArgs e)
        {
            txtProductoSala2.ReadOnly = true;
        }

        private void boxRubroSala2_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxRubroSala2.Enabled = false;
        }

        private void txtSerieSala2_TextChanged(object sender, EventArgs e)
        {
            txtSerieSala2.ReadOnly = true;
        }

        private void txtCantidadSala2_TextChanged(object sender, EventArgs e)
        {
            txtCantidadSala2.ReadOnly = true;
        }

        private void boxEstadoSala2_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxEstadoSala2.Enabled = false;
        }

        private void txtObservacionesSala2_TextChanged(object sender, EventArgs e)
        {
            txtObservacionesSala2.ReadOnly = true;
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (boxLugarSala2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((boxLugarSala2.Text == "Taller_de_Mecanica_Automotriz" && boxSalasMA2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Electricidad" && boxSalasE2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Mecanica_Industrial" && boxSalasMI2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Construcciones_Metalicas" && boxSalasCM2.SelectedItem == null) ||
                (boxLugarSala2.Text == "Taller_de_Terminaciones_de_la_Construccion" && boxSalasTC2.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione la sala en el cual quiere eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtSerieSalaB.Text) || boxRubroBS2.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, Agrege el NºInterno y el Rubro del prodcuto a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxLugarSalas.Text == "Taller_de_Mecanica_Automotriz")
            {
                sala = boxSalasMA2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Electricidad")
            {
                sala = boxSalasE2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Mecanica_Industrial")
            {
                sala = boxSalasMI2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Construcciones_Metalicas")
            {
                sala = boxSalasCM2.Text;
            }
            else if (boxLugarSala2.Text == "Taller_de_Terminaciones_de_la_Construccion")
            {
                sala = boxSalasTC2.Text;
            }

            string sql = $"DELETE FROM {sala} WHERE NºInterno = @NºInterno AND Rubro = @Rubro";
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.Add(new MySqlParameter("@NºInterno", txtSerieSalaB.Text));
            command.Parameters.Add(new MySqlParameter("@Rubro", boxRubroBS2.Text));

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el NºInterno proporcionado.");
            }

            string query1 = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

            using (MySqlConnection con = Conexion.getConexion())
            using (MySqlCommand comando = new MySqlCommand(query1, con))
            {
                comando.Parameters.Add(new MySqlParameter("@NºActual", txtSerieSalaB.Text));
                comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtProductoSala2.Text));
                comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                comando.Parameters.Add(new MySqlParameter("@Alteracion", "Eliminado"));
                comando.Parameters.Add(new MySqlParameter("@Tabla", sala));
                comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                con.Open();
                comando.ExecuteNonQuery();
            }

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                txtProductoSala2.Clear();
                boxRubroSala2.SelectedIndex = -1;
                txtSerieSala2.Clear();
                txtCantidadSala2.Clear();
                boxEstadoSala2.SelectedIndex = -1;
                txtObservacionesSala2.Clear();
                txtInterno2.Clear();
                boxRubroBS2.SelectedIndex = -1;
                txtSerieSalaB.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void ckSalas3_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSectores3.SelectedItem == null && ckSalas3.Checked)
            {
                t88.Visible = false;
                boxSectores3.Visible = false;
                t87.Visible = true;
                boxLugarSala3.Visible = true;
                t86.Visible = true;
                t89.Visible = false;
                boxLugar.Visible = false;

                txtAnterior2.Visible = false;
                txtTipo2.Visible = false;
                txtActual3.Visible = false;
                txtEspecie2.Visible = false;
                boxRubro2.Visible = false;
                boxEstado2.Visible = false;
                txtResponsable2.Visible = false;
                txtTalleres2.Visible = false;
                txtUbicacion2.Visible = false;
                txtValor2.Visible = false;
                txtFecha2.Visible = false;
                txtOrigen2.Visible = false;
                boxClase1.Visible = false;
                txtActual2.Visible = false;

                t1.Visible = false;
                t2.Visible = false;
                t90.Visible = false;
                t91.Visible = false;
                t37.Visible = false;
                t3.Visible = false;
                t8.Visible = false;
                t4.Visible = false;
                t5.Visible = false;
                t92.Visible = false;
                t6.Visible = false;
                t7.Visible = false;
                t40.Visible = false;

                t80.Visible = true;
                t81.Visible = true;
                t82.Visible = true;
                t83.Visible = true;
                t84.Visible = true;
                t85.Visible = true;
                t93.Visible = true;

                txtProductoSala3.Visible = true;
                boxRubroSala3.Visible = true;
                txtSerieSala3.Visible = true;
                txtCantidadSala3.Visible = true;
                boxEstadoSala3.Visible = true;
                txtObservacionesSala3.Visible = true;
                txtSerieSalaB2.Visible = true;

                boxSalasLujo3.Visible = true;
                btnModificar.Visible = false;
                btnModificar2.Visible = true;
                btnBuscarSalas2.Visible = true;
                txtRut3.Visible = false;
                txtEstablecimiento3.Visible = false;
                t99.Visible = false;
                t100.Visible = false;
                boxClase1.Visible = false;
                t40.Visible = false;
                txtInterno3.Visible = true;
                t103.Visible = true;
                boxRubroB1.Visible = false;
                boxRubroBS1.Visible = true;

                ckAyO.Enabled = false;
            }
            else if (boxSectores3.SelectedItem == null || boxSectores3.SelectedItem.ToString() == "Inventario General" && ckSalas3.Checked)
            {
                t88.Visible = false;
                boxSectores3.Visible = false;
                t87.Visible = true;
                boxLugarSala3.Visible = true;
                t86.Visible = true;
                t89.Visible = false;
                boxLugar.Visible = false;

                txtAnterior2.Visible = false;
                txtTipo2.Visible = false;
                txtActual3.Visible = false;
                txtEspecie2.Visible = false;
                boxRubro2.Visible = false;
                boxEstado2.Visible = false;
                txtResponsable2.Visible = false;
                txtTalleres2.Visible = false;
                txtUbicacion2.Visible = false;
                txtValor2.Visible = false;
                txtFecha2.Visible = false;
                txtOrigen2.Visible = false;
                boxClase1.Visible = false;
                txtActual2.Visible = false;

                t1.Visible = false;
                t2.Visible = false;
                t90.Visible = false;
                t91.Visible = false;
                t37.Visible = false;
                t3.Visible = false;
                t8.Visible = false;
                t4.Visible = false;
                t5.Visible = false;
                t92.Visible = false;
                t6.Visible = false;
                t7.Visible = false;
                t40.Visible = false;

                t80.Visible = true;
                t81.Visible = true;
                t82.Visible = true;
                t83.Visible = true;
                t84.Visible = true;
                t85.Visible = true;
                t93.Visible = true;


                txtProductoSala3.Visible = true;
                boxRubroSala3.Visible = true;
                txtSerieSala3.Visible = true;
                txtCantidadSala3.Visible = true;
                boxEstadoSala3.Visible = true;
                txtObservacionesSala3.Visible = true;
                txtSerieSalaB2.Visible = true;

                boxSalasLujo3.Visible = true;
                btnModificar.Visible = false;
                btnModificar2.Visible = true;
                btnBuscarSalas2.Visible = true;
                txtRut3.Visible = false;
                txtEstablecimiento3.Visible = false;
                t99.Visible = false;
                t100.Visible = false;
                boxClase1.Visible = false;
                t40.Visible = false;

                txtInterno3.Visible = true;
                t103.Visible = true;

                boxRubroB1.Visible = false;
                boxRubroBS1.Visible = true;

                ckAyO.Enabled = false;
            }

            else if (boxSectores3.SelectedItem.ToString() == "Materiales de Escritorio" && ckSalas3.Checked)
            {
                t88.Visible = false;
                boxSectores3.Visible = false;
                t87.Visible = true;
                boxLugarSala3.Visible = true;
                t86.Visible = true;
                t89.Visible = false;
                boxLugar.Visible = false;

                txtActual3.Visible = false;
                txtEspecie2.Visible = false;
                txtUbicacion2.Visible = false;
                boxRubro2.Visible = false;
                txtRetirador.Visible = false;
                txtIngreso.Visible = false;
                boxTipo.Visible = false;
                txtDevolucion.Visible = false;
                txtAnterior2.Visible = false;
                txtTipo2.Visible = false;
                txtResponsable2.Visible = false;
                txtValor2.Visible = false;
                txtActual2.Visible = false;


                t25.Visible = false;
                t26.Visible = false;
                t27.Visible = false;
                t28.Visible = false;
                t90.Visible = false;
                t91.Visible = false;
                t37.Visible = false;
                t1.Visible = false;
                t2.Visible = false;
                t8.Visible = false;
                t5.Visible = false;
                t92.Visible = false;

                t80.Visible = true;
                t81.Visible = true;
                t82.Visible = true;
                t83.Visible = true;
                t84.Visible = true;
                t85.Visible = true;
                t93.Visible = true;

                txtProductoSala3.Visible = true;
                boxRubroSala3.Visible = true;
                txtSerieSala3.Visible = true;
                txtCantidadSala3.Visible = true;
                boxEstadoSala3.Visible = true;
                txtObservacionesSala3.Visible = true;
                txtSerieSalaB2.Visible = true;

                boxSalasLujo3.Visible = true;
                btnModificar.Visible = false;
                btnModificar2.Visible = true;
                btnBuscarSalas2.Visible = true;

                txtRut3.Visible = false;
                txtEstablecimiento3.Visible = false;
                t99.Visible = false;
                t100.Visible = false;
                boxClase1.Visible = false;
                t40.Visible = false;

                txtInterno3.Visible = true;
                t103.Visible = true;

                boxRubroB1.Visible = false;
                boxRubroBS1.Visible = true;

                ckAyO.Enabled = false;
            }

            else if (boxSectores3.SelectedItem.ToString() == "Materiales de Aseo" && ckSalas3.Checked)
            {
                t88.Visible = false;
                boxSectores3.Visible = false;
                t87.Visible = true;
                boxLugarSala3.Visible = true;
                t86.Visible = true;
                t89.Visible = false;
                boxLugar.Visible = false;

                txtActual3.Visible = false;
                txtEspecie2.Visible = false;
                txtUbicacion2.Visible = false;
                txtRetirador.Visible = false;
                txtIngreso.Visible = false;
                boxTipo.Visible = false;
                txtDevolucion.Visible = false;
                txtAnterior2.Visible = false;
                txtTipo2.Visible = false;
                boxRubro2.Visible = false;
                txtResponsable2.Visible = false;
                txtValor2.Visible = false;
                txtActual2.Visible = false;


                t25.Visible = false;
                t26.Visible = false;
                t27.Visible = false;
                t28.Visible = false;
                t90.Visible = false;
                t91.Visible = false;
                t1.Visible = false;
                t2.Visible = false;
                t37.Visible = false;
                t8.Visible = false;
                t92.Visible = false;
                t5.Visible = false;

                t80.Visible = true;
                t81.Visible = true;
                t82.Visible = true;
                t83.Visible = true;
                t84.Visible = true;
                t85.Visible = true;
                t93.Visible = true;

                txtProductoSala3.Visible = true;
                boxRubroSala3.Visible = true;
                txtSerieSala3.Visible = true;
                txtCantidadSala3.Visible = true;
                boxEstadoSala3.Visible = true;
                txtObservacionesSala3.Visible = true;
                txtSerieSalaB2.Visible = true;

                boxSalasLujo3.Visible = true;
                btnModificar.Visible = false;
                btnModificar2.Visible = true;
                btnBuscarSalas2.Visible = true;

                txtRut3.Visible = false;
                txtEstablecimiento3.Visible = false;
                t99.Visible = false;
                t100.Visible = false;
                boxClase1.Visible = false;
                t40.Visible = false;

                txtInterno3.Visible = true;
                t103.Visible = true;

                boxRubroB1.Visible = false;
                boxRubroBS1.Visible = true;

                ckAyO.Enabled = false;
            }

            if (boxSectores3.SelectedItem == null && !ckSalas3.Checked)
            {
                t88.Visible = true;
                boxSectores3.Visible = true;
                t87.Visible = false;
                boxLugarSala3.Visible = false;
                t86.Visible = false;
                t89.Visible = true;
                boxLugar.Visible = true;

                txtAnterior2.Visible = true;
                txtTipo2.Visible = true;
                txtActual3.Visible = true;
                txtEspecie2.Visible = true;
                boxRubro2.Visible = true;
                boxEstado2.Visible = true;
                txtResponsable2.Visible = true;
                txtTalleres2.Visible = true;
                txtUbicacion2.Visible = true;
                txtValor2.Visible = true;
                txtFecha2.Visible = true;
                txtOrigen2.Visible = true;
                boxClase1.Visible = true;
                txtActual2.Visible = true;

                t1.Visible = true;
                t2.Visible = true;
                t90.Visible = true;
                t91.Visible = true;
                t37.Visible = true;
                t3.Visible = true;
                t8.Visible = true;
                t4.Visible = true;
                t5.Visible = true;
                t92.Visible = true;
                t6.Visible = true;
                t7.Visible = true;
                t40.Visible = true;

                t80.Visible = false;
                t81.Visible = false;
                t82.Visible = false;
                t83.Visible = false;
                t84.Visible = false;
                t85.Visible = false;
                t93.Visible = false;

                txtProductoSala3.Visible = false;
                boxRubroSala3.Visible = false;
                txtSerieSala3.Visible = false;
                txtCantidadSala3.Visible = false;
                boxEstadoSala3.Visible = false;
                txtObservacionesSala3.Visible = false;
                txtSerieSalaB2.Visible = false;

                boxSalasLujo3.Visible = false;
                btnModificar.Visible = true;
                btnModificar2.Visible = false;
                btnBuscarSalas2.Visible = false;
                txtRut3.Visible = true;
                txtEstablecimiento3.Visible = true;
                t99.Visible = true;
                t100.Visible = true;
                boxClase1.Visible = true;
                t40.Visible = true;

                txtInterno3.Visible = false;
                t103.Visible = false;

                boxRubroB1.Visible = true;
                boxRubroBS1.Visible = false;
                ckAyO.Enabled = true;

                boxSalasMA3.Visible = false;
                boxSalasCM3.Visible = false;
                boxSalasE3.Visible = false;
                boxSalasMI3.Visible = false;
                boxSalasTC3.Visible = false;

                boxLugarSala3.SelectedIndex = -1;

                txtProductoSala3.Clear();
                boxRubroSala3.SelectedIndex = -1;
                txtSerieSala3.Clear();
                txtCantidadSala3.Clear();
                boxEstadoSala3.SelectedIndex = -1;
                txtObservacionesSala3.Clear();
                txtInterno3.Clear();
                txtSerieSalaB2.Clear();
                boxRubroBS1.SelectedIndex = -1;
            }

            else if (boxSectores3.SelectedItem != null && boxSectores3.SelectedItem.ToString() == "Inventario General" && !ckSalas3.Checked)
            {
                t88.Visible = true;
                boxSectores3.Visible = true;
                t87.Visible = false;
                boxLugarSala3.Visible = false;
                t86.Visible = false;
                t89.Visible = true;
                boxLugar.Visible = true;

                txtAnterior2.Visible = true;
                txtTipo2.Visible = true;
                txtActual3.Visible = true;
                txtEspecie2.Visible = true;
                boxRubro2.Visible = true;
                boxEstado2.Visible = true;
                txtResponsable2.Visible = true;
                txtTalleres2.Visible = true;
                txtUbicacion2.Visible = true;
                txtValor2.Visible = true;
                txtFecha2.Visible = true;
                txtOrigen2.Visible = true;
                boxClase1.Visible = true;
                txtActual2.Visible = true;

                t1.Visible = true;
                t2.Visible = true;
                t90.Visible = true;
                t91.Visible = true;
                t37.Visible = true;
                t3.Visible = true;
                t8.Visible = true;
                t4.Visible = true;
                t5.Visible = true;
                t92.Visible = true;
                t6.Visible = true;
                t7.Visible = true;
                t40.Visible = true;

                t80.Visible = false;
                t81.Visible = false;
                t82.Visible = false;
                t83.Visible = false;
                t84.Visible = false;
                t85.Visible = false;
                t93.Visible = false;

                txtProductoSala3.Visible = false;
                boxRubroSala3.Visible = false;
                txtSerieSala3.Visible = false;
                txtCantidadSala3.Visible = false;
                boxEstadoSala3.Visible = false;
                txtObservacionesSala3.Visible = false;
                txtSerieSalaB2.Visible = false;

                boxSalasLujo3.Visible = false;
                btnModificar.Visible = true;
                btnModificar2.Visible = false;
                btnBuscarSalas2.Visible = false;
                txtRut3.Visible = true;
                txtEstablecimiento3.Visible = true;
                t99.Visible = true;
                t100.Visible = true;

                txtRut3.Visible = true;
                txtEstablecimiento3.Visible = true;
                t99.Visible = true;
                t100.Visible = true;
                boxClase1.Visible = true;
                t40.Visible = true;

                txtInterno3.Visible = false;
                t103.Visible = false;

                boxRubroB1.Visible = true;
                boxRubroBS1.Visible = false;

                ckAyO.Enabled = true;

                boxSalasMA3.Visible = false;
                boxSalasCM3.Visible = false;
                boxSalasE3.Visible = false;
                boxSalasMI3.Visible = false;
                boxSalasTC3.Visible = false;

                boxLugarSala3.SelectedIndex = -1;

                txtProductoSala3.Clear();
                boxRubroSala3.SelectedIndex = -1;
                txtSerieSala3.Clear();
                txtCantidadSala3.Clear();
                boxEstadoSala3.SelectedIndex = -1;
                txtObservacionesSala3.Clear();
                txtInterno3.Clear();
                txtSerieSalaB2.Clear();
                boxRubroBS1.SelectedIndex = -1;
            }
            else if (boxSectores3.SelectedItem != null && boxSectores3.SelectedItem.ToString() == "Materiales de Escritorio" && !ckSalas3.Checked)
            {
                t88.Visible = true;
                boxSectores3.Visible = true;
                t87.Visible = false;
                boxLugarSala3.Visible = false;
                t86.Visible = false;
                t89.Visible = true;
                boxLugar.Visible = true;

                txtActual3.Visible = true;
                txtEspecie2.Visible = true;
                txtUbicacion2.Visible = true;
                boxRubro2.Visible = true;
                txtRetirador.Visible = true;
                txtIngreso.Visible = true;
                boxTipo.Visible = true;
                txtDevolucion.Visible = true;
                txtAnterior2.Visible = true;
                txtTipo2.Visible = true;
                txtResponsable2.Visible = true;
                txtValor2.Visible = true;
                txtActual2.Visible = true;


                t25.Visible = true;
                t26.Visible = true;
                t27.Visible = true;
                t28.Visible = true;
                t90.Visible = true;
                t91.Visible = true;
                t37.Visible = true;
                t1.Visible = true;
                t2.Visible = true;
                t8.Visible = true;
                t5.Visible = true;
                t92.Visible = true;

                t80.Visible = false;
                t81.Visible = false;
                t82.Visible = false;
                t83.Visible = false;
                t84.Visible = false;
                t85.Visible = false;
                t93.Visible = false;

                txtProductoSala3.Visible = false;
                boxRubroSala3.Visible = false;
                txtSerieSala3.Visible = false;
                txtCantidadSala3.Visible = false;
                boxEstadoSala3.Visible = false;
                txtObservacionesSala3.Visible = false;
                txtSerieSalaB2.Visible = false;

                boxSalasLujo3.Visible = false;
                btnModificar.Visible = true;
                btnModificar2.Visible = false;
                btnBuscarSalas2.Visible = false;

                txtRut3.Visible = true;
                txtEstablecimiento3.Visible = true;
                t99.Visible = true;
                t100.Visible = true;
                boxClase1.Visible = true;
                t40.Visible = true;

                txtInterno3.Visible = false;
                t103.Visible = false;

                boxRubroB1.Visible = true;
                boxRubroBS1.Visible = false;
            }
            else if (boxSectores3.SelectedItem != null && boxSectores3.SelectedItem.ToString() == "Materiales de Aseo" && !ckSalas3.Checked)
            {
                t88.Visible = true;
                boxSectores3.Visible = true;
                t87.Visible = false;
                boxLugarSala3.Visible = false;
                t86.Visible = false;
                t89.Visible = true;
                boxLugar.Visible = true;

                txtActual3.Visible = true;
                txtEspecie2.Visible = true;
                txtUbicacion2.Visible = true;
                txtRetirador.Visible = true;
                txtIngreso.Visible = true;
                boxTipo.Visible = true;
                txtDevolucion.Visible = true;
                txtAnterior2.Visible = true;
                txtTipo2.Visible = true;
                boxRubro2.Visible = true;
                txtResponsable2.Visible = true;
                txtValor2.Visible = true;
                txtActual2.Visible = true;


                t25.Visible = true;
                t26.Visible = true;
                t27.Visible = true;
                t28.Visible = true;
                t90.Visible = true;
                t91.Visible = true;
                t1.Visible = true;
                t2.Visible = true;
                t37.Visible = true;
                t8.Visible = true;
                t92.Visible = true;
                t5.Visible = true;

                t80.Visible = false;
                t81.Visible = false;
                t82.Visible = false;
                t83.Visible = false;
                t84.Visible = false;
                t85.Visible = false;
                t93.Visible = false;

                txtProductoSala3.Visible = false;
                boxRubroSala3.Visible = false;
                txtSerieSala3.Visible = false;
                txtCantidadSala3.Visible = false;
                boxEstadoSala3.Visible = false;
                txtObservacionesSala3.Visible = false;
                txtSerieSalaB2.Visible = false;

                boxSalasLujo3.Visible = false;
                btnModificar.Visible = true;
                btnModificar2.Visible = false;
                btnBuscarSalas2.Visible = false;

                txtRut3.Visible = true;
                txtEstablecimiento3.Visible = true;
                t99.Visible = true;
                t100.Visible = true;
                boxClase1.Visible = true;
                t40.Visible = true;

                txtInterno3.Visible = false;
                t103.Visible = false;

                boxRubroB1.Visible = true;
                boxRubroBS1.Visible = false;
            }
        }

        private void boxLugarSala3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxLugarSala3.SelectedItem != null && boxLugarSala3.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && ckSalas3.Checked)
            {
                boxSalasMA3.Visible = true;


                boxSalasTC3.Visible = false;
                boxSalasMI3.Visible = false;
                boxSalasE3.Visible = false;
                boxSalasCM3.Visible = false;
                boxSalasLujo3.Visible = false;
            }
            else if (boxLugarSala3.SelectedItem != null && boxLugarSala3.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && ckSalas3.Checked)
            {
                boxSalasCM3.Visible = true;


                boxSalasMA3.Visible = false;
                boxSalasTC3.Visible = false;
                boxSalasMI3.Visible = false;
                boxSalasE3.Visible = false;
                boxSalasLujo3.Visible = false;
            }
            else if (boxLugarSala3.SelectedItem != null && boxLugarSala3.SelectedItem.ToString() == "Taller_de_Electricidad" && ckSalas3.Checked)
            {
                boxSalasE3.Visible = true;

                boxSalasMA3.Visible = false;
                boxSalasTC3.Visible = false;
                boxSalasMI3.Visible = false;
                boxSalasCM3.Visible = false;
                boxSalasLujo3.Visible = false;
            }
            else if (boxLugarSala3.SelectedItem != null && boxLugarSala3.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && ckSalas3.Checked)
            {
                boxSalasMI3.Visible = true;

                boxSalasMA3.Visible = false;
                boxSalasTC3.Visible = false;
                boxSalasCM3.Visible = false;
                boxSalasE3.Visible = false;
                boxSalasLujo3.Visible = false;
            }
            else if (boxLugarSala3.SelectedItem != null && boxLugarSala3.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && ckSalas3.Checked)
            {
                boxSalasTC3.Visible = true;

                boxSalasCM3.Visible = false;
                boxSalasE3.Visible = false;
                boxSalasMA3.Visible = false;
                boxSalasMI3.Visible = false;
                boxSalasLujo3.Visible = false;
            }
        }

        private void LlenarComboBoxSalas3()
        {
            MySqlConnection connMA = Conexion.getConexion();
            MySqlCommand cmdMA = new MySqlCommand("SELECT nombre FROM masalas", connMA);
            connMA.Open();
            MySqlDataReader readerMA = cmdMA.ExecuteReader();
            while (readerMA.Read())
            {
                string nombreSalaMA = readerMA.GetString("nombre");
                boxSalasMA3.Items.Add(nombreSalaMA);
            }
            readerMA.Close();
            cmdMA.Dispose();
            connMA.Close();

            // ComboBox boxSalasCM
            MySqlConnection connCM = Conexion.getConexion();
            MySqlCommand cmdCM = new MySqlCommand("SELECT nombre FROM cmsalas", connCM);
            connCM.Open();
            MySqlDataReader readerCM = cmdCM.ExecuteReader();
            while (readerCM.Read())
            {
                string nombreSalaCM = readerCM.GetString("nombre");
                boxSalasCM3.Items.Add(nombreSalaCM);
            }
            readerCM.Close();
            cmdCM.Dispose();
            connCM.Close();

            // ComboBox boxSalasE
            MySqlConnection connE = Conexion.getConexion();
            MySqlCommand cmdE = new MySqlCommand("SELECT nombre FROM esalas", connE);
            connE.Open();
            MySqlDataReader readerE = cmdE.ExecuteReader();
            while (readerE.Read())
            {
                string nombreSalaE = readerE.GetString("nombre");
                boxSalasE3.Items.Add(nombreSalaE);
            }
            readerE.Close();
            cmdE.Dispose();
            connE.Close();

            // ComboBox boxSalasMI
            MySqlConnection connMI = Conexion.getConexion();
            MySqlCommand cmdMI = new MySqlCommand("SELECT nombre FROM misalas", connMI);
            connMI.Open();
            MySqlDataReader readerMI = cmdMI.ExecuteReader();
            while (readerMI.Read())
            {
                string nombreSalaMI = readerMI.GetString("nombre");
                boxSalasMI3.Items.Add(nombreSalaMI);
            }
            readerMI.Close();
            cmdMI.Dispose();
            connMI.Close();

            // ComboBox boxSalasTC
            MySqlConnection connTC = Conexion.getConexion();
            MySqlCommand cmdTC = new MySqlCommand("SELECT nombre FROM tcsalas", connTC);
            connTC.Open();
            MySqlDataReader readerTC = cmdTC.ExecuteReader();
            while (readerTC.Read())
            {
                string nombreSalaTC = readerTC.GetString("nombre");
                boxSalasTC3.Items.Add(nombreSalaTC);
            }
            readerTC.Close();
            cmdTC.Dispose();
            connTC.Close();

            MySqlConnection connAV = Conexion.getConexion();
            MySqlCommand cmdAV = new MySqlCommand("SELECT nombre FROM Aulas", connAV);
            connAV.Open();
            MySqlDataReader readerAV = cmdAV.ExecuteReader();
            while (readerAV.Read())
            {
                string nombreSalaAV = readerAV.GetString("nombre");
                boxAulasV.Items.Add(nombreSalaAV);
            }
            readerAV.Close();
            cmdAV.Dispose();
            connAV.Close();

            MySqlConnection connOV = Conexion.getConexion();
            MySqlCommand cmdOV = new MySqlCommand("SELECT nombre FROM Oficinas", connOV);
            connOV.Open();
            MySqlDataReader readerOV = cmdOV.ExecuteReader();
            while (readerOV.Read())
            {
                string nombreSalaOV = readerOV.GetString("nombre");
                boxOficinasV.Items.Add(nombreSalaOV);
            }
            readerOV.Close();
            cmdOV.Dispose();
            connOV.Close();

            MySqlConnection connI = Conexion.getConexion();
            MySqlCommand cmdI = new MySqlCommand("SELECT nombre FROM Internado_IG", connI);
            connI.Open();
            MySqlDataReader readerI = cmdI.ExecuteReader();
            while (readerI.Read())
            {
                string nombreSalaI = readerI.GetString("nombre");
                boxInternado.Items.Add(nombreSalaI);
            }
            readerI.Close();
            cmdI.Dispose();
            connI.Close();
        }

        private void btnBuscarSalas2_Click(object sender, EventArgs e)
        {
            if (boxLugarSala3.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxLugarSala3.Text == "Taller_de_Mecanica_Automotriz")
            {
                sala = boxSalasMA3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Electricidad")
            {
                sala = boxSalasE3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Mecanica_Industrial")
            {
                sala = boxSalasMI3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Construcciones_Metalicas")
            {
                sala = boxSalasCM3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Terminaciones_de_la_Construccion")
            {
                sala = boxSalasTC3.Text;
            }

            if ((boxLugarSala3.Text == "Taller_de_Mecanica_Automotriz" && boxSalasMA3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Electricidad" && boxSalasE3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Mecanica_Industrial" && boxSalasMI3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Construcciones_Metalicas" && boxSalasCM3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Terminaciones_de_la_Construccion" && boxSalasTC3.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione una sala de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (string.IsNullOrEmpty(txtSerieSalaB2.Text) || boxRubroBS1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, inserte un NºInterno y el Rubro");
                return;
            }
            
            string codigo = txtSerieSalaB2.Text;
            string rubro = boxRubroBS1.Text;

            string consulta = "SELECT NºInterno, Descripcion_Especie, Rubro, NºSerie, Cantidad, Estado, Observaciones FROM " + sala + " WHERE NºInterno LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1"; ;
            MySqlConnection conexion = Conexion.getConexion();
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            try
            {
                // Ejecutar la consulta SQL y obtener los resultados
                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    // Si se encontraron resultados, mostrarlos en los controles correspondientes
                    reader.Read();
                    txtInterno3.Text = reader.GetString("NºInterno");
                    txtProductoSala3.Text = reader.GetString("Descripcion_Especie");
                    boxRubroSala3.Text = reader.GetString("Rubro");
                    txtSerieSala3.Text = reader.GetString("NºSerie");
                    txtCantidadSala3.Text = reader.GetString("Cantidad");
                    boxEstadoSala3.Text = reader.GetString("Estado");
                    txtObservacionesSala3.Text = reader.GetString("Observaciones");
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para el número de serie especificado");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            if (boxLugarSala3.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((boxLugarSala3.Text == "Taller_de_Mecanica_Automotriz" && boxSalasMA3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Electricidad" && boxSalasE3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Mecanica_Industrial" && boxSalasMI3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Construcciones_Metalicas" && boxSalasCM3.SelectedItem == null) ||
                (boxLugarSala3.Text == "Taller_de_Terminaciones_de_la_Construccion" && boxSalasTC3.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione la sala en el cual quiere eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtSerieSalaB2.Text) || boxRubroBS1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, Agrege el NºInterno del prodcuto y el Rubro para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxLugarSala3.Text == "Taller_de_Mecanica_Automotriz")
            {
                sala = boxSalasMA3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Electricidad")
            {
                sala = boxSalasE3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Mecanica_Industrial")
            {
                sala = boxSalasMI3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Construcciones_Metalicas")
            {
                sala = boxSalasCM3.Text;
            }
            else if (boxLugarSala3.Text == "Taller_de_Terminaciones_de_la_Construccion")
            {
                sala = boxSalasTC3.Text;
            }

            string sql = $"UPDATE {sala} SET NºInterno=@Nºinterno2, Descripcion_Especie=@Descripcion_Especie, Rubro=@Rubro, NºSerie=@NºSerie," +
                $" Cantidad=@Cantidad, Estado=@Estado, Observaciones=@Observaciones WHERE NºInterno=@NºInterno AND Rubro=@Rubro2";
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.Add(new MySqlParameter("@Rubro2", boxRubroBS1.Text));
            command.Parameters.Add(new MySqlParameter("@NºInterno", txtSerieSalaB2.Text));
            command.Parameters.Add(new MySqlParameter("@NºInterno2", txtInterno3.Text));
            command.Parameters.Add(new MySqlParameter("@NºSerie", txtSerieSala3.Text));
            command.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtProductoSala3.Text));
            command.Parameters.Add(new MySqlParameter("@Rubro", boxRubroSala3.Text));
            command.Parameters.Add(new MySqlParameter("@Cantidad", txtCantidadSala3.Text));
            command.Parameters.Add(new MySqlParameter("@Estado", boxEstadoSala3.Text));
            command.Parameters.Add(new MySqlParameter("@Observaciones", txtObservacionesSala3.Text));

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro Modificado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el NºInterno proporcionado.");
            }

            string query1 = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

            using (MySqlConnection con = Conexion.getConexion())
            using (MySqlCommand comando = new MySqlCommand(query1, con))
            {
                comando.Parameters.Add(new MySqlParameter("@NºActual", txtSerieSalaB2.Text));
                comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtProductoSala3.Text));
                comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                comando.Parameters.Add(new MySqlParameter("@Alteracion", "Modificado"));
                comando.Parameters.Add(new MySqlParameter("@Tabla", sala));
                comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                con.Open();
                comando.ExecuteNonQuery();
            }

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                txtProductoSala3.Clear();
                boxRubroSala3.SelectedIndex = -1;
                txtSerieSala3.Clear();
                txtCantidadSala3.Clear();
                boxEstadoSala3.SelectedIndex = -1;
                txtObservacionesSala3.Clear();
                txtInterno3.Clear();
                txtSerieSalaB2.Clear();
                boxRubroBS1.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Modificar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void ckSalas4_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarBoxDepartamentos();
        }

        private void ActualizarBoxDepartamentos()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            boxDepartamentos2.Items.Clear();

            if (boxSectores2.SelectedItem.ToString() == "Inventario General" && !ckSalas4.Checked)
            {
                boxLujo.Visible = false;
                tSalas.Visible = false;
                boxTallerSalas.Visible = false;
                boxDepartamentos2.Visible = true;

                boxDepartamentos2.Items.Add("Taller_de_Mecanica_Automotriz");
                boxDepartamentos2.Items.Add("Taller_de_Mecanica_Industrial");
                boxDepartamentos2.Items.Add("Taller_de_Construcciones_Metalicas");
                boxDepartamentos2.Items.Add("Taller_de_Terminaciones_de_la_Construccion");
                boxDepartamentos2.Items.Add("Taller_de_Electricidad");

                boxDepartamentos2.Items.Add("Aulas");
                boxDepartamentos2.Items.Add("Oficinas");
                boxDepartamentos2.Items.Add("Internado");

                ckSalas4.Visible = true;
                boxSalasCM5.Visible = false;
                boxSalasE5.Visible = false;
                boxSalasMA5.Visible = false;
                boxSalasMI5.Visible = false;
                boxSalasTC5.Visible = false;
            }
            else if (boxSectores2.SelectedItem.ToString() == "Materiales de Escritorio" && !ckSalas4.Checked)
            {
                boxLujo.Visible = false;
                tSalas.Visible = false;
                boxTallerSalas.Visible = false;
                boxDepartamentos2.Visible = true;

                boxDepartamentos2.Items.Add("DeptoUTP");
                boxDepartamentos2.Items.Add("DeptoAdministracion");
                boxDepartamentos2.Items.Add("DeptoInspectoriaGeneral");
                boxDepartamentos2.Items.Add("DeptoPsicosocial");
                boxDepartamentos2.Items.Add("DeptoDireccion");
                boxDepartamentos2.Items.Add("DeptoBiblioteca");
                boxDepartamentos2.Items.Add("DeptoInternado");

                ckSalas4.Visible = false;
                boxSalasCM5.Visible = false;
                boxSalasE5.Visible = false;
                boxSalasMA5.Visible = false;
                boxSalasMI5.Visible = false;
                boxSalasTC5.Visible = false;

                boxOficinasV.Visible = false;
                boxAulasV.Visible = false;

                lAV.Visible = false;
                lOV.Visible = false;
            }
            else if (boxSectores2.SelectedItem.ToString() == "Materiales de Aseo" && !ckSalas4.Checked)
            {
                boxLujo.Visible = false;
                tSalas.Visible = false;
                boxTallerSalas.Visible = false;
                boxDepartamentos2.Visible = true;

                boxDepartamentos2.Items.Add("Liceo");
                boxDepartamentos2.Items.Add("Internado ");

                ckSalas4.Visible = false;
                boxSalasCM5.Visible = false;
                boxSalasE5.Visible = false;
                boxSalasMA5.Visible = false;
                boxSalasMI5.Visible = false;
                boxSalasTC5.Visible = false;

                boxOficinasV.Visible = false;
                boxAulasV.Visible = false;

                lAV.Visible = false;
                lOV.Visible = false;

            }
            else if (ckSalas4.Checked)
            {
                boxLujo.Visible = true;
                tSalas.Visible = true;
                boxTallerSalas.Visible = true;
                boxDepartamentos2.Visible = false;

                boxOficinasV.Visible = false;
                boxAulasV.Visible = false;
                lAV.Visible = false;
                lOV.Visible = false;
                boxInternado.Visible = false;
            }
        }

        private void LlenarComboBoxSalas4()
        {
            MySqlConnection connMA = Conexion.getConexion();
            MySqlCommand cmdMA = new MySqlCommand("SELECT nombre FROM masalas", connMA);
            connMA.Open();
            MySqlDataReader readerMA = cmdMA.ExecuteReader();
            while (readerMA.Read())
            {
                string nombreSalaMA = readerMA.GetString("nombre");
                boxSalasMA5.Items.Add(nombreSalaMA);
            }
            readerMA.Close();
            cmdMA.Dispose();
            connMA.Close();

            // ComboBox boxSalasCM
            MySqlConnection connCM = Conexion.getConexion();
            MySqlCommand cmdCM = new MySqlCommand("SELECT nombre FROM cmsalas", connCM);
            connCM.Open();
            MySqlDataReader readerCM = cmdCM.ExecuteReader();
            while (readerCM.Read())
            {
                string nombreSalaCM = readerCM.GetString("nombre");
                boxSalasCM5.Items.Add(nombreSalaCM);
            }
            readerCM.Close();
            cmdCM.Dispose();
            connCM.Close();

            // ComboBox boxSalasE
            MySqlConnection connE = Conexion.getConexion();
            MySqlCommand cmdE = new MySqlCommand("SELECT nombre FROM esalas", connE);
            connE.Open();
            MySqlDataReader readerE = cmdE.ExecuteReader();
            while (readerE.Read())
            {
                string nombreSalaE = readerE.GetString("nombre");
                boxSalasE5.Items.Add(nombreSalaE);
            }
            readerE.Close();
            cmdE.Dispose();
            connE.Close();

            // ComboBox boxSalasMI
            MySqlConnection connMI = Conexion.getConexion();
            MySqlCommand cmdMI = new MySqlCommand("SELECT nombre FROM misalas", connMI);
            connMI.Open();
            MySqlDataReader readerMI = cmdMI.ExecuteReader();
            while (readerMI.Read())
            {
                string nombreSalaMI = readerMI.GetString("nombre");
                boxSalasMI5.Items.Add(nombreSalaMI);
            }
            readerMI.Close();
            cmdMI.Dispose();
            connMI.Close();

            // ComboBox boxSalasTC
            MySqlConnection connTC = Conexion.getConexion();
            MySqlCommand cmdTC = new MySqlCommand("SELECT nombre FROM tcsalas", connTC);
            connTC.Open();
            MySqlDataReader readerTC = cmdTC.ExecuteReader();
            while (readerTC.Read())
            {
                string nombreSalaTC = readerTC.GetString("nombre");
                boxSalasTC5.Items.Add(nombreSalaTC);
            }
            readerTC.Close();
            cmdTC.Dispose();
            connTC.Close();

            MySqlConnection connA = Conexion.getConexion();
            MySqlCommand cmdA = new MySqlCommand("SELECT nombre FROM Aulas", connA);
            connA.Open();
            MySqlDataReader readerA = cmdA.ExecuteReader();
            while (readerA.Read())
            {
                string nombreSalaA = readerA.GetString("nombre");
                boxAulas.Items.Add(nombreSalaA);
            }
            readerA.Close();
            cmdA.Dispose();
            connA.Close();

            MySqlConnection connO = Conexion.getConexion();
            MySqlCommand cmdO = new MySqlCommand("SELECT nombre FROM Oficinas", connO);
            connO.Open();
            MySqlDataReader readerO = cmdO.ExecuteReader();
            while (readerO.Read())
            {
                string nombreSalaO = readerO.GetString("nombre");
                boxOficinas.Items.Add(nombreSalaO);
            }
            readerO.Close();
            cmdO.Dispose();
            connO.Close();

            MySqlConnection connO2 = Conexion.getConexion();
            MySqlCommand cmdO2 = new MySqlCommand("SELECT nombre FROM Aulas", connO2);
            connO2.Open();
            MySqlDataReader readerO2 = cmdO2.ExecuteReader();
            while (readerO2.Read())
            {
                string nombreSalaO2 = readerO2.GetString("nombre");
                boxAulas3.Items.Add(nombreSalaO2);
            }
            readerO2.Close();
            cmdO2.Dispose();
            connO2.Close();

            MySqlConnection connA2 = Conexion.getConexion();
            MySqlCommand cmdA2 = new MySqlCommand("SELECT nombre FROM Oficinas", connA2);
            connA2.Open();
            MySqlDataReader readerA2 = cmdA2.ExecuteReader();
            while (readerA2.Read())
            {
                string nombreSalaA2 = readerA2.GetString("nombre");
                boxOficinas3.Items.Add(nombreSalaA2);
            }
            readerA2.Close();
            cmdA2.Dispose();
            connA2.Close();

            MySqlConnection connI = Conexion.getConexion();
            MySqlCommand cmdI = new MySqlCommand("SELECT nombre FROM Internado_IG", connI);
            connI.Open();
            MySqlDataReader readerI = cmdI.ExecuteReader();
            while (readerI.Read())
            {
                string nombreSalaI = readerI.GetString("nombre");
                boxInternado3.Items.Add(nombreSalaI);
            }
            readerI.Close();
            cmdI.Dispose();
            connI.Close();

            MySqlConnection connI2 = Conexion.getConexion();
            MySqlCommand cmdI2 = new MySqlCommand("SELECT nombre FROM Internado_IG", connI2);
            connI2.Open();
            MySqlDataReader readerI2 = cmdI2.ExecuteReader();
            while (readerI2.Read())
            {
                string nombreSalaI2 = readerI2.GetString("nombre");
                boxInternado4.Items.Add(nombreSalaI2);
            }
            readerI2.Close();
            cmdI2.Dispose();
            connI2.Close();
        }

        private void boxTallerSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && ckSalas4.Checked)
            {
                boxSalasMA5.Visible = true;


                boxSalasTC5.Visible = false;
                boxSalasMI5.Visible = false;
                boxSalasE5.Visible = false;
                boxSalasCM5.Visible = false;
                boxLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && ckSalas4.Checked)
            {
                boxSalasCM5.Visible = true;


                boxSalasMA5.Visible = false;
                boxSalasTC5.Visible = false;
                boxSalasMI5.Visible = false;
                boxSalasE5.Visible = false;
                boxLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Electricidad" && ckSalas4.Checked)
            {
                boxSalasE5.Visible = true;

                boxSalasMA5.Visible = false;
                boxSalasTC5.Visible = false;
                boxSalasMI5.Visible = false;
                boxSalasCM5.Visible = false;
                boxLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && ckSalas4.Checked)
            {
                boxSalasMI5.Visible = true;

                boxSalasMA5.Visible = false;
                boxSalasTC5.Visible = false;
                boxSalasCM5.Visible = false;
                boxSalasE5.Visible = false;
                boxLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && ckSalas4.Checked)
            {
                boxSalasTC5.Visible = true;

                boxSalasCM5.Visible = false;
                boxSalasE5.Visible = false;
                boxSalasMA5.Visible = false;
                boxSalasMI5.Visible = false;
                boxLujo.Visible = false;
            }
        }

        private DataTable GetTable(string tableName2)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string query = "SELECT * FROM " + tableName2;
            MySqlCommand command = new MySqlCommand(query, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conexion.Close();
            return table;
        }

        private void txtRut1_TextChanged(object sender, EventArgs e)
        {
            txtRut1.ReadOnly = true;
        }

        private void txtEstablecimiento1_TextChanged(object sender, EventArgs e)
        {
            txtEstablecimiento1.ReadOnly = true;
        }

        private void txtRetirador3_TextChanged(object sender, EventArgs e)
        {
            txtRetirador3.ReadOnly = true;
        }

        private void txtIngreso3_TextChanged(object sender, EventArgs e)
        {
            txtIngreso3.ReadOnly = true;
        }

        private void boxTipo3_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxTipo3.Enabled = true;
        }

        private void txtDevolucion3_TextChanged(object sender, EventArgs e)
        {
            txtDevolucion3.ReadOnly = true;
        }

        private void txtInterno2_TextChanged(object sender, EventArgs e)
        {
            txtInterno2.ReadOnly = true;
        }

        private void identificadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Identificador i = new Identificador();
            i.Show();
            this.Hide();
        }

        private void ckAyO_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSectores3.SelectedItem == null && ckAyO.Checked)
            {
                btnBuscarAyO.Visible = true;
                boxAyO.Visible = true;
                boxLujoAyO.Visible = true;
                btnModificarAyO.Visible = true;

                boxSectores3.Visible = false;
                boxLugar.Visible = false;
                btnBuscar2.Visible = false;
                btnModificar.Visible = false;
                ckSalas3.Enabled = false;
            }
            else if (boxSectores3.SelectedItem == null || boxSectores3.SelectedItem.ToString() == "Inventario General" && ckAyO.Checked)
            {
                btnBuscarAyO.Visible = true;
                boxAyO.Visible = true;
                boxLujoAyO.Visible = true;
                btnModificarAyO.Visible = true;

                boxSectores3.Visible = false;
                boxLugar.Visible = false;
                btnBuscar2.Visible = false;
                btnModificar.Visible = false;
                ckSalas3.Enabled = false;
            }
            if (boxSectores3.SelectedItem == null && !ckAyO.Checked)
            {
                btnBuscarAyO.Visible = false;
                boxAyO.Visible = false;
                boxLujoAyO.Visible = false;
                btnModificarAyO.Visible = false;

                boxSectores3.Visible = true;
                boxLugar.Visible = true;
                btnBuscar2.Visible = true;
                btnModificar.Visible = true;


                boxAyO.SelectedIndex = -1;
                boxAulas.Visible = false;
                boxOficinas.Visible = false;
                lO.Visible = false;
                lA.Visible = false;
                ckSalas3.Enabled = true;
                li3.Visible = false;
                boxInternado3.Visible = false;

                txtAnterior2.Clear();
                txtActual3.Clear();
                txtTipo2.Clear();
                txtEspecie2.Clear();
                boxRubro2.SelectedIndex = -1;
                boxEstado2.SelectedIndex = -1;
                txtResponsable2.Clear();
                txtRut3.Clear();
                txtEstablecimiento3.Clear();
                txtTalleres2.Clear();
                txtUbicacion2.Clear();
                txtValor2.Clear();
                txtFecha2.Clear();
                txtOrigen2.Clear();
                txtActual2.Clear();
                boxClase1.SelectedIndex = -1;
                boxRubroB1.SelectedIndex = -1;

            }

            else if (boxSectores3.SelectedItem != null && boxSectores3.SelectedItem.ToString() == "Inventario General" && !ckAyO.Checked)
            {
                btnBuscarAyO.Visible = false;
                boxAyO.Visible = false;
                boxLujoAyO.Visible = false;
                btnModificarAyO.Visible = false;

                boxSectores3.Visible = true;
                boxLugar.Visible = true;
                btnBuscar2.Visible = true;
                btnModificar.Visible = true;

                boxAyO.SelectedIndex = -1;

                boxAulas.Visible = false;
                boxOficinas.Visible = false;
                lO.Visible = false;
                lA.Visible = false;
                ckSalas3.Enabled = true;
                li3.Visible = false;
                boxInternado3.Visible = false;

                txtAnterior2.Clear();
                txtActual3.Clear();
                txtTipo2.Clear();
                txtEspecie2.Clear();
                boxRubro2.SelectedIndex = -1;
                boxEstado2.SelectedIndex = -1;
                txtResponsable2.Clear();
                txtRut3.Clear();
                txtEstablecimiento3.Clear();
                txtTalleres2.Clear();
                txtUbicacion2.Clear();
                txtValor2.Clear();
                txtFecha2.Clear();
                txtOrigen2.Clear();
                txtActual2.Clear();
                boxClase1.SelectedIndex = -1;
                boxRubroB1.SelectedIndex = -1;

            }            
        }

        private void boxAyO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(boxAyO.SelectedItem != null && boxAyO.SelectedItem.ToString() == "Aulas")
            {
                lA.Visible = true;
                lO.Visible = false;
                boxAulas.Visible = true;
                boxLujoAyO.Visible = false;
                boxOficinas.Visible = false;
                li3.Visible = false;
                boxInternado3.Visible = false;
            }

            if (boxAyO.SelectedItem != null && boxAyO.SelectedItem.ToString() == "Oficinas")
            {
                lO.Visible = true;
                lA.Visible = false;
                boxLujoAyO.Visible = false;
                boxOficinas.Visible = true;
                boxAulas.Visible = false;
                li3.Visible = false;
                boxInternado3.Visible = false;
            }

            if (boxAyO.SelectedItem != null && boxAyO.SelectedItem.ToString() == "Internado")
            {
                lO.Visible = false;
                lA.Visible = false;
                li3.Visible = true;
                boxLujoAyO.Visible = false;
                boxOficinas.Visible = false;
                boxAulas.Visible = false;
                boxInternado3.Visible = true;
            }
        }

        private void boxDepartamentos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxDepartamentos2.SelectedItem != null && boxDepartamentos2.SelectedItem.ToString() == "Aulas")
            {
                boxAulasV.Visible = true;
                lAV.Visible = true;
                lOV.Visible = false;
            }
            else
            {
                boxAulasV.Visible = false;
                lAV.Visible = false;
            }

            if (boxDepartamentos2.SelectedItem != null && boxDepartamentos2.SelectedItem.ToString() == "Oficinas")
            {
                boxOficinasV.Visible = true;
                lAV.Visible = false;
                lOV.Visible = true;
            }
            else
            {
                boxOficinasV.Visible = false;
                lOV.Visible = false;
            }

            if (boxDepartamentos2.SelectedItem !=null && boxDepartamentos2.SelectedItem.ToString() == "Internado")
            {
                boxInternado.Visible = true;
                lAV.Visible = false;
                lOV.Visible = false;
                li.Visible = true;
            }
            else
            {
                boxInternado.Visible = false;
                li.Visible = false;
            }
        }

        private void ckAyO2_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSectores4.SelectedItem == null && ckAyO2.Checked)
            {
                boxAyO2.Visible = true;
                boxLujoAyO2.Visible = true;
                btnAgregarAyO.Visible = true;

                boxSectores4.Visible = false;
                boxLugar2.Visible = false;
                btnAgregar.Visible = false;
                ckSalas.Enabled = false;
                t46.Visible = false;
            }
            else if (boxSectores4.SelectedItem == null || boxSectores4.SelectedItem.ToString() == "Inventario General" && ckAyO2.Checked)
            {
                boxAyO2.Visible = true;
                boxLujoAyO2.Visible = true;
                btnAgregarAyO.Visible = true;

                boxSectores4.Visible = false;
                boxLugar2.Visible = false;
                btnAgregar.Visible = false;
                ckSalas.Enabled = false;
                t46.Visible = false;
            }
            if (boxSectores4.SelectedItem == null && !ckAyO2.Checked)
            {
                boxAyO2.Visible = false;
                boxLujoAyO2.Visible = false;
                btnAgregarAyO.Visible = false;

                boxSectores4.Visible = true;
                boxLugar2.Visible = true;
                btnAgregar.Visible = true;

                boxInternado2.Visible = false;
                li2.Visible = false;
                boxAyO2.SelectedIndex = -1;
                boxAulas2.Visible = false;
                boxOficinas2.Visible = false;
                lO2.Visible = false;
                lA2.Visible = false;
                ckSalas.Enabled = true;
                t46.Visible = true;

                txtActual.Clear();
                txtTipo.Clear();
                txtEspecie.Clear();
                boxRubro.SelectedIndex = -1;
                boxEstado.SelectedIndex = -1;
                txtResponsable.Clear();
                txtTalleres.Clear();
                txtUbicacion.Clear();
                txtValor.Clear();
                txtFecha.Clear();
                txtOrigen.Clear();
                txtRut2.Clear();
                txtEstablecimiento2.Clear();
                boxClase2.SelectedIndex = -1;

            }

            else if (boxSectores4.SelectedItem != null && boxSectores4.SelectedItem.ToString() == "Inventario General" && !ckAyO2.Checked)
            {
                boxInternado2.Visible = false;
                li2.Visible = false;
                boxAyO2.Visible = false;
                boxLujoAyO2.Visible = false;
                btnAgregarAyO.Visible = false;

                boxSectores4.Visible = true;
                boxLugar2.Visible = true;
                btnAgregar.Visible = true;

                boxAyO2.SelectedIndex = -1;

                boxAulas2.Visible = false;
                boxOficinas2.Visible = false;
                lO2.Visible = false;
                lA2.Visible = false;
                ckSalas.Enabled = true;
                t46.Visible = true;

                txtActual.Clear();
                txtTipo.Clear();
                txtEspecie.Clear();
                boxRubro.SelectedIndex = -1;
                boxEstado.SelectedIndex = -1;
                txtResponsable.Clear();
                txtTalleres.Clear();
                txtUbicacion.Clear();
                txtValor.Clear();
                txtFecha.Clear();
                txtOrigen.Clear();
                txtRut2.Clear();
                txtEstablecimiento2.Clear();
                boxClase2.SelectedIndex = -1;
            }
        }

        private void boxAyO2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxAyO2.SelectedItem != null && boxAyO2.SelectedItem.ToString() == "Aulas")
            {
                li2.Visible = false;
                lA2.Visible = true;
                lO2.Visible = false;
                boxAulas2.Visible = true;
                boxLujoAyO2.Visible = false;
                boxOficinas2.Visible = false;
                boxInternado2.Visible = false;
            }

            if (boxAyO2.SelectedItem != null && boxAyO2.SelectedItem.ToString() == "Oficinas")
            {
                li2.Visible = false;
                lO2.Visible = true;
                lA2.Visible = false;
                boxLujoAyO2.Visible = false;
                boxOficinas2.Visible = true;
                boxAulas2.Visible = false;
                boxInternado2.Visible = false;
            }

            if (boxAyO2.SelectedItem !=null && boxAyO2.SelectedItem.ToString() == "Internado")
            {
                li2.Visible = true;
                boxInternado2.Visible = true;
                lO2.Visible = false;
                lA2.Visible = false;
                boxLujoAyO2.Visible = false;
                boxAulas2.Visible = false;
                boxOficinas2.Visible = false;
            }
        }

        private void btnAgregarAyO_Click(object sender, EventArgs e)
        {
            if (boxAyO2.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxAyO2.Text == "Aulas")
            {
                sala = boxAulas2.Text;
            }
            else if (boxAyO2.Text == "Oficinas")
            {
                sala = boxOficinas2.Text;
            }
            else if (boxAyO2.Text == "Internado")
            {
                sala = boxInternado2.Text;
            }

            if (string.IsNullOrEmpty(txtActual.Text) || string.IsNullOrEmpty(txtTipo.Text)
                || string.IsNullOrEmpty(txtEspecie.Text) || boxRubro.SelectedIndex == -1 || boxEstado.SelectedIndex == -1
                || string.IsNullOrEmpty(txtResponsable.Text) || string.IsNullOrEmpty(txtTalleres.Text)
                || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtValor.Text)
                || string.IsNullOrEmpty(txtFecha.Text) || string.IsNullOrEmpty(txtOrigen.Text) || string.IsNullOrEmpty(txtRut2.Text)
                || string.IsNullOrEmpty(txtEstablecimiento2.Text))
            {
                MessageBox.Show("Debe llenar todos los campos para agregar un producto a la sala seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((boxAyO2.Text == "Aulas" && boxAulas2.SelectedItem == null) ||
                (boxAyO2.Text == "Oficinas" && boxOficinas2.SelectedItem == null) ||
                (boxAyO2.Text == "Internado" && boxInternado2.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione una ubicacion de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string verificaSql = $"SELECT COUNT(*) FROM {sala} WHERE NºActual = @NºActual AND Rubro = @Rubro";
            MySqlCommand verificaCommand = new MySqlCommand(verificaSql, conexion);
            verificaCommand.Parameters.Add(new MySqlParameter("@NºActual", txtActual.Text));
            verificaCommand.Parameters.Add(new MySqlParameter("@Rubro", boxRubro.Text));

            int count = Convert.ToInt32(verificaCommand.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Ya existe un producto con el mismo NºActual en el mismo Rubro, por favor modifíquelo para agregar el producto.");
                conexion.Close();
                return;
            }


            string query = "INSERT INTO " + sala + " (NºAnterior, NºActual, Tipo_Especie, Descripcion_Especie, Rubro, Estado, Responsable, RUT, Nombre_de_Establecimiento, Talleres_Aulas, Ubicacion_Fisica," +
                "Valor_Adquicision, Fecha_Adquicision, Origen, Clase) " +
                           "VALUES (@NºAnterior, @NºActual, @Tipo_Especie, @Descripcion_Especie, @Rubro, @Estado, @Responsable, @RUT, @Nombre_de_Establecimiento, @Talleres_Aulas, @Ubicacion_Fisica," +
                "@Valor_Adquicision, @Fecha_Adquicision, @Origen, @Clase)";

            using (MySqlConnection conn = Conexion.getConexion())
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.Add("@NºActual", MySqlDbType.VarChar).Value = txtActual.Text;
                cmd.Parameters.Add("@NºAnterior", MySqlDbType.VarChar).Value = txtAnterior.Text;
                cmd.Parameters.Add("@Tipo_Especie", MySqlDbType.VarChar).Value = txtTipo.Text;
                cmd.Parameters.Add("@Descripcion_Especie", MySqlDbType.VarChar).Value = txtEspecie.Text;
                cmd.Parameters.Add("@Rubro", MySqlDbType.VarChar).Value = boxRubro.Text;
                cmd.Parameters.Add("@Estado", MySqlDbType.VarChar).Value = boxEstado.Text;
                cmd.Parameters.Add("@Responsable", MySqlDbType.VarChar).Value = txtResponsable.Text;
                cmd.Parameters.Add("@RUT", MySqlDbType.VarChar).Value = txtRut2.Text;
                cmd.Parameters.Add("@Nombre_de_Establecimiento", MySqlDbType.VarChar).Value = txtEstablecimiento2.Text;
                cmd.Parameters.Add("@Talleres_Aulas", MySqlDbType.VarChar).Value = txtTalleres.Text;
                cmd.Parameters.Add("@Ubicacion_Fisica", MySqlDbType.VarChar).Value = txtUbicacion.Text;
                cmd.Parameters.Add("@Valor_Adquicision", MySqlDbType.Int32).Value = txtValor.Text;
                cmd.Parameters.Add("@Fecha_Adquicision", MySqlDbType.VarChar).Value = txtFecha.Text;
                cmd.Parameters.Add("@Origen", MySqlDbType.VarChar).Value = txtOrigen.Text;
                cmd.Parameters.Add("@Clase", MySqlDbType.VarChar).Value = boxClase2.Text;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                string query1 = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

                using (MySqlConnection con = Conexion.getConexion())
                using (MySqlCommand comando = new MySqlCommand(query1, con))
                {
                    comando.Parameters.Add(new MySqlParameter("@NºActual", txtActual.Text));
                    comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie.Text));
                    comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                    comando.Parameters.Add(new MySqlParameter("@Alteracion", "Agregado"));
                    comando.Parameters.Add(new MySqlParameter("@Tabla", sala));
                    comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                    con.Open();
                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show("El producto se ha agregado a la ubicacion seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificarAyO_Click(object sender, EventArgs e)
        {
            if (boxAyO.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((boxAyO.Text == "Aulas" && boxAulas.SelectedItem == null) ||
                (boxAyO.Text == "Oficinas" && boxOficinas.SelectedItem == null) ||
                (boxAyO.Text == "Internado" && boxInternado3.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione una ubicacion en el cual quiere eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtActual2.Text) || boxRubroB1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, Agrege el NºInterno del prodcuto y el Rubro para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxAyO.Text == "Aulas")
            {
                sala = boxAulas.Text;
            }
            else if (boxAyO.Text == "Oficinas")
            {
                sala = boxOficinas.Text;
            }
            else if (boxAyO.Text == "Internado")
            {
                sala = boxInternado3.Text;
            }

            string sql = $"UPDATE {sala} SET NºActual=@NºActual, NºAnterior=@NºAnterior, Tipo_Especie=@Tipo_Especie, Descripcion_Especie=@Descripcion_Especie, Rubro=@Rubro, Estado=@Estado, Responsable=@Responsable, RUT=@RUT, Nombre_de_Establecimiento=@Establecimiento, Talleres_Aulas=@Talleres_Aulas," +
                        $" Ubicacion_Fisica=@Ubicacion_Fisica, Valor_Adquicision=@Valor_Adquicision, Fecha_Adquicision=@Fecha_Adquicision, Origen=@Origen, Clase=@Clase WHERE NºActual=@NºActual2 AND Rubro=@Rubro2";
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.Add(new MySqlParameter("@Rubro2", boxRubroB1.Text));
            command.Parameters.Add(new MySqlParameter("@NºAnterior", txtAnterior2.Text));
            command.Parameters.Add(new MySqlParameter("@NºActual", txtActual3.Text));
            command.Parameters.Add(new MySqlParameter("@NºActual2", txtActual2.Text));
            command.Parameters.Add(new MySqlParameter("@Tipo_Especie", txtTipo2.Text));
            command.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie2.Text));
            command.Parameters.Add(new MySqlParameter("@Rubro", boxRubro2.Text));
            command.Parameters.Add(new MySqlParameter("@Estado", boxEstado2.Text));
            command.Parameters.Add(new MySqlParameter("@Responsable", txtResponsable2.Text));
            command.Parameters.Add(new MySqlParameter("@RUT", txtRut3.Text));
            command.Parameters.Add(new MySqlParameter("@Establecimiento", txtEstablecimiento3.Text));
            command.Parameters.Add(new MySqlParameter("@Talleres_Aulas", txtTalleres2.Text));
            command.Parameters.Add(new MySqlParameter("@Ubicacion_Fisica", txtUbicacion2.Text));
            command.Parameters.Add(new MySqlParameter("@Valor_Adquicision", txtValor2.Text));
            command.Parameters.Add(new MySqlParameter("@Fecha_Adquicision", txtFecha2.Text));
            command.Parameters.Add(new MySqlParameter("@Origen", txtOrigen2.Text));
            command.Parameters.Add(new MySqlParameter("@Clase", boxClase1.Text));

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro Modificado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el NºInterno proporcionado.");
            }

            string query1 = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

            using (MySqlConnection con = Conexion.getConexion())
            using (MySqlCommand comando = new MySqlCommand(query1, con))
            {
                comando.Parameters.Add(new MySqlParameter("@NºActual", txtActual3.Text));
                comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie2.Text));
                comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                comando.Parameters.Add(new MySqlParameter("@Alteracion", "Modificado"));
                comando.Parameters.Add(new MySqlParameter("@Tabla", sala));
                comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                con.Open();
                comando.ExecuteNonQuery();
            }

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                txtAnterior2.Clear();
                txtActual3.Clear();
                txtTipo2.Clear();
                txtEspecie2.Clear();
                boxRubro2.SelectedIndex = -1;
                boxEstado2.SelectedIndex = -1;
                txtResponsable2.Clear();
                txtRut3.Clear();
                txtEstablecimiento3.Clear();
                txtTalleres2.Clear();
                txtUbicacion2.Clear();
                txtValor2.Clear();
                txtFecha2.Clear();
                txtOrigen2.Clear();
                txtActual2.Clear();
                boxClase1.SelectedIndex = -1;
                boxRubroB1.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Modificar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnBuscarAyO_Click(object sender, EventArgs e)
        {
            if (boxAyO.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxAyO.Text == "Aulas")
            {
                sala = boxAulas.Text;
            }
            else if (boxAyO.Text == "Oficinas")
            {
                sala = boxOficinas.Text;
            }
            else if (boxAyO.Text == "Internado")
            {
                sala = boxInternado3.Text;
            }

            if ((boxAyO.Text == "Aulas" && boxAulas.SelectedItem == null) ||
                (boxAyO.Text == "Oficinas" && boxOficinas.SelectedItem == null) ||
                (boxAyO.Text == "Internado" && boxInternado3.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione una ubicacion de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtActual2.Text) || boxRubroB1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, inserte un NºActual y el Rubro");
                return;
            }

            string codigo = txtActual2.Text;
            string rubro = boxRubroB1.Text;

            string consulta = "SELECT NºActual, NºAnterior, Tipo_Especie, Descripcion_Especie, Rubro, Estado, Responsable, RUT, Nombre_de_Establecimiento, Talleres_Aulas, Ubicacion_Fisica, " +
                "Valor_Adquicision, Fecha_Adquicision, Origen, Clase FROM " + sala + " WHERE NºActual LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1";
            MySqlConnection conexion = Conexion.getConexion();
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            try
            {
                // Ejecutar la consulta SQL y obtener los resultados
                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    // Si se encontraron resultados, mostrarlos en los controles correspondientes
                    reader.Read();
                    txtActual3.Text = reader.GetString(0);
                    txtAnterior2.Text = reader.GetString(1);
                    txtTipo2.Text = reader.GetString(2);
                    txtEspecie2.Text = reader.GetString(3);
                    boxRubro2.Text = reader.GetString(4);
                    boxEstado2.Text = reader.GetString(5);
                    txtResponsable2.Text = reader.GetString(6);
                    txtRut3.Text = reader.GetString(7);
                    txtEstablecimiento3.Text = reader.GetString(8);
                    txtTalleres2.Text = reader.GetString(9);
                    txtUbicacion2.Text = reader.GetString(10);
                    txtValor2.Text = reader.GetString(11);
                    txtFecha2.Text = reader.GetString(12);
                    txtOrigen2.Text = reader.GetString(13);
                    boxClase1.Text = reader.GetString(14);
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para el número de serie especificado");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void ckAyO3_CheckedChanged(object sender, EventArgs e)
        {
            if (boxSectores6.SelectedItem == null && ckAyO3.Checked)
            {
                btnBuscarAyO2.Visible = true;
                boxAyO3.Visible = true;
                boxLujoAyO3.Visible = true;
                btnEliminarAyO.Visible = true;

                boxSectores6.Visible = false;
                boxLugar3.Visible = false;
                btnBuscar3.Visible = false;
                btnEliminar.Visible = false;
                ckSalas2.Enabled = false;
            }
            else if (boxSectores6.SelectedItem == null || boxSectores6.SelectedItem.ToString() == "Inventario General" && ckAyO3.Checked)
            {
                btnBuscarAyO2.Visible = true;
                boxAyO3.Visible = true;
                boxLujoAyO3.Visible = true;
                btnEliminarAyO.Visible = true;

                boxSectores6.Visible = false;
                boxLugar3.Visible = false;
                btnBuscar3.Visible = false;
                btnEliminar.Visible = false;
                ckSalas2.Enabled = false;
            }
            if (boxSectores6.SelectedItem == null && !ckAyO3.Checked)
            {
                li4.Visible = false;
                boxInternado4.Visible = false;
                btnBuscarAyO2.Visible = false;
                boxAyO3.Visible = false;
                boxLujoAyO3.Visible = false;
                btnEliminarAyO.Visible = false;

                boxSectores6.Visible = true;
                boxLugar3.Visible = true;
                btnBuscar3.Visible = true;
                btnEliminar.Visible = true;


                boxAyO3.SelectedIndex = -1;
                boxAulas3.Visible = false;
                boxOficinas3.Visible = false;
                lO3.Visible = false;
                lA3.Visible = false;
                ckSalas2.Enabled = true;

                txtAnterior3.Clear();
                txtActual4.Clear();
                txtTipo3.Clear();
                txtEspecie3.Clear();
                boxRubro3.SelectedIndex = -1;
                boxEstado3.SelectedIndex = -1;
                txtResponsable3.Clear();
                txtTalleres3.Clear();
                txtUbicacion3.Clear();
                txtValor3.Clear();
                txtFecha3.Clear();
                txtOrigen3.Clear();
                txtActual5.Clear();
                boxClase3.SelectedIndex = -1;
                txtRut1.Clear();
                txtEstablecimiento1.Clear();
                boxRubroB2.SelectedIndex = -1;

            }

            else if (boxSectores6.SelectedItem != null && boxSectores6.SelectedItem.ToString() == "Inventario General" && !ckAyO3.Checked)
            {
                li4.Visible = false;
                boxInternado4.Visible = false;
                btnBuscarAyO2.Visible = false;
                boxAyO3.Visible = false;
                boxLujoAyO3.Visible = false;
                btnEliminarAyO.Visible = false;

                boxSectores6.Visible = true;
                boxLugar3.Visible = true;
                btnBuscar3.Visible = true;
                btnEliminar.Visible = true;

                boxAyO3.SelectedIndex = -1;

                boxAulas3.Visible = false;
                boxOficinas3.Visible = false;
                lO3.Visible = false;
                lA3.Visible = false;
                ckSalas2.Enabled = true;

                txtAnterior3.Clear();
                txtActual4.Clear();
                txtTipo3.Clear();
                txtEspecie3.Clear();
                boxRubro3.SelectedIndex = -1;
                boxEstado3.SelectedIndex = -1;
                txtResponsable3.Clear();
                txtTalleres3.Clear();
                txtUbicacion3.Clear();
                txtValor3.Clear();
                txtFecha3.Clear();
                txtOrigen3.Clear();
                txtActual5.Clear();
                boxClase3.SelectedIndex = -1;
                txtRut1.Clear();
                txtEstablecimiento1.Clear();
                boxRubroB2.SelectedIndex = -1;

            }
        }

        private void boxAyO3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxAyO3.SelectedItem != null && boxAyO3.SelectedItem.ToString() == "Aulas")
            {
                lA3.Visible = true;
                lO3.Visible = false;
                boxAulas3.Visible = true;
                boxLujoAyO3.Visible = false;
                boxOficinas3.Visible = false;
                boxInternado4.Visible = false;
                li4.Visible = false;
            }

            if (boxAyO3.SelectedItem != null && boxAyO3.SelectedItem.ToString() == "Oficinas")
            {
                lO3.Visible = true;
                lA3.Visible = false;
                boxLujoAyO3.Visible = false;
                boxOficinas3.Visible = true;
                boxAulas3.Visible = false;
                boxInternado4.Visible = false;
                li4.Visible = false;
            }

            if (boxAyO3.SelectedItem != null && boxAyO3.SelectedItem.ToString() == "Internado")
            {
                lO3.Visible = false;
                lA3.Visible = false;
                boxLujoAyO3.Visible = false;
                boxOficinas3.Visible = false;
                boxAulas3.Visible = false;
                boxInternado4.Visible = true;
                li4.Visible = true;
            }
        }

        private void btnBuscarAyO2_Click(object sender, EventArgs e)
        {
            if (boxAyO3.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxAyO3.Text == "Aulas")
            {
                sala = boxAulas3.Text;
            }
            else if (boxAyO3.Text == "Oficinas")
            {
                sala = boxOficinas3.Text;
            }
            else if (boxAyO3.Text == "Internado")
            {
                sala = boxInternado4.Text;
            }

            if ((boxAyO3.Text == "Aulas" && boxAulas3.SelectedItem == null) ||
                (boxAyO3.Text == "Oficinas" && boxOficinas3.SelectedItem == null) ||
                (boxAyO3.Text == "Internado" && boxInternado4.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione una ubicacion de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtActual4.Text) || boxRubroB2.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, inserte un NºActual y el Rubro");
                return;
            }

            string codigo = txtActual4.Text;
            string rubro = boxRubroB2.Text;

            string consulta = "SELECT NºActual, NºAnterior, Tipo_Especie, Descripcion_Especie, Rubro, Estado, Responsable, RUT, Nombre_de_Establecimiento, Talleres_Aulas, Ubicacion_Fisica, " +
                "Valor_Adquicision, Fecha_Adquicision, Origen, Clase FROM " + sala + " WHERE NºActual LIKE '" + codigo + "' AND Rubro LIKE '" + rubro + "' LIMIT 1";
            MySqlConnection conexion = Conexion.getConexion();
            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            try
            {
                // Ejecutar la consulta SQL y obtener los resultados
                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    // Si se encontraron resultados, mostrarlos en los controles correspondientes
                    reader.Read();
                    txtActual5.Text = reader.GetString(0);
                    txtAnterior3.Text = reader.GetString(1);
                    txtTipo3.Text = reader.GetString(2);
                    txtEspecie3.Text = reader.GetString(3);
                    boxRubro3.Text = reader.GetString(4);
                    boxEstado3.Text = reader.GetString(5);
                    txtResponsable3.Text = reader.GetString(6);
                    txtRut1.Text = reader.GetString(7);
                    txtEstablecimiento1.Text = reader.GetString(8);
                    txtTalleres3.Text = reader.GetString(9);
                    txtUbicacion3.Text = reader.GetString(10);
                    txtValor3.Text = reader.GetString(11);
                    txtFecha3.Text = reader.GetString(12);
                    txtOrigen3.Text = reader.GetString(13);
                    boxClase3.Text = reader.GetString(14);
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados para el número de serie especificado");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEliminarAyO_Click(object sender, EventArgs e)
        {
            if (boxAyO3.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un lugar de la lista antes de agregar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((boxAyO3.Text == "Aulas" && boxAulas3.SelectedItem == null) ||
                (boxAyO3.Text == "Oficinas" && boxOficinas3.SelectedItem == null) ||
                (boxAyO3.Text == "Internado" && boxInternado4.SelectedItem == null))
            {
                MessageBox.Show("Por favor, seleccione la ubicacion en el cual quiere eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtActual4.Text) || boxRubroB2.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, Agrege el NºInterno y el Rubro del prodcuto a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sala = "";
            if (boxAyO3.Text == "Aulas")
            {
                sala = boxAulas3.Text;
            }
            else if (boxAyO3.Text == "Oficinas")
            {
                sala = boxOficinas3.Text;
            }
            else if (boxAyO3.Text == "Internado")
            {
                sala = boxInternado4.Text;
            }

            string sql = $"DELETE FROM {sala} WHERE NºActual = @NºActual AND Rubro = @Rubro";
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(sql, conexion);

            command.Parameters.Add(new MySqlParameter("@NºActual", txtActual4.Text));
            command.Parameters.Add(new MySqlParameter("@Rubro", boxRubroB2.Text));

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró ningún registro con el NºInterno proporcionado.");
            }

            string query1 = "INSERT INTO HistorialProductos (NºActual, Tabla, Descripcion_Especie, Fecha_Alteracion, Alteracion, Alterador) VALUES (@NºActual, @Tabla, @Descripcion_Especie, @Fecha_Alteracion, @Alteracion, @Alterador)";

            using (MySqlConnection con = Conexion.getConexion())
            using (MySqlCommand comando = new MySqlCommand(query1, con))
            {
                comando.Parameters.Add(new MySqlParameter("@NºActual", txtActual4.Text));
                comando.Parameters.Add(new MySqlParameter("@Descripcion_Especie", txtEspecie3.Text));
                comando.Parameters.Add(new MySqlParameter("@Fecha_Alteracion", DateTime.Now));
                comando.Parameters.Add(new MySqlParameter("@Alteracion", "Eliminado"));
                comando.Parameters.Add(new MySqlParameter("@Tabla", sala));
                comando.Parameters.Add(new MySqlParameter("@Alterador", Session.nombre));

                con.Open();
                comando.ExecuteNonQuery();
            }

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                txtAnterior3.Clear();
                txtActual4.Clear();
                txtTipo3.Clear();
                txtEspecie3.Clear();
                boxRubro3.SelectedIndex = -1;
                boxEstado3.SelectedIndex = -1;
                txtResponsable3.Clear();
                txtTalleres3.Clear();
                txtUbicacion3.Clear();
                txtValor3.Clear();
                txtFecha3.Clear();
                txtOrigen3.Clear();
                txtActual5.Clear();
                boxClase3.SelectedIndex = -1;
                txtRut1.Clear();
                txtEstablecimiento1.Clear();
                boxRubroB2.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese el carácter no numérico
            }
        }

        private void txtValor3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese el carácter no numérico
            }
        }
    }
}
