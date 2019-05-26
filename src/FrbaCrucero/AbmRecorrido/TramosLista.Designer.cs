namespace FrbaCrucero.AbmRecorrido
{
    partial class TramosLista
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
            this.tramosTable.Location = new System.Drawing.Point(15, 61);
            this.tramosTable.Name = "tramosTable";
            this.tramosTable.Size = new System.Drawing.Size(345, 134);
            this.tramosTable.TabIndex = 1;
            // 
            // ciudadOrigen
            // 
            this.ciudadOrigen.DataPropertyName = "desde";
            this.ciudadOrigen.HeaderText = "Ciudad origen";
            this.ciudadOrigen.Name = "ciudadOrigen";
            // 
            // ciudadDestino
            // 
            this.ciudadDestino.DataPropertyName = "hasta";
            this.ciudadDestino.HeaderText = "Ciudad destino";
            this.ciudadDestino.Name = "ciudadDestino";
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // TramosLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 251);
            this.Controls.Add(this.tramosTable);
            this.Name = "TramosLista";
            this.Text = "Tramos";
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tramosTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;

    }
}