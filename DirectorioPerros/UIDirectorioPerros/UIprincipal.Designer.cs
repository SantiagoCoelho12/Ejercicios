namespace UIDirectorioPerros
{
    partial class UIprincipal
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnAgregarPerro = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAgregarDuenio = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Calibri Light", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(331, 19);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(460, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Bienvenido al directorio de perros";
            // 
            // btnAgregarPerro
            // 
            this.btnAgregarPerro.Location = new System.Drawing.Point(45, 305);
            this.btnAgregarPerro.Name = "btnAgregarPerro";
            this.btnAgregarPerro.Size = new System.Drawing.Size(124, 47);
            this.btnAgregarPerro.TabIndex = 1;
            this.btnAgregarPerro.Text = "Agregar Perro";
            this.btnAgregarPerro.UseVisualStyleBackColor = true;
            this.btnAgregarPerro.Click += new System.EventHandler(this.btnAgregarPerro_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(45, 434);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(124, 47);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAgregarDuenio
            // 
            this.btnAgregarDuenio.Location = new System.Drawing.Point(45, 174);
            this.btnAgregarDuenio.Name = "btnAgregarDuenio";
            this.btnAgregarDuenio.Size = new System.Drawing.Size(124, 47);
            this.btnAgregarDuenio.TabIndex = 3;
            this.btnAgregarDuenio.Text = "Agregar Dueño";
            this.btnAgregarDuenio.UseVisualStyleBackColor = true;
            this.btnAgregarDuenio.Click += new System.EventHandler(this.btnAgregarDuenio_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(338, 174);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1111, 566);
            this.panelPrincipal.TabIndex = 4;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(45, 579);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(124, 41);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // UIprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 761);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnAgregarDuenio);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnAgregarPerro);
            this.Controls.Add(this.labelTitulo);
            this.Name = "UIprincipal";
            this.Text = "Directorios de perros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnAgregarPerro;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAgregarDuenio;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button buttonSalir;
    }
}

