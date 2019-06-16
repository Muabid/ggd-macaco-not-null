namespace FrbaCrucero.AbmCrucero
{
    partial class FormBaja
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
            this.btn_seleccionar_fecha_baja_definitiva = new System.Windows.Forms.Button();
            this.txt_fecha_baja_definitiva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_vida_util = new System.Windows.Forms.CheckBox();
            this.chb_fuera_de_servicio = new System.Windows.Forms.CheckBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_seleccionar_fecha_reinicio_servicio = new System.Windows.Forms.Button();
            this.txt_fecha_reinicio_servicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_seleccionar_fecha_fuera_servicio = new System.Windows.Forms.Button();
            this.txt_fecha_fuera_servicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_seleccionar_fecha_baja_definitiva);
            this.groupBox1.Controls.Add(this.txt_fecha_baja_definitiva);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chb_vida_util);
            this.groupBox1.Controls.Add(this.chb_fuera_de_servicio);
            this.groupBox1.Controls.Add(this.txt_motivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.btn_seleccionar_fecha_reinicio_servicio);
            this.groupBox1.Controls.Add(this.txt_fecha_reinicio_servicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_seleccionar_fecha_fuera_servicio);
            this.groupBox1.Controls.Add(this.txt_fecha_fuera_servicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 417);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja Crucero";
            // 
            // btn_seleccionar_fecha_baja_definitiva
            // 
            this.btn_seleccionar_fecha_baja_definitiva.Location = new System.Drawing.Point(653, 117);
            this.btn_seleccionar_fecha_baja_definitiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seleccionar_fecha_baja_definitiva.Name = "btn_seleccionar_fecha_baja_definitiva";
            this.btn_seleccionar_fecha_baja_definitiva.Size = new System.Drawing.Size(97, 26);
            this.btn_seleccionar_fecha_baja_definitiva.TabIndex = 22;
            this.btn_seleccionar_fecha_baja_definitiva.Text = "Seleccionar";
            this.btn_seleccionar_fecha_baja_definitiva.UseVisualStyleBackColor = true;
            this.btn_seleccionar_fecha_baja_definitiva.Click += new System.EventHandler(this.btn_seleccionar_fecha_baja_definitiva_Click);
            // 
            // txt_fecha_baja_definitiva
            // 
            this.txt_fecha_baja_definitiva.Location = new System.Drawing.Point(484, 119);
            this.txt_fecha_baja_definitiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_baja_definitiva.Name = "txt_fecha_baja_definitiva";
            this.txt_fecha_baja_definitiva.ReadOnly = true;
            this.txt_fecha_baja_definitiva.Size = new System.Drawing.Size(163, 22);
            this.txt_fecha_baja_definitiva.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha Baja DEFINITIVA";
            // 
            // chb_vida_util
            // 
            this.chb_vida_util.AutoSize = true;
            this.chb_vida_util.Location = new System.Drawing.Point(484, 47);
            this.chb_vida_util.Name = "chb_vida_util";
            this.chb_vida_util.Size = new System.Drawing.Size(226, 21);
            this.chb_vida_util.TabIndex = 20;
            this.chb_vida_util.Text = "Baja por Vida Útil (DEFINITIVA)";
            this.chb_vida_util.UseVisualStyleBackColor = true;
            // 
            // chb_fuera_de_servicio
            // 
            this.chb_fuera_de_servicio.AutoSize = true;
            this.chb_fuera_de_servicio.Location = new System.Drawing.Point(34, 47);
            this.chb_fuera_de_servicio.Name = "chb_fuera_de_servicio";
            this.chb_fuera_de_servicio.Size = new System.Drawing.Size(198, 21);
            this.chb_fuera_de_servicio.TabIndex = 19;
            this.chb_fuera_de_servicio.Text = "Baja por Fuera de Servicio";
            this.chb_fuera_de_servicio.UseVisualStyleBackColor = true;
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(34, 244);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(396, 167);
            this.txt_motivo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Motivo";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(484, 189);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btn_seleccionar_fecha_reinicio_servicio
            // 
            this.btn_seleccionar_fecha_reinicio_servicio.Location = new System.Drawing.Point(203, 189);
            this.btn_seleccionar_fecha_reinicio_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seleccionar_fecha_reinicio_servicio.Name = "btn_seleccionar_fecha_reinicio_servicio";
            this.btn_seleccionar_fecha_reinicio_servicio.Size = new System.Drawing.Size(97, 26);
            this.btn_seleccionar_fecha_reinicio_servicio.TabIndex = 14;
            this.btn_seleccionar_fecha_reinicio_servicio.Text = "Seleccionar";
            this.btn_seleccionar_fecha_reinicio_servicio.UseVisualStyleBackColor = true;
            this.btn_seleccionar_fecha_reinicio_servicio.Click += new System.EventHandler(this.btn_seleccionar_fecha_reinicio_servicio_Click);
            // 
            // txt_fecha_reinicio_servicio
            // 
            this.txt_fecha_reinicio_servicio.Location = new System.Drawing.Point(34, 191);
            this.txt_fecha_reinicio_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_reinicio_servicio.Name = "txt_fecha_reinicio_servicio";
            this.txt_fecha_reinicio_servicio.ReadOnly = true;
            this.txt_fecha_reinicio_servicio.Size = new System.Drawing.Size(163, 22);
            this.txt_fecha_reinicio_servicio.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha Reinicio de Servicio";
            // 
            // btn_seleccionar_fecha_fuera_servicio
            // 
            this.btn_seleccionar_fecha_fuera_servicio.Location = new System.Drawing.Point(203, 117);
            this.btn_seleccionar_fecha_fuera_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seleccionar_fecha_fuera_servicio.Name = "btn_seleccionar_fecha_fuera_servicio";
            this.btn_seleccionar_fecha_fuera_servicio.Size = new System.Drawing.Size(97, 26);
            this.btn_seleccionar_fecha_fuera_servicio.TabIndex = 10;
            this.btn_seleccionar_fecha_fuera_servicio.Text = "Seleccionar";
            this.btn_seleccionar_fecha_fuera_servicio.UseVisualStyleBackColor = true;
            this.btn_seleccionar_fecha_fuera_servicio.Click += new System.EventHandler(this.btn_seleccionar_fecha_fuera_servicio_Click);
            // 
            // txt_fecha_fuera_servicio
            // 
            this.txt_fecha_fuera_servicio.Location = new System.Drawing.Point(34, 119);
            this.txt_fecha_fuera_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_fuera_servicio.Name = "txt_fecha_fuera_servicio";
            this.txt_fecha_fuera_servicio.ReadOnly = true;
            this.txt_fecha_fuera_servicio.Size = new System.Drawing.Size(163, 22);
            this.txt_fecha_fuera_servicio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Fuera de Servicio";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(686, 447);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(97, 31);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(513, 447);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 31);
            this.btn_limpiar.TabIndex = 18;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.Location = new System.Drawing.Point(27, 447);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(97, 31);
            this.btn_atras.TabIndex = 20;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            // 
            // FormBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 489);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_limpiar);
            this.Name = "FormBaja";
            this.Text = "Baja Crucero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_seleccionar_fecha_reinicio_servicio;
        private System.Windows.Forms.TextBox txt_fecha_reinicio_servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_seleccionar_fecha_fuera_servicio;
        private System.Windows.Forms.TextBox txt_fecha_fuera_servicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_seleccionar_fecha_baja_definitiva;
        private System.Windows.Forms.TextBox txt_fecha_baja_definitiva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chb_vida_util;
        private System.Windows.Forms.CheckBox chb_fuera_de_servicio;
    }
}