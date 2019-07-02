namespace FrbaCrucero.CompraReservaPasaje
{
    partial class MediosDeLosPagos
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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.botonPagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.tablaMediosDePago = new System.Windows.Forms.DataGridView();
            this.methodOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.ComboBox();
            this.cantCuotas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMediosDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(51, 351);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 24;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(262, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad de Cuotas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(48, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripcion:";
            // 
            // botonPagar
            // 
            this.botonPagar.Location = new System.Drawing.Point(532, 351);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(75, 23);
            this.botonPagar.TabIndex = 19;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = true;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(262, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo de Compra :";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(532, 115);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 16;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
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
            this.tablaMediosDePago.Location = new System.Drawing.Point(52, 145);
            this.tablaMediosDePago.Name = "tablaMediosDePago";
            this.tablaMediosDePago.ShowCellErrors = false;
            this.tablaMediosDePago.Size = new System.Drawing.Size(555, 200);
            this.tablaMediosDePago.TabIndex = 15;
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
            // columnButtonDelete
            // 
            this.columnButtonDelete.HeaderText = "Eliminar";
            this.columnButtonDelete.Name = "columnButtonDelete";
            this.columnButtonDelete.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medios De Pago";
            // 
            // descripcion
            // 
            this.descripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descripcion.FormattingEnabled = true;
            this.descripcion.Location = new System.Drawing.Point(52, 103);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(166, 21);
            this.descripcion.TabIndex = 25;
            // 
            // cantCuotas
            // 
            this.cantCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cantCuotas.FormattingEnabled = true;
            this.cantCuotas.Location = new System.Drawing.Point(266, 103);
            this.cantCuotas.Name = "cantCuotas";
            this.cantCuotas.Size = new System.Drawing.Size(157, 21);
            this.cantCuotas.TabIndex = 26;
            // 
            // MediosDeLosPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 400);
            this.Controls.Add(this.cantCuotas);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.tablaMediosDePago);
            this.Controls.Add(this.label1);
            this.Name = "MediosDeLosPagos";
            this.Text = "Medios de Pago";
            this.Load += new System.EventHandler(this.MediosDeLosPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMediosDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.DataGridView tablaMediosDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotas;
        private System.Windows.Forms.DataGridViewButtonColumn columnButtonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox descripcion;
        private System.Windows.Forms.ComboBox cantCuotas;
    }
}