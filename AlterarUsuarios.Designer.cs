
namespace InventarioLI
{
    partial class AlterarUsuarios
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
            this.btnVolver10 = new System.Windows.Forms.Button();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // btnVolver10
            // 
            this.btnVolver10.Location = new System.Drawing.Point(12, 663);
            this.btnVolver10.Name = "btnVolver10";
            this.btnVolver10.Size = new System.Drawing.Size(109, 50);
            this.btnVolver10.TabIndex = 1;
            this.btnVolver10.Text = "Volver";
            this.btnVolver10.UseVisualStyleBackColor = true;
            this.btnVolver10.Click += new System.EventHandler(this.btnVolver10_Click);
            // 
            // dataUsers
            // 
            this.dataUsers.AllowUserToAddRows = false;
            this.dataUsers.AllowUserToDeleteRows = false;
            this.dataUsers.AllowUserToResizeColumns = false;
            this.dataUsers.AllowUserToResizeRows = false;
            this.dataUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Location = new System.Drawing.Point(1, 99);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.ReadOnly = true;
            this.dataUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataUsers.RowHeadersVisible = false;
            this.dataUsers.Size = new System.Drawing.Size(679, 546);
            this.dataUsers.TabIndex = 2;
            this.dataUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUsers_CellContentClick_1);
            // 
            // AlterarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 725);
            this.ControlBox = false;
            this.Controls.Add(this.dataUsers);
            this.Controls.Add(this.btnVolver10);
            this.Controls.Add(this.label1);
            this.Name = "AlterarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarUsuarios";
            this.Load += new System.EventHandler(this.AlterarUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver10;
        private System.Windows.Forms.DataGridView dataUsers;
    }
}