namespace FrbaCrucero.CompraReservaPasaje
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pagoReservaTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cabi_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabi_piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabi_tipoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pagoReservaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(617, 302);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(73, 25);
            this.btn_atras.TabIndex = 29;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.pagoReservaTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cabi_nro,
            this.cabi_piso,
            this.cabi_tipoServicio});
            this.pagoReservaTable.Location = new System.Drawing.Point(12, 204);
            this.pagoReservaTable.Name = "pagoReservaTable";
            this.pagoReservaTable.ReadOnly = true;
            this.pagoReservaTable.Size = new System.Drawing.Size(533, 199);
            this.pagoReservaTable.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(323, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Detalles de la compra";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(35, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(386, 96);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(176, 59);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(176, 96);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 35;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(386, 59);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 36;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(176, 122);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 37;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(551, 59);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(115, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Listas de cabinas seleccionadas";
            // 
            // cabi_nro
            // 
            this.cabi_nro.HeaderText = "Numero";
            this.cabi_nro.Name = "cabi_nro";
            this.cabi_nro.ReadOnly = true;
            // 
            // cabi_piso
            // 
            this.cabi_piso.HeaderText = "Piso";
            this.cabi_piso.Name = "cabi_piso";
            this.cabi_piso.ReadOnly = true;
            // 
            // cabi_tipoServicio
            // 
            this.cabi_tipoServicio.HeaderText = "Tipo de Servicio";
            this.cabi_tipoServicio.Name = "cabi_tipoServicio";
            this.cabi_tipoServicio.ReadOnly = true;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pagoReservaTable);
            this.Controls.Add(this.label1);
            this.Name = "Pago";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagoReservaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView pagoReservaTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabi_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabi_piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabi_tipoServicio;
    }
}