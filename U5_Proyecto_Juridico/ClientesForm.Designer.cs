namespace U5_Proyecto_Juridico
{
    partial class ClientesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_idCliente = new System.Windows.Forms.Label();
            this.tbx_idCliente = new System.Windows.Forms.TextBox();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tbx_Apellido = new System.Windows.Forms.TextBox();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.dtg_Clientes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.tbx_tipoCaso = new System.Windows.Forms.TextBox();
            this.lbl_tipoCaso = new System.Windows.Forms.Label();
            this.tbx_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbx_tipoCaso);
            this.panel1.Controls.Add(this.lbl_tipoCaso);
            this.panel1.Controls.Add(this.tbx_Telefono);
            this.panel1.Controls.Add(this.lbl_Telefono);
            this.panel1.Controls.Add(this.lbl_idCliente);
            this.panel1.Controls.Add(this.tbx_idCliente);
            this.panel1.Controls.Add(this.tbx_Email);
            this.panel1.Controls.Add(this.lbl_Email);
            this.panel1.Controls.Add(this.tbx_Apellido);
            this.panel1.Controls.Add(this.tbx_Nombre);
            this.panel1.Controls.Add(this.lbl_Apellido);
            this.panel1.Controls.Add(this.lbl_Nombre);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 162);
            this.panel1.TabIndex = 6;
            // 
            // lbl_idCliente
            // 
            this.lbl_idCliente.AutoSize = true;
            this.lbl_idCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idCliente.Location = new System.Drawing.Point(26, 11);
            this.lbl_idCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_idCliente.Name = "lbl_idCliente";
            this.lbl_idCliente.Size = new System.Drawing.Size(66, 20);
            this.lbl_idCliente.TabIndex = 16;
            this.lbl_idCliente.Text = "ID Cliente";
            // 
            // tbx_idCliente
            // 
            this.tbx_idCliente.Location = new System.Drawing.Point(152, 13);
            this.tbx_idCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_idCliente.Name = "tbx_idCliente";
            this.tbx_idCliente.Size = new System.Drawing.Size(158, 20);
            this.tbx_idCliente.TabIndex = 14;
            // 
            // tbx_Email
            // 
            this.tbx_Email.Location = new System.Drawing.Point(152, 124);
            this.tbx_Email.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(158, 20);
            this.tbx_Email.TabIndex = 12;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(26, 124);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(42, 20);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email";
            // 
            // tbx_Apellido
            // 
            this.tbx_Apellido.Location = new System.Drawing.Point(152, 85);
            this.tbx_Apellido.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Apellido.Name = "tbx_Apellido";
            this.tbx_Apellido.Size = new System.Drawing.Size(158, 20);
            this.tbx_Apellido.TabIndex = 10;
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Location = new System.Drawing.Point(152, 50);
            this.tbx_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(158, 20);
            this.tbx_Nombre.TabIndex = 9;
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(26, 85);
            this.lbl_Apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(59, 20);
            this.lbl_Apellido.TabIndex = 8;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(26, 49);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(57, 20);
            this.lbl_Nombre.TabIndex = 7;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // dtg_Clientes
            // 
            this.dtg_Clientes.AllowUserToAddRows = false;
            this.dtg_Clientes.AllowUserToDeleteRows = false;
            this.dtg_Clientes.AllowUserToResizeColumns = false;
            this.dtg_Clientes.AllowUserToResizeRows = false;
            this.dtg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Clientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_Clientes.Location = new System.Drawing.Point(0, 264);
            this.dtg_Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.dtg_Clientes.Name = "dtg_Clientes";
            this.dtg_Clientes.RowHeadersWidth = 51;
            this.dtg_Clientes.RowTemplate.Height = 24;
            this.dtg_Clientes.Size = new System.Drawing.Size(652, 230);
            this.dtg_Clientes.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Eliminar);
            this.panel2.Controls.Add(this.btn_Modificar);
            this.panel2.Controls.Add(this.btn_Salir);
            this.panel2.Controls.Add(this.btn_Agregar);
            this.panel2.Location = new System.Drawing.Point(1, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 91);
            this.panel2.TabIndex = 4;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(210, 29);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(56, 26);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(113, 29);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(65, 26);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(323, 29);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(56, 26);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(28, 29);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(56, 26);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // tbx_tipoCaso
            // 
            this.tbx_tipoCaso.Location = new System.Drawing.Point(466, 52);
            this.tbx_tipoCaso.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_tipoCaso.Name = "tbx_tipoCaso";
            this.tbx_tipoCaso.Size = new System.Drawing.Size(158, 20);
            this.tbx_tipoCaso.TabIndex = 20;
            // 
            // lbl_tipoCaso
            // 
            this.lbl_tipoCaso.AutoSize = true;
            this.lbl_tipoCaso.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoCaso.Location = new System.Drawing.Point(340, 52);
            this.lbl_tipoCaso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipoCaso.Name = "lbl_tipoCaso";
            this.lbl_tipoCaso.Size = new System.Drawing.Size(70, 20);
            this.lbl_tipoCaso.TabIndex = 19;
            this.lbl_tipoCaso.Text = "Tipo Caso";
            // 
            // tbx_Telefono
            // 
            this.tbx_Telefono.Location = new System.Drawing.Point(466, 13);
            this.tbx_Telefono.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_Telefono.Name = "tbx_Telefono";
            this.tbx_Telefono.Size = new System.Drawing.Size(158, 20);
            this.tbx_Telefono.TabIndex = 18;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(340, 13);
            this.lbl_Telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(61, 20);
            this.lbl_Telefono.TabIndex = 17;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtg_Clientes);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_idCliente;
        private System.Windows.Forms.TextBox tbx_idCliente;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tbx_Apellido;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.DataGridView dtg_Clientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox tbx_tipoCaso;
        private System.Windows.Forms.Label lbl_tipoCaso;
        private System.Windows.Forms.TextBox tbx_Telefono;
        private System.Windows.Forms.Label lbl_Telefono;
    }
}