namespace FrbaCrucero.AbmRecorrido
{
    partial class RecorridoForm
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
            this.tramosTable = new System.Windows.Forms.DataGridView();
            this.ciudadOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tramoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.precioBox = new System.Windows.Forms.TextBox();
            this.codigoBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tramosTable
            // 
            this.tramosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tramosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudadOrigen,
            this.ciudadDestino,
            this.precio,
            this.tramoId});
            this.tramosTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.tramosTable.Location = new System.Drawing.Point(54, 129);
            this.tramosTable.Name = "tramosTable";
            this.tramosTable.ReadOnly = true;
            this.tramosTable.Size = new System.Drawing.Size(345, 134);
            this.tramosTable.TabIndex = 1;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.DataPropertyName = "desde";
            this.ciudadOrigen.HeaderText = "Ciudad origen";
            this.ciudadOrigen.Name = "ciudadOrigen";
            this.ciudadOrigen.ReadOnly = true;
            this.ciudadOrigen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.DataPropertyName = "hasta";
            this.ciudadDestino.HeaderText = "Ciudad destino";
            this.ciudadDestino.Name = "ciudadDestino";
            this.ciudadDestino.ReadOnly = true;
            this.ciudadDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tramoId
            // 
            this.tramoId.DataPropertyName = "tramoId";
            this.tramoId.HeaderText = "ID";
            this.tramoId.Name = "tramoId";
            this.tramoId.ReadOnly = true;
            this.tramoId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tramoId.Visible = false;
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(51, 51);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(40, 13);
            this.codigo.TabIndex = 2;
            this.codigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Precio";
            // 
            // precioBox
            // 
            this.precioBox.Enabled = false;
            this.precioBox.Location = new System.Drawing.Point(272, 48);
            this.precioBox.Name = "precioBox";
            this.precioBox.ReadOnly = true;
            this.precioBox.Size = new System.Drawing.Size(100, 20);
            this.precioBox.TabIndex = 5;
            // 
            // codigoBox
            // 
            this.codigoBox.Enabled = false;
            this.codigoBox.Location = new System.Drawing.Point(97, 48);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.ReadOnly = true;
            this.codigoBox.Size = new System.Drawing.Size(100, 20);
            this.codigoBox.TabIndex = 6;
            // 
            // RecorridoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 319);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.precioBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.tramosTable);
            this.Name = "RecorridoForm";
            this.Text = "Recorrido";
            this.Load += new System.EventHandler(this.TramosLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tramosTable;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox precioBox;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramoId;

    }
}