
namespace InventarioLI
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.boxSectores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxDepartamentos = new System.Windows.Forms.ComboBox();
            this.boxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver2 = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boxInternado = new System.Windows.Forms.ComboBox();
            this.boxOficinas = new System.Windows.Forms.ComboBox();
            this.boxAulas = new System.Windows.Forms.ComboBox();
            this.boxSalas = new System.Windows.Forms.ComboBox();
            this.boxSalasE = new System.Windows.Forms.ComboBox();
            this.boxSalasMI = new System.Windows.Forms.ComboBox();
            this.boxLugarSalas = new System.Windows.Forms.ComboBox();
            this.boxSalasTC = new System.Windows.Forms.ComboBox();
            this.t1 = new System.Windows.Forms.Label();
            this.boxSalasCM = new System.Windows.Forms.ComboBox();
            this.ckSalas = new System.Windows.Forms.CheckBox();
            this.boxSalasMA = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.boxABF = new System.Windows.Forms.ComboBox();
            this.LABF = new System.Windows.Forms.Label();
            this.dataInventario = new System.Windows.Forms.DataGridView();
            this.PLdata = new System.Windows.Forms.Panel();
            this.PLsalas = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnESala = new System.Windows.Forms.Button();
            this.txtNSala2 = new System.Windows.Forms.TextBox();
            this.boxAlugarSala2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnASala = new System.Windows.Forms.Button();
            this.txtNSala = new System.Windows.Forms.TextBox();
            this.boxAlugarSalas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVolverD = new System.Windows.Forms.Button();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.tR = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).BeginInit();
            this.PLdata.SuspendLayout();
            this.PLsalas.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sectores:";
            // 
            // boxSectores
            // 
            this.boxSectores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSectores.FormattingEnabled = true;
            this.boxSectores.Items.AddRange(new object[] {
            "Inventario General",
            "Materiales de Escritorio",
            "Materiales de Aseo"});
            this.boxSectores.Location = new System.Drawing.Point(99, 35);
            this.boxSectores.Name = "boxSectores";
            this.boxSectores.Size = new System.Drawing.Size(209, 21);
            this.boxSectores.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lugar:";
            // 
            // boxDepartamentos
            // 
            this.boxDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDepartamentos.FormattingEnabled = true;
            this.boxDepartamentos.Location = new System.Drawing.Point(99, 80);
            this.boxDepartamentos.Name = "boxDepartamentos";
            this.boxDepartamentos.Size = new System.Drawing.Size(209, 21);
            this.boxDepartamentos.TabIndex = 5;
            this.boxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.boxDepartamentos_SelectedIndexChanged);
            // 
            // boxCategoria
            // 
            this.boxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.boxCategoria.Location = new System.Drawing.Point(6, 52);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(221, 21);
            this.boxCategoria.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rubro:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(122, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(335, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Buscar por Producto:";
            // 
            // btnVolver2
            // 
            this.btnVolver2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver2.Location = new System.Drawing.Point(37, 641);
            this.btnVolver2.Name = "btnVolver2";
            this.btnVolver2.Size = new System.Drawing.Size(107, 47);
            this.btnVolver2.TabIndex = 10;
            this.btnVolver2.Text = "Volver";
            this.btnVolver2.UseVisualStyleBackColor = true;
            this.btnVolver2.Click += new System.EventHandler(this.btnVolver2_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVer.Location = new System.Drawing.Point(366, 52);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(107, 59);
            this.btnVer.TabIndex = 11;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.boxInternado);
            this.groupBox1.Controls.Add(this.boxOficinas);
            this.groupBox1.Controls.Add(this.boxAulas);
            this.groupBox1.Controls.Add(this.boxSalas);
            this.groupBox1.Controls.Add(this.boxSalasE);
            this.groupBox1.Controls.Add(this.boxSalasMI);
            this.groupBox1.Controls.Add(this.boxLugarSalas);
            this.groupBox1.Controls.Add(this.boxSalasTC);
            this.groupBox1.Controls.Add(this.t1);
            this.groupBox1.Controls.Add(this.boxSalasCM);
            this.groupBox1.Controls.Add(this.ckSalas);
            this.groupBox1.Controls.Add(this.btnVer);
            this.groupBox1.Controls.Add(this.boxSalasMA);
            this.groupBox1.Controls.Add(this.boxDepartamentos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxSectores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 160);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Tabla";
            // 
            // boxInternado
            // 
            this.boxInternado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxInternado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxInternado.FormattingEnabled = true;
            this.boxInternado.Location = new System.Drawing.Point(99, 124);
            this.boxInternado.Name = "boxInternado";
            this.boxInternado.Size = new System.Drawing.Size(209, 21);
            this.boxInternado.TabIndex = 26;
            // 
            // boxOficinas
            // 
            this.boxOficinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxOficinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOficinas.FormattingEnabled = true;
            this.boxOficinas.Location = new System.Drawing.Point(99, 124);
            this.boxOficinas.Name = "boxOficinas";
            this.boxOficinas.Size = new System.Drawing.Size(209, 21);
            this.boxOficinas.TabIndex = 25;
            // 
            // boxAulas
            // 
            this.boxAulas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAulas.FormattingEnabled = true;
            this.boxAulas.Location = new System.Drawing.Point(99, 124);
            this.boxAulas.Name = "boxAulas";
            this.boxAulas.Size = new System.Drawing.Size(209, 21);
            this.boxAulas.TabIndex = 24;
            // 
            // boxSalas
            // 
            this.boxSalas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalas.FormattingEnabled = true;
            this.boxSalas.Location = new System.Drawing.Point(99, 124);
            this.boxSalas.Name = "boxSalas";
            this.boxSalas.Size = new System.Drawing.Size(209, 21);
            this.boxSalas.TabIndex = 23;
            // 
            // boxSalasE
            // 
            this.boxSalasE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSalasE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasE.FormattingEnabled = true;
            this.boxSalasE.Location = new System.Drawing.Point(99, 124);
            this.boxSalasE.Name = "boxSalasE";
            this.boxSalasE.Size = new System.Drawing.Size(209, 21);
            this.boxSalasE.TabIndex = 20;
            // 
            // boxSalasMI
            // 
            this.boxSalasMI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSalasMI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasMI.FormattingEnabled = true;
            this.boxSalasMI.Location = new System.Drawing.Point(99, 124);
            this.boxSalasMI.Name = "boxSalasMI";
            this.boxSalasMI.Size = new System.Drawing.Size(209, 21);
            this.boxSalasMI.TabIndex = 21;
            // 
            // boxLugarSalas
            // 
            this.boxLugarSalas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxLugarSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLugarSalas.FormattingEnabled = true;
            this.boxLugarSalas.Items.AddRange(new object[] {
            "Taller_de_Mecanica_Automotriz",
            "Taller_de_Mecanica_Industrial",
            "Taller_de_Construcciones_Metalicas",
            "Taller_de_Terminaciones_de_la_Construccion",
            "Taller_de_Electricidad"});
            this.boxLugarSalas.Location = new System.Drawing.Point(99, 80);
            this.boxLugarSalas.Name = "boxLugarSalas";
            this.boxLugarSalas.Size = new System.Drawing.Size(209, 21);
            this.boxLugarSalas.TabIndex = 15;
            this.boxLugarSalas.SelectedIndexChanged += new System.EventHandler(this.boxLugarSalas_SelectedIndexChanged);
            // 
            // boxSalasTC
            // 
            this.boxSalasTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSalasTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasTC.FormattingEnabled = true;
            this.boxSalasTC.Location = new System.Drawing.Point(99, 124);
            this.boxSalasTC.Name = "boxSalasTC";
            this.boxSalasTC.Size = new System.Drawing.Size(209, 21);
            this.boxSalasTC.TabIndex = 22;
            // 
            // t1
            // 
            this.t1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t1.AutoSize = true;
            this.t1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(50, 125);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(41, 16);
            this.t1.TabIndex = 14;
            this.t1.Text = "Salas:";
            // 
            // boxSalasCM
            // 
            this.boxSalasCM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSalasCM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasCM.FormattingEnabled = true;
            this.boxSalasCM.Location = new System.Drawing.Point(99, 124);
            this.boxSalasCM.Name = "boxSalasCM";
            this.boxSalasCM.Size = new System.Drawing.Size(209, 21);
            this.boxSalasCM.TabIndex = 16;
            // 
            // ckSalas
            // 
            this.ckSalas.AutoSize = true;
            this.ckSalas.Location = new System.Drawing.Point(323, 126);
            this.ckSalas.Name = "ckSalas";
            this.ckSalas.Size = new System.Drawing.Size(71, 17);
            this.ckSalas.TabIndex = 12;
            this.ckSalas.Text = "Ver Salas";
            this.ckSalas.UseVisualStyleBackColor = true;
            this.ckSalas.CheckedChanged += new System.EventHandler(this.ckSalas_CheckedChanged);
            // 
            // boxSalasMA
            // 
            this.boxSalasMA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxSalasMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasMA.FormattingEnabled = true;
            this.boxSalasMA.Location = new System.Drawing.Point(99, 124);
            this.boxSalasMA.Name = "boxSalasMA";
            this.boxSalasMA.Size = new System.Drawing.Size(209, 21);
            this.boxSalasMA.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Location = new System.Drawing.Point(767, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnLimpiar);
            this.groupBox4.Controls.Add(this.btnFiltrar);
            this.groupBox4.Controls.Add(this.boxCategoria);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(527, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 160);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar por Rubro";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(133, 90);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 46);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.Location = new System.Drawing.Point(6, 90);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 46);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click_1);
            // 
            // btnDescargar
            // 
            this.btnDescargar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargar.Location = new System.Drawing.Point(1218, 641);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(107, 47);
            this.btnDescargar.TabIndex = 16;
            this.btnDescargar.Text = "Descargar Excel";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnQR
            // 
            this.btnQR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQR.Location = new System.Drawing.Point(150, 641);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(107, 47);
            this.btnQR.TabIndex = 17;
            this.btnQR.Text = "Descargar QR";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalas.Location = new System.Drawing.Point(1086, 641);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(107, 47);
            this.btnSalas.TabIndex = 18;
            this.btnSalas.Text = "Alterar";
            this.btnSalas.UseVisualStyleBackColor = true;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // boxABF
            // 
            this.boxABF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxABF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxABF.FormattingEnabled = true;
            this.boxABF.Items.AddRange(new object[] {
            "ALTA",
            "BAJA",
            "FUNGIBLE",
            "TODO"});
            this.boxABF.Location = new System.Drawing.Point(1147, 147);
            this.boxABF.Name = "boxABF";
            this.boxABF.Size = new System.Drawing.Size(209, 21);
            this.boxABF.TabIndex = 14;
            this.boxABF.SelectedIndexChanged += new System.EventHandler(this.boxABF_SelectedIndexChanged);
            // 
            // LABF
            // 
            this.LABF.AutoSize = true;
            this.LABF.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABF.Location = new System.Drawing.Point(936, 149);
            this.LABF.Name = "LABF";
            this.LABF.Size = new System.Drawing.Size(204, 16);
            this.LABF.TabIndex = 19;
            this.LABF.Text = "Seleccionar Altas, Bajas o Fungibles:";
            // 
            // dataInventario
            // 
            this.dataInventario.AllowUserToAddRows = false;
            this.dataInventario.AllowUserToDeleteRows = false;
            this.dataInventario.AllowUserToResizeColumns = false;
            this.dataInventario.AllowUserToResizeRows = false;
            this.dataInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataInventario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInventario.Location = new System.Drawing.Point(10, 3);
            this.dataInventario.Name = "dataInventario";
            this.dataInventario.ReadOnly = true;
            this.dataInventario.RowHeadersVisible = false;
            this.dataInventario.Size = new System.Drawing.Size(1345, 443);
            this.dataInventario.TabIndex = 0;
            // 
            // PLdata
            // 
            this.PLdata.Controls.Add(this.dataInventario);
            this.PLdata.Location = new System.Drawing.Point(2, 178);
            this.PLdata.Name = "PLdata";
            this.PLdata.Size = new System.Drawing.Size(1364, 457);
            this.PLdata.TabIndex = 20;
            // 
            // PLsalas
            // 
            this.PLsalas.Controls.Add(this.groupBox5);
            this.PLsalas.Controls.Add(this.groupBox3);
            this.PLsalas.Controls.Add(this.label5);
            this.PLsalas.Location = new System.Drawing.Point(13, 178);
            this.PLsalas.Name = "PLsalas";
            this.PLsalas.Size = new System.Drawing.Size(1344, 454);
            this.PLsalas.TabIndex = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnESala);
            this.groupBox5.Controls.Add(this.txtNSala2);
            this.groupBox5.Controls.Add(this.boxAlugarSala2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(675, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(661, 387);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar Sala";
            // 
            // btnESala
            // 
            this.btnESala.Location = new System.Drawing.Point(274, 233);
            this.btnESala.Name = "btnESala";
            this.btnESala.Size = new System.Drawing.Size(150, 46);
            this.btnESala.TabIndex = 5;
            this.btnESala.Text = "Eliminar";
            this.btnESala.UseVisualStyleBackColor = true;
            this.btnESala.Click += new System.EventHandler(this.btnESala_Click);
            // 
            // txtNSala2
            // 
            this.txtNSala2.Location = new System.Drawing.Point(129, 156);
            this.txtNSala2.Name = "txtNSala2";
            this.txtNSala2.Size = new System.Drawing.Size(426, 20);
            this.txtNSala2.TabIndex = 4;
            this.txtNSala2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNSala2_KeyPress);
            // 
            // boxAlugarSala2
            // 
            this.boxAlugarSala2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAlugarSala2.FormattingEnabled = true;
            this.boxAlugarSala2.Items.AddRange(new object[] {
            "Taller_de_Mecanica_Automotriz",
            "Taller_de_Construcciones_Metalicas",
            "Taller_de_Electricidad",
            "Taller_de_Mecanica_Industrial",
            "Taller_de_Terminaciones_de_la_Construccion",
            "Aulas",
            "Oficinas",
            "Internado"});
            this.boxAlugarSala2.Location = new System.Drawing.Point(129, 84);
            this.boxAlugarSala2.Name = "boxAlugarSala2";
            this.boxAlugarSala2.Size = new System.Drawing.Size(426, 21);
            this.boxAlugarSala2.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lugar:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnASala);
            this.groupBox3.Controls.Add(this.txtNSala);
            this.groupBox3.Controls.Add(this.boxAlugarSalas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(8, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 387);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Añadir Sala";
            // 
            // btnASala
            // 
            this.btnASala.Location = new System.Drawing.Point(255, 233);
            this.btnASala.Name = "btnASala";
            this.btnASala.Size = new System.Drawing.Size(150, 46);
            this.btnASala.TabIndex = 4;
            this.btnASala.Text = "Añadir";
            this.btnASala.UseVisualStyleBackColor = true;
            this.btnASala.Click += new System.EventHandler(this.btnASala_Click);
            // 
            // txtNSala
            // 
            this.txtNSala.Location = new System.Drawing.Point(129, 156);
            this.txtNSala.Name = "txtNSala";
            this.txtNSala.Size = new System.Drawing.Size(426, 20);
            this.txtNSala.TabIndex = 3;
            this.txtNSala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNSala_KeyPress);
            // 
            // boxAlugarSalas
            // 
            this.boxAlugarSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAlugarSalas.FormattingEnabled = true;
            this.boxAlugarSalas.Items.AddRange(new object[] {
            "Taller_de_Mecanica_Automotriz",
            "Taller_de_Construcciones_Metalicas",
            "Taller_de_Electricidad",
            "Taller_de_Mecanica_Industrial",
            "Taller_de_Terminaciones_de_la_Construccion",
            "Aulas",
            "Oficinas",
            "Internado"});
            this.boxAlugarSalas.Location = new System.Drawing.Point(129, 82);
            this.boxAlugarSalas.Name = "boxAlugarSalas";
            this.boxAlugarSalas.Size = new System.Drawing.Size(426, 21);
            this.boxAlugarSalas.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lugar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Alterar Salas";
            // 
            // btnVolverD
            // 
            this.btnVolverD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolverD.Location = new System.Drawing.Point(631, 641);
            this.btnVolverD.Name = "btnVolverD";
            this.btnVolverD.Size = new System.Drawing.Size(107, 47);
            this.btnVolverD.TabIndex = 22;
            this.btnVolverD.Text = "Volver";
            this.btnVolverD.UseVisualStyleBackColor = true;
            this.btnVolverD.Click += new System.EventHandler(this.btnVolverD_Click);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(787, 667);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(271, 20);
            this.txtResponsable.TabIndex = 23;
            // 
            // tR
            // 
            this.tR.AutoSize = true;
            this.tR.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tR.Location = new System.Drawing.Point(874, 644);
            this.tR.Name = "tR";
            this.tR.Size = new System.Drawing.Size(89, 20);
            this.tR.TabIndex = 24;
            this.tR.Text = "Responsable";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1368, 712);
            this.ControlBox = false;
            this.Controls.Add(this.tR);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.btnVolverD);
            this.Controls.Add(this.PLsalas);
            this.Controls.Add(this.PLdata);
            this.Controls.Add(this.LABF);
            this.Controls.Add(this.boxABF);
            this.Controls.Add(this.btnSalas);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInventario)).EndInit();
            this.PLdata.ResumeLayout(false);
            this.PLsalas.ResumeLayout(false);
            this.PLsalas.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxSectores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxDepartamentos;
        private System.Windows.Forms.ComboBox boxCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver2;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox ckSalas;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.ComboBox boxSalasMA;
        private System.Windows.Forms.ComboBox boxABF;
        private System.Windows.Forms.Label LABF;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.ComboBox boxLugarSalas;
        private System.Windows.Forms.ComboBox boxSalasMI;
        private System.Windows.Forms.ComboBox boxSalasE;
        private System.Windows.Forms.ComboBox boxSalasCM;
        private System.Windows.Forms.ComboBox boxSalas;
        private System.Windows.Forms.ComboBox boxSalasTC;
        private System.Windows.Forms.DataGridView dataInventario;
        private System.Windows.Forms.Panel PLdata;
        private System.Windows.Forms.Panel PLsalas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnESala;
        private System.Windows.Forms.TextBox txtNSala2;
        private System.Windows.Forms.ComboBox boxAlugarSala2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnASala;
        private System.Windows.Forms.TextBox txtNSala;
        private System.Windows.Forms.ComboBox boxAlugarSalas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVolverD;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label tR;
        private System.Windows.Forms.ComboBox boxAulas;
        private System.Windows.Forms.ComboBox boxOficinas;
        private System.Windows.Forms.ComboBox boxInternado;
    }
}