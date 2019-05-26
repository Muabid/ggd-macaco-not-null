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
            this.codigoField = new System.Windows.Forms.TextBox();
            this.recorridosTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ciudadOrigenCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ciudadDestinoCombo = new System.Windows.Forms.ComboBox();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // codigoField
            // 
            this.codigoField.Location = new System.Drawing.Point(125, 82);
            this.codigoField.Name = "codigoField";
            this.codigoField.Size = new System.Drawing.Size(100, 20);
            this.codigoField.TabIndex = 1;
            // 
            // recorridosTable
            // 
            this.recorridosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recorridosTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.from,
            this.end,
            this.price,
            this.detail,
            this.delete});
            this.recorridosTable.Location = new System.Drawing.Point(25, 204);
            this.recorridosTable.Name = "recorridosTable";
            this.recorridosTable.Size = new System.Drawing.Size(547, 226);
            this.recorridosTable.TabIndex = 2;
            this.recorridosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onBuscar);
            // 
            // ciudadOrigenCombo
            // 
            this.ciudadOrigenCombo.FormattingEnabled = true;
            this.ciudadOrigenCombo.Location = new System.Drawing.Point(125, 31);
            this.ciudadOrigenCombo.Name = "ciudadOrigenCombo";
            this.ciudadOrigenCombo.Size = new System.Drawing.Size(121, 21);
            this.ciudadOrigenCombo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ciudad Origen";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ciudad Origen";
            // 
            // ciudadDestinoCombo
            // 
            this.ciudadDestinoCombo.FormattingEnabled = true;
            this.ciudadDestinoCombo.Location = new System.Drawing.Point(393, 31);
            this.ciudadDestinoCombo.Name = "ciudadDestinoCombo";
            this.ciudadDestinoCombo.Size = new System.Drawing.Size(121, 21);
            this.ciudadDestinoCombo.TabIndex = 8;
            // 
            // code
            // 
            this.code.DataPropertyName = "codigo";
            this.code.HeaderText = "Código";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // from
            // 
            this.from.DataPropertyName = "ciudadOrigen";
            this.from.HeaderText = "Origen";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // end
            // 
            this.end.DataPropertyName = "ciudadDestino";
            this.end.HeaderText = "Destino";
            this.end.Name = "end";
            this.end.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "precio";
            this.price.HeaderText = "Precio";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.HeaderText = "Ver";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Text = "Ver";
            this.detail.UseColumnTextForButtonValue = true;
            this.detail.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "Borrar";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Borrar";
            this.delete.ToolTipText = "sgd";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 50;
            // 
            // BajaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 442);
            this.Controls.Add(this.ciudadDestinoCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ciudadOrigenCombo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.recorridosTable);
            this.Controls.Add(this.codigoField);
            this.Controls.Add(this.label1);
            this.Name = "BajaRecorrido";
            this.Text = "Baja";
            ((System.ComponentModel.ISupportInitialize)(this.recorridosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codigoField;
        private System.Windows.Forms.DataGridView recorridosTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ciudadOrigenCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ciudadDestinoCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}