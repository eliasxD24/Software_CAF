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
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using Application = Microsoft.Office.Interop.Excel.Application;
using QRCoder;
using System.IO;
using System.Web.UI.WebControls;
using Excel = Microsoft.Office.Interop.Excel;

namespace InventarioLI
{
    public partial class Inventario : Form
    {
        int tipoUsuario;
        public Inventario()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            boxSectores.SelectedIndexChanged += boxSectores_SelectedIndexChanged;
            txtBuscar.TextChanged += (sender, e) => FiltrarTabla();
            ckSalas.Visible = false;
            boxSalasMA.Visible = false;
            LABF.Visible = false;
            boxABF.Visible = false;
            t1.Visible = false;
            boxLugarSalas.Visible = false;
            boxSalasCM.Visible = false;
            boxSalasE.Visible = false;
            boxSalasMI.Visible = false;
            boxSalasTC.Visible = false;
            boxSalas.Visible = false;
            PLdata.Visible = true;
            PLsalas.Visible = false;
            btnVolver2.Visible = true;
            btnVolverD.Visible = false;
            LlenarComboBoxSalas();
            btnVer.Enabled = true;
            btnQR.Visible = false;
            txtResponsable.Visible = false;
            tR.Visible = false;
            boxAulas.Visible = false;
            boxOficinas.Visible = false;
            boxInternado.Visible = false;

            tipoUsuario = Session.id_tipo;

            if (tipoUsuario == 1 || tipoUsuario == 3)
            {
                this.btnSalas.Enabled = true;

            }
            else
            {
                this.btnSalas.Enabled = false;
            }
        }

        private void btnVolver2_Click(object sender, EventArgs e)
        {
            ActivosFijos a = new ActivosFijos();
            a.Show();
            this.Hide();
        }

