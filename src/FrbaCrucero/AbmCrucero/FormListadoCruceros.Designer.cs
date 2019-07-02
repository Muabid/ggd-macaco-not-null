namespace FrbaCrucero.AbmCrucero
{
    partial class FormListadoCruceros
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
            this.dgv_cruceros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cabinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Baja = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CompaniaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cabinas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.cbo_compania = new System.Windows.Forms.ComboBox();
            this.cbo_modelo = new System.Windows.Forms.ComboBox();
            this.txt_fecha_alta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cruceros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_cruceros
            // 
            this.dgv_cruceros.AllowUserToAddRows = false;
            this.dgv_cruceros.AllowUserToDeleteRows = false;
            this.dgv_cruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Modelo,
            this.Compania,
            this.Cabinas,
            this.Alta,
            this.Editar,
            this.Baja,
            this.CompaniaId});
            this.dgv_cruceros.Location = new System.Drawing.Point(9, 263);
            this.dgv_cruceros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_cruceros.Name = "dgv_cruceros";
            this.dgv_cruceros.ReadOnly = true;
            this.dgv_cruceros.RowTemplate.Height = 24;
            this.dgv_cruceros.Size = new System.Drawing.Size(657, 154);
            this.dgv_cruceros.TabIndex = 13;
            this.dgv_cruceros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cruceros_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "cruc_id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "cruc_nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "cruc_modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Compania
            // 
            this.Compania.DataPropertyName = "comp_nombre";
            this.Compania.HeaderText = "Compañia";
            this.Compania.Name = "Compania";
            this.Compania.ReadOnly = true;
            // 
            // Cabinas
            // 
            this.Cabinas.DataPropertyName = "cruc_cantidad_cabinas";
            this.Cabinas.HeaderText = "Cabinas";
            this.Cabinas.Name = "Cabinas";
            this.Cabinas.ReadOnly = true;
            // 
            // Alta
            // 
            this.Alta.DataPropertyName = "cruc_fecha_alta";
            this.Alta.HeaderText = "Fecha de Alta";
            this.Alta.Name = "Alta";
            this.Alta.ReadOnly = true;
            this.Alta.Width = 120;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Modificar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Visible = false;
            this.Editar.Width = 90;
            // 
            // Baja
            // 
            this.Baja.HeaderText = "Baja";
            this.Baja.Name = "Baja";
            this.Baja.ReadOnly = true;
            this.Baja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Baja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Baja.Visible = false;
            // 
            // CompaniaId
            // 
            this.CompaniaId.DataPropertyName = "cruc_compañia_id";
            this.CompaniaId.HeaderText = "Compania Id";
            this.CompaniaId.Name = "CompaniaId";
            this.CompaniaId.ReadOnly = true;
            this.CompaniaId.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cabinas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.btn_seleccionar);
            this.groupBox1.Controls.Add(this.cbo_compania);
            this.groupBox1.Controls.Add(this.cbo_modelo);
            this.groupBox1.Controls.Add(this.txt_fecha_alta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(602, 191);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crucero";
            // 
            // txt_cabinas
            // 
            this.txt_cabinas.Location = new System.Drawing.Point(86, 128);
            this.txt_cabinas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_cabinas.Name = "txt_cabinas";
            this.txt_cabinas.ReadOnly = true;
            this.txt_cabinas.Size = new System.Drawing.Size(124, 20);
            this.txt_cabinas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cabinas";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(327, 16);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(213, 163);
            this.btn_seleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(73, 21);
            this.btn_seleccionar.TabIndex = 6;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // cbo_compania
            // 
            this.cbo_compania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_compania.FormattingEnabled = true;
            this.cbo_compania.Location = new System.Drawing.Point(86, 89);
            this.cbo_compania.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_compania.Name = "cbo_compania";
            this.cbo_compania.Size = new System.Drawing.Size(124, 21);
            this.cbo_compania.TabIndex = 3;
            // 
            // cbo_modelo
            // 
            this.cbo_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_modelo.FormattingEnabled = true;
            this.cbo_modelo.Location = new System.Drawing.Point(86, 54);
            this.cbo_modelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_modelo.Name = "cbo_modelo";
            this.cbo_modelo.Size = new System.Drawing.Size(124, 21);
            this.cbo_modelo.TabIndex = 2;
            // 
            // txt_fecha_alta
            // 
            this.txt_fecha_alta.Location = new System.Drawing.Point(86, 163);
            this.txt_fecha_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_fecha_alta.Name = "txt_fecha_alta";
            this.txt_fecha_alta.ReadOnly = true;
            this.txt_fecha_alta.Size = new System.Drawing.Size(123, 20);
            this.txt_fecha_alta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Alta";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(86, 22);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(124, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compañia (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(9, 447);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(73, 25);
            this.btn_atras.TabIndex = 21;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(9, 220);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(73, 25);
            this.btn_limpiar.TabIndex = 22;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(494, 220);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(73, 25);
            this.btn_buscar.TabIndex = 23;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // FormListadoCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 481);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_cruceros);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListadoCruceros";
            this.Text = "Listado Cruceros";
            this.Load += new System.EventHandler(this.FormListadoCruceros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cruceros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cruceros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cabinas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.ComboBox cbo_compania;
        private System.Windows.Forms.ComboBox cbo_modelo;
        private System.Windows.Forms.TextBox txt_fecha_alta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cabinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alta;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompaniaId;

    }
}