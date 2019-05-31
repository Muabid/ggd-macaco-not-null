namespace FrbaCrucero.AbmRecorrido
{
    partial class ListadoModificacionRecorrido
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
            this.recorridosTable = new System.Windows.Forms.DataGridView();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadOrigenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestinoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codigoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.destinoCombo = new System.Windows.Forms.ComboBox();
            this.origenCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // recorridosTable
            // 
            this.recorridosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoColumn,
            this.ciudadOrigenColumn,
            this.ciudadDestinoColumn,
            this.precioColumn,
            this.modificarColumn});
            this.recorridosTable.Location = new System.Drawing.Point(43, 189);
            this.recorridosTable.Name = "recorridosTable";
            this.recorridosTable.Size = new System.Drawing.Size(515, 174);
            this.recorridosTable.TabIndex = 0;
            this.recorridosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosTable_CellContentClick);
            // 
            // codigoColumn
            // 
            this.codigoColumn.DataPropertyName = "codigo";
            this.codigoColumn.HeaderText = "Código";
            this.codigoColumn.Name = "codigoColumn";
            // 
            // ciudadOrigenColumn
            // 
            this.ciudadOrigenColumn.DataPropertyName = "ciudadOrigen";
            this.ciudadOrigenColumn.HeaderText = "Ciudad origen";
            this.ciudadOrigenColumn.Name = "ciudadOrigenColumn";
            // 
            // ciudadDestinoColumn
            // 
            this.ciudadDestinoColumn.DataPropertyName = "ciudadDestino";
            this.ciudadDestinoColumn.HeaderText = "Ciudad destino";
            this.ciudadDestinoColumn.Name = "ciudadDestinoColumn";
            // 
            // precioColumn
            // 
            this.precioColumn.DataPropertyName = "precio";
            this.precioColumn.HeaderText = "Precio";
            this.precioColumn.Name = "precioColumn";
            // 
            // modificarColumn
            // 
            this.modificarColumn.HeaderText = "";
            this.modificarColumn.Name = "modificarColumn";
            this.modificarColumn.Text = "Modificar";
            this.modificarColumn.UseColumnTextForButtonValue = true;
            this.modificarColumn.Width = 60;
            // 
            // codigoBox
            // 
            this.codigoBox.Location = new System.Drawing.Point(143, 39);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(100, 20);
            this.codigoBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(79, 387);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(75, 23);
            this.limpiarButton.TabIndex = 3;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.limpiarButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(411, 114);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 5;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // destinoCombo
            // 
            this.destinoCombo.FormattingEnabled = true;
            this.destinoCombo.Location = new System.Drawing.Point(143, 106);
            this.destinoCombo.Name = "destinoCombo";
            this.destinoCombo.Size = new System.Drawing.Size(121, 21);
            this.destinoCombo.TabIndex = 6;
            // 
            // origenCombo
            // 
            this.origenCombo.FormattingEnabled = true;
            this.origenCombo.Location = new System.Drawing.Point(411, 35);
            this.origenCombo.Name = "origenCombo";
            this.origenCombo.Size = new System.Drawing.Size(121, 21);
            this.origenCombo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ciudad origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ciudad destino";
            // 
            // ListadoModificacionRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.origenCombo);
            this.Controls.Add(this.destinoCombo);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.recorridosTable);
            this.Name = "ListadoModificacionRecorrido";
            this.Text = "Modificación recorrido";
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recorridosTable;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.ComboBox destinoCombo;
        private System.Windows.Forms.ComboBox origenCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestinoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewButtonColumn modificarColumn;
    }
}