        private void boxSectores_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarBoxDepartamentos();
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
                if (boxLugarSalas.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione el lugar de donde quiere ver las salas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz")
                {
                    if (boxSalasMA.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameMA = boxSalasMA.SelectedItem.ToString();
                    DataTable tableMA = GetTable(tableNameMA);
                    dataInventario.DataSource = tableMA;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas")
                {
                    if (boxSalasCM.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameCM = boxSalasCM.SelectedItem.ToString();
                    DataTable tableCM = GetTable(tableNameCM);
                    dataInventario.DataSource = tableCM;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Electricidad")
                {
                    if (boxSalasE.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameE = boxSalasE.SelectedItem.ToString();
                    DataTable tableE = GetTable(tableNameE);
                    dataInventario.DataSource = tableE;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial")
                {
                    if (boxSalasMI.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameMI = boxSalasMI.SelectedItem.ToString();
                    DataTable tableMI = GetTable(tableNameMI);
                    dataInventario.DataSource = tableMI;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion")
                {
                    if (boxSalasTC.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una Sala del Taller.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string tableNameTC = boxSalasTC.SelectedItem.ToString();
                    DataTable tableTC = GetTable(tableNameTC);
                    dataInventario.DataSource = tableTC;
                }
            }
            else
            {
                if (boxDepartamentos.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un lugar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectedDepartamento = boxDepartamentos.SelectedItem.ToString();

                if (selectedDepartamento == "Aulas")
                {
                    if (boxAulas.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un aula");
                        return;
                    }

                    string tableNameA = boxAulas.SelectedItem.ToString();
                    DataTable tableA = GetTable(tableNameA);
                    dataInventario.DataSource = tableA;
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
                    dataInventario.DataSource = tableO;
                }
                else if (selectedDepartamento == "Internado")
                {
                    if (boxInternado.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un ubicacion");
                        return;
                    }
                    string tableNameI = boxInternado.SelectedItem.ToString();
                    DataTable tableI = GetTable(tableNameI);
                    dataInventario.DataSource = tableI;
                }
                else
                {
                    string tableName = selectedDepartamento;
                    DataTable table = GetTable(tableName);
                    dataInventario.DataSource = table;
                }
            }
        }
        private DataTable GetTable(string tableName)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string rubro = boxCategoria.SelectedItem != null ? boxCategoria.SelectedItem.ToString() : "";
            string sql = $"SELECT * FROM {tableName}";
            if (!string.IsNullOrEmpty(rubro))
            {
                sql += $" WHERE Rubro='{rubro}'";
            }

            MySqlCommand command = new MySqlCommand(sql, conexion);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conexion.Close();
            return table;
        }

        private void ExportToExcel(DataTable table)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo de Excel|*.xlsx";
            saveFileDialog.Title = "Guardar como archivo de Excel";
            saveFileDialog.ShowDialog();

            if(!ckSalas.Checked)
            {
                if (saveFileDialog.FileName != "")
                {
                    string plantillaPath = "";
                    if (boxSectores.SelectedItem != null && boxSectores.SelectedItem.ToString() == "Inventario General")
                    {
                        if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "A"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel IG Rubro A.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "B"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel IG Rubro B.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "C"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel IG Rubro C.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "D"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel IG Rubro D.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "E"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel IG Rubro E.xlsx";
                        }
                        else
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel IG.xlsx";
                        }
                    }
                    else if (boxSectores.SelectedItem != null && boxSectores.SelectedItem.ToString() == "Materiales de Escritorio")
                    {
                        if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "A"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel ME Rubro A.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "B"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel ME Rubro B.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "C"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel ME Rubro C.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "D"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel ME Rubro D.xlsx";
                        }
                        else if (boxCategoria.SelectedItem != null && (boxCategoria.SelectedItem.ToString() == "D"))
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel ME Rubro D.xlsx";
                        }
                        else
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel ME.xlsx";
                        }
                    }
                    else if (boxSectores.SelectedItem != null && boxSectores.SelectedItem.ToString() == "Materiales de Aseo")
                    {
                        plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\PlantillaExcel MA.xlsx";
                    }

                    Application excel = new Application();
                    Workbook workbook = excel.Workbooks.Open(plantillaPath);
                    Worksheet worksheet = (Worksheet)workbook.Sheets[1];

                    // Filtrar por rubro solo si se ha seleccionado un rubro en el ComboBox boxCategoria
                    string rubro = boxCategoria.SelectedItem != null ? boxCategoria.SelectedItem.ToString() : "";
                    DataView dataView = table.DefaultView;
                    if (!string.IsNullOrEmpty(rubro))
                    {
                        dataView.RowFilter = $"Rubro='{rubro}'";
                    }
                    table = dataView.ToTable();

                    for (int i = 9; i <= table.Rows.Count + 8; i++)
                    {
                        for (int j = 1; j <= table.Columns.Count; j++)
                        {
                            if (table.Columns[j - 1].ColumnName == "Fecha Adquisición")
                            {
                                // Obtener la fecha en el formato deseado (día-mes-año)
                                DateTime fecha = Convert.ToDateTime(table.Rows[i - 9][j - 1]);
                                string fechaFormateada = fecha.ToString("dd-MM-yyyy");
                                worksheet.Cells[i, j].NumberFormat = "dd-mm-yyyy";
                                worksheet.Cells[i, j] = fechaFormateada;
                            }
                            else
                            {
                                worksheet.Cells[i, j] = table.Rows[i - 9][j - 1].ToString();
                            }

                            Excel.Range cell = (Excel.Range)worksheet.Cells[i, j];
                            cell.Font.Name = "Arial";
                            cell.Font.Size = 18;
                        }
                    }

                    int lastRow = table.Rows.Count + 8;
                    int lastColumn = table.Columns.Count;
                    Range dataRange = worksheet.Range["A9", $"O{lastRow}"];

                    Borders borders = dataRange.Borders;
                    borders.LineStyle = XlLineStyle.xlContinuous;
                    borders.Weight = XlBorderWeight.xlThin;
                    borders.ColorIndex = XlColorIndex.xlColorIndexAutomatic;


                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    workbook.Close(false, Type.Missing, Type.Missing);
                    excel.Quit();
                }
            }
            else if(ckSalas.Checked)
            {
                if (saveFileDialog.FileName != "")
                {
                    string plantillaPath = "";
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

                    if (sala != null && boxCategoria.SelectedItem != null)
                    {
                        if (boxCategoria.SelectedItem.ToString() == "A")
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\Plantilla_Sala Rubro A.xlsx";
                        }
                        else if (boxCategoria.SelectedItem.ToString() == "B")
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\Plantilla_Sala Rubro B.xlsx";
                        }
                        else if (boxCategoria.SelectedItem.ToString() == "C")
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\Plantilla_Sala Rubro C.xlsx";
                        }
                        else if (boxCategoria.SelectedItem.ToString() == "D")
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\Plantilla_Sala Rubro D.xlsx";
                        }
                        else if (boxCategoria.SelectedItem.ToString() == "E")
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\Plantilla_Sala Rubro E.xlsx";
                        }
                        else
                        {
                            plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\Plantilla_Sala.xlsx";
                        }
                    }
                    else
                    {
                        plantillaPath = AppDomain.CurrentDomain.BaseDirectory + "Imagenes\\Plantilla_Sala.xlsx";
                    }

                    Application excel = new Application();
                    Workbook workbook = excel.Workbooks.Open(plantillaPath);
                    Worksheet worksheet = (Worksheet)workbook.Sheets[1];
                    
                    string rubro = boxCategoria.SelectedItem != null ? boxCategoria.SelectedItem.ToString() : "";
                    DataView dataView = table.DefaultView;
                    if (!string.IsNullOrEmpty(rubro))
                    {
                        dataView.RowFilter = $"Rubro='{rubro}'";
                    }
                    table = dataView.ToTable();

                    for (int i = 9; i <= table.Rows.Count + 8; i++)
                    {
                        for (int j = 1; j <= table.Columns.Count; j++)
                        {
                            worksheet.Cells[i, j] = table.Rows[i - 9][j - 1].ToString();

                            Excel.Range cell = (Excel.Range)worksheet.Cells[i, j];
                            cell.Font.Name = "Arial";
                            cell.Font.Size = 15;
                        }
                    }

                    int lastRow = table.Rows.Count + 8;
                    int lastColumn = table.Columns.Count;
                    Range dataRange = worksheet.Range["A9", $"H{lastRow}"];

                    Borders borders = dataRange.Borders;
                    borders.LineStyle = XlLineStyle.xlContinuous;
                    borders.Weight = XlBorderWeight.xlThin;
                    borders.ColorIndex = XlColorIndex.xlColorIndexAutomatic;

