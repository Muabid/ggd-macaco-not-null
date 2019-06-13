namespace FrbaCrucero.PagoReserva
{
    partial class mediosDePago
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonRemover = new System.Windows.Forms.Button();
            this.methodOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.methodOfPayment,
            this.cuotas});
            this.dataGridView1.Location = new System.Drawing.Point(49, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(49, 300);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 4;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonRemover
            // 
            this.botonRemover.Location = new System.Drawing.Point(179, 300);
            this.botonRemover.Name = "botonRemover";
            this.botonRemover.Size = new System.Drawing.Size(75, 23);
            this.botonRemover.TabIndex = 5;
            this.botonRemover.Text = "Remover";
            this.botonRemover.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
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
            this.botonPagar.Location = new System.Drawing.Point(556, 300);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(75, 23);
            this.botonPagar.TabIndex = 8;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = true;
            // 
            // mediosDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 360);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonRemover);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "mediosDePago";
            this.Text = "mediosDePago";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonPagar;
    }
}