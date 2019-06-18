namespace FrbaCrucero.AbmCrucero
{
    partial class FormAlta
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_cabinas = new System.Windows.Forms.DataGridView();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cbo_tipo_servicio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.group_box_crucero = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cabinas)).BeginInit();
            this.group_box_crucero.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(217, 599);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 31);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(513, 599);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(97, 31);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_piso);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgv_cabinas);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.cbo_tipo_servicio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(760, 341);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cabinas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(463, 64);
            this.txt_piso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(135, 22);
            this.txt_piso.TabIndex = 10;
            this.txt_piso.TextChanged += new System.EventHandler(this.txt_piso_TextChanged);
            this.txt_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_piso_KeyPress);
            this.txt_piso.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_piso_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Piso";
            // 
            // dgv_cabinas
            // 
            this.dgv_cabinas.AllowUserToAddRows = false;
            this.dgv_cabinas.AllowUserToDeleteRows = false;
            this.dgv_cabinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cabinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicio,
            this.cabinas,
            this.piso,
            this.eliminar});
            this.dgv_cabinas.Location = new System.Drawing.Point(9, 94);
            this.dgv_cabinas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_cabinas.Name = "dgv_cabinas";
            this.dgv_cabinas.ReadOnly = true;
            this.dgv_cabinas.RowTemplate.Height = 24;
            this.dgv_cabinas.Size = new System.Drawing.Size(745, 223);
            this.dgv_cabinas.TabIndex = 14;
            this.dgv_cabinas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cabinas_CellContentClick);
            // 
            // servicio
            // 
            this.servicio.DataPropertyName = "servicio";
            this.servicio.HeaderText = "Tipo Servicio";
            this.servicio.Name = "servicio";
            this.servicio.ReadOnly = true;
            this.servicio.Width = 200;
            // 
            // cabinas
            // 
            this.cabinas.DataPropertyName = "cabinas";
            this.cabinas.HeaderText = "Cantidad";
            this.cabinas.Name = "cabinas";
            this.cabinas.ReadOnly = true;
            // 
            // piso
            // 
            this.piso.DataPropertyName = "piso";
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Width = 50;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(300, 65);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(143, 22);
            this.txt_cantidad.TabIndex = 9;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Enabled = false;
            this.btn_agregar.Location = new System.Drawing.Point(657, 53);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(97, 33);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // cbo_tipo_servicio
            // 
            this.cbo_tipo_servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_servicio.FormattingEnabled = true;
            this.cbo_tipo_servicio.Location = new System.Drawing.Point(9, 64);
            this.cbo_tipo_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_tipo_servicio.Name = "cbo_tipo_servicio";
            this.cbo_tipo_servicio.Size = new System.Drawing.Size(271, 24);
            this.cbo_tipo_servicio.TabIndex = 8;
            this.cbo_tipo_servicio.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_servicio_SelectedIndexChanged);
            this.cbo_tipo_servicio.TextChanged += new System.EventHandler(this.cbo_tipo_servicio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Servicio (*)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // group_box_crucero
            // 
            this.group_box_crucero.Controls.Add(this.txt_cabinas);
            this.group_box_crucero.Controls.Add(this.label4);
            this.group_box_crucero.Controls.Add(this.monthCalendar1);
            this.group_box_crucero.Controls.Add(this.btn_seleccionar);
            this.group_box_crucero.Controls.Add(this.cbo_compania);
            this.group_box_crucero.Controls.Add(this.cbo_modelo);
            this.group_box_crucero.Controls.Add(this.txt_fecha_alta);
            this.group_box_crucero.Controls.Add(this.label5);
            this.group_box_crucero.Controls.Add(this.txt_nombre);
            this.group_box_crucero.Controls.Add(this.label3);
            this.group_box_crucero.Controls.Add(this.label2);
            this.group_box_crucero.Controls.Add(this.label1);
            this.group_box_crucero.Location = new System.Drawing.Point(12, 12);
            this.group_box_crucero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_crucero.Name = "group_box_crucero";
            this.group_box_crucero.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_box_crucero.Size = new System.Drawing.Size(760, 235);
            this.group_box_crucero.TabIndex = 16;
            this.group_box_crucero.TabStop = false;
            this.group_box_crucero.Text = "Crucero";
            // 
            // txt_cabinas
            // 
            this.txt_cabinas.Location = new System.Drawing.Point(115, 158);
            this.txt_cabinas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cabinas.Name = "txt_cabinas";
            this.txt_cabinas.ReadOnly = true;
            this.txt_cabinas.Size = new System.Drawing.Size(164, 22);
            this.txt_cabinas.TabIndex = 4;
            this.txt_cabinas.TextChanged += new System.EventHandler(this.txt_cabinas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cabinas";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(412, 22);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(284, 201);
            this.btn_seleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(97, 26);
            this.btn_seleccionar.TabIndex = 6;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // cbo_compania
            // 
            this.cbo_compania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_compania.FormattingEnabled = true;
            this.cbo_compania.Location = new System.Drawing.Point(115, 110);
            this.cbo_compania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_compania.Name = "cbo_compania";
            this.cbo_compania.Size = new System.Drawing.Size(164, 24);
            this.cbo_compania.TabIndex = 3;
            this.cbo_compania.SelectionChangeCommitted += new System.EventHandler(this.cbo_compania_SelectionChangeCommitted);
            // 
            // cbo_modelo
            // 
            this.cbo_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_modelo.FormattingEnabled = true;
            this.cbo_modelo.Location = new System.Drawing.Point(115, 66);
            this.cbo_modelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_modelo.Name = "cbo_modelo";
            this.cbo_modelo.Size = new System.Drawing.Size(164, 24);
            this.cbo_modelo.TabIndex = 2;
            this.cbo_modelo.TextChanged += new System.EventHandler(this.cbo_modelo_TextChanged);
            // 
            // txt_fecha_alta
            // 
            this.txt_fecha_alta.Location = new System.Drawing.Point(115, 201);
            this.txt_fecha_alta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_alta.Name = "txt_fecha_alta";
            this.txt_fecha_alta.ReadOnly = true;
            this.txt_fecha_alta.Size = new System.Drawing.Size(163, 22);
            this.txt_fecha_alta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Alta";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(115, 27);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compañia (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(18, 599);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 21;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 662);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.group_box_crucero);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAlta";
            this.Text = "Alta Crucero";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cabinas)).EndInit();
            this.group_box_crucero.ResumeLayout(false);
            this.group_box_crucero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_cabinas;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cbo_tipo_servicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox group_box_crucero;
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
        private System.Windows.Forms.TextBox txt_cabinas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.Button btn_atras;
    }
}