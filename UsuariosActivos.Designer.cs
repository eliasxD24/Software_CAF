
namespace InventarioLI
{
    partial class UsuariosActivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosActivos));
            this.label1 = new System.Windows.Forms.Label();
            this.dataUsuariosAc = new System.Windows.Forms.DataGridView();
            this.btnVolver8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuariosAc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios Activos";
            // 
            // dataUsuariosAc
            // 
            this.dataUsuariosAc.AllowUserToAddRows = false;
            this.dataUsuariosAc.AllowUserToDeleteRows = false;
            this.dataUsuariosAc.AllowUserToResizeColumns = false;
            this.dataUsuariosAc.AllowUserToResizeRows = false;
            this.dataUsuariosAc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataUsuariosAc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUsuariosAc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataUsuariosAc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataUsuariosAc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataUsuariosAc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUsuariosAc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUsuariosAc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataUsuariosAc.Location = new System.Drawing.Point(1, 106);
            this.dataUsuariosAc.Name = "dataUsuariosAc";
            this.dataUsuariosAc.ReadOnly = true;
            this.dataUsuariosAc.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataUsuariosAc.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataUsuariosAc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataUsuariosAc.Size = new System.Drawing.Size(574, 520);
            this.dataUsuariosAc.TabIndex = 1;
            // 
            // btnVolver8
            // 
            this.btnVolver8.Location = new System.Drawing.Point(12, 638);
            this.btnVolver8.Name = "btnVolver8";
            this.btnVolver8.Size = new System.Drawing.Size(96, 43);
            this.btnVolver8.TabIndex = 2;
            this.btnVolver8.Text = "Volver";
            this.btnVolver8.UseVisualStyleBackColor = true;
            this.btnVolver8.Click += new System.EventHandler(this.btnVolver8_Click);
            // 
            // UsuariosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 693);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver8);
            this.Controls.Add(this.dataUsuariosAc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuariosActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuariosActivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UsuariosActivos_FormClosing);
            this.Load += new System.EventHandler(this.UsuariosActivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuariosAc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataUsuariosAc;
        private System.Windows.Forms.Button btnVolver8;
    }
}