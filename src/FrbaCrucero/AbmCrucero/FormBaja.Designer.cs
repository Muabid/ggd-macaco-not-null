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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_seleccionar_fecha_fuera_servicio = new System.Windows.Forms.Button();
            this.txt_fecha_fuera_servicio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_seleccionar_fecha_reinicio = new System.Windows.Forms.Button();
            this.txt_fecha_reinicio_servicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_motivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_seleccionar_fecha_reinicio);
            this.groupBox1.Controls.Add(this.txt_fecha_reinicio_servicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Controls.Add(this.btn_seleccionar_fecha_fuera_servicio);
            this.groupBox1.Controls.Add(this.txt_fecha_fuera_servicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baja Crucero";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(536, 52);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            this.monthCalendar1.Visible = false;
            // 
            // btn_seleccionar_fecha_fuera_servicio
            // 
            this.btn_seleccionar_fecha_fuera_servicio.Location = new System.Drawing.Point(178, 78);
            this.btn_seleccionar_fecha_fuera_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seleccionar_fecha_fuera_servicio.Name = "btn_seleccionar_fecha_fuera_servicio";
            this.btn_seleccionar_fecha_fuera_servicio.Size = new System.Drawing.Size(97, 26);
            this.btn_seleccionar_fecha_fuera_servicio.TabIndex = 10;
            this.btn_seleccionar_fecha_fuera_servicio.Text = "Seleccionar";
            this.btn_seleccionar_fecha_fuera_servicio.UseVisualStyleBackColor = true;
            // 
            // txt_fecha_fuera_servicio
            // 
            this.txt_fecha_fuera_servicio.Location = new System.Drawing.Point(9, 80);
            this.txt_fecha_fuera_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_fuera_servicio.Name = "txt_fecha_fuera_servicio";
            this.txt_fecha_fuera_servicio.ReadOnly = true;
            this.txt_fecha_fuera_servicio.Size = new System.Drawing.Size(163, 22);
            this.txt_fecha_fuera_servicio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha Fuera de Servicio";
            // 
            // btn_seleccionar_fecha_reinicio
            // 
            this.btn_seleccionar_fecha_reinicio.Location = new System.Drawing.Point(178, 161);
            this.btn_seleccionar_fecha_reinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_seleccionar_fecha_reinicio.Name = "btn_seleccionar_fecha_reinicio";
            this.btn_seleccionar_fecha_reinicio.Size = new System.Drawing.Size(97, 26);
            this.btn_seleccionar_fecha_reinicio.TabIndex = 14;
            this.btn_seleccionar_fecha_reinicio.Text = "Seleccionar";
            this.btn_seleccionar_fecha_reinicio.UseVisualStyleBackColor = true;
            // 
            // txt_fecha_reinicio_servicio
            // 
            this.txt_fecha_reinicio_servicio.Location = new System.Drawing.Point(9, 163);
            this.txt_fecha_reinicio_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_reinicio_servicio.Name = "txt_fecha_reinicio_servicio";
            this.txt_fecha_reinicio_servicio.ReadOnly = true;
            this.txt_fecha_reinicio_servicio.Size = new System.Drawing.Size(163, 22);
            this.txt_fecha_reinicio_servicio.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fecha Reinicio de Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Motivo";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(6, 227);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(460, 99);
            this.txt_motivo.TabIndex = 17;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(686, 386);
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
            this.btn_limpiar.Location = new System.Drawing.Point(27, 379);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 31);
            this.btn_limpiar.TabIndex = 18;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // FormBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 428);
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
        private System.Windows.Forms.Button btn_seleccionar_fecha_reinicio;
        private System.Windows.Forms.TextBox txt_fecha_reinicio_servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_seleccionar_fecha_fuera_servicio;
        private System.Windows.Forms.TextBox txt_fecha_fuera_servicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
    }
}