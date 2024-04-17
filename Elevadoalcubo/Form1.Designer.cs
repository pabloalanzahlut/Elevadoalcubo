namespace Elevadoalcubo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarUltimo = new System.Windows.Forms.Button();
            this.btnFiltrarHistorial = new System.Windows.Forms.Button();
            this.btnExportarHistorial = new System.Windows.Forms.Button();
            this.btnGuardarHistorial = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbTipoOperacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNum1.Location = new System.Drawing.Point(123, 50);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(182, 22);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Ingrese un número:";
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.Color.White;
            this.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtnumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtnumero.Location = new System.Drawing.Point(329, 50);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(135, 26);
            this.txtnumero.TabIndex = 1;
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMultiplicacion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnMultiplicacion.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicacion.Location = new System.Drawing.Point(357, 233);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(147, 55);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblResult.Location = new System.Drawing.Point(120, 405);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 22);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado:";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(978, 514);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(147, 55);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnreset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnreset.FlatAppearance.BorderSize = 2;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(79, 430);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(147, 55);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reintentar";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.BackColor = System.Drawing.Color.White;
            this.lstHistorial.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 24;
            this.lstHistorial.Location = new System.Drawing.Point(766, 65);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(297, 436);
            this.lstHistorial.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(813, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Historial de Cálculos:";
            // 
            // btnBorrarUltimo
            // 
            this.btnBorrarUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnBorrarUltimo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnBorrarUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnBorrarUltimo.ForeColor = System.Drawing.Color.White;
            this.btnBorrarUltimo.Location = new System.Drawing.Point(613, 88);
            this.btnBorrarUltimo.Name = "btnBorrarUltimo";
            this.btnBorrarUltimo.Size = new System.Drawing.Size(147, 39);
            this.btnBorrarUltimo.TabIndex = 10;
            this.btnBorrarUltimo.Text = "Borrar Último";
            this.btnBorrarUltimo.UseVisualStyleBackColor = false;
            this.btnBorrarUltimo.Click += new System.EventHandler(this.btnBorrarUltimo_Click);
            // 
            // btnFiltrarHistorial
            // 
            this.btnFiltrarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnFiltrarHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnFiltrarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnFiltrarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnFiltrarHistorial.Location = new System.Drawing.Point(533, 306);
            this.btnFiltrarHistorial.Name = "btnFiltrarHistorial";
            this.btnFiltrarHistorial.Size = new System.Drawing.Size(147, 39);
            this.btnFiltrarHistorial.TabIndex = 11;
            this.btnFiltrarHistorial.Text = "Filtrar Historial";
            this.btnFiltrarHistorial.UseVisualStyleBackColor = false;
            this.btnFiltrarHistorial.Click += new System.EventHandler(this.btnFiltrarHistorial_Click);
            // 
            // btnExportarHistorial
            // 
            this.btnExportarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnExportarHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnExportarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnExportarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnExportarHistorial.Location = new System.Drawing.Point(613, 199);
            this.btnExportarHistorial.Name = "btnExportarHistorial";
            this.btnExportarHistorial.Size = new System.Drawing.Size(147, 39);
            this.btnExportarHistorial.TabIndex = 12;
            this.btnExportarHistorial.Text = "Exportar Historial";
            this.btnExportarHistorial.UseVisualStyleBackColor = false;
            this.btnExportarHistorial.Click += new System.EventHandler(this.btnExportarHistorial_Click);
            // 
            // btnGuardarHistorial
            // 
            this.btnGuardarHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnGuardarHistorial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnGuardarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnGuardarHistorial.Location = new System.Drawing.Point(613, 249);
            this.btnGuardarHistorial.Name = "btnGuardarHistorial";
            this.btnGuardarHistorial.Size = new System.Drawing.Size(147, 39);
            this.btnGuardarHistorial.TabIndex = 13;
            this.btnGuardarHistorial.Text = "Guardar Historial";
            this.btnGuardarHistorial.UseVisualStyleBackColor = false;
            this.btnGuardarHistorial.Click += new System.EventHandler(this.btnGuardarHistorial_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.btnBorrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnBorrarTodo.ForeColor = System.Drawing.Color.White;
            this.btnBorrarTodo.Location = new System.Drawing.Point(613, 143);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(147, 39);
            this.btnBorrarTodo.TabIndex = 14;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(232, 405);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(25, 28);
            this.lblresultado.TabIndex = 15;
            this.lblresultado.Text = "-";
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnDivision.ForeColor = System.Drawing.Color.White;
            this.btnDivision.Location = new System.Drawing.Point(204, 233);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(147, 55);
            this.btnDivision.TabIndex = 2;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnResta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnResta.ForeColor = System.Drawing.Color.White;
            this.btnResta.Location = new System.Drawing.Point(357, 159);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(147, 55);
            this.btnResta.TabIndex = 2;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSuma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSuma.ForeColor = System.Drawing.Color.White;
            this.btnSuma.Location = new System.Drawing.Point(204, 159);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(147, 55);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnPotencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnPotencia.ForeColor = System.Drawing.Color.White;
            this.btnPotencia.Location = new System.Drawing.Point(274, 306);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(147, 55);
            this.btnPotencia.TabIndex = 2;
            this.btnPotencia.Text = "N^3";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.btnPotencia_Click);
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumero2.Location = new System.Drawing.Point(120, 88);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(182, 22);
            this.lblNumero2.TabIndex = 0;
            this.lblNumero2.Text = "Ingrese un número:";
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.Color.White;
            this.txtnumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtnumero2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtnumero2.Location = new System.Drawing.Point(329, 84);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(135, 26);
            this.txtnumero2.TabIndex = 1;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtFiltro.Location = new System.Drawing.Point(689, 313);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(71, 26);
            this.txtFiltro.TabIndex = 16;
            // 
            // cmbTipoOperacion
            // 
            this.cmbTipoOperacion.FormattingEnabled = true;
            this.cmbTipoOperacion.Location = new System.Drawing.Point(689, 354);
            this.cmbTipoOperacion.Name = "cmbTipoOperacion";
            this.cmbTipoOperacion.Size = new System.Drawing.Size(71, 36);
            this.cmbTipoOperacion.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1126, 641);
            this.Controls.Add(this.cmbTipoOperacion);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnGuardarHistorial);
            this.Controls.Add(this.btnExportarHistorial);
            this.Controls.Add(this.btnFiltrarHistorial);
            this.Controls.Add(this.btnBorrarUltimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNum1);
            this.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Calculador de Cubos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarUltimo;
        private System.Windows.Forms.Button btnFiltrarHistorial;
        private System.Windows.Forms.Button btnExportarHistorial;
        private System.Windows.Forms.Button btnGuardarHistorial;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbTipoOperacion;
    }
}
