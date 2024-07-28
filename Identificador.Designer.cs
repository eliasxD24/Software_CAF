
namespace InventarioLI
{
    partial class Identificador
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataIdentificadores = new System.Windows.Forms.DataGridView();
            this.boxSectores = new System.Windows.Forms.ComboBox();
            this.boxLugar = new System.Windows.Forms.ComboBox();
            this.boxSalasLujo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tSalas = new System.Windows.Forms.Label();
            this.ckSalas = new System.Windows.Forms.CheckBox();
            this.boxTallerSalas = new System.Windows.Forms.ComboBox();
            this.boxSalasTC = new System.Windows.Forms.ComboBox();
            this.boxSalasMI = new System.Windows.Forms.ComboBox();
            this.boxSalasMA = new System.Windows.Forms.ComboBox();
            this.boxSalasCM = new System.Windows.Forms.ComboBox();
            this.boxSalasE = new System.Windows.Forms.ComboBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tbuscar = new System.Windows.Forms.Label();
            this.boxAulas = new System.Windows.Forms.ComboBox();
            this.boxOficinas = new System.Windows.Forms.ComboBox();
            this.tBuscarS = new System.Windows.Forms.Label();
            this.boxInternado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataIdentificadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 639);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 46);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificadores";
            // 
            // dataIdentificadores
            // 
            this.dataIdentificadores.AllowUserToAddRows = false;
            this.dataIdentificadores.AllowUserToDeleteRows = false;
            this.dataIdentificadores.AllowUserToResizeColumns = false;
            this.dataIdentificadores.AllowUserToResizeRows = false;
            this.dataIdentificadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataIdentificadores.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataIdentificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIdentificadores.Location = new System.Drawing.Point(2, 209);
            this.dataIdentificadores.Name = "dataIdentificadores";
            this.dataIdentificadores.ReadOnly = true;
            this.dataIdentificadores.RowHeadersVisible = false;
            this.dataIdentificadores.Size = new System.Drawing.Size(697, 413);
            this.dataIdentificadores.TabIndex = 2;
            this.dataIdentificadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataIdentificadores_CellContentClick);
            // 
            // boxSectores
            // 
            this.boxSectores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSectores.FormattingEnabled = true;
            this.boxSectores.Items.AddRange(new object[] {
            "Inventario General",
            "Materiales de Escritorio",
            "Materiales de Aseo"});
            this.boxSectores.Location = new System.Drawing.Point(43, 93);
            this.boxSectores.Name = "boxSectores";
            this.boxSectores.Size = new System.Drawing.Size(173, 21);
            this.boxSectores.TabIndex = 3;
            this.boxSectores.SelectedIndexChanged += new System.EventHandler(this.boxSectores_SelectedIndexChanged);
            // 
            // boxLugar
            // 
            this.boxLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLugar.FormattingEnabled = true;
            this.boxLugar.Location = new System.Drawing.Point(461, 93);
            this.boxLugar.Name = "boxLugar";
            this.boxLugar.Size = new System.Drawing.Size(173, 21);
            this.boxLugar.TabIndex = 4;
            this.boxLugar.SelectedIndexChanged += new System.EventHandler(this.boxLugar_SelectedIndexChanged);
            // 
            // boxSalasLujo
            // 
            this.boxSalasLujo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasLujo.FormattingEnabled = true;
            this.boxSalasLujo.Location = new System.Drawing.Point(249, 148);
            this.boxSalasLujo.Name = "boxSalasLujo";
            this.boxSalasLujo.Size = new System.Drawing.Size(173, 21);
            this.boxSalasLujo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sectores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lugar";
            // 
            // tSalas
            // 
            this.tSalas.AutoSize = true;
            this.tSalas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSalas.Location = new System.Drawing.Point(313, 126);
            this.tSalas.Name = "tSalas";
            this.tSalas.Size = new System.Drawing.Size(43, 20);
            this.tSalas.TabIndex = 8;
            this.tSalas.Text = "Salas";
            // 
            // ckSalas
            // 
            this.ckSalas.AutoSize = true;
            this.ckSalas.Location = new System.Drawing.Point(526, 148);
            this.ckSalas.Name = "ckSalas";
            this.ckSalas.Size = new System.Drawing.Size(71, 17);
            this.ckSalas.TabIndex = 9;
            this.ckSalas.Text = "Ver Salas";
            this.ckSalas.UseVisualStyleBackColor = true;
            this.ckSalas.CheckedChanged += new System.EventHandler(this.ckSalas_CheckedChanged);
            // 
            // boxTallerSalas
            // 
            this.boxTallerSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTallerSalas.FormattingEnabled = true;
            this.boxTallerSalas.Items.AddRange(new object[] {
            "Taller_de_Mecanica_Automotriz",
            "Taller_de_Construcciones_Metalicas",
            "Taller_de_Electricidad",
            "Taller_de_Mecanica_Industrial",
            "Taller_de_Terminaciones_de_la_Construccion"});
            this.boxTallerSalas.Location = new System.Drawing.Point(461, 93);
            this.boxTallerSalas.Name = "boxTallerSalas";
            this.boxTallerSalas.Size = new System.Drawing.Size(173, 21);
            this.boxTallerSalas.TabIndex = 10;
            this.boxTallerSalas.SelectedIndexChanged += new System.EventHandler(this.boxTallerSalas_SelectedIndexChanged);
            // 
            // boxSalasTC
            // 
            this.boxSalasTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasTC.FormattingEnabled = true;
            this.boxSalasTC.Location = new System.Drawing.Point(249, 148);
            this.boxSalasTC.Name = "boxSalasTC";
            this.boxSalasTC.Size = new System.Drawing.Size(173, 21);
            this.boxSalasTC.TabIndex = 11;
            // 
            // boxSalasMI
            // 
            this.boxSalasMI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasMI.FormattingEnabled = true;
            this.boxSalasMI.Location = new System.Drawing.Point(249, 148);
            this.boxSalasMI.Name = "boxSalasMI";
            this.boxSalasMI.Size = new System.Drawing.Size(173, 21);
            this.boxSalasMI.TabIndex = 12;
            // 
            // boxSalasMA
            // 
            this.boxSalasMA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasMA.FormattingEnabled = true;
            this.boxSalasMA.Location = new System.Drawing.Point(249, 148);
            this.boxSalasMA.Name = "boxSalasMA";
            this.boxSalasMA.Size = new System.Drawing.Size(173, 21);
            this.boxSalasMA.TabIndex = 13;
            // 
            // boxSalasCM
            // 
            this.boxSalasCM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasCM.FormattingEnabled = true;
            this.boxSalasCM.Location = new System.Drawing.Point(249, 148);
            this.boxSalasCM.Name = "boxSalasCM";
            this.boxSalasCM.Size = new System.Drawing.Size(173, 21);
            this.boxSalasCM.TabIndex = 14;
            // 
            // boxSalasE
            // 
            this.boxSalasE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxSalasE.FormattingEnabled = true;
            this.boxSalasE.Location = new System.Drawing.Point(249, 148);
            this.boxSalasE.Name = "boxSalasE";
            this.boxSalasE.Size = new System.Drawing.Size(173, 21);
            this.boxSalasE.TabIndex = 15;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(587, 639);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(103, 46);
            this.btnVer.TabIndex = 16;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(350, 653);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tbuscar
            // 
            this.tbuscar.AutoSize = true;
            this.tbuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuscar.Location = new System.Drawing.Point(231, 653);
            this.tbuscar.Name = "tbuscar";
            this.tbuscar.Size = new System.Drawing.Size(113, 20);
            this.tbuscar.TabIndex = 18;
            this.tbuscar.Text = "Buscar NºActual:";
            // 
            // boxAulas
            // 
            this.boxAulas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAulas.FormattingEnabled = true;
            this.boxAulas.Location = new System.Drawing.Point(249, 148);
            this.boxAulas.Name = "boxAulas";
            this.boxAulas.Size = new System.Drawing.Size(173, 21);
            this.boxAulas.TabIndex = 19;
            // 
            // boxOficinas
            // 
            this.boxOficinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxOficinas.FormattingEnabled = true;
            this.boxOficinas.Location = new System.Drawing.Point(249, 148);
            this.boxOficinas.Name = "boxOficinas";
            this.boxOficinas.Size = new System.Drawing.Size(173, 21);
            this.boxOficinas.TabIndex = 20;
            // 
            // tBuscarS
            // 
            this.tBuscarS.AutoSize = true;
            this.tBuscarS.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBuscarS.Location = new System.Drawing.Point(226, 651);
            this.tBuscarS.Name = "tBuscarS";
            this.tBuscarS.Size = new System.Drawing.Size(118, 20);
            this.tBuscarS.TabIndex = 21;
            this.tBuscarS.Text = "Buscar NºInterno:";
            // 
            // boxInternado
            // 
            this.boxInternado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxInternado.FormattingEnabled = true;
            this.boxInternado.Location = new System.Drawing.Point(249, 148);
            this.boxInternado.Name = "boxInternado";
            this.boxInternado.Size = new System.Drawing.Size(173, 21);
            this.boxInternado.TabIndex = 22;
            // 
            // Identificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 697);
            this.ControlBox = false;
            this.Controls.Add(this.boxInternado);
            this.Controls.Add(this.tBuscarS);
            this.Controls.Add(this.boxOficinas);
            this.Controls.Add(this.boxAulas);
            this.Controls.Add(this.tbuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.boxSalasE);
            this.Controls.Add(this.boxSalasCM);
            this.Controls.Add(this.boxSalasMA);
            this.Controls.Add(this.boxSalasMI);
            this.Controls.Add(this.boxSalasTC);
            this.Controls.Add(this.boxTallerSalas);
            this.Controls.Add(this.ckSalas);
            this.Controls.Add(this.tSalas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxSalasLujo);
            this.Controls.Add(this.boxLugar);
            this.Controls.Add(this.boxSectores);
            this.Controls.Add(this.dataIdentificadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Name = "Identificador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificador";
            this.Load += new System.EventHandler(this.Identificador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataIdentificadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataIdentificadores;
        private System.Windows.Forms.ComboBox boxSectores;
        private System.Windows.Forms.ComboBox boxLugar;
        private System.Windows.Forms.ComboBox boxSalasLujo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tSalas;
        private System.Windows.Forms.CheckBox ckSalas;
        private System.Windows.Forms.ComboBox boxTallerSalas;
        private System.Windows.Forms.ComboBox boxSalasTC;
        private System.Windows.Forms.ComboBox boxSalasMI;
        private System.Windows.Forms.ComboBox boxSalasMA;
        private System.Windows.Forms.ComboBox boxSalasCM;
        private System.Windows.Forms.ComboBox boxSalasE;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label tbuscar;
        private System.Windows.Forms.ComboBox boxAulas;
        private System.Windows.Forms.ComboBox boxOficinas;
        private System.Windows.Forms.Label tBuscarS;
        private System.Windows.Forms.ComboBox boxInternado;
    }
}