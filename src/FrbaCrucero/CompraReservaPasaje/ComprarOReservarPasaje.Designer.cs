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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.dataGridViewViajes = new System.Windows.Forms.DataGridView();
            this.viaj_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaj_fecha_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaj_fecha_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaj_fecha_llegada_estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaj_crucero_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cruceroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viaj_recorrido_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recorridoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verRecorridoButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonSelection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajes)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1021, 261);
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
            this.destinoComboBox.Location = new System.Drawing.Point(159, 110);
            this.destinoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destinoComboBox.Name = "destinoComboBox";
            this.destinoComboBox.Size = new System.Drawing.Size(160, 24);
            this.destinoComboBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ciudad destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ciudad origen";
            // 
            // origenComboBox
            // 
            this.origenComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.origenComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.origenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origenComboBox.FormattingEnabled = true;
            this.origenComboBox.Location = new System.Drawing.Point(159, 52);
            this.origenComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.origenComboBox.Name = "origenComboBox";
            this.origenComboBox.Size = new System.Drawing.Size(160, 24);
            this.origenComboBox.TabIndex = 19;
            this.origenComboBox.SelectedIndexChanged += new System.EventHandler(this.origenComboBox_SelectedIndexChanged);
            // 
            // monthCalendar
            // 
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.monthCalendar.Location = new System.Drawing.Point(549, 30);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(1900, 6, 23, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 18;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // btn_seleccionar_salida
            // 
            this.btn_seleccionar_salida.Location = new System.Drawing.Point(327, 165);
            this.btn_seleccionar_salida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_seleccionar_salida.Name = "btn_seleccionar_salida";
            this.btn_seleccionar_salida.Size = new System.Drawing.Size(100, 28);
            this.btn_seleccionar_salida.TabIndex = 17;
            this.btn_seleccionar_salida.Text = "Seleccionar";
            this.btn_seleccionar_salida.UseVisualStyleBackColor = true;
            this.btn_seleccionar_salida.Click += new System.EventHandler(this.btn_seleccionar_salida_Click);
            // 
            // salidaText
            // 
            this.salidaText.Location = new System.Drawing.Point(159, 165);
            this.salidaText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salidaText.Name = "salidaText";
            this.salidaText.ReadOnly = true;
            this.salidaText.Size = new System.Drawing.Size(160, 22);
            this.salidaText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha de salida";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(793, 748);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(197, 31);
            this.btn_cancelar.TabIndex = 26;
            this.btn_cancelar.Text = "Cancelar Operación";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(477, 278);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(97, 30);
            this.btn_buscar.TabIndex = 24;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(12, 278);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 30);
            this.btn_limpiar.TabIndex = 23;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // dataGridViewViajes
            // 
            this.dataGridViewViajes.AllowUserToAddRows = false;
            this.dataGridViewViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.viaj_id,
            this.viaj_fecha_salida,
            this.viaj_fecha_llegada,
            this.viaj_fecha_llegada_estimada,
            this.viaj_crucero_id,
            this.cruceroColumn,
            this.viaj_recorrido_id,
            this.recorridoColumn,
            this.verRecorridoButton,
            this.ButtonSelection});
            this.dataGridViewViajes.Location = new System.Drawing.Point(35, 337);
            this.dataGridViewViajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewViajes.Name = "dataGridViewViajes";
            this.dataGridViewViajes.Size = new System.Drawing.Size(999, 350);
            this.dataGridViewViajes.TabIndex = 32;
            this.dataGridViewViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViajes_CellContentClick);
            // 
            // viaj_id
            // 
            this.viaj_id.DataPropertyName = "viaj_id";
            this.viaj_id.HeaderText = "Viaje_id";
            this.viaj_id.Name = "viaj_id";
            this.viaj_id.ReadOnly = true;
            this.viaj_id.Visible = false;
            // 
            // viaj_fecha_salida
            // 
            this.viaj_fecha_salida.DataPropertyName = "viaj_fecha_salida";
            this.viaj_fecha_salida.FillWeight = 200F;
            this.viaj_fecha_salida.HeaderText = "Viaje_Fecha_Salida";
            this.viaj_fecha_salida.Name = "viaj_fecha_salida";
            this.viaj_fecha_salida.Width = 126;
            // 
            // viaj_fecha_llegada
            // 
            this.viaj_fecha_llegada.DataPropertyName = "viaj_fecha_llegada";
            this.viaj_fecha_llegada.FillWeight = 200F;
            this.viaj_fecha_llegada.HeaderText = "Viaje fecha llegada";
            this.viaj_fecha_llegada.Name = "viaj_fecha_llegada";
            this.viaj_fecha_llegada.ReadOnly = true;
            this.viaj_fecha_llegada.Width = 200;
            // 
            // viaj_fecha_llegada_estimada
            // 
            this.viaj_fecha_llegada_estimada.DataPropertyName = "viaj_fecha_llegada_estimada";
            this.viaj_fecha_llegada_estimada.FillWeight = 200F;
            this.viaj_fecha_llegada_estimada.HeaderText = "Fecha llegada estimada";
            this.viaj_fecha_llegada_estimada.Name = "viaj_fecha_llegada_estimada";
            this.viaj_fecha_llegada_estimada.ReadOnly = true;
            this.viaj_fecha_llegada_estimada.Width = 200;
            // 
            // viaj_crucero_id
            // 
            this.viaj_crucero_id.DataPropertyName = "viaj_crucero_id";
            this.viaj_crucero_id.HeaderText = "Viaje_crucero_id";
            this.viaj_crucero_id.Name = "viaj_crucero_id";
            this.viaj_crucero_id.ReadOnly = true;
            // 
            // cruceroColumn
            // 
            this.cruceroColumn.DataPropertyName = "cruc_modelo";
            this.cruceroColumn.HeaderText = "Crucero";
            this.cruceroColumn.Name = "cruceroColumn";
            // 
            // viaj_recorrido_id
            // 
            this.viaj_recorrido_id.DataPropertyName = "viaj_recorrido_id";
            this.viaj_recorrido_id.HeaderText = "Viaje_recorrido_id";
            this.viaj_recorrido_id.Name = "viaj_recorrido_id";
            this.viaj_recorrido_id.ReadOnly = true;
            // 
            // recorridoColumn
            // 
            this.recorridoColumn.DataPropertyName = "reco_codigo";
            this.recorridoColumn.HeaderText = "Recorrido";
            this.recorridoColumn.Name = "recorridoColumn";
            // 
            // verRecorridoButton
            // 
            this.verRecorridoButton.HeaderText = "Ver Recorrido";
            this.verRecorridoButton.Name = "verRecorridoButton";
            // 
            // ButtonSelection
            // 
            this.ButtonSelection.HeaderText = "Seleccionar";
            this.ButtonSelection.Name = "ButtonSelection";
            this.ButtonSelection.ReadOnly = true;
            // 
            // ComprarOReservarPasaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1132, 484);
            this.Controls.Add(this.dataGridViewViajes);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ComprarOReservarPasaje";
            this.Text = "ComprarPasaje";
            this.Load += new System.EventHandler(this.ComprarOReservarPasaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViajes)).EndInit();
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
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.DataGridView dataGridViewViajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaj_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaj_fecha_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaj_fecha_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaj_fecha_llegada_estimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaj_crucero_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cruceroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viaj_recorrido_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn recorridoColumn;
        private System.Windows.Forms.DataGridViewButtonColumn verRecorridoButton;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonSelection;
    }
}