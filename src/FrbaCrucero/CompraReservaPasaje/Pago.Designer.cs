﻿namespace FrbaCrucero.CompraReservaPasaje
{
    partial class Pago
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
            this.btn_atras = new System.Windows.Forms.Button();
            this.botonBuscarReserva = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pagoReservaTable = new System.Windows.Forms.DataGridView();
            this.codigoReservaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pagoReservaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(76, 351);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 29;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // botonBuscarReserva
            // 
            this.botonBuscarReserva.Location = new System.Drawing.Point(687, 46);
            this.botonBuscarReserva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonBuscarReserva.Name = "botonBuscarReserva";
            this.botonBuscarReserva.Size = new System.Drawing.Size(100, 28);
            this.botonBuscarReserva.TabIndex = 28;
            this.botonBuscarReserva.Text = "Buscar";
            this.botonBuscarReserva.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 354);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pagoReservaTable
            // 
            this.pagoReservaTable.AllowUserToAddRows = false;
            this.pagoReservaTable.AllowUserToDeleteRows = false;
            this.pagoReservaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagoReservaTable.Location = new System.Drawing.Point(76, 101);
            this.pagoReservaTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pagoReservaTable.Name = "pagoReservaTable";
            this.pagoReservaTable.ReadOnly = true;
            this.pagoReservaTable.Size = new System.Drawing.Size(711, 245);
            this.pagoReservaTable.TabIndex = 25;
            // 
            // codigoReservaBox
            // 
            this.codigoReservaBox.Location = new System.Drawing.Point(448, 48);
            this.codigoReservaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigoReservaBox.Name = "codigoReservaBox";
            this.codigoReservaBox.Size = new System.Drawing.Size(213, 22);
            this.codigoReservaBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Detalles de la compra";
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 511);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.botonBuscarReserva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pagoReservaTable);
            this.Controls.Add(this.codigoReservaBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pago";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pagoReservaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button botonBuscarReserva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView pagoReservaTable;
        private System.Windows.Forms.TextBox codigoReservaBox;
        private System.Windows.Forms.Label label1;
    }
}