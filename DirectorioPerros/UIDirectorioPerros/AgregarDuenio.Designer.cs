namespace UIDirectorioPerros
{
    partial class AgregarDuenio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAgregarDuenio = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCelular = new System.Windows.Forms.TextBox();
            this.buttonAgregarDuenio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAgregarDuenio
            // 
            this.labelAgregarDuenio.AutoSize = true;
            this.labelAgregarDuenio.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarDuenio.Location = new System.Drawing.Point(442, 45);
            this.labelAgregarDuenio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAgregarDuenio.Name = "labelAgregarDuenio";
            this.labelAgregarDuenio.Size = new System.Drawing.Size(178, 33);
            this.labelAgregarDuenio.TabIndex = 0;
            this.labelAgregarDuenio.Text = "Agregar Dueño";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(217, 164);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(81, 25);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Location = new System.Drawing.Point(217, 237);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(74, 25);
            this.labelCelular.TabIndex = 2;
            this.labelCelular.Text = "Celular";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(448, 164);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(172, 30);
            this.textNombre.TabIndex = 3;
            // 
            // textCelular
            // 
            this.textCelular.Location = new System.Drawing.Point(448, 237);
            this.textCelular.Name = "textCelular";
            this.textCelular.Size = new System.Drawing.Size(172, 30);
            this.textCelular.TabIndex = 4;
            // 
            // buttonAgregarDuenio
            // 
            this.buttonAgregarDuenio.Location = new System.Drawing.Point(619, 388);
            this.buttonAgregarDuenio.Name = "buttonAgregarDuenio";
            this.buttonAgregarDuenio.Size = new System.Drawing.Size(113, 54);
            this.buttonAgregarDuenio.TabIndex = 5;
            this.buttonAgregarDuenio.Text = "Agregar";
            this.buttonAgregarDuenio.UseVisualStyleBackColor = true;
            this.buttonAgregarDuenio.Click += new System.EventHandler(this.buttonAgregarDuenio_Click);
            // 
            // AgregarDuenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAgregarDuenio);
            this.Controls.Add(this.textCelular);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelAgregarDuenio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AgregarDuenio";
            this.Size = new System.Drawing.Size(1111, 566);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgregarDuenio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCelular;
        private System.Windows.Forms.Button buttonAgregarDuenio;
    }
}
