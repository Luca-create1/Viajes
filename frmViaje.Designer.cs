namespace Viajes
{
    partial class frmViaje
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboTransporte = new System.Windows.Forms.ComboBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblTrasnporte = new System.Windows.Forms.Label();
            this.LblDestino = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtDestino = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbtNacional = new System.Windows.Forms.RadioButton();
            this.rbtInternacional = new System.Windows.Forms.RadioButton();
            this.lstViajes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(26, 300);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(399, 300);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(205, 300);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cboTransporte
            // 
            this.cboTransporte.FormattingEnabled = true;
            this.cboTransporte.Location = new System.Drawing.Point(133, 143);
            this.cboTransporte.Name = "cboTransporte";
            this.cboTransporte.Size = new System.Drawing.Size(121, 21);
            this.cboTransporte.TabIndex = 3;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Location = new System.Drawing.Point(58, 67);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo.TabIndex = 4;
            this.LblCodigo.Text = "Codigo";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(58, 242);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 5;
            this.LblFecha.Text = "Fecha";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Location = new System.Drawing.Point(58, 193);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(28, 13);
            this.LblTipo.TabIndex = 6;
            this.LblTipo.Text = "Tipo";
            // 
            // LblTrasnporte
            // 
            this.LblTrasnporte.AutoSize = true;
            this.LblTrasnporte.Location = new System.Drawing.Point(55, 143);
            this.LblTrasnporte.Name = "LblTrasnporte";
            this.LblTrasnporte.Size = new System.Drawing.Size(58, 13);
            this.LblTrasnporte.TabIndex = 7;
            this.LblTrasnporte.Text = "Transporte";
            // 
            // LblDestino
            // 
            this.LblDestino.AutoSize = true;
            this.LblDestino.Location = new System.Drawing.Point(58, 105);
            this.LblDestino.Name = "LblDestino";
            this.LblDestino.Size = new System.Drawing.Size(43, 13);
            this.LblDestino.TabIndex = 8;
            this.LblDestino.Text = "Destino";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(133, 67);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigo.TabIndex = 9;
            // 
            // TxtDestino
            // 
            this.TxtDestino.Location = new System.Drawing.Point(133, 105);
            this.TxtDestino.Name = "TxtDestino";
            this.TxtDestino.Size = new System.Drawing.Size(100, 20);
            this.TxtDestino.TabIndex = 11;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(133, 242);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // rbtNacional
            // 
            this.rbtNacional.AutoSize = true;
            this.rbtNacional.Location = new System.Drawing.Point(133, 193);
            this.rbtNacional.Name = "rbtNacional";
            this.rbtNacional.Size = new System.Drawing.Size(82, 17);
            this.rbtNacional.TabIndex = 13;
            this.rbtNacional.TabStop = true;
            this.rbtNacional.Text = "1 - Nacional";
            this.rbtNacional.UseVisualStyleBackColor = true;
            // 
            // rbtInternacional
            // 
            this.rbtInternacional.AutoSize = true;
            this.rbtInternacional.Location = new System.Drawing.Point(224, 189);
            this.rbtInternacional.Name = "rbtInternacional";
            this.rbtInternacional.Size = new System.Drawing.Size(101, 17);
            this.rbtInternacional.TabIndex = 14;
            this.rbtInternacional.TabStop = true;
            this.rbtInternacional.Text = "2 - Internacional";
            this.rbtInternacional.UseVisualStyleBackColor = true;
            // 
            // lstViajes
            // 
            this.lstViajes.FormattingEnabled = true;
            this.lstViajes.Location = new System.Drawing.Point(373, 61);
            this.lstViajes.Name = "lstViajes";
            this.lstViajes.Size = new System.Drawing.Size(149, 212);
            this.lstViajes.TabIndex = 15;
            // 
            // frmViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 335);
            this.Controls.Add(this.lstViajes);
            this.Controls.Add(this.rbtInternacional);
            this.Controls.Add(this.rbtNacional);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.TxtDestino);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblDestino);
            this.Controls.Add(this.LblTrasnporte);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.cboTransporte);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmViaje";
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.frmViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboTransporte;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblTrasnporte;
        private System.Windows.Forms.Label LblDestino;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtDestino;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbtNacional;
        private System.Windows.Forms.RadioButton rbtInternacional;
        private System.Windows.Forms.ListBox lstViajes;
    }
}

