namespace FrbaCrucero.PagoReserva
{
    partial class PagoReserva
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
            this.codigoReservaBox = new System.Windows.Forms.TextBox();
            this.pagoReservaTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.botonBuscarReserva = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pagoReservaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese codigo de su reserva:";
            // 
            // codigoReservaBox
            // 
            this.codigoReservaBox.Location = new System.Drawing.Point(396, 58);
            this.codigoReservaBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigoReservaBox.Name = "codigoReservaBox";
            this.codigoReservaBox.Size = new System.Drawing.Size(213, 22);
            this.codigoReservaBox.TabIndex = 1;
            // 
            // pagoReservaTable
            // 
            this.pagoReservaTable.AllowUserToAddRows = false;
            this.pagoReservaTable.AllowUserToDeleteRows = false;
            this.pagoReservaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagoReservaTable.Location = new System.Drawing.Point(24, 111);
            this.pagoReservaTable.Margin = new System.Windows.Forms.Padding(4);
            this.pagoReservaTable.Name = "pagoReservaTable";
            this.pagoReservaTable.ReadOnly = true;
            this.pagoReservaTable.Size = new System.Drawing.Size(711, 245);
            this.pagoReservaTable.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonBuscarReserva
            // 
            this.botonBuscarReserva.Location = new System.Drawing.Point(635, 55);
            this.botonBuscarReserva.Margin = new System.Windows.Forms.Padding(4);
            this.botonBuscarReserva.Name = "botonBuscarReserva";
            this.botonBuscarReserva.Size = new System.Drawing.Size(100, 28);
            this.botonBuscarReserva.TabIndex = 5;
            this.botonBuscarReserva.Text = "Buscar";
            this.botonBuscarReserva.UseVisualStyleBackColor = true;
            this.botonBuscarReserva.Click += new System.EventHandler(this.botonBuscarReserva_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(24, 361);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 22;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // PagoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 409);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.botonBuscarReserva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pagoReservaTable);
            this.Controls.Add(this.codigoReservaBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PagoReserva";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PagoReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagoReservaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoReservaBox;
        private System.Windows.Forms.DataGridView pagoReservaTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botonBuscarReserva;
        private System.Windows.Forms.Button btn_atras;
    }
}