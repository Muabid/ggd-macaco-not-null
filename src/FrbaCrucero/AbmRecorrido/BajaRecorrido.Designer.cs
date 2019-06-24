namespace FrbaCrucero.AbmRecorrido
{
    partial class BajaRecorrido
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
            this.codigoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ciudadOrigenCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ciudadDestinoCombo = new System.Windows.Forms.ComboBox();
            this.recorridosTable = new System.Windows.Forms.DataGridView();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadOrigenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDestinoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bajaColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // codigoBox
            // 
            this.codigoBox.Location = new System.Drawing.Point(167, 101);
            this.codigoBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.Size = new System.Drawing.Size(132, 22);
            this.codigoBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onBuscar);
            // 
            // ciudadOrigenCombo
            // 
            this.ciudadOrigenCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadOrigenCombo.FormattingEnabled = true;
            this.ciudadOrigenCombo.Location = new System.Drawing.Point(167, 38);
            this.ciudadOrigenCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ciudadOrigenCombo.Name = "ciudadOrigenCombo";
            this.ciudadOrigenCombo.Size = new System.Drawing.Size(160, 24);
            this.ciudadOrigenCombo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ciudad Origen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ciudad Destino";
            // 
            // ciudadDestinoCombo
            // 
            this.ciudadDestinoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadDestinoCombo.FormattingEnabled = true;
            this.ciudadDestinoCombo.Location = new System.Drawing.Point(513, 41);
            this.ciudadDestinoCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ciudadDestinoCombo.Name = "ciudadDestinoCombo";
            this.ciudadDestinoCombo.Size = new System.Drawing.Size(160, 24);
            this.ciudadDestinoCombo.TabIndex = 8;
            // 
            // recorridosTable
            // 
            this.recorridosTable.AllowUserToAddRows = false;
            this.recorridosTable.AllowUserToDeleteRows = false;
            this.recorridosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoColumn,
            this.ciudadOrigenColumn,
            this.ciudadDestinoColumn,
            this.precioColumn,
            this.verColumn,
            this.bajaColumn,
            this.id});
            this.recorridosTable.Location = new System.Drawing.Point(13, 237);
            this.recorridosTable.Margin = new System.Windows.Forms.Padding(4);
            this.recorridosTable.Name = "recorridosTable";
            this.recorridosTable.ReadOnly = true;
            this.recorridosTable.Size = new System.Drawing.Size(839, 177);
            this.recorridosTable.TabIndex = 9;
            this.recorridosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recorridosTable_CellContentClick);
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
            // bajaColumn
            // 
            this.bajaColumn.HeaderText = "";
            this.bajaColumn.Name = "bajaColumn";
            this.bajaColumn.ReadOnly = true;
            this.bajaColumn.Text = "Baja";
            this.bajaColumn.UseColumnTextForButtonValue = true;
            this.bajaColumn.Width = 60;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(60, 467);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 22;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // BajaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 544);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.recorridosTable);
            this.Controls.Add(this.ciudadDestinoCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciudadOrigenCombo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BajaRecorrido";
            this.Text = "Baja";
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ciudadOrigenCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ciudadDestinoCombo;
        private System.Windows.Forms.DataGridView recorridosTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadOrigenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDestinoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioColumn;
        private System.Windows.Forms.DataGridViewButtonColumn verColumn;
        private System.Windows.Forms.DataGridViewButtonColumn bajaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button btn_atras;
    }
}