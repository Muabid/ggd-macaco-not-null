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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tramosTable = new System.Windows.Forms.DataGridView();
            this.origenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borrarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tramoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregarTramoButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tramosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // codigoText
            // 
            this.codigoText.Location = new System.Drawing.Point(159, 39);
            this.codigoText.Margin = new System.Windows.Forms.Padding(4);
            this.codigoText.Name = "codigoText";
            this.codigoText.ReadOnly = true;
            this.codigoText.Size = new System.Drawing.Size(132, 22);
            this.codigoText.TabIndex = 1;
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(460, 39);
            this.precioText.Margin = new System.Windows.Forms.Padding(4);
            this.precioText.Name = "precioText";
            this.precioText.ReadOnly = true;
            this.precioText.Size = new System.Drawing.Size(132, 22);
            this.precioText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio";
            // 
            // tramosTable
            // 
            this.tramosTable.AllowUserToAddRows = false;
            this.tramosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tramosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.origenColumn,
            this.destinoColumn,
            this.precioColumn,
            this.modificarColumn,
            this.borrarColumn,
            this.tramoId});
            this.tramosTable.Location = new System.Drawing.Point(25, 164);
            this.tramosTable.Margin = new System.Windows.Forms.Padding(4);
            this.tramosTable.Name = "tramosTable";
            this.tramosTable.ReadOnly = true;
            this.tramosTable.Size = new System.Drawing.Size(567, 185);
            this.tramosTable.TabIndex = 4;
            this.tramosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tramosTable_CellContentClick);
            // 
            // origenColumn
            // 
            this.origenColumn.DataPropertyName = "desde";
            this.origenColumn.HeaderText = "Ciudad origen";
            this.origenColumn.Name = "origenColumn";
            this.origenColumn.ReadOnly = true;
            this.origenColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // destinoColumn
            // 
            this.destinoColumn.DataPropertyName = "hasta";
            this.destinoColumn.HeaderText = "Ciudad destino";
            this.destinoColumn.Name = "destinoColumn";
            this.destinoColumn.ReadOnly = true;
            this.destinoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // precioColumn
            // 
            this.precioColumn.DataPropertyName = "precio";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.precioColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioColumn.HeaderText = "Precio";
            this.precioColumn.Name = "precioColumn";
            this.precioColumn.ReadOnly = true;
            this.precioColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // modificarColumn
            // 
            this.modificarColumn.HeaderText = "";
            this.modificarColumn.Name = "modificarColumn";
            this.modificarColumn.ReadOnly = true;
            this.modificarColumn.Text = "Modificar";
            this.modificarColumn.UseColumnTextForButtonValue = true;
            this.modificarColumn.Width = 60;
            // 
            // borrarColumn
            // 
            this.borrarColumn.HeaderText = "";
            this.borrarColumn.Name = "borrarColumn";
            this.borrarColumn.ReadOnly = true;
            this.borrarColumn.Text = "Borrar";
            this.borrarColumn.UseColumnTextForButtonValue = true;
            this.borrarColumn.Width = 60;
            // 
            // tramoId
            // 
            this.tramoId.DataPropertyName = "tramoId";
            this.tramoId.HeaderText = "Tramo ";
            this.tramoId.Name = "tramoId";
            this.tramoId.ReadOnly = true;
            this.tramoId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tramoId.Visible = false;
            // 
            // agregarTramoButton
            // 
            this.agregarTramoButton.Location = new System.Drawing.Point(473, 97);
            this.agregarTramoButton.Margin = new System.Windows.Forms.Padding(4);
            this.agregarTramoButton.Name = "agregarTramoButton";
            this.agregarTramoButton.Size = new System.Drawing.Size(119, 32);
            this.agregarTramoButton.TabIndex = 5;
            this.agregarTramoButton.Text = "Agregar Tramo";
            this.agregarTramoButton.UseVisualStyleBackColor = true;
            this.agregarTramoButton.Click += new System.EventHandler(this.agregarTramoButton_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(314, 423);
            this.limpiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(100, 28);
            this.limpiarButton.TabIndex = 6;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(492, 423);
            this.guardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(100, 28);
            this.guardarButton.TabIndex = 7;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(25, 423);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 22;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // ModificacionRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 494);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.agregarTramoButton);
            this.Controls.Add(this.tramosTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button agregarTramoButton;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewButtonColumn modificarColumn;
        private System.Windows.Forms.DataGridViewButtonColumn borrarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tramoId;
        private System.Windows.Forms.Button btn_atras;
    }
}