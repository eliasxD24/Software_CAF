
namespace InventarioLI
{
    partial class RecuperarContra
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRcorreo = new System.Windows.Forms.TextBox();
            this.btnEnviarC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar Contraseña";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(23, 374);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 49);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Introduzca el correo por el cual quiere recuperar la contraseña";
            // 
            // txtRcorreo
            // 
            this.txtRcorreo.Location = new System.Drawing.Point(207, 199);
            this.txtRcorreo.Name = "txtRcorreo";
            this.txtRcorreo.Size = new System.Drawing.Size(359, 20);
            this.txtRcorreo.TabIndex = 3;
            // 
            // btnEnviarC
            // 
            this.btnEnviarC.Location = new System.Drawing.Point(335, 236);
            this.btnEnviarC.Name = "btnEnviarC";
            this.btnEnviarC.Size = new System.Drawing.Size(127, 49);
            this.btnEnviarC.TabIndex = 4;
            this.btnEnviarC.Text = "Enviar";
            this.btnEnviarC.UseVisualStyleBackColor = true;
            this.btnEnviarC.Click += new System.EventHandler(this.btnEnviarC_Click);
            // 
            // RecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnEnviarC);
            this.Controls.Add(this.txtRcorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "RecuperarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRcorreo;
        private System.Windows.Forms.Button btnEnviarC;
    }
}