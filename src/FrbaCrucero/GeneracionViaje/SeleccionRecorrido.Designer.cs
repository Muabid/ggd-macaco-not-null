namespace FrbaCrucero.GeneracionViaje
{
    partial class SeleccionRecorrido
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
            this.ciudadDestinoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ciudadOrigenCombo = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.codigoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadOrigenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestinoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.seleccionarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // recorridosTable
            // 
            this.recorridosTable.AllowUserToAddRows = false;
            this.recorridosTable.AllowUserToDeleteRows = false;
            this.recorridosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigoColumn,
            this.ciudadOrigenColumn,
            this.ciudadDestinoColumn,
            this.precioColumn,
            this.verColumn,
            this.seleccionarColumn});
            this.recorridosTable.Location = new System.Drawing.Point(59, 233);
            this.recorridosTable.Name = "recorridosTable";
            this.recorridosTable.ReadOnly = true;
            this.recorridosTable.Size = new System.Drawing.Size(654, 144);
            this.recorridosTable.TabIndex = 18;
            this.recorridosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosTable_CellContentClick_1);
            // 
            // ciudadDestinoCombo
            // 
            this.ciudadDestinoCombo.FormattingEnabled = true;
            this.ciudadDestinoCombo.Location = new System.Drawing.Point(449, 26);
            this.ciudadDestinoCombo.Name = "ciudadDestinoCombo";
            this.ciudadDestinoCombo.Size = new System.Drawing.Size(121, 21);
            this.ciudadDestinoCombo.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ciudad Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ciudad Origen";
            // 
            // ciudadOrigenCombo
            // 
            this.ciudadOrigenCombo.FormattingEnabled = true;
            this.ciudadOrigenCombo.Location = new System.Drawing.Point(181, 26);
            this.ciudadOrigenCombo.Name = "ciudadOrigenCombo";
            this.ciudadOrigenCombo.Size = new System.Drawing.Size(121, 21);
            this.ciudadOrigenCombo.TabIndex = 14;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(468, 152);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 13;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(163, 152);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 12;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click_1);
            // 
            // codigoBox
            // 
            this.codigoBox.Location = new System.Drawing.Point(181, 77);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(100, 20);
            this.codigoBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigoColumn
            // 
            this.codigoColumn.DataPropertyName = "codigo";
            this.codigoColumn.HeaderText = "Código";
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.ReadOnly = true;
            this.codigoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ciudadOrigenColumn
            // 
            this.ciudadOrigenColumn.DataPropertyName = "ciudadOrigen";
            this.ciudadOrigenColumn.HeaderText = "Ciudad de origen";
            this.ciudadOrigenColumn.Name = "ciudadOrigenColumn";
            this.ciudadOrigenColumn.ReadOnly = true;
            this.ciudadOrigenColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ciudadOrigenColumn.Width = 120;
            // 
            // ciudadDestinoColumn
            // 
            this.ciudadDestinoColumn.DataPropertyName = "ciudadDestino";
            this.ciudadDestinoColumn.HeaderText = "Ciudad destino";
            this.ciudadDestinoColumn.Name = "ciudadDestinoColumn";
            this.ciudadDestinoColumn.ReadOnly = true;
            this.ciudadDestinoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ciudadDestinoColumn.Width = 120;
            // 
            // precioColumn
            // 
            this.precioColumn.DataPropertyName = "precio";
            this.precioColumn.HeaderText = "Precio";
            this.precioColumn.Name = "precioColumn";
            this.precioColumn.ReadOnly = true;
            this.precioColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // verColumn
            // 
            this.verColumn.HeaderText = "";
            this.verColumn.Name = "verColumn";
            this.verColumn.ReadOnly = true;
            this.verColumn.Text = "Ver";
            this.verColumn.UseColumnTextForButtonValue = true;
            this.verColumn.Width = 60;
            // 
            // seleccionarColumn
            // 
            this.seleccionarColumn.HeaderText = "";
            this.seleccionarColumn.Name = "seleccionarColumn";
            this.seleccionarColumn.ReadOnly = true;
            this.seleccionarColumn.Text = "Seleccionar";
            this.seleccionarColumn.UseColumnTextForButtonValue = true;
            this.seleccionarColumn.Width = 70;
            // 
            // SeleccionRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 402);
            this.Controls.Add(this.recorridosTable);
            this.Controls.Add(this.ciudadDestinoCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciudadOrigenCombo);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionRecorrido";
            this.Text = "SeleccionRecorrido";
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recorridosTable;
        private System.Windows.Forms.ComboBox ciudadDestinoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ciudadOrigenCombo;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestinoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewButtonColumn verColumn;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionarColumn;
    }
}