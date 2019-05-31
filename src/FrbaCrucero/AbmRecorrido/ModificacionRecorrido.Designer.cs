namespace FrbaCrucero.AbmRecorrido
{
    partial class ModificacionRecorrido
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
            this.codigoText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tramosTable = new System.Windows.Forms.DataGridView();
            this.origenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tramoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // codigoText
            // 
            this.codigoText.Location = new System.Drawing.Point(97, 46);
            this.codigoText.Name = "codigoText";
            this.codigoText.ReadOnly = true;
            this.codigoText.Size = new System.Drawing.Size(100, 20);
            this.codigoText.TabIndex = 1;
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(386, 46);
            this.precioText.Name = "precioText";
            this.precioText.ReadOnly = true;
            this.precioText.Size = new System.Drawing.Size(100, 20);
            this.precioText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // tramosTable
            // 
            this.tramosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tramosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.origenColumn,
            this.destinoColumn,
            this.precioColumn,
            this.modificarColumn,
            this.tramoId});
            this.tramosTable.Location = new System.Drawing.Point(38, 151);
            this.tramosTable.Name = "tramosTable";
            this.tramosTable.Size = new System.Drawing.Size(448, 150);
            this.tramosTable.TabIndex = 4;
            // 
            // origenColumn
            // 
            this.origenColumn.DataPropertyName = "desde";
            this.origenColumn.HeaderText = "Ciudad origen";
            this.origenColumn.Name = "origenColumn";
            this.origenColumn.ReadOnly = true;
            // 
            // destinoColumn
            // 
            this.destinoColumn.DataPropertyName = "hasta";
            this.destinoColumn.HeaderText = "Ciudad destino";
            this.destinoColumn.Name = "destinoColumn";
            this.destinoColumn.ReadOnly = true;
            // 
            // precioColumn
            // 
            this.precioColumn.DataPropertyName = "precio";
            this.precioColumn.HeaderText = "Precio";
            this.precioColumn.Name = "precioColumn";
            this.precioColumn.ReadOnly = true;
            // 
            // modificarColumn
            // 
            this.modificarColumn.HeaderText = "";
            this.modificarColumn.Name = "modificarColumn";
            this.modificarColumn.Text = "Modificar";
            this.modificarColumn.UseColumnTextForButtonValue = true;
            // 
            // tramoId
            // 
            this.tramoId.DataPropertyName = "tramoId";
            this.tramoId.HeaderText = "Tramo ";
            this.tramoId.Name = "tramoId";
            this.tramoId.Visible = false;
            // 
            // ModificacionRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 401);
            this.Controls.Add(this.tramosTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionRecorrido";
            this.Text = "Modificacion recorrido";
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tramosTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewButtonColumn modificarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramoId;
    }
}