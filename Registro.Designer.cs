
namespace InventarioLI
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label2 = new System.Windows.Forms.Label();
            this.frmUsuario = new System.Windows.Forms.TextBox();
            this.frmContraseña = new System.Windows.Forms.TextBox();
            this.frmContraseñaR = new System.Windows.Forms.TextBox();
            this.frmNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVolver1 = new System.Windows.Forms.Button();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.frmCorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registrarse";
            // 
            // frmUsuario
            // 
            this.frmUsuario.Location = new System.Drawing.Point(82, 150);
            this.frmUsuario.Name = "frmUsuario";
            this.frmUsuario.Size = new System.Drawing.Size(186, 20);
            this.frmUsuario.TabIndex = 3;
            // 
            // frmContraseña
            // 
            this.frmContraseña.Location = new System.Drawing.Point(483, 151);
            this.frmContraseña.Name = "frmContraseña";
            this.frmContraseña.PasswordChar = '*';
            this.frmContraseña.Size = new System.Drawing.Size(186, 20);
            this.frmContraseña.TabIndex = 4;
            // 
            // frmContraseñaR
            // 
            this.frmContraseñaR.Location = new System.Drawing.Point(483, 207);
            this.frmContraseñaR.Name = "frmContraseñaR";
            this.frmContraseñaR.PasswordChar = '*';
            this.frmContraseñaR.Size = new System.Drawing.Size(186, 20);
            this.frmContraseñaR.TabIndex = 5;
            // 
            // frmNombre
            // 
            this.frmNombre.Location = new System.Drawing.Point(82, 207);
            this.frmNombre.Name = "frmNombre";
            this.frmNombre.Size = new System.Drawing.Size(186, 20);
            this.frmNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmar Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(290, 411);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 47);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVolver1
            // 
            this.btnVolver1.Location = new System.Drawing.Point(40, 478);
            this.btnVolver1.Name = "btnVolver1";
            this.btnVolver1.Size = new System.Drawing.Size(106, 50);
            this.btnVolver1.TabIndex = 12;
            this.btnVolver1.Text = "Volver";
            this.btnVolver1.UseVisualStyleBackColor = true;
            this.btnVolver1.Click += new System.EventHandler(this.btnVolver1_Click);
            // 
            // boxTipo
            // 
            this.boxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.boxTipo.Location = new System.Drawing.Point(483, 259);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(186, 21);
            this.boxTipo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Correo:";
            // 
            // frmCorreo
            // 
            this.frmCorreo.Location = new System.Drawing.Point(82, 260);
            this.frmCorreo.Name = "frmCorreo";
            this.frmCorreo.Size = new System.Drawing.Size(186, 20);
            this.frmCorreo.TabIndex = 16;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(697, 551);
            this.ControlBox = false;
            this.Controls.Add(this.frmCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxTipo);
            this.Controls.Add(this.btnVolver1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmNombre);
            this.Controls.Add(this.frmContraseñaR);
            this.Controls.Add(this.frmContraseña);
            this.Controls.Add(this.frmUsuario);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox frmUsuario;
        private System.Windows.Forms.TextBox frmContraseña;
        private System.Windows.Forms.TextBox frmContraseñaR;
        private System.Windows.Forms.TextBox frmNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver1;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox frmCorreo;
    }
}