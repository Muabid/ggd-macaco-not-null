namespace FrbaCrucero.AbmRecorrido
{
    partial class AltaRecorrido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tramosTable = new System.Windows.Forms.DataGridView();
            this.ciudadOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addTramoButton = new System.Windows.Forms.Button();
            this.clean = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tramosTable
            // 
            this.tramosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tramosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudadOrigen,
            this.ciudadDestino,
            this.precio});
            this.tramosTable.Location = new System.Drawing.Point(80, 115);
            this.tramosTable.Name = "tramosTable";
            this.tramosTable.Size = new System.Drawing.Size(348, 159);
            this.tramosTable.TabIndex = 0;
            this.tramosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.DataPropertyName = "ciudadOrigen";
            this.ciudadOrigen.HeaderText = "Ciudad origen";
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.DataPropertyName = "ciudadDestino";
            this.ciudadDestino.HeaderText = "Ciudad destino";
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(121, 28);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addTramoButton
            // 
            this.addTramoButton.Location = new System.Drawing.Point(330, 28);
            this.addTramoButton.Name = "addTramoButton";
            this.addTramoButton.Size = new System.Drawing.Size(98, 22);
            this.addTramoButton.TabIndex = 3;
            this.addTramoButton.Text = "Agregar Tramo";
            this.addTramoButton.UseVisualStyleBackColor = true;
            this.addTramoButton.Click += new System.EventHandler(this.onAgregarTramo);
            // 
            // clean
            // 
            this.clean.Location = new System.Drawing.Point(80, 294);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(75, 23);
            this.clean.TabIndex = 4;
            this.clean.Text = "Limpiar";
            this.clean.UseVisualStyleBackColor = true;
            this.clean.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(353, 294);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AltaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 384);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.addTramoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.tramosTable);
            this.Name = "AltaRecorrido";
            this.Text = "Alta recorrido";
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tramosTable;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTramoButton;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}