namespace FrbaCrucero.PagoReserva
{
    partial class MediosDePago
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
            this.tablaMediosDePago = new System.Windows.Forms.DataGridView();
            this.methodOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.reserva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonPagar = new System.Windows.Forms.Button();
            this.columnButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.cantCuotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMediosDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medios De Pago";
            // 
            // tablaMediosDePago
            // 
            this.tablaMediosDePago.AllowUserToAddRows = false;
            this.tablaMediosDePago.AllowUserToDeleteRows = false;
            this.tablaMediosDePago.AllowUserToOrderColumns = true;
            this.tablaMediosDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMediosDePago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.methodOfPayment,
            this.cuotas,
            this.columnButtonDelete});
            this.tablaMediosDePago.Location = new System.Drawing.Point(49, 149);
            this.tablaMediosDePago.Name = "tablaMediosDePago";
            this.tablaMediosDePago.ShowCellErrors = false;
            this.tablaMediosDePago.Size = new System.Drawing.Size(497, 200);
            this.tablaMediosDePago.TabIndex = 2;
            this.tablaMediosDePago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaMediosDePago_CellContentClick);
            // 
            // methodOfPayment
            // 
            this.methodOfPayment.HeaderText = "Descripcion";
            this.methodOfPayment.Name = "methodOfPayment";
            // 
            // cuotas
            // 
            this.cuotas.HeaderText = "CantidadDeCuotas";
            this.cuotas.Name = "cuotas";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(49, 355);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 4;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // reserva
            // 
            this.reserva.Location = new System.Drawing.Point(556, 35);
            this.reserva.Name = "reserva";
            this.reserva.ReadOnly = true;
            this.reserva.Size = new System.Drawing.Size(100, 20);
            this.reserva.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(310, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo de Reserva :";
            // 
            // botonPagar
            // 
            this.botonPagar.Location = new System.Drawing.Point(345, 355);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(75, 23);
            this.botonPagar.TabIndex = 8;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = true;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // columnButtonDelete
            // 
            this.columnButtonDelete.HeaderText = "Eliminar";
            this.columnButtonDelete.Name = "columnButtonDelete";
            this.columnButtonDelete.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(49, 97);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(166, 20);
            this.descripcion.TabIndex = 9;
            // 
            // cantCuotas
            // 
            this.cantCuotas.Location = new System.Drawing.Point(263, 97);
            this.cantCuotas.Name = "cantCuotas";
            this.cantCuotas.Size = new System.Drawing.Size(157, 20);
            this.cantCuotas.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(45, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(259, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad de Cuotas:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MediosDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantCuotas);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reserva);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.tablaMediosDePago);
            this.Controls.Add(this.label1);
            this.Name = "MediosDePago";
            this.Text = "mediosDePago";
            this.Load += new System.EventHandler(this.mediosDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMediosDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaMediosDePago;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotas;
        private System.Windows.Forms.TextBox reserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonPagar;
        private System.Windows.Forms.DataGridViewButtonColumn columnButtonDelete;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox cantCuotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}