﻿namespace FrbaCrucero
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
            this.btnRol = new System.Windows.Forms.Button();
            this.btnCrucero = new System.Windows.Forms.Button();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnPasaje = new System.Windows.Forms.Button();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.btnPagoReserva = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRol
            // 
            this.btnRol.Location = new System.Drawing.Point(43, 39);
            this.btnRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(100, 28);
            this.btnRol.TabIndex = 0;
            this.btnRol.Text = "ABM ROL";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnCrucero
            // 
            this.btnCrucero.Location = new System.Drawing.Point(43, 111);
            this.btnCrucero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrucero.Name = "btnCrucero";
            this.btnCrucero.Size = new System.Drawing.Size(100, 49);
            this.btnCrucero.TabIndex = 1;
            this.btnCrucero.Text = "ABM CRUCERO";
            this.btnCrucero.UseVisualStyleBackColor = true;
            this.btnCrucero.Click += new System.EventHandler(this.btnCrucero_Click);
            // 
            // btnRecorrido
            // 
            this.btnRecorrido.Location = new System.Drawing.Point(217, 31);
            this.btnRecorrido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecorrido.Name = "btnRecorrido";
            this.btnRecorrido.Size = new System.Drawing.Size(112, 44);
            this.btnRecorrido.TabIndex = 2;
            this.btnRecorrido.Text = "ABM RECORRIDO";
            this.btnRecorrido.UseVisualStyleBackColor = true;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);
            // 
            // btnPasaje
            // 
            this.btnPasaje.Location = new System.Drawing.Point(217, 122);
            this.btnPasaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPasaje.Name = "btnPasaje";
            this.btnPasaje.Size = new System.Drawing.Size(100, 28);
            this.btnPasaje.TabIndex = 3;
            this.btnPasaje.Text = "PASAJE";
            this.btnPasaje.UseVisualStyleBackColor = true;
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.Location = new System.Drawing.Point(43, 201);
            this.btnGenerarViaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(100, 46);
            this.btnGenerarViaje.TabIndex = 4;
            this.btnGenerarViaje.Text = "GENERAR VIAJE";
            this.btnGenerarViaje.UseVisualStyleBackColor = true;
            this.btnGenerarViaje.Click += new System.EventHandler(this.btnGenerarViaje_Click);
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Location = new System.Drawing.Point(213, 201);
            this.btnListadoEstadistico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(116, 46);
            this.btnListadoEstadistico.TabIndex = 5;
            this.btnListadoEstadistico.Text = "LISTADO ESTADISTICO";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // btnPagoReserva
            // 
            this.btnPagoReserva.Location = new System.Drawing.Point(43, 288);
            this.btnPagoReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPagoReserva.Name = "btnPagoReserva";
            this.btnPagoReserva.Size = new System.Drawing.Size(100, 44);
            this.btnPagoReserva.TabIndex = 6;
            this.btnPagoReserva.Text = "PAGO RESERVA";
            this.btnPagoReserva.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(43, 412);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 49);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 476);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPagoReserva);
            this.Controls.Add(this.btnListadoEstadistico);
            this.Controls.Add(this.btnGenerarViaje);
            this.Controls.Add(this.btnPasaje);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.btnCrucero);
            this.Controls.Add(this.btnRol);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnCrucero;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnPasaje;
        private System.Windows.Forms.Button btnGenerarViaje;
        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Button btnPagoReserva;
        private System.Windows.Forms.Button btnCerrar;
    }
}

