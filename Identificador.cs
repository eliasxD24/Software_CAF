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
    public partial class Identificador : Form
    {
        public Identificador()
        {
            InitializeComponent();

            boxInternado.Visible = false;
            boxAulas.Visible = false;
            boxOficinas.Visible = false;
            boxSalasLujo.Visible = false;
            boxSalasCM.Visible = false;
            boxSalasE.Visible = false;
            boxSalasMA.Visible = false;
            boxSalasMI.Visible = false;
            boxSalasTC.Visible = false;
            ckSalas.Visible = false;
            boxTallerSalas.Visible = false;
            tSalas.Visible = false;

            LlenarComboBoxSalas();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            txtBuscar.TextChanged += (sender, e) => FiltrarTabla();

            tBuscarS.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AgregarProducto ap = new AgregarProducto();
            ap.Show();
            this.Hide();
        }

        private void ActualizarBoxDepartamentos()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            boxLugar.Items.Clear();

            if (boxSectores.SelectedItem.ToString() == "Inventario General" && !ckSalas.Checked)
            {
                boxSalasLujo.Visible = false;
                tSalas.Visible = false;
                boxTallerSalas.Visible = false;
                boxLugar.Visible = true;

                boxLugar.Items.Add("Taller_de_Mecanica_Automotriz");
                boxLugar.Items.Add("Taller_de_Mecanica_Industrial");
                boxLugar.Items.Add("Taller_de_Construcciones_Metalicas");
                boxLugar.Items.Add("Taller_de_Terminaciones_de_la_Construccion");
                boxLugar.Items.Add("Taller_de_Electricidad");

                boxLugar.Items.Add("Aulas");
                boxLugar.Items.Add("Oficinas");
                boxLugar.Items.Add("Internado");

                ckSalas.Visible = true;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;

                tbuscar.Visible = true;
                tBuscarS.Visible = false;
            }
            else if (boxSectores.SelectedItem.ToString() == "Materiales de Escritorio" && !ckSalas.Checked)
            {
                boxSalasLujo.Visible = false;
                tSalas.Visible = false;
                boxTallerSalas.Visible = false;
                boxLugar.Visible = true;

                boxLugar.Items.Add("DeptoUTP");
                boxLugar.Items.Add("DeptoAdministracion");
                boxLugar.Items.Add("DeptoInspectoriaGeneral");
                boxLugar.Items.Add("DeptoPsicosocial");
                boxLugar.Items.Add("DeptoDireccion");
                boxLugar.Items.Add("DeptoBiblioteca");
                boxLugar.Items.Add("DeptoInternado");

                ckSalas.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;

                boxAulas.Visible = false;
                boxOficinas.Visible = false;

                tbuscar.Visible = true;
                tBuscarS.Visible = false;
            }
            else if (boxSectores.SelectedItem.ToString() == "Materiales de Aseo" && !ckSalas.Checked)
            {
                boxSalasLujo.Visible = false;
                tSalas.Visible = false;
                boxTallerSalas.Visible = false;
                boxLugar.Visible = true;

                boxLugar.Items.Add("Liceo");
                boxLugar.Items.Add("Internado ");

                ckSalas.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;
                tbuscar.Visible = true;
                tBuscarS.Visible = false;

            }
            else if (ckSalas.Checked)
            {
                boxSalasLujo.Visible = true;
                tSalas.Visible = true;
                boxTallerSalas.Visible = true;
                boxLugar.Visible = false;
                boxAulas.Visible = false;
                boxOficinas.Visible = false;
                boxInternado.Visible = false;

                boxAulas.Visible = false;
                boxOficinas.Visible = false;
                tbuscar.Visible = false;
                tBuscarS.Visible = true;
            }
        }

        private void boxSectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBoxDepartamentos();
        }

        private void ckSalas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarBoxDepartamentos();
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

        private void boxTallerSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && ckSalas.Checked)
            {
                boxSalasMA.Visible = true;


                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasE.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && ckSalas.Checked)
            {
                boxSalasCM.Visible = true;


                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasE.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Electricidad" && ckSalas.Checked)
            {
                boxSalasE.Visible = true;

                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && ckSalas.Checked)
            {
                boxSalasMI.Visible = true;

                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasLujo.Visible = false;
            }
            else if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && ckSalas.Checked)
            {
                boxSalasTC.Visible = true;

                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasLujo.Visible = false;
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (boxSectores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un Sector", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ckSalas.Checked)
            {
                if (boxTallerSalas.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione el lugar de donde quiere ver las salas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz")
                {
                    if (boxSalasMA.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameMA = boxSalasMA.SelectedItem.ToString();
                    DataTable tableMA = GetTable2(tableNameMA);
                    dataIdentificadores.DataSource = tableMA;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas")
                {
                    if (boxSalasCM.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameCM = boxSalasCM.SelectedItem.ToString();
                    DataTable tableCM = GetTable2(tableNameCM);
                    dataIdentificadores.DataSource = tableCM;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Electricidad")
                {
                    if (boxSalasE.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameE = boxSalasE.SelectedItem.ToString();
                    DataTable tableE = GetTable2(tableNameE);
                    dataIdentificadores.DataSource = tableE;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial")
                {
                    if (boxSalasMI.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameMI = boxSalasMI.SelectedItem.ToString();
                    DataTable tableMI = GetTable2(tableNameMI);
                    dataIdentificadores.DataSource = tableMI;
                }

                if (boxTallerSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion")
                {
                    if (boxSalasTC.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameTC = boxSalasTC.SelectedItem.ToString();
                    DataTable tableTC = GetTable2(tableNameTC);
                    dataIdentificadores.DataSource = tableTC;
                }
            }
            else
            {
                if (boxLugar.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedDepartamento = boxLugar.SelectedItem.ToString();

                if (selectedDepartamento == "Aulas")
                {
                    if (boxAulas.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un aula");
                        return;
                    }

                    string tableNameA = boxAulas.SelectedItem.ToString();
                    DataTable tableA = GetTable(tableNameA);
                    dataIdentificadores.DataSource = tableA;
                }
                else if (selectedDepartamento == "Oficinas")
                {
                    if (boxOficinas.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una oficina");
                        return;
                    }

                    string tableNameO = boxOficinas.SelectedItem.ToString();
                    DataTable tableO = GetTable(tableNameO);
                    dataIdentificadores.DataSource = tableO;
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
                    dataIdentificadores.DataSource = tableI;
                }
                else
                {
                    string tableName = selectedDepartamento;
                    DataTable table = GetTable(tableName);
                    dataIdentificadores.DataSource = table;
                }
            }

            DataTable dataTable = (DataTable)dataIdentificadores.DataSource;

            dataTable.Columns.Add("Descargar", typeof(Image));

            Image descargarLogo = Image.FromFile("Imagenes\\descargar.jpg");

            foreach (DataRow row in dataTable.Rows)
            {
                row["Descargar"] = descargarLogo;
            }
            dataIdentificadores.DataSource = dataTable;
        }

        private DataTable GetTable(string tableName2)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string query = "SELECT id, NºActual, Descripcion_Especie FROM " + tableName2;
            MySqlCommand command = new MySqlCommand(query, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conexion.Close();
            return table;
        }

        private DataTable GetTable2(string tableName2)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string query = "SELECT id, Nºinterno, Descripcion_Especie FROM " + tableName2;
            MySqlCommand command = new MySqlCommand(query, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conexion.Close();
            return table;
        }

        private bool isSavingImage = false;

        private void dataIdentificadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en la columna "descargar"
            if (e.ColumnIndex == dataIdentificadores.Columns["Descargar"].Index && e.RowIndex >= 0)
            {
                if (isSavingImage)
                {
                    return; // Salir si ya se está guardando una imagen para evitar el ciclo de eventos
                }

                dataIdentificadores.CellContentClick -= dataIdentificadores_CellContentClick;

                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataIdentificadores.Rows[e.RowIndex];
                string tabla = boxLugar.Text;
                string id = row.Cells["id"].Value.ToString();
                string numeroActualColumna;

                string sala = "";
                string ayo = "";
                if (boxTallerSalas.Text == "Taller_de_Mecanica_Automotriz")
                {
                    sala = boxSalasMA.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Electricidad")
                {
                    sala = boxSalasE.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Mecanica_Industrial")
                {
                    sala = boxSalasMI.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Construcciones_Metalicas")
                {
                    sala = boxSalasCM.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Terminaciones_de_la_Construccion")
                {
                    sala = boxSalasTC.Text;
                }

                if (boxLugar.Text == "Aulas")
                {
                    ayo = boxAulas.Text;
                }
                else if (boxLugar.Text == "Oficinas")
                {
                    ayo = boxOficinas.Text;
                }
                else if (boxLugar.Text == "Internado")
                {
                    ayo = boxInternado.Text;
                }

                if (dataIdentificadores.Columns.Contains("NºActual"))
                {
                    numeroActualColumna = "NºActual";
                }
                else if (dataIdentificadores.Columns.Contains("NºInterno"))
                {
                    numeroActualColumna = "NºInterno";
                }
                else
                {
                    MessageBox.Show("No se encontró la columna para el número actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string numeroActual = row.Cells[numeroActualColumna].Value.ToString();

                // Crear un cuadro de diálogo para guardar la imagen en una ubicación específica
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de imagen (*.jpg)|*.jpg";
                saveFileDialog.FileName = "datos_" + id + ".jpg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    isSavingImage = true;

                    string rutaGuardar = saveFileDialog.FileName;

                    dataIdentificadores.CellContentClick += dataIdentificadores_CellContentClick;

                    isSavingImage = false;

                    // Obtener la plantilla de imagen y reemplazar los datos
                    Image plantilla = Image.FromFile("Imagenes\\Plantilla_Identificador.jpg");
                    // Asumiendo que los datos se colocarán en la esquina superior izquierda de la imagen
                    using (Graphics graphics = Graphics.FromImage(plantilla))
                    {
                        using (Font font = new Font("Caslon Old Face Std Heavy", 20))
                        {
                            // Crear un objeto Font separado con un tamaño de letra más pequeño
                            Font smallFont = new Font("Arial", 6);

                            string selectedDepartamento = string.Empty;

                            using (Graphics measureGraphics = Graphics.FromImage(new Bitmap(1, 1)))
                            {
                                SizeF textSize;
                                if (ckSalas.Checked)
                                {
                                    textSize = measureGraphics.MeasureString(sala, smallFont);
                                }

                                if (boxLugar.SelectedItem != null)
                                {
                                    selectedDepartamento = boxLugar.SelectedItem.ToString();
                                }

                                if (selectedDepartamento == "Aulas")
                                {
                                    textSize = measureGraphics.MeasureString(ayo, smallFont);
                                }
                                else if (selectedDepartamento == "Oficinas")
                                {
                                    textSize = measureGraphics.MeasureString(ayo, smallFont);
                                }
                                else if (selectedDepartamento == "Internado")
                                {
                                    textSize = measureGraphics.MeasureString(ayo, smallFont);
                                }
                                else
                                {
                                    textSize = measureGraphics.MeasureString(tabla, smallFont);
                                }

                                float x, y;

                                if (boxLugar.SelectedItem != null)
                                {
                                    selectedDepartamento = boxLugar.SelectedItem.ToString();
                                }

                                if (selectedDepartamento == "Aulas")
                                {
                                    x = 370 - textSize.Width / 2;
                                }
                                else if (selectedDepartamento == "Oficinas")
                                {
                                    x = 370 - textSize.Width / 2;
                                }
                                else if (selectedDepartamento == "Internado")
                                {
                                    x = 370 - textSize.Width / 2;
                                }
                                else if (ckSalas.Checked)
                                {
                                    x = 370 - textSize.Width / 2;
                                }
                                else
                                {
                                    x = 280 - textSize.Width / 2;
                                }
                                y = 130 - textSize.Height;

                                // Dibujar la primera línea con el tamaño de letra más pequeño
                                if (ckSalas.Checked)
                                {
                                    graphics.DrawString(sala, smallFont, Brushes.Black, new PointF(x, y));
                                }
                                
                                if (selectedDepartamento == "Aulas")
                                {
                                    graphics.DrawString(ayo, smallFont, Brushes.Black, new PointF(x, y));
                                }
                                else if (selectedDepartamento == "Oficinas")
                                {
                                    graphics.DrawString(ayo, smallFont, Brushes.Black, new PointF(x, y));
                                }
                                else if (selectedDepartamento == "Internado")
                                {
                                    graphics.DrawString(ayo, smallFont, Brushes.Black, new PointF(x, y));
                                }
                                else
                                {
                                    graphics.DrawString(tabla, smallFont, Brushes.Black, new PointF(x, y));
                                }

                                // Dibujar las demás líneas con el tamaño de letra original
                                graphics.DrawString(id, font, Brushes.Black, new PointF(250, 190));
                                graphics.DrawString("-", font, Brushes.Black, new PointF(400, 190));
                                graphics.DrawString(numeroActual, font, Brushes.Black, new PointF(550, 190));
                            }
                        }
                    }

                    // Guardar la imagen con los datos en la ubicación seleccionada
                    plantilla.Save(rutaGuardar);

                    MessageBox.Show("Imagen descargada con éxito en: " + rutaGuardar, "Descargar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataIdentificadores.CellContentClick += dataIdentificadores_CellContentClick;

                }
            }
        }

        private void boxLugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxLugar.SelectedItem != null && boxLugar.SelectedItem.ToString() == "Aulas")
            {
                boxAulas.Visible = true;
            }
            else
            {
                boxAulas.Visible = false;
            }

            if (boxLugar.SelectedItem != null && boxLugar.SelectedItem.ToString() == "Oficinas")
            {
                boxOficinas.Visible = true;
            }
            else
            {
                boxOficinas.Visible = false;
            }

            if (boxLugar.SelectedItem != null && boxLugar.SelectedItem.ToString() == "Internado")
            {
                boxInternado.Visible = true;
            }
            else
            {
                boxInternado.Visible = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarTabla();
        }

        private void FiltrarTabla()
        {
            if (!ckSalas.Checked)
            {
                string ayo = "";
                if (boxLugar.Text == "Aulas")
                {
                    ayo = boxAulas.Text;
                }
                else if (boxLugar.Text == "Oficinas")
                {
                    ayo = boxOficinas.Text;
                }
                else if (boxLugar.Text == "Internado")
                {
                    ayo = boxInternado.Text;
                }

                if (boxLugar.SelectedItem != null)
                {
                    string tableName = boxLugar.SelectedItem.ToString();

                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();

                    if (tableName == "Aulas")
                    {
                        string query = $"SELECT id, NºActual, Descripcion_Especie FROM {ayo} WHERE NºActual LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND NºActual LIKE '%{filtro}%'";
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataIdentificadores.DataSource = table;

                        DataTable dataTable = (DataTable)dataIdentificadores.DataSource;

                        dataTable.Columns.Add("Descargar", typeof(Image));

                        Image descargarLogo = Image.FromFile("Imagenes\\descargar.jpg");

                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Descargar"] = descargarLogo;
                        }
                        dataIdentificadores.DataSource = dataTable;
                    }
                    else if (tableName == "Oficinas")
                    {
                        string query = $"SELECT id, NºActual, Descripcion_Especie FROM {ayo} WHERE NºActual LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND NºActual LIKE '%{filtro}%'";
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataIdentificadores.DataSource = table;

                        DataTable dataTable = (DataTable)dataIdentificadores.DataSource;

                        dataTable.Columns.Add("Descargar", typeof(Image));

                        Image descargarLogo = Image.FromFile("Imagenes\\descargar.jpg");

                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Descargar"] = descargarLogo;
                        }
                        dataIdentificadores.DataSource = dataTable;
                    }
                    else if (tableName == "Internado")
                    {
                        string query = $"SELECT id, NºActual, Descripcion_Especie FROM {ayo} WHERE NºActual LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND NºActual LIKE '%{filtro}%'";
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataIdentificadores.DataSource = table;

                        DataTable dataTable = (DataTable)dataIdentificadores.DataSource;

                        dataTable.Columns.Add("Descargar", typeof(Image));

                        Image descargarLogo = Image.FromFile("Imagenes\\descargar.jpg");

                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Descargar"] = descargarLogo;
                        }
                        dataIdentificadores.DataSource = dataTable;
                    }
                    else
                    {
                        string query = $"SELECT id, NºActual, Descripcion_Especie FROM {tableName} WHERE NºActual LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND NºActual LIKE '%{filtro}%'";
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataIdentificadores.DataSource = table;

                        DataTable dataTable = (DataTable)dataIdentificadores.DataSource;

                        dataTable.Columns.Add("Descargar", typeof(Image));

                        Image descargarLogo = Image.FromFile("Imagenes\\descargar.jpg");

                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Descargar"] = descargarLogo;
                        }
                        dataIdentificadores.DataSource = dataTable;
                    }
                }
            }
            else if (ckSalas.Checked)
            {
                string sala = "";
                if (boxTallerSalas.Text == "Taller_de_Mecanica_Automotriz")
                {
                    sala = boxSalasMA.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Electricidad")
                {
                    sala = boxSalasE.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Mecanica_Industrial")
                {
                    sala = boxSalasMI.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Construcciones_Metalicas")
                {
                    sala = boxSalasCM.Text;
                }
                else if (boxTallerSalas.Text == "Taller_de_Terminaciones_de_la_Construccion")
                {
                    sala = boxSalasTC.Text;
                }

                if (sala != null)
                {
                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();

                    string query2 = $"SELECT id, NºInterno, Descripcion_Especie FROM {sala} WHERE NºInterno LIKE '%%'";

                    if (!string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                        query2 += $" AND NºInterno LIKE '%{filtro}%'";
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query2, conexion);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataIdentificadores.DataSource = table;

                    DataTable dataTable = (DataTable)dataIdentificadores.DataSource;

                    dataTable.Columns.Add("Descargar", typeof(Image));

                    Image descargarLogo = Image.FromFile("Imagenes\\descargar.jpg");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        row["Descargar"] = descargarLogo;
                    }
                    dataIdentificadores.DataSource = dataTable;
                }
            }
        }

        private void Identificador_Load(object sender, EventArgs e)
        {
            FiltrarTabla();
        }
    }
}
