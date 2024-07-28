
namespace InventarioLI
{
    partial class Historial
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
            this.label1 = new System.Windows.Forms.Label();
            this.bntVolver9 = new System.Windows.Forms.Button();
            this.dataHistorial = new System.Windows.Forms.DataGridView();
            this.boxFiltrarAME = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            // 
            // bntVolver9
            // 
            this.bntVolver9.Location = new System.Drawing.Point(29, 640);
            this.bntVolver9.Name = "bntVolver9";
            this.bntVolver9.Size = new System.Drawing.Size(110, 48);
            this.bntVolver9.TabIndex = 1;
            this.bntVolver9.Text = "Volver";
            this.bntVolver9.UseVisualStyleBackColor = true;
            this.bntVolver9.Click += new System.EventHandler(this.bntVolver9_Click);
            // 
            // dataHistorial
            // 
            this.dataHistorial.AllowUserToAddRows = false;
            this.dataHistorial.AllowUserToDeleteRows = false;
            this.dataHistorial.AllowUserToResizeColumns = false;
            this.dataHistorial.AllowUserToResizeRows = false;
            this.dataHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHistorial.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistorial.Location = new System.Drawing.Point(3, 74);
            this.dataHistorial.Name = "dataHistorial";
            this.dataHistorial.ReadOnly = true;
            this.dataHistorial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataHistorial.RowHeadersVisible = false;
            this.dataHistorial.Size = new System.Drawing.Size(1178, 549);
            this.dataHistorial.TabIndex = 2;
            this.dataHistorial.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataHistorial_CellFormatting);
            // 
            // boxFiltrarAME
            // 
            this.boxFiltrarAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFiltrarAME.FormattingEnabled = true;
            this.boxFiltrarAME.Items.AddRange(new object[] {
            "Agregado",
            "Modificado",
            "Eliminado",
            "Todo"});
            this.boxFiltrarAME.Location = new System.Drawing.Point(1052, 655);
            this.boxFiltrarAME.Name = "boxFiltrarAME";
            this.boxFiltrarAME.Size = new System.Drawing.Size(121, 21);
            this.boxFiltrarAME.TabIndex = 3;
            this.boxFiltrarAME.SelectedIndexChanged += new System.EventHandler(this.boxFiltrarAME_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(996, 656);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(523, 640);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 48);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar Historial";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 714);
            this.ControlBox = false;
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxFiltrarAME);
            this.Controls.Add(this.dataHistorial);
            this.Controls.Add(this.bntVolver9);
            this.Controls.Add(this.label1);
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntVolver9;
        private System.Windows.Forms.DataGridView dataHistorial;
        private System.Windows.Forms.ComboBox boxFiltrarAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrar;
    }
}