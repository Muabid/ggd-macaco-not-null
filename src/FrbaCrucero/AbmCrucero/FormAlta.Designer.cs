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
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.cbo_tipo_servicio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cabinas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(12, 600);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 31);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(598, 600);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 341);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cabinas";
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(433, 64);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(135, 22);
            this.txt_piso.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 46);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_cabinas.Location = new System.Drawing.Point(9, 93);
            this.dgv_cabinas.Name = "dgv_cabinas";
            this.dgv_cabinas.ReadOnly = true;
            this.dgv_cabinas.RowTemplate.Height = 24;
            this.dgv_cabinas.Size = new System.Drawing.Size(662, 223);
            this.dgv_cabinas.TabIndex = 14;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(285, 66);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(142, 22);
            this.txt_cantidad.TabIndex = 9;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(574, 55);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(97, 33);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // cbo_tipo_servicio
            // 
            this.cbo_tipo_servicio.FormattingEnabled = true;
            this.cbo_tipo_servicio.Location = new System.Drawing.Point(9, 64);
            this.cbo_tipo_servicio.Name = "cbo_tipo_servicio";
            this.cbo_tipo_servicio.Size = new System.Drawing.Size(270, 24);
            this.cbo_tipo_servicio.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo Servicio (*)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 235);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crucero";
            // 
            // txt_cabinas
            // 
            this.txt_cabinas.Location = new System.Drawing.Point(115, 157);
            this.txt_cabinas.Name = "txt_cabinas";
            this.txt_cabinas.ReadOnly = true;
            this.txt_cabinas.Size = new System.Drawing.Size(164, 22);
            this.txt_cabinas.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cabinas";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(412, 22);
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(284, 201);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(97, 26);
            this.btn_seleccionar.TabIndex = 6;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            // 
            // cbo_compania
            // 
            this.cbo_compania.FormattingEnabled = true;
            this.cbo_compania.Location = new System.Drawing.Point(115, 110);
            this.cbo_compania.Name = "cbo_compania";
            this.cbo_compania.Size = new System.Drawing.Size(164, 24);
            this.cbo_compania.TabIndex = 3;
            // 
            // cbo_modelo
            // 
            this.cbo_modelo.FormattingEnabled = true;
            this.cbo_modelo.Location = new System.Drawing.Point(115, 67);
            this.cbo_modelo.Name = "cbo_modelo";
            this.cbo_modelo.Size = new System.Drawing.Size(164, 24);
            this.cbo_modelo.TabIndex = 2;
            // 
            // txt_fecha_alta
            // 
            this.txt_fecha_alta.Location = new System.Drawing.Point(115, 201);
            this.txt_fecha_alta.Name = "txt_fecha_alta";
            this.txt_fecha_alta.ReadOnly = true;
            this.txt_fecha_alta.Size = new System.Drawing.Size(163, 22);
            this.txt_fecha_alta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Alta";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(115, 27);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(164, 22);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "MZBWKK-43983";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Compañia (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Servicio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Piso";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Eliminar";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 50;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 656);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Name = "FormAlta";
            this.Text = "Alta Crucero";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cabinas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}