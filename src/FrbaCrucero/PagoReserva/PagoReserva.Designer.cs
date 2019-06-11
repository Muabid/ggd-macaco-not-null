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
            ((System.ComponentModel.ISupportInitialize)(this.pagoReservaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese codigo de su reserva:";
            // 
            // codigoReservaBox
            // 
            this.codigoReservaBox.Location = new System.Drawing.Point(297, 47);
            this.codigoReservaBox.Name = "codigoReservaBox";
            this.codigoReservaBox.Size = new System.Drawing.Size(161, 20);
            this.codigoReservaBox.TabIndex = 1;
            // 
            // pagoReservaTable
            // 
            this.pagoReservaTable.AllowUserToAddRows = false;
            this.pagoReservaTable.AllowUserToDeleteRows = false;
            this.pagoReservaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagoReservaTable.Location = new System.Drawing.Point(18, 90);
            this.pagoReservaTable.Name = "pagoReservaTable";
            this.pagoReservaTable.ReadOnly = true;
            this.pagoReservaTable.Size = new System.Drawing.Size(533, 199);
            this.pagoReservaTable.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonBuscarReserva
            // 
            this.botonBuscarReserva.Location = new System.Drawing.Point(519, 47);
            this.botonBuscarReserva.Name = "botonBuscarReserva";
            this.botonBuscarReserva.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarReserva.TabIndex = 5;
            this.botonBuscarReserva.Text = "Buscar";
            this.botonBuscarReserva.UseVisualStyleBackColor = true;
            this.botonBuscarReserva.Click += new System.EventHandler(this.botonBuscarReserva_Click);
            // 
            // PagoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 350);
            this.Controls.Add(this.botonBuscarReserva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pagoReservaTable);
            this.Controls.Add(this.codigoReservaBox);
            this.Controls.Add(this.label1);
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
    }
}