namespace U5_Proyecto_Juridico
{
    partial class FormularioInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientesButton = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientesButton
            // 
            this.ClientesButton.Location = new System.Drawing.Point(199, 295);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(118, 40);
            this.ClientesButton.TabIndex = 6;
            this.ClientesButton.Text = "Clientes Juridico";
            this.ClientesButton.UseVisualStyleBackColor = true;
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(69, 54);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(358, 175);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Proyecto U5 Base de Datos Juridico\r\n\r\nIntegrantes:\r\nApaéz Acuña Ángel Antonio\r\nCo" +
    "rral Ceballos Samuel Eberaldo\r\nDiaz Sonoqui Ivan Gilberto\r\nMonge Alonso Katia Li" +
    "lian";
            // 
            // FormularioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 393);
            this.Controls.Add(this.ClientesButton);
            this.Controls.Add(this.Titulo);
            this.Name = "FormularioInicio";
            this.Text = "FormularioInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientesButton;
        private System.Windows.Forms.Label Titulo;
    }
}

