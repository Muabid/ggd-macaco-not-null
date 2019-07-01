namespace FrbaCrucero.CompraReservaPasaje
{
    partial class ElegirCabinas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewCabinasDisponibles = new System.Windows.Forms.DataGridView();
            this.cabi_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabi_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabi_piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.cbo_tipo_servicio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCabinasReservadas = new System.Windows.Forms.DataGridView();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabinasDisponibles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabinasReservadas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridViewCabinasDisponibles);
            this.groupBox2.Controls.Add(this.txt_piso);
            this.groupBox2.Controls.Add(this.cbo_tipo_servicio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(11, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(403, 399);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Cantidad de Pasajes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewCabinasDisponibles
            // 
            this.dataGridViewCabinasDisponibles.AllowUserToAddRows = false;
            this.dataGridViewCabinasDisponibles.AllowUserToDeleteRows = false;
            this.dataGridViewCabinasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCabinasDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cabi_id,
            this.cabi_nro,
            this.cabi_piso,
            this.servicio1,
            this.agregar});
            this.dataGridViewCabinasDisponibles.Location = new System.Drawing.Point(-9, 76);
            this.dataGridViewCabinasDisponibles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCabinasDisponibles.Name = "dataGridViewCabinasDisponibles";
            this.dataGridViewCabinasDisponibles.ReadOnly = true;
            this.dataGridViewCabinasDisponibles.RowTemplate.Height = 24;
            this.dataGridViewCabinasDisponibles.Size = new System.Drawing.Size(414, 303);
            this.dataGridViewCabinasDisponibles.TabIndex = 14;
            this.dataGridViewCabinasDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCabinasDisponibles_CellContentClick);
            // 
            // cabi_id
            // 
            this.cabi_id.DataPropertyName = "cabi_id";
            this.cabi_id.HeaderText = "id";
            this.cabi_id.Name = "cabi_id";
            this.cabi_id.ReadOnly = true;
            this.cabi_id.Visible = false;
            // 
            // cabi_nro
            // 
            this.cabi_nro.DataPropertyName = "cabi_nro";
            this.cabi_nro.HeaderText = "Numero";
            this.cabi_nro.Name = "cabi_nro";
            this.cabi_nro.ReadOnly = true;
            this.cabi_nro.Width = 50;
            // 
            // cabi_piso
            // 
            this.cabi_piso.DataPropertyName = "cabi_piso";
            this.cabi_piso.HeaderText = "Piso";
            this.cabi_piso.Name = "cabi_piso";
            this.cabi_piso.ReadOnly = true;
            this.cabi_piso.Width = 50;
            // 
            // servicio1
            // 
            this.servicio1.DataPropertyName = "tipo_servicio_descripcion";
            this.servicio1.HeaderText = "Tipo Servicio";
            this.servicio1.Name = "servicio1";
            this.servicio1.ReadOnly = true;
            this.servicio1.Width = 200;
            // 
            // agregar
            // 
            this.agregar.DataPropertyName = "agregar";
            this.agregar.HeaderText = "Agregar";
            this.agregar.Name = "agregar";
            this.agregar.ReadOnly = true;
            this.agregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.agregar.Text = "Agregar";
            this.agregar.Width = 50;
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(214, 54);
            this.txt_piso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(108, 20);
            this.txt_piso.TabIndex = 9;
            this.txt_piso.TextChanged += new System.EventHandler(this.txt_piso_TextChanged);
            this.txt_piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_piso_KeyPress);
            // 
            // cbo_tipo_servicio
            // 
            this.cbo_tipo_servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_servicio.FormattingEnabled = true;
            this.cbo_tipo_servicio.Location = new System.Drawing.Point(7, 52);
            this.cbo_tipo_servicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_tipo_servicio.Name = "cbo_tipo_servicio";
            this.cbo_tipo_servicio.Size = new System.Drawing.Size(204, 21);
            this.cbo_tipo_servicio.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Piso";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewCabinasReservadas);
            this.groupBox1.Location = new System.Drawing.Point(420, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(403, 399);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabinas seleccionadas";
            // 
            // dataGridViewCabinasReservadas
            // 
            this.dataGridViewCabinasReservadas.AllowUserToAddRows = false;
            this.dataGridViewCabinasReservadas.AllowUserToDeleteRows = false;
            this.dataGridViewCabinasReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCabinasReservadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicio,
            this.id,
            this.numero,
            this.piso,
            this.eliminar});
            this.dataGridViewCabinasReservadas.Location = new System.Drawing.Point(7, 76);
            this.dataGridViewCabinasReservadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCabinasReservadas.Name = "dataGridViewCabinasReservadas";
            this.dataGridViewCabinasReservadas.ReadOnly = true;
            this.dataGridViewCabinasReservadas.RowTemplate.Height = 24;
            this.dataGridViewCabinasReservadas.Size = new System.Drawing.Size(395, 303);
            this.dataGridViewCabinasReservadas.TabIndex = 14;
            this.dataGridViewCabinasReservadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCabinasReservadas_CellContentClick);
            // 
            // servicio
            // 
            this.servicio.DataPropertyName = "servicio";
            this.servicio.HeaderText = "Tipo Servicio";
            this.servicio.Name = "servicio";
            this.servicio.ReadOnly = true;
            this.servicio.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "cabi_id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // piso
            // 
            this.piso.DataPropertyName = "piso";
            this.piso.HeaderText = "Piso";
            this.piso.Name = "piso";
            this.piso.ReadOnly = true;
            this.piso.Width = 50;
            // 
            // eliminar
            // 
            this.eliminar.DataPropertyName = "agregar";
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminar.Width = 50;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(687, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 49);
            this.button4.TabIndex = 31;
            this.button4.Text = "Agregar datos del cliente";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(532, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 49);
            this.button5.TabIndex = 32;
            this.button5.Text = "Atras";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ElegirCabinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 609);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ElegirCabinas";
            this.Text = "Seleccion de cabinas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ElegirCabinas_FormClosed);
            this.Load += new System.EventHandler(this.ElegirCabinas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabinasDisponibles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabinasReservadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCabinasDisponibles;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.ComboBox cbo_tipo_servicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewCabinasReservadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn piso;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabi_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabi_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabi_piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio1;
        private System.Windows.Forms.DataGridViewButtonColumn agregar;
    }
}