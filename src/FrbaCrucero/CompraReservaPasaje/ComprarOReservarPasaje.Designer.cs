namespace FrbaCrucero.CompraReservaPasaje
{
    partial class ComprarOReservarPasaje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.destinoComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.origenComboBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btn_seleccionar_salida = new System.Windows.Forms.Button();
            this.salidaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dgv_cruceros = new System.Windows.Forms.DataGridView();
            this.cruc_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cruc_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dgv_cabinas = new System.Windows.Forms.DataGridView();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cbo_tipo_servicio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cruceros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cabinas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.destinoComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.origenComboBox);
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Controls.Add(this.btn_seleccionar_salida);
            this.groupBox1.Controls.Add(this.salidaText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(766, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra / Reserva Pasaje";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // destinoComboBox
            // 
            this.destinoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.destinoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.destinoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinoComboBox.FormattingEnabled = true;
            this.destinoComboBox.Location = new System.Drawing.Point(119, 89);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinoComboBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ciudad destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ciudad origen";
            // 
            // origenComboBox
            // 
            this.origenComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.origenComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.origenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenComboBox.FormattingEnabled = true;
            this.origenComboBox.Location = new System.Drawing.Point(119, 42);
            this.origenComboBox.Name = "origenComboBox";
            this.origenComboBox.Size = new System.Drawing.Size(121, 21);
            this.origenComboBox.TabIndex = 19;
            this.origenComboBox.SelectedIndexChanged += new System.EventHandler(this.origenComboBox_SelectedIndexChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.monthCalendar.Location = new System.Drawing.Point(412, 24);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 18;
            // 
            // btn_seleccionar_salida
            // 
            this.btn_seleccionar_salida.Location = new System.Drawing.Point(245, 134);
            this.btn_seleccionar_salida.Name = "btn_seleccionar_salida";
            this.btn_seleccionar_salida.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar_salida.TabIndex = 17;
            this.btn_seleccionar_salida.Text = "Seleccionar";
            this.btn_seleccionar_salida.UseVisualStyleBackColor = true;
            this.btn_seleccionar_salida.Click += new System.EventHandler(this.btn_seleccionar_salida_Click);
            // 
            // salidaText
            // 
            this.salidaText.Location = new System.Drawing.Point(119, 134);
            this.salidaText.Name = "salidaText";
            this.salidaText.ReadOnly = true;
            this.salidaText.Size = new System.Drawing.Size(121, 20);
            this.salidaText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha de salida";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(598, 704);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(148, 25);
            this.btn_cancelar.TabIndex = 26;
            this.btn_cancelar.Text = "Cancelar Operación";
            this.btn_cancelar.UseVisualStyleBackColor = true;
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
            this.dgv_cruceros.Location = new System.Drawing.Point(9, 278);
            this.dgv_cruceros.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_cruceros.Name = "dgv_cruceros";
            this.dgv_cruceros.ReadOnly = true;
            this.dgv_cruceros.RowTemplate.Height = 24;
            this.dgv_cruceros.Size = new System.Drawing.Size(422, 158);
            this.dgv_cruceros.TabIndex = 25;
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
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(358, 226);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(73, 24);
            this.btn_buscar.TabIndex = 24;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(9, 226);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(73, 24);
            this.btn_limpiar.TabIndex = 23;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // dgv_cabinas
            // 
            this.dgv_cabinas.AllowUserToAddRows = false;
            this.dgv_cabinas.AllowUserToDeleteRows = false;
            this.dgv_cabinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cabinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicio,
            this.cabinas,
            this.piso});
            this.dgv_cabinas.Location = new System.Drawing.Point(436, 278);
            this.dgv_cabinas.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_cabinas.Name = "dgv_cabinas";
            this.dgv_cabinas.ReadOnly = true;
            this.dgv_cabinas.RowTemplate.Height = 24;
            this.dgv_cabinas.Size = new System.Drawing.Size(340, 158);
            this.dgv_cabinas.TabIndex = 27;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.btn_agregar);
            this.groupBox2.Controls.Add(this.cbo_tipo_servicio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 462);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(570, 268);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Cantidad de Pasajes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(7, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(559, 181);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "servicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tipo Servicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cabinas";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "piso";
            this.dataGridViewTextBoxColumn3.HeaderText = "Piso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Eliminar";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Width = 50;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(214, 54);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(108, 20);
            this.txt_cantidad.TabIndex = 9;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(493, 43);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(73, 27);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // cbo_tipo_servicio
            // 
            this.cbo_tipo_servicio.FormattingEnabled = true;
            this.cbo_tipo_servicio.Location = new System.Drawing.Point(7, 52);
            this.cbo_tipo_servicio.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_tipo_servicio.Name = "cbo_tipo_servicio";
            this.cbo_tipo_servicio.Size = new System.Drawing.Size(204, 21);
            this.cbo_tipo_servicio.TabIndex = 8;
            this.cbo_tipo_servicio.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_servicio_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Servicio (*)";
            // 
            // btn_pagar
            // 
            this.btn_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.Location = new System.Drawing.Point(628, 549);
            this.btn_pagar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(98, 25);
            this.btn_pagar.TabIndex = 29;
            this.btn_pagar.Text = "Pagar ";
            this.btn_pagar.UseVisualStyleBackColor = true;
            // 
            // btn_reservar
            // 
            this.btn_reservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reservar.Location = new System.Drawing.Point(628, 603);
            this.btn_reservar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Size = new System.Drawing.Size(98, 25);
            this.btn_reservar.TabIndex = 30;
            this.btn_reservar.Text = "Reservar";
            this.btn_reservar.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(800, 34);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 706);
            this.vScrollBar1.TabIndex = 31;
            // 
            // ComprarOReservarPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(829, 749);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btn_reservar);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_cabinas);
            this.Controls.Add(this.dgv_cruceros);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ComprarOReservarPasaje";
            this.Text = "ComprarPasaje";
            this.Load += new System.EventHandler(this.ComprarOReservarPasaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cruceros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cabinas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_seleccionar_salida;
        private System.Windows.Forms.TextBox salidaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox destinoComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox origenComboBox;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView dgv_cruceros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruc_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruc_id;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dgv_cabinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cbo_tipo_servicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Button btn_reservar;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}