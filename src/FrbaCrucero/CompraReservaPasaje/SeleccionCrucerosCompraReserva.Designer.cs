namespace FrbaCrucero.GeneracionViaje
{
    partial class SeleccionCrucerosCompraReserva
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
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_cruceros = new System.Windows.Forms.DataGridView();
            this.cruc_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cruc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_compania = new System.Windows.Forms.ComboBox();
            this.cbo_modelo = new System.Windows.Forms.ComboBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cruceros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(34, 206);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(73, 24);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(443, 206);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(73, 24);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_cruceros
            // 
            this.dgv_cruceros.AllowUserToAddRows = false;
            this.dgv_cruceros.AllowUserToDeleteRows = false;
            this.dgv_cruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cruc_nombre,
            this.Column2,
            this.Column3,
            this.Column4,
            this.seleccionar,
            this.cruc_id});
            this.dgv_cruceros.Location = new System.Drawing.Point(9, 246);
            this.dgv_cruceros.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_cruceros.Name = "dgv_cruceros";
            this.dgv_cruceros.ReadOnly = true;
            this.dgv_cruceros.RowTemplate.Height = 24;
            this.dgv_cruceros.Size = new System.Drawing.Size(540, 154);
            this.dgv_cruceros.TabIndex = 13;
            this.dgv_cruceros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cruceros_CellContentClick);
            // 
            // cruc_nombre
            // 
            this.cruc_nombre.DataPropertyName = "cruc_nombre";
            this.cruc_nombre.HeaderText = "Nombre";
            this.cruc_nombre.Name = "cruc_nombre";
            this.cruc_nombre.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cruc_modelo";
            this.Column2.HeaderText = "Modelo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "comp_nombre";
            this.Column3.HeaderText = "Compañia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cruc_cantidad_cabinas";
            this.Column4.HeaderText = "Cabinas";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.ReadOnly = true;
            this.seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseColumnTextForButtonValue = true;
            this.seleccionar.Width = 90;
            // 
            // cruc_id
            // 
            this.cruc_id.DataPropertyName = "cruc_id";
            this.cruc_id.HeaderText = "id";
            this.cruc_id.Name = "cruc_id";
            this.cruc_id.ReadOnly = true;
            this.cruc_id.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_compania);
            this.groupBox1.Controls.Add(this.cbo_modelo);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(540, 191);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crucero";
            // 
            // cbo_compania
            // 
            this.cbo_compania.FormattingEnabled = true;
            this.cbo_compania.Location = new System.Drawing.Point(86, 89);
            this.cbo_compania.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_compania.Name = "cbo_compania";
            this.cbo_compania.Size = new System.Drawing.Size(124, 21);
            this.cbo_compania.TabIndex = 3;
            this.cbo_compania.SelectedIndexChanged += new System.EventHandler(this.cbo_compania_SelectedIndexChanged);
            // 
            // cbo_modelo
            // 
            this.cbo_modelo.FormattingEnabled = true;
            this.cbo_modelo.Location = new System.Drawing.Point(86, 54);
            this.cbo_modelo.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_modelo.Name = "cbo_modelo";
            this.cbo_modelo.Size = new System.Drawing.Size(124, 21);
            this.cbo_modelo.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(86, 22);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(124, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compañia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(9, 435);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(73, 25);
            this.btn_atras.TabIndex = 22;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // SeleccionCrucerosCompraReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 474);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_cruceros);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpiar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeleccionCrucerosCompraReserva";
            this.Text = "Listado Cruceros";
            this.Load += new System.EventHandler(this.FormListadoCruceros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cruceros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_cruceros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_compania;
        private System.Windows.Forms.ComboBox cbo_modelo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruc_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruc_id;
        private System.Windows.Forms.Button btn_atras;

    }
}