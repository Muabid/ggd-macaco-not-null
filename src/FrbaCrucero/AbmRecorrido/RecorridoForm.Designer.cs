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
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tramosTable
            // 
            this.tramosTable.AllowUserToAddRows = false;
            this.tramosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tramosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciudadOrigen,
            this.ciudadDestino,
            this.precio,
            this.tramoId});
            this.tramosTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.tramosTable.Location = new System.Drawing.Point(71, 118);
            this.tramosTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tramosTable.Name = "tramosTable";
            this.tramosTable.ReadOnly = true;
            this.tramosTable.Size = new System.Drawing.Size(460, 165);
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
            this.codigo.Location = new System.Drawing.Point(68, 63);
            this.codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(52, 17);
            this.codigo.TabIndex = 2;
            this.codigo.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Precio";
            // 
            // precioBox
            // 
            this.precioBox.Enabled = false;
            this.precioBox.Location = new System.Drawing.Point(363, 59);
            this.precioBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precioBox.Name = "precioBox";
            this.precioBox.ReadOnly = true;
            this.precioBox.Size = new System.Drawing.Size(132, 22);
            this.precioBox.TabIndex = 5;
            // 
            // codigoBox
            // 
            this.codigoBox.Enabled = false;
            this.codigoBox.Location = new System.Drawing.Point(129, 59);
            this.codigoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.ReadOnly = true;
            this.codigoBox.Size = new System.Drawing.Size(132, 22);
            this.codigoBox.TabIndex = 6;
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(71, 339);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 22;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // RecorridoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 393);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.precioBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.tramosTable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btn_atras;

    }
}