                    // Obtener la última fila utilizada en la hoja de cálculo
                    int lastRow2 = table.Rows.Count + 8;
                    string responsable = txtResponsable.Text;

                    // Agregar el texto en las dos columnas debajo de la última fila
                    worksheet.Cells[lastRow2 + 2, 2] = "Carlos Moreno Diaz";
                    worksheet.Cells[lastRow2 + 3, 2] = "Director";
                    worksheet.Cells[lastRow2 + 4, 2] = "Liceo Industrial de San Fernando";
                    worksheet.Cells[lastRow2 + 3, 7] = "Responsable: " + responsable;

                    // Establecer el formato y estilo del texto agregado
                    Excel.Range nameCell = (Excel.Range)worksheet.Cells[lastRow2 + 2, 2];
                    nameCell.Font.Bold = true;
                    nameCell.Font.Size = 15;

                    Excel.Range titleCell = (Excel.Range)worksheet.Cells[lastRow2 + 3, 2];
                    titleCell.Font.Bold = true;
                    titleCell.Font.Size = 15;

                    Excel.Range schoolCell = (Excel.Range)worksheet.Cells[lastRow2 + 4, 2];
                    schoolCell.Font.Bold = true;
                    schoolCell.Font.Size = 15;

                    Excel.Range responsableCell = (Excel.Range)worksheet.Cells[lastRow2 + 3, 7];
                    responsableCell.Font.Bold = true;
                    responsableCell.Font.Size = 15;


                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    workbook.Close(false, Type.Missing, Type.Missing);
                    excel.Quit();
                }
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (ckSalas.Checked)
            {
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

                if (sala == null)
                {
                    MessageBox.Show("Por favor, seleccione una tabla antes de descargar el excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string tableName = sala;
                DataTable table = GetTable(tableName);

                if (string.IsNullOrEmpty(txtResponsable.Text))
                {
                    MessageBox.Show("Antes de descargar el excel, por favor agregue el responsable.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ExportToExcel(table);
            }
            else if(!ckSalas.Checked)
            {
                if (boxDepartamentos.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una tabla antes de descargar el excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string selectdep = boxDepartamentos.SelectedItem.ToString();

                if(selectdep == "Aulas")
                {
                    if(boxAulas.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un aula antes de descargar");
                        return;
                    }
                    string tableNameA = boxAulas.SelectedItem.ToString();
                    DataTable table = GetTable(tableNameA);
                    ExportToExcel(table);
                }
                else if (selectdep == "Oficinas")
                {
                    if(boxOficinas.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una oficina antes de descargar");
                        return;
                    }
                    string tableNameO = boxOficinas.SelectedItem.ToString();
                    DataTable table = GetTable(tableNameO);
                    ExportToExcel(table);
                }
                else if (selectdep == "Internado")
                {
                    if(boxInternado.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione una ubicacion antes de descargar");
                        return;
                    }
                    string tableNameI = boxInternado.SelectedItem.ToString();
                    DataTable tableI = GetTable(tableNameI);
                    ExportToExcel(tableI);
                }
                else
                {
                    string tableName = boxDepartamentos.SelectedItem.ToString();
                    DataTable table = GetTable(tableName);
                    ExportToExcel(table);
                }
            }
        }

        private void btnQR_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            boxABF.SelectedIndex = -1;

            if (!ckSalas.Checked)
            {
                if (boxDepartamentos.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una tabla para filtrar.", "Mensaje");
                    return;
                }
            }
            else if (ckSalas.Checked)
            {
                if (boxLugarSalas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un lugar.");
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Electricidad" && boxSalasE.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una Sala para filtrar.", "Mensaje");
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && boxSalasTC.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una Sala para filtrar.", "Mensaje");
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && boxSalasMI.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una Sala para filtrar.", "Mensaje");
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && boxSalasMA.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una Sala para filtrar.", "Mensaje");
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && boxSalasCM.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una Sala para filtrar.", "Mensaje");
                    return;
                }
            }

            string rubro = boxCategoria.SelectedItem?.ToString();

            if (boxCategoria.SelectedIndex == -1)
            {
                
                MessageBox.Show("Seleccione que categoria quiere para filtrar.", "Mensaje");
                return;
            }

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            
            if(!ckSalas.Checked)
            {
                string ayo = "";
                if (boxDepartamentos.Text == "Aulas")
                {
                    ayo = boxAulas.Text;
                }
                else if (boxDepartamentos.Text == "Oficinas")
                {
                    ayo = boxOficinas.Text;
                }
                else if (boxDepartamentos.Text == "Internado")
                {
                    ayo = boxInternado.Text;
                }

                string tableName = boxDepartamentos.SelectedItem.ToString();

                if (tableName == "Aulas")
                {
                    if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                    {
                        string query = $"SELECT * FROM {ayo} WHERE Rubro LIKE '{rubro.Last()}'";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                    else
                    {
                        DataTable table = GetTable(ayo);
                        dataInventario.DataSource = table;
                    }
                }
                else if (tableName == "Oficinas")
                {
                    if(rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                    {
                        string query = $"SELECT * FROM {ayo} WHERE Rubro LIKE '{rubro.Last()}'";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                    else
                    {
                        DataTable table = GetTable(ayo);
                        dataInventario.DataSource = table;
                    }
                }
                else if (tableName == "Internado")
                {
                    if(rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                    {
                        string query = $"SELECT * FROM {ayo} WHERE Rubro LIKE '{rubro.Last()}'";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                    else
                    {
                        DataTable table = GetTable(ayo);
                        dataInventario.DataSource = table;
                    }
                }
                else
                {
                    if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                    {
                        string query = $"SELECT * FROM {tableName} WHERE Rubro LIKE '{rubro.Last()}'";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                    else
                    {
                        DataTable table = GetTable(tableName);
                        dataInventario.DataSource = table;
                    }
                }
            }
            else if(ckSalas.Checked)
            {
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

                if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                {
                    string query2 = $"SELECT * FROM {sala} WHERE Rubro LIKE '{rubro.Last()}'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query2, conexion);
                    DataTable table2 = new DataTable();
                    adapter.Fill(table2);
                    dataInventario.DataSource = table2;
                }
                else
                {
                    DataTable table2 = GetTable(sala);
                    dataInventario.DataSource = table2;
                }
            }
        }

        private void FiltrarTabla()
        {
            if(!ckSalas.Checked)
            {
                string ayo = "";
                if (boxDepartamentos.Text == "Aulas")
                {
                    ayo = boxAulas.Text;
                }
                else if (boxDepartamentos.Text == "Oficinas")
                {
                    ayo = boxOficinas.Text;
                }
                else if (boxDepartamentos.Text == "Internado")
                {
                    ayo = boxInternado.Text;
                }

                if (boxDepartamentos.SelectedItem != null)
                {
                    string tableName = boxDepartamentos.SelectedItem.ToString();
                    string rubro = boxCategoria.SelectedItem?.ToString();

                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();

                    if (tableName == "Aulas")
                    {
                        string query = $"SELECT * FROM {ayo} WHERE Descripcion_Especie LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND Descripcion_Especie LIKE '%{filtro}%'";
                        }

                        if (!string.IsNullOrEmpty(rubro))
                        {
                            if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                            {
                                query += $" AND Rubro LIKE '{rubro.Last()}'";
                            }
                            else
                            {
                                query += $" AND Rubro = '{rubro}'";
                            }
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                    else if (tableName == "Oficinas")
                    {
                        string query = $"SELECT * FROM {ayo} WHERE Descripcion_Especie LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND Descripcion_Especie LIKE '%{filtro}%'";
                        }

                        if (!string.IsNullOrEmpty(rubro))
                        {
                            if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                            {
                                query += $" AND Rubro LIKE '{rubro.Last()}'";
                            }
                            else
                            {
                                query += $" AND Rubro = '{rubro}'";
                            }
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                    else if (tableName == "Internado")
                    {
                        string query = $"SELECT * FROM {ayo} WHERE Descripcion_Especie LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND Descripcion_Especie LIKE '%{filtro}%'";
                        }

                        if (!string.IsNullOrEmpty(rubro))
                        {
                            if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                            {
                                query += $" AND Rubro LIKE '{rubro.Last()}'";
                            }
                            else
                            {
                                query += $" AND Rubro = '{rubro}'";
                            }
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                    else
                    {
                        string query = $"SELECT * FROM {tableName} WHERE Descripcion_Especie LIKE '%%'";

                        if (!string.IsNullOrEmpty(txtBuscar.Text))
                        {
                            string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                            query += $" AND Descripcion_Especie LIKE '%{filtro}%'";
                        }

                        if (!string.IsNullOrEmpty(rubro))
                        {
                            if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                            {
                                query += $" AND Rubro LIKE '{rubro.Last()}'";
                            }
                            else
                            {
                                query += $" AND Rubro = '{rubro}'";
                            }
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataInventario.DataSource = table;
                    }
                }
            }
            else if(ckSalas.Checked)
            {
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

                if(sala != null)
                {
                    string rubro = boxCategoria.SelectedItem?.ToString();
                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();

                    string query2 = $"SELECT * FROM {sala} WHERE Descripcion_Especie LIKE '%%'";

                    if (!string.IsNullOrEmpty(txtBuscar.Text))
                    {
                        string filtro = txtBuscar.Text.Trim().Replace("'", "''");
                        query2 += $" AND Descripcion_Especie LIKE '%{filtro}%'";
                    }

                    if (!string.IsNullOrEmpty(rubro))
                    {
                        if (rubro == "Rubro A" || rubro == "Rubro B" || rubro == "Rubro C" || rubro == "Rubro D" || rubro == "Rubro E")
                        {
                            query2 += $" AND Rubro LIKE '{rubro.Last()}'";
                        }
                        else
                        {
                            query2 += $" AND Rubro = '{rubro}'";
                        }
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query2, conexion);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataInventario.DataSource = table;
                }
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            FiltrarTabla();            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarTabla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            boxABF.SelectedIndex = -1;

            if (!ckSalas.Checked)
            {
                if (boxDepartamentos.SelectedItem == null)
                {
                    boxCategoria.SelectedIndex = -1;
                    return;
                }
            }
            else if (ckSalas.Checked)
            {
                if (boxLugarSalas.SelectedItem == null)
                {
                    boxCategoria.SelectedIndex = -1;
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Electricidad" && boxSalasE.SelectedItem == null)
                {
                    boxCategoria.SelectedIndex = -1;
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && boxSalasTC.SelectedItem == null)
                {
                    boxCategoria.SelectedIndex = -1;
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && boxSalasMI.SelectedItem == null)
                {
                    boxCategoria.SelectedIndex = -1;
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && boxSalasMA.SelectedItem == null)
                {
                    boxCategoria.SelectedIndex = -1;
                    return;
                }

                if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && boxSalasCM.SelectedItem == null)
                {
                    boxCategoria.SelectedIndex = -1;
                    return;
                }
            }

            boxCategoria.SelectedIndex = -1;

            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            if(!ckSalas.Checked)
            {
                string ayo = "";

                if (boxDepartamentos.Text == "Aulas")
                {
                    ayo = boxAulas.Text;
                }
                else if (boxDepartamentos.Text == "Oficinas")
                {
                    ayo = boxOficinas.Text;
                }
                else if (boxDepartamentos.Text == "Internado")
                {
                    ayo = boxInternado.Text;
                }

                string tableName = boxDepartamentos.SelectedItem.ToString();

                if (tableName == "Aulas")
                {
                    string query = "SELECT * FROM " + ayo;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataInventario.DataSource = dataTable;

                    dataInventario.Columns[0].Visible = false;
                }
                else if (tableName == "Oficinas")
                {
                    string query = "SELECT * FROM " + ayo;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataInventario.DataSource = dataTable;

                    dataInventario.Columns[0].Visible = false;
                }
                else if (tableName == "Internado")
                {
                    string query = "SELECT * FROM " + ayo;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataInventario.DataSource = dataTable;

                    dataInventario.Columns[0].Visible = false;
                }
                else
                {
                    string query = "SELECT * FROM " + tableName;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataInventario.DataSource = dataTable;

                    dataInventario.Columns[0].Visible = false;
                }
                
            }
            else if(ckSalas.Checked)
            {
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

                string query2 = "SELECT * FROM " + sala;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query2, conexion);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataInventario.DataSource = dataTable;
            }
        }

        private void ckSalas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarBoxDepartamentos();
        }

        private void ActualizarBoxDepartamentos()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            boxDepartamentos.Items.Clear();

            if (boxSectores.SelectedItem != null && boxSectores.SelectedItem.ToString() == "Inventario General" && !ckSalas.Checked)
            {
                btnFiltrar.Enabled = true;
                btnLimpiar.Enabled = true;
                boxCategoria.Enabled = true;
                boxSalas.Visible = false;
                LABF.Visible = true;
                boxABF.Visible = true;
                t1.Visible = false;
                boxLugarSalas.Visible = false;
                boxDepartamentos.Visible = true;

                boxDepartamentos.Items.Add("Taller_de_Mecanica_Automotriz");
                boxDepartamentos.Items.Add("Taller_de_Mecanica_Industrial");
                boxDepartamentos.Items.Add("Taller_de_Construcciones_Metalicas");
                boxDepartamentos.Items.Add("Taller_de_Terminaciones_de_la_Construccion");
                boxDepartamentos.Items.Add("Taller_de_Electricidad");

                boxDepartamentos.Items.Add("Aulas");
                boxDepartamentos.Items.Add("Oficinas");
                boxDepartamentos.Items.Add("Internado");

                ckSalas.Visible = true;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;

                txtResponsable.Visible = false;
                tR.Visible = false;
            }
            else if (boxSectores.SelectedItem.ToString() == "Materiales de Escritorio" && !ckSalas.Checked)
            {
                btnFiltrar.Enabled = true;
                btnLimpiar.Enabled = true;
                boxCategoria.Enabled = true;
                boxSalas.Visible = false;
                LABF.Visible = true;
                boxABF.Visible = true;
                t1.Visible = false;
                boxLugarSalas.Visible = false;
                boxDepartamentos.Visible = true;

                boxDepartamentos.Items.Add("DeptoUTP");
                boxDepartamentos.Items.Add("DeptoAdministracion");
                boxDepartamentos.Items.Add("DeptoInspectoriaGeneral");
                boxDepartamentos.Items.Add("DeptoPsicosocial");
                boxDepartamentos.Items.Add("DeptoDireccion");
                boxDepartamentos.Items.Add("DeptoBiblioteca");
                boxDepartamentos.Items.Add("DeptoInternado");

                ckSalas.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;
                boxAulas.Visible = false;
                boxOficinas.Visible = false;
                boxInternado.Visible = false;

                txtResponsable.Visible = false;
                tR.Visible = false;
            }
            else if (boxSectores.SelectedItem.ToString() == "Materiales de Aseo" && !ckSalas.Checked)
            {
                btnFiltrar.Enabled = false;
                btnLimpiar.Enabled = false;
                boxCategoria.Enabled = false;
                boxSalas.Visible = false;
                LABF.Visible = false;
                boxABF.Visible = false;
                t1.Visible = false;
                boxLugarSalas.Visible = false;
                boxDepartamentos.Visible = true;

                boxDepartamentos.Items.Add("Liceo");
                boxDepartamentos.Items.Add("Internado ");

                ckSalas.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasTC.Visible = false;
                boxAulas.Visible = false;
                boxOficinas.Visible = false;
                boxInternado.Visible = false;

                txtResponsable.Visible = false;
                tR.Visible = false;

            }
            else if (ckSalas.Checked)
            {
                t1.Visible = true;
                boxLugarSalas.Visible = true;
                boxDepartamentos.Visible = false;
                boxABF.Visible = false;
                LABF.Visible = false;

                txtResponsable.Visible = true;
                tR.Visible = true;
                boxOficinas.Visible = false;
                boxAulas.Visible = false;
                boxInternado.Visible = false;
            }
        }

        public void btnSalas_Click(object sender, EventArgs e)
        {
            PLdata.Visible = false;
            PLsalas.Visible = true;
            btnVolver2.Visible = false;
            btnVolverD.Visible = true;
            btnVer.Enabled = false;
        }

        private void boxABF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablaSeleccionada = "";
            string filtroCategoria = "";
            string filtroClase = "";

            if (boxDepartamentos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar una tabla");
                return;
            }
            else
            {
                tablaSeleccionada = boxDepartamentos.SelectedItem.ToString();
            }

            if (boxDepartamentos.SelectedItem.ToString() == "Aulas")
            {
                if (boxAulas.SelectedItem == null)
                {
                    MessageBox.Show("Debes seleccionar una Aula");
                    return;
                }
                else
                {
                    tablaSeleccionada = boxAulas.SelectedItem.ToString();
                }
            }

            if (boxDepartamentos.SelectedItem.ToString() == "Oficinas")
            {
                if (boxOficinas.SelectedItem == null)
                {
                    MessageBox.Show("Debes seleccionar una Oficina");
                    return;
                }
                else
                {
                    tablaSeleccionada = boxOficinas.SelectedItem.ToString();
                }
            }

            if (boxDepartamentos.SelectedItem.ToString() == "Internado")
            {
                if (boxInternado.SelectedItem == null)
                {
                    MessageBox.Show("Debes seleccionar una ubicacion");
                    return;
                }
                else
                {
                    tablaSeleccionada = boxInternado.SelectedItem.ToString();
                }
            }

            if (boxCategoria.SelectedItem != null)
            {
                string categoriaSeleccionada = boxCategoria.SelectedItem.ToString();

                filtroCategoria = "Rubro = '" + categoriaSeleccionada + "'";
            }

            if (boxABF.SelectedItem != null)
            {
                string opcionSeleccionada = boxABF.SelectedItem.ToString();

                switch (opcionSeleccionada)
                {
                    case "ALTA":
                        filtroClase = "Clase = 'ALTA'";
                        break;
                    case "BAJA":
                        filtroClase = "Clase = 'BAJA'";
                        break;
                    case "FUNGIBLE":
                        filtroClase = "Clase = 'FUNGIBLE'";
                        break;
                    default:
                        break;
                }
            }

            string consulta = "SELECT * FROM " + tablaSeleccionada;

            if (!string.IsNullOrEmpty(filtroCategoria) || !string.IsNullOrEmpty(filtroClase))
            {
                consulta += " WHERE ";

                if (!string.IsNullOrEmpty(filtroCategoria))
                {
                    consulta += filtroCategoria;

                    if (!string.IsNullOrEmpty(filtroClase))
                    {
                        consulta += " AND " + filtroClase;
                    }
                }
                else
                {
                    consulta += filtroClase;
                }
            }

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataInventario.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
            }
        }

        private void boxLugarSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz" && ckSalas.Checked)
            {
                boxSalasMA.Visible = true;


                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasE.Visible = false;
                boxSalasCM.Visible = false;
                boxSalas.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas" && ckSalas.Checked)
            {
                boxSalasCM.Visible = true;


                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasE.Visible = false;
                boxSalas.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Electricidad" && ckSalas.Checked)
            {
                boxSalasE.Visible = true;

                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasMI.Visible = false;
                boxSalasCM.Visible = false;
                boxSalas.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial" && ckSalas.Checked)
            {
                boxSalasMI.Visible = true;

                boxSalasMA.Visible = false;
                boxSalasTC.Visible = false;
                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalas.Visible = false;
            }
            else if (boxLugarSalas.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion" && ckSalas.Checked)
            {
                boxSalasTC.Visible = true;

                boxSalasCM.Visible = false;
                boxSalasE.Visible = false;
                boxSalasMA.Visible = false;
                boxSalasMI.Visible = false;
                boxSalas.Visible = false;
            }
        }

        private void btnVolverD_Click(object sender, EventArgs e)
        {
            btnVolverD.Visible = false;
            PLsalas.Visible = false;
            PLdata.Visible = true;
            btnVolver2.Visible = true;
            btnVer.Enabled = true;
        }

        private void btnASala_Click(object sender, EventArgs e)
        {
            if (boxAlugarSalas.SelectedItem != null && txtNSala.Text != "")
            {
                string nombreTabla = txtNSala.Text;

                bool tablaExiste = false;
                MySqlConnection conexion = Conexion.getConexion();
                string consulta = "SELECT count(*) FROM information_schema.tables WHERE table_schema = 'activosfijos' AND table_name = '" + nombreTabla + "'";
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    tablaExiste = (count > 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar si la tabla sala ya existe en la base de datos: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }

                if (!tablaExiste)
                {
                    string taller = boxAlugarSalas.SelectedItem.ToString();
                    MySqlCommand cmd = null;
                    
                    if (taller == "Aulas")
                    {
                        string insert = "CREATE TABLE " + nombreTabla + " (ID INT AUTO_INCREMENT NOT NULL, NºAnterior VARCHAR (50), NºActual VARCHAR (50) NOT NULL, Tipo_Especie VARCHAR (100) NOT NULL, Descripcion_Especie VARCHAR(100) NOT NULL, Rubro VARCHAR(20) NOT NULL, Estado VARCHAR (15) NOT NULL, Responsable VARCHAR (100) NOT NULL, RUT VARCHAR(50) NOT NULL, " +
                            "Nombre_de_Establecimiento VARCHAR(100) NOT NULL, Talleres_Aulas VARCHAR(100) NOT NULL, Ubicacion_Fisica VARCHAR (100) NOT NULL, Valor_Adquicision INT NOT NULL, Fecha_Adquicision VARCHAR (20) NOT NULL, Origen VARCHAR (100), Clase VARCHAR (20), PRIMARY KEY (ID))";
                        cmd = new MySqlCommand(insert, conexion);
                    }
                    else if (taller == "Oficinas")
                    {
                        string insert = "CREATE TABLE " + nombreTabla + " (ID INT AUTO_INCREMENT NOT NULL, NºAnterior VARCHAR (50), NºActual VARCHAR (50) NOT NULL, Tipo_Especie VARCHAR (100) NOT NULL, Descripcion_Especie VARCHAR(100) NOT NULL, Rubro VARCHAR(20) NOT NULL, Estado VARCHAR (15) NOT NULL, Responsable VARCHAR (100) NOT NULL, RUT VARCHAR(50) NOT NULL, " +
                            "Nombre_de_Establecimiento VARCHAR(100) NOT NULL, Talleres_Aulas VARCHAR(100) NOT NULL, Ubicacion_Fisica VARCHAR (100) NOT NULL, Valor_Adquicision INT NOT NULL, Fecha_Adquicision VARCHAR (20) NOT NULL, Origen VARCHAR (100), Clase VARCHAR (20), PRIMARY KEY (ID))";
                         cmd = new MySqlCommand(insert, conexion);
                    }
                    else if (taller == "Internado")
                    {
                        string insert = "CREATE TABLE " + nombreTabla + " (ID INT AUTO_INCREMENT NOT NULL, NºAnterior VARCHAR (50), NºActual VARCHAR (50) NOT NULL, Tipo_Especie VARCHAR (100) NOT NULL, Descripcion_Especie VARCHAR(100) NOT NULL, Rubro VARCHAR(20) NOT NULL, Estado VARCHAR (15) NOT NULL, Responsable VARCHAR (100) NOT NULL, RUT VARCHAR(50) NOT NULL, " +
                            "Nombre_de_Establecimiento VARCHAR(100) NOT NULL, Talleres_Aulas VARCHAR(100) NOT NULL, Ubicacion_Fisica VARCHAR (100) NOT NULL, Valor_Adquicision INT NOT NULL, Fecha_Adquicision VARCHAR (20) NOT NULL, Origen VARCHAR (100), Clase VARCHAR (20), PRIMARY KEY (ID))";
                        cmd = new MySqlCommand(insert, conexion);
                    }
                    else
                    {
                        string insert = "CREATE TABLE " + nombreTabla + " (ID INT AUTO_INCREMENT NOT NULL, NºInterno VARCHAR (50) NOT NULL, Descripcion_Especie VARCHAR(100) NOT NULL, Rubro VARCHAR(20) NOT NULL, NºSerie VARCHAR(50) NOT NULL, Cantidad VARCHAR(50) NOT NULL, " +
                        "Estado VARCHAR(50) NOT NULL, Observaciones VARCHAR(100), PRIMARY KEY (ID))";
                        cmd = new MySqlCommand(insert, conexion);
                    }

                    try
                    {
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Tabla creada exitosamente.");
                        
                        string insertSala = "";
                        if (taller == "Taller_de_Terminaciones_de_la_Construccion")
                        {
                            insertSala = "INSERT INTO tcsalas (nombre) VALUES (@nombre)";
                        }
                        else if (taller == "Taller_de_Construcciones_Metalicas")
                        {
                            insertSala = "INSERT INTO cmsalas (nombre) VALUES (@nombre)";
                        }
                        else if (taller == "Taller_de_Electricidad")
                        {
                            insertSala = "INSERT INTO esalas (nombre) VALUES (@nombre)";
                        }
                        else if (taller == "Taller_de_Mecanica_Industrial")
                        {
                            insertSala = "INSERT INTO misalas (nombre) VALUES (@nombre)";
                        }
                        else if (taller == "Taller_de_Mecanica_Automotriz")
                        {
                            insertSala = "INSERT INTO masalas (nombre) VALUES (@nombre)";
                        }
                        else if (taller == "Aulas")
                        {
                            insertSala = "INSERT INTO Aulas (nombre) VALUES (@nombre)";
                        }
                        else if (taller == "Oficinas")
                        {
                            insertSala = "INSERT INTO Oficinas (nombre) VALUES (@nombre)";
                        }
                        else if (taller == "Internado")
                        {
                            insertSala = "INSERT INTO Internado_IG (nombre) VALUES (@nombre)";
                        }

                        if (insertSala != "")
                        {
                            MySqlCommand cmdSala = new MySqlCommand(insertSala, conexion);
                            cmdSala.Parameters.Add(new MySqlParameter("@nombre", txtNSala.Text));
                            cmdSala.ExecuteNonQuery();
                        }
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear la sala: " + ex.Message);
                    }
                    finally
                    {
                        conexion.Close();
                    }

                }
                else
                {
                    MessageBox.Show("El nombre de esta Sala, Aula o Oficina ya existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un lugar y coloquele un nombre.");
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

        private void btnESala_Click(object sender, EventArgs e)
        {
            string tallerSeleccionado = boxAlugarSala2.Text;
            string nombreSala = txtNSala2.Text;

            if (string.IsNullOrEmpty(tallerSeleccionado))
            {
                MessageBox.Show("Seleccione un lugar primero.");
                return;
            }

            if (string.IsNullOrEmpty(nombreSala))
            {
                MessageBox.Show("Escriba el nombre de la ubicacion que desea eliminar.");
                return;
            }

            string tabla = tallerSeleccionado;

            using (MySqlConnection conexion = Conexion.getConexion())
            {
                try
                {
                    conexion.Open();

                    if (boxAlugarSala2.SelectedItem.ToString() == "Taller_de_Electricidad")
                    { 
                        string query = $"DELETE FROM esalas WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró la sala '{nombreSala}'.");
                            return;
                        }

                        query = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"La sala '{nombreSala}' ha sido eliminada correctamente.");
                    }

                    if (boxAlugarSala2.SelectedItem.ToString() == "Taller_de_Mecanica_Automotriz")
                    {
                        string query = $"DELETE FROM masalas WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró la sala '{nombreSala}'.");
                            return;
                        }

                        query = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"La sala '{nombreSala}' ha sido eliminada correctamente.");
                    }

                    if (boxAlugarSala2.SelectedItem.ToString() == "Taller_de_Mecanica_Industrial")
                    {
                        string query = $"DELETE FROM misalas WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró la sala '{nombreSala}'.");
                            return;
                        }

                        query = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"La sala '{nombreSala}' ha sido eliminada correctamente.");
                    }

                    if (boxAlugarSala2.SelectedItem.ToString() == "Taller_de_Construcciones_Metalicas")
                    {
                        string query = $"DELETE FROM cmsalas WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró la sala '{nombreSala}'.");
                            return;
                        }

                        string query1 = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query1, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"La sala '{nombreSala}' ha sido eliminada correctamente.");
                    }

                    if (boxAlugarSala2.SelectedItem.ToString() == "Taller_de_Terminaciones_de_la_Construccion")
                    {
                        string query = $"DELETE FROM tcsalas WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró la sala '{nombreSala}'.");
                            return;
                        }

                        query = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"La sala '{nombreSala}' ha sido eliminada correctamente.");
                    }

                    if (boxAlugarSala2.SelectedItem.ToString() == "Aulas")
                    {
                        string query = $"DELETE FROM Aulas WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró el Aula '{nombreSala}'.");
                            return;
                        }

                        query = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"El Aula '{nombreSala}' ha sido eliminada correctamente.");
                    }

                    if (boxAlugarSala2.SelectedItem.ToString() == "Oficinas")
                    {
                        string query = $"DELETE FROM Oficinas WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró la Oficina '{nombreSala}'.");
                            return;
                        }

                        query = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"La Oficina '{nombreSala}' ha sido eliminada correctamente.");
                    }

                    if (boxAlugarSala2.SelectedItem.ToString() == "Internado")
                    {
                        string query = $"DELETE FROM Internado_IG WHERE nombre = '{nombreSala}'";
                        MySqlCommand comando = new MySqlCommand(query, conexion);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show($"No se encontró la ubicacion '{nombreSala}'.");
                            return;
                        }

                        query = $"DROP TABLE {nombreSala}";
                        comando = new MySqlCommand(query, conexion);
                        filasAfectadas = comando.ExecuteNonQuery();

                        txtNSala2.Clear();
                        boxOficinas.Items.Clear();
                        boxInternado.Items.Clear();
                        boxAulas.Items.Clear();
                        boxSalasMA.Items.Clear();
                        boxSalasMI.Items.Clear();
                        boxSalasE.Items.Clear();
                        boxSalasCM.Items.Clear();
                        boxSalasTC.Items.Clear();
                        LlenarComboBoxSalas();

                        MessageBox.Show($"La ubicacion '{nombreSala}' ha sido eliminada correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la tabla: {ex.Message}");
                }
            }
        }

        private void boxDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxDepartamentos.SelectedItem != null && boxDepartamentos.SelectedItem.ToString() == "Aulas")
            {
                boxAulas.Visible = true;
            }
            else
            {
                boxAulas.Visible = false;
            }

            if(boxDepartamentos.SelectedItem != null && boxDepartamentos.SelectedItem.ToString() == "Oficinas")
            {
                boxOficinas.Visible = true;
            }
            else
            {
                boxOficinas.Visible = false;
            }

            if (boxDepartamentos.SelectedItem !=null && boxDepartamentos.SelectedItem.ToString() == "Internado")
            {
                boxInternado.Visible = true;
            }
            else
            {
                boxInternado.Visible = false;
            }
        }

        private void txtNSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtNSala2